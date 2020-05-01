﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Identity.Client;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Identity
{
    /// <summary>
    /// A <see cref="TokenCredential"/> implementation which launches the system default browser to interactively authenticate a user, and obtain an access token.
    /// The browser will only be launched to authenticate the user once, then will silently acquire access tokens through the users refresh token as long as it's valid.
    /// </summary>
    public class InteractiveBrowserCredential : TokenCredential
    {
        private readonly MsalPublicClient _client;
        private readonly CredentialPipeline _pipeline;
        private AuthenticationRecord _record = null;
        private bool _disableAutomaticAuthentication = false;
        private const string AuthenticationRequiredMessage = "Interactive authentication is needed to acquire token. Call Authenticate to interactively authenticate.";
        private const string NoDefaultScopeMessage = "Authenticating in this environment requires the specifying a TokenRequestContext.";

        /// <summary>
        /// Creates a new <see cref="InteractiveBrowserCredential"/> with the specified options, which will authenticate users.
        /// </summary>
        public InteractiveBrowserCredential()
            : this(null, Constants.DeveloperSignOnClientId, CredentialPipeline.GetInstance(null), false)
        {

        }

        /// <summary>
        /// Creates a new <see cref="InteractiveBrowserCredential"/> with the specified options, which will authenticate users with the specified application.
        /// </summary>
        /// <param name="options">The client options for the newly created <see cref="InteractiveBrowserCredential"/>.</param>
        public InteractiveBrowserCredential(InteractiveBrowserCredentialOptions options)
            : this(options?.TenantId, options?.ClientId ?? Constants.DeveloperSignOnClientId, CredentialPipeline.GetInstance(options), options?.EnablePersistentCache ?? false)
        {
            _disableAutomaticAuthentication = options?.DisableAutomaticAuthentication ?? false;
            _record = options?.AuthenticationRecord;
        }

        /// <summary>
        /// Creates a new <see cref="InteractiveBrowserCredential"/> with the specified options, which will authenticate users with the specified application.
        /// </summary>
        /// <param name="clientId">The client id of the application to which the users will authenticate</param>
        public InteractiveBrowserCredential(string clientId)
            : this(null, clientId, CredentialPipeline.GetInstance(null), false)
        {

        }

        /// <summary>
        /// Creates a new <see cref="InteractiveBrowserCredential"/> with the specified options, which will authenticate users with the specified application.
        /// </summary>
        /// <param name="tenantId">The tenant id of the application and the users to authenticate. Can be null in the case of multi-tenant applications.</param>
        /// <param name="clientId">The client id of the application to which the users will authenticate</param>
        /// TODO: need to link to info on how the application has to be created to authenticate users, for multiple applications
        /// <param name="options">The client options for the newly created <see cref="InteractiveBrowserCredential"/>.</param>
        public InteractiveBrowserCredential(string tenantId, string clientId, TokenCredentialOptions options = default)
            : this(tenantId, clientId, CredentialPipeline.GetInstance(options), false)
        {
        }

        internal InteractiveBrowserCredential(string tenantId, string clientId, CredentialPipeline pipeline, bool attachSharedCache)
        {
            if (clientId is null) throw new ArgumentNullException(nameof(clientId));

            _pipeline = pipeline;

            _client = _pipeline.CreateMsalPublicClient(clientId, tenantId, "http://localhost", attachSharedCache);
        }

        internal InteractiveBrowserCredential(CredentialPipeline pipeline, MsalPublicClient client)
        {
            _pipeline = pipeline;

            _client = client;
        }

        /// <summary>
        /// Interactively authenticates a user via the default browser.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The result of the authentication request, containing the acquired <see cref="AccessToken"/>, and the <see cref="AuthenticationRecord"/> which can be used to silently authenticate the account.</returns>
        public virtual AuthenticationRecord Authenticate(CancellationToken cancellationToken = default)
        {
            // get the default scope for the authority, throw if no default scope exists
            string defaultScope = KnownAuthorityHosts.GetDefaultScope(_pipeline.AuthorityHost) ?? throw new CredentialUnavailableException(NoDefaultScopeMessage);

            return Authenticate(new TokenRequestContext(new string[] { defaultScope }), cancellationToken);
        }

        /// <summary>
        /// Interactively authenticates a user via the default browser.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The result of the authentication request, containing the acquired <see cref="AccessToken"/>, and the <see cref="AuthenticationRecord"/> which can be used to silently authenticate the account.</returns>
        public virtual async Task<AuthenticationRecord> AuthenticateAsync(CancellationToken cancellationToken = default)
        {
            // get the default scope for the authority, throw if no default scope exists
            string defaultScope = KnownAuthorityHosts.GetDefaultScope(_pipeline.AuthorityHost) ?? throw new CredentialUnavailableException(NoDefaultScopeMessage);

            return await AuthenticateAsync(new TokenRequestContext(new string[] { defaultScope }), cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Interactively authenticates a user via the default browser.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <param name="requestContext">The details of the authentication request.</param>
        /// <returns>The <see cref="AuthenticationRecord"/> of the authenticated account.</returns>
        public virtual AuthenticationRecord Authenticate(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return AuthenticateImplAsync(false, requestContext, cancellationToken).EnsureCompleted();
        }

        /// <summary>
        /// Interactively authenticates a user via the default browser.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <param name="requestContext">The details of the authentication request.</param>
        /// <returns>The <see cref="AuthenticationRecord"/> of the authenticated account.</returns>
        public virtual async Task<AuthenticationRecord> AuthenticateAsync(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return await AuthenticateImplAsync(true, requestContext, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Obtains an <see cref="AccessToken"/> token for a user account silently if the user has already authenticated, otherwise the default browser is launched to authenticate the user. This method is called by Azure SDK clients. It isn't intended for use in application code.
        /// </summary>
        /// <param name="requestContext">The details of the authentication request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An <see cref="AccessToken"/> which can be used to authenticate service client calls.</returns>
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return GetTokenImplAsync(false, requestContext, cancellationToken).EnsureCompleted();
        }

        /// <summary>
        /// Obtains an <see cref="AccessToken"/> token for a user account silently if the user has already authenticated, otherwise the default browser is launched to authenticate the user. This method is called by Azure SDK clients. It isn't intended for use in application code.
        /// </summary>
        /// <param name="requestContext">The details of the authentication request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An <see cref="AccessToken"/> which can be used to authenticate service client calls.</returns>
        public override async ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return await GetTokenImplAsync(true, requestContext, cancellationToken).ConfigureAwait(false);
        }

        private async Task<AuthenticationRecord> AuthenticateImplAsync(bool async, TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            using CredentialDiagnosticScope scope = _pipeline.StartGetTokenScope("InteractiveBrowserCredential.Authenticate", requestContext);

            try
            {
                AuthenticationResult result = await GetTokenViaBrowserLoginAsync(requestContext.Scopes, async, cancellationToken).ConfigureAwait(false);

                scope.Succeeded(new AccessToken(result.AccessToken, result.ExpiresOn));

                return _record;
            }
            catch (OperationCanceledException e)
            {
                scope.Failed(e);

                throw;
            }
            catch (Exception e)
            {
                throw scope.FailAndWrap(e);
            }
        }

        private async ValueTask<AccessToken> GetTokenImplAsync(bool async, TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            using CredentialDiagnosticScope scope = _pipeline.StartGetTokenScope("InteractiveBrowserCredential.GetToken", requestContext);

            try
            {
                if (_record != null)
                {
                    try
                    {
                        AuthenticationResult result = await _client.AcquireTokenSilentAsync(requestContext.Scopes, (AuthenticationAccount)_record, async, cancellationToken).ConfigureAwait(false);

                        return scope.Succeeded(new AccessToken(result.AccessToken, result.ExpiresOn));
                    }
                    catch (MsalUiRequiredException e)
                    {
                        if (_disableAutomaticAuthentication)
                        {
                            throw new AuthenticationRequiredException(AuthenticationRequiredMessage, requestContext, e);
                        }

                        AuthenticationResult result = await GetTokenViaBrowserLoginAsync(requestContext.Scopes, async, cancellationToken).ConfigureAwait(false);

                        return scope.Succeeded(new AccessToken(result.AccessToken, result.ExpiresOn));
                    }
                }
                else
                {
                    if (_disableAutomaticAuthentication)
                    {
                        throw new AuthenticationRequiredException(AuthenticationRequiredMessage, requestContext);
                    }

                    AuthenticationResult result = await GetTokenViaBrowserLoginAsync(requestContext.Scopes, async, cancellationToken).ConfigureAwait(false);

                    return scope.Succeeded(new AccessToken(result.AccessToken, result.ExpiresOn));
                }
            }
            catch (OperationCanceledException e)
            {
                scope.Failed(e);

                throw;
            }
            catch (Exception e)
            {
               throw scope.FailAndWrap(e);
            }
        }

        private async Task<AuthenticationResult> GetTokenViaBrowserLoginAsync(string[] scopes, bool async, CancellationToken cancellationToken)
        {
            AuthenticationResult result = await _client.AcquireTokenInteractiveAsync(scopes, Prompt.SelectAccount, async, cancellationToken).ConfigureAwait(false);

            _record = new AuthenticationRecord(result);

            return result;
        }
    }
}
