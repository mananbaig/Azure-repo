﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;
using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault
{
    internal class ChallengeBasedAuthenticationPolicy : BearerTokenChallengeAuthenticationPolicy
    {
        private static ConcurrentDictionary<string, AuthorityScope> _scopeCache = new ConcurrentDictionary<string, AuthorityScope>();
        private AuthorityScope _scope;

        public ChallengeBasedAuthenticationPolicy(TokenCredential credential) : base(credential, Array.Empty<string>())
        { }

        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            base.Process(message, pipeline);
        }

        public override async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            await base.ProcessAsync(message, pipeline).ConfigureAwait(false);
        }

        /// <inheritdoc cref="BearerTokenChallengeAuthenticationPolicy.AuthenticateRequestFromChallengeAsync(HttpMessage, bool)" />
        protected override async ValueTask PreProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            if (message.Request.Uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new InvalidOperationException("Bearer token authentication is not permitted for non TLS protected (https) endpoints.");
            }

            // if this policy doesn't have _scope cached try to get it from the static challenge cache.
            if (_scope != null)
            {
                return;
            }

            string authority = GetRequestAuthority(message.Request);
            _scopeCache.TryGetValue(authority, out _scope);

            if (_scope == null)
            {
                // The body is removed from the initial request because Key Vault supports other authentication schemes which also protect the body of the request.
                // As a result, before we know the auth scheme we need to avoid sending an unprotected body to Key Vault.
                // We don't currently support this enhanced auth scheme in the SDK but we still don't want to send any unprotected data to vaults which require it.

                RequestContent originalContent = message.Request.Content;
                message.Request.Content = null;

                if (async)
                {
                    await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
                }
                else
                {
                    ProcessNext(message, pipeline);
                }

                // set the content to the original content.
                message.Request.Content = originalContent;
            }
            else
            {
                // We fetched the scope from the cache, but we have not initialized the Scopes in the base yet.
                var context = new TokenRequestContext(_scope.Scopes);
                await AuthenticateRequestAsync(message, context, async).ConfigureAwait(false);
            }
        }

        protected override async ValueTask<bool> AuthenticateRequestFromChallengeAsync(HttpMessage message, bool async)
        {
            string authority = GetRequestAuthority(message.Request);
            string scope = AuthorizationChallengeParser.GetChallengeParameterFromResponse(message.Response, "Bearer", "resource");
            if (scope != null)
            {
                scope = scope + "/.default";
            }
            else
            {
                scope = AuthorizationChallengeParser.GetChallengeParameterFromResponse(message.Response, "Bearer", "scope");
            }

            if (scope is null)
            {
                if (_scopeCache.TryGetValue(authority, out _scope))
                {
                    return false;
                }
            }
            else
            {
                _scope = new AuthorityScope(authority, new string[] { scope });
                _scopeCache[authority] = _scope;
            }

            var context = new TokenRequestContext(_scope.Scopes, message.Request.ClientRequestId);
            await AuthenticateRequestAsync(message, context, async).ConfigureAwait(false);
            return true;
        }

        internal class AuthorityScope
        {
            internal AuthorityScope(string authrority, string[] scopes)
            {
                Authority = authrority;
                Scopes = scopes;
            }
            public string Authority { get; }

            public string[] Scopes { get; }
        }

        internal static void ClearCache()
        {
            _scopeCache.Clear();
        }

        private static string GetRequestAuthority(Request request)
        {
            Uri uri = request.Uri.ToUri();

            string authority = uri.Authority;

            if (!authority.Contains(":") && uri.Port > 0)
            {
                // Append port for complete authority
                authority = uri.Authority + ":" + uri.Port.ToString(CultureInfo.InvariantCulture);
            }

            return authority;
        }
    }
}
