// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Identity.Broker.Tests
{
    /// <summary>
    /// A policy that supports <see href="https://learn.microsoft.com/entra/msal/dotnet/advanced/proof-of-possession-tokens">Proof of Possession (PoP) tokens</see>.
    /// </summary>
    public class PopTokenAuthenticationPolicy : HttpPipelinePolicy
    {
        private readonly TokenCredential _tokenCredential;
        private string _popNonce;
        private readonly string[] _scopes;

        /// <summary>
        /// Creates a new instance of <see cref="PopTokenAuthenticationPolicy"/>.
        /// </summary>
        /// <param name="credential">The <see cref="TokenCredential"/> to be used for authorization.</param>
        /// <param name="scope">The scope to be included in acquired tokens.</param>
        public PopTokenAuthenticationPolicy(TokenCredential credential, string scope)
        {
            _tokenCredential = credential;
            _scopes = new[] { scope };
        }

        /// <inheritdoc />
        public override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline) =>
            ProcessAsync(message, pipeline, true);

        /// <inheritdoc />
        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline) =>
            ProcessAsync(message, pipeline, false).EnsureCompleted();

        /// <summary>
        /// Executes before <see cref="HttpPipelinePolicy.Process(HttpMessage, ReadOnlyMemory{HttpPipelinePolicy})"/> <see cref="HttpPipelinePolicy.ProcessAsync(HttpMessage, ReadOnlyMemory{HttpPipelinePolicy})"/> or
        /// <see cref="HttpPipelinePolicy.Process(HttpMessage, ReadOnlyMemory{HttpPipelinePolicy})"/> is called.
        /// Implementers of this method are expected to call <see cref="AuthenticateAndAuthorizeRequest"/> or <see cref="AuthenticateAndAuthorizeRequestAsync"/>
        /// if authorization is required for requests not related to handling a challenge response.
        /// </summary>
        /// <param name="message">The <see cref="HttpMessage"/> this policy would be applied to.</param>
        /// <returns>The <see cref="ValueTask"/> representing the asynchronous operation.</returns>
        protected virtual async ValueTask AuthorizeRequestAsync(HttpMessage message)
            => await AuthorizeRequestInternal(message, true).ConfigureAwait(false);

        /// <inheritdoc cref="BearerTokenAuthenticationPolicy.AuthorizeRequest(Azure.Core.HttpMessage)" />
        protected void AuthorizeRequest(HttpMessage message)
            => AuthorizeRequestInternal(message, false).EnsureCompleted();

        /// <summary>
        /// Sets the Authorization header on the <see cref="Request"/> by calling GetToken, or from cache, if possible.
        /// </summary>
        /// <param name="message">The <see cref="HttpMessage"/> with the <see cref="Request"/> to be authorized.</param>
        /// <param name="context">The <see cref="TokenRequestContext"/> used to authorize the <see cref="Request"/>.</param>
        protected async ValueTask AuthenticateAndAuthorizeRequestAsync(HttpMessage message, TokenRequestContext context) =>
            await AuthenticateAndAuthorizeRequestInternal(message, context, true).ConfigureAwait(false);

        /// <summary>
        /// Sets the Authorization header on the <see cref="Request"/> by calling GetToken, or from cache, if possible.
        /// </summary>
        /// <param name="message">The <see cref="HttpMessage"/> with the <see cref="Request"/> to be authorized.</param>
        /// <param name="context">The <see cref="TokenRequestContext"/> used to authorize the <see cref="Request"/>.</param>
        protected void AuthenticateAndAuthorizeRequest(HttpMessage message, TokenRequestContext context) =>
            AuthenticateAndAuthorizeRequestInternal(message, context, false).EnsureCompleted();

        /// <summary>
        /// Executed in the event a 401 response with a WWW-Authenticate authentication challenge header is received after the initial request.
        /// </summary>
        /// <remarks>Service client libraries may override this to handle service specific authentication challenges.</remarks>
        /// <param name="message">The <see cref="HttpMessage"/> to be authenticated.</param>
        /// <returns>A boolean indicating whether the request was successfully authenticated and should be sent to the transport.</returns>
        protected virtual async ValueTask<bool> AuthorizeRequestOnChallengeAsync(HttpMessage message) =>
            await AuthorizeRequestOnChallengeAsyncInternal(message, true).ConfigureAwait(false);

        /// <summary>
        /// Executed in the event a 401 response with a WWW-Authenticate authentication challenge header is received after the initial request.
        /// </summary>
        /// <remarks>Service client libraries may override this to handle service specific authentication challenges.</remarks>
        /// <param name="message">The <see cref="HttpMessage"/> to be authenticated.</param>
        /// <returns>A boolean indicating whether the request was successfully authenticated and should be sent to the transport.</returns>
        protected virtual bool AuthorizeRequestOnChallenge(HttpMessage message) =>
            AuthorizeRequestOnChallengeAsyncInternal(message, false).EnsureCompleted();

        private async ValueTask AuthenticateAndAuthorizeRequestInternal(HttpMessage message, TokenRequestContext context, bool async)
        {
            _popNonce = context.ProofOfPossessionNonce;
            var token = async ?
                await _tokenCredential.GetTokenAsync(context, message.CancellationToken).ConfigureAwait(false) :
                _tokenCredential.GetToken(context, message.CancellationToken);
            message.Request.Headers.SetValue(HttpHeader.Names.Authorization, "PoP " + token.Token);
        }

        private async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            if (message.Request.Uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException("Bearer token authentication is not permitted for non TLS-protected (HTTPS) endpoints.");
            }

            if (async)
            {
                await AuthorizeRequestAsync(message).ConfigureAwait(false);
                await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
            }
            else
            {
                AuthorizeRequest(message);
                ProcessNext(message, pipeline);
            }

            // Check if we have received a challenge or we have not yet issued the first request.
            if (message.Response.Status == (int)HttpStatusCode.Unauthorized && message.Response.Headers.Contains(HttpHeader.Names.WwwAuthenticate))
            {
                // Attempt to get the TokenRequestContext based on the challenge.
                // If we fail to get the context, the challenge was not present or invalid.
                // If we succeed in getting the context, authenticate the request and pass it up the policy chain.
                if (async)
                {
                    if (await AuthorizeRequestOnChallengeAsync(message).ConfigureAwait(false))
                    {
                        await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
                    }
                }
                else
                {
                    if (AuthorizeRequestOnChallenge(message))
                    {
                        ProcessNext(message, pipeline);
                    }
                }
            }
            // Handle the PoP token scenario where successful responses will also contain a WWW-Authenticate header containing a nonce.
            else if (!message.Response.IsError && message.Response.Headers.Contains(HttpHeader.Names.WwwAuthenticate))
            {
                var nonce = AuthorizationChallengeParser.GetChallengeParameterFromResponse(message.Response, "PoP", "nonce");
                // if nonce is null, the response was not a PoP token response, so null assignment is intended.
                _popNonce = nonce;
            }
        }

        private async ValueTask AuthorizeRequestInternal(HttpMessage message, bool async)
        {
            if (message.Request.Uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException("Proof of possession token authentication is not permitted for non TLS-protected (HTTPS) endpoints.");
            }

            if (_popNonce != null)
            {
                // We fetched the challenge from the cache, but we have not initialized the Scopes in the base yet.
                var context = new TokenRequestContext(_scopes, parentRequestId: message.Request.ClientRequestId, isProofOfPossessionEnabled: true, proofOfPossessionNonce: _popNonce, requestUri: message.Request.Uri.ToUri(), requestMethod: message.Request.Method.ToString());
                if (async)
                {
                    await AuthenticateAndAuthorizeRequestAsync(message, context).ConfigureAwait(false);
                }
                else
                {
                    AuthenticateAndAuthorizeRequest(message, context);
                }

                return;
            }
        }

        private async ValueTask<bool> AuthorizeRequestOnChallengeAsyncInternal(HttpMessage message, bool async)
        {
            _popNonce = AuthorizationChallengeParser.GetChallengeParameterFromResponse(message.Response, "PoP", "nonce");
            if (_popNonce is null)
            {
                return false;
            }
            var context = new TokenRequestContext(_scopes, parentRequestId: message.Request.ClientRequestId, isProofOfPossessionEnabled: true, proofOfPossessionNonce: _popNonce, requestUri: message.Request.Uri.ToUri(), requestMethod: message.Request.Method.ToString());
            if (async)
            {
                await AuthenticateAndAuthorizeRequestAsync(message, context).ConfigureAwait(false);
            }
            else
            {
                AuthenticateAndAuthorizeRequest(message, context);
            }

            return true;
        }

        internal static class AuthorizationChallengeParser
    {
        /// <summary>
        /// Parses the specified parameter from a challenge header found in the specified <see cref="Response"/>.
        /// </summary>
        /// <param name="response">The <see cref="Response"/> to parse.</param>
        /// <param name="challengeScheme">The challenge scheme containing the <paramref name="challengeParameter"/>. For example: "Bearer"</param>
        /// <param name="challengeParameter">The parameter key name containing the value to return.</param>
        /// <returns>The value of the parameter name specified in <paramref name="challengeParameter"/> if it is found in the specified <paramref name="challengeScheme"/>.</returns>
        public static string GetChallengeParameterFromResponse(Response response, string challengeScheme, string challengeParameter)
        {
            if (!response.Headers.TryGetValue(HttpHeader.Names.WwwAuthenticate, out string headerValue))
            {
                return null;
            }

            ReadOnlySpan<char> scheme = challengeScheme.AsSpan();
            ReadOnlySpan<char> parameter = challengeParameter.AsSpan();
            ReadOnlySpan<char> headerSpan = headerValue.AsSpan();

            // Iterate through each challenge value.
            while (TryGetNextChallenge(ref headerSpan, out var challengeKey))
            {
                // Enumerate each key-value parameter until we find the parameter key on the specified scheme challenge.
                while (TryGetNextParameter(ref headerSpan, out var key, out var value))
                {
                    if (challengeKey.Equals(scheme, StringComparison.OrdinalIgnoreCase) && key.Equals(parameter, StringComparison.OrdinalIgnoreCase))
                    {
                        return value.ToString();
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Iterates through the challenge schemes present in a challenge header.
        /// </summary>
        /// <param name="headerValue">
        /// The header value which will be sliced to remove the first parsed <paramref name="challengeKey"/>.
        /// </param>
        /// <param name="challengeKey">The parsed challenge scheme.</param>
        /// <returns>
        /// <c>true</c> if a challenge scheme was successfully parsed.
        /// The value of <paramref name="headerValue"/> should be passed to <see cref="TryGetNextParameter"/> to parse the challenge parameters if <c>true</c>.
        /// </returns>
        internal static bool TryGetNextChallenge(ref ReadOnlySpan<char> headerValue, out ReadOnlySpan<char> challengeKey)
        {
            challengeKey = default;

            headerValue = headerValue.TrimStart(' ');
            int endOfChallengeKey = headerValue.IndexOf(' ');

            if (endOfChallengeKey < 0)
            {
                return false;
            }

            challengeKey = headerValue.Slice(0, endOfChallengeKey);

            // Slice the challenge key from the headerValue
            headerValue = headerValue.Slice(endOfChallengeKey + 1);

            return true;
        }

        /// <summary>
        /// Iterates through a challenge header value after being parsed by <see cref="TryGetNextChallenge"/>.
        /// </summary>
        /// <param name="headerValue">The header value after being parsed by <see cref="TryGetNextChallenge"/>.</param>
        /// <param name="paramKey">The parsed challenge parameter key.</param>
        /// <param name="paramValue">The parsed challenge parameter value.</param>
        /// <param name="separator">The challenge parameter key / value pair separator. The default is '='.</param>
        /// <returns>
        /// <c>true</c> if the next available challenge parameter was successfully parsed.
        /// <c>false</c> if there are no more parameters for the current challenge scheme or an additional challenge scheme was encountered in the <paramref name="headerValue"/>.
        /// The value of <paramref name="headerValue"/> should be passed again to <see cref="TryGetNextChallenge"/> to attempt to parse any additional challenge schemes if <c>false</c>.
        /// </returns>
        internal static bool TryGetNextParameter(ref ReadOnlySpan<char> headerValue, out ReadOnlySpan<char> paramKey, out ReadOnlySpan<char> paramValue, char separator = '=')
        {
            paramKey = default;
            paramValue = default;
            var spaceOrComma = " ,".AsSpan();

            // Trim any separater prefixes.
            headerValue = headerValue.TrimStart(spaceOrComma);

            int nextSpace = headerValue.IndexOf(' ');
            int nextSeparator = headerValue.IndexOf(separator);

            if (nextSpace < nextSeparator && nextSpace != -1)
            {
                // we encountered another challenge value.
                return false;
            }

            if (nextSeparator < 0)
                return false;

            // Get the paramKey.
            paramKey = headerValue.Slice(0, nextSeparator).Trim();

            // Slice to remove the 'paramKey=' from the parameters.
            headerValue = headerValue.Slice(nextSeparator + 1);

            // The start of paramValue will usually be a quoted string. Find the first quote.
            int quoteIndex = headerValue.IndexOf('\"');

            // Get the paramValue, which is delimited by the trailing quote.
            headerValue = headerValue.Slice(quoteIndex + 1);
            if (quoteIndex >= 0)
            {
                // The values are quote wrapped
                paramValue = headerValue.Slice(0, headerValue.IndexOf('\"'));
            }
            else
            {
                //the values are not quote wrapped (storage is one example of this)
                // either find the next space indicating the delimiter to the next value, or go to the end since this is the last value.
                int trailingDelimiterIndex = headerValue.IndexOfAny(spaceOrComma);
                if (trailingDelimiterIndex >= 0)
                {
                    paramValue = headerValue.Slice(0, trailingDelimiterIndex);
                }
                else
                {
                    paramValue = headerValue;
                }
            }

            // Slice to remove the '"paramValue"' from the parameters.
            if (headerValue != paramValue)
                headerValue = headerValue.Slice(paramValue.Length + 1);

            return true;
        }
    }
    }
}
