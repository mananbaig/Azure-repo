﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.Attestation.Models;

namespace Azure.Security.Attestation
{
    /// <summary>
    /// Attestation Client for the Microsoft Azure Attestation service.
    ///
    /// The Attestation client contains the implementation of the "Attest" family of MAA apis.
    /// </summary>
    public class AttestationAdministrativeClient
    {
        private readonly AttestationClientOptions _options;
        private readonly Uri _endpoint;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PolicyRestClient _policyClient;
        private readonly PolicyCertificatesRestClient _policyManagementClient;
        private readonly AttestationClient _attestationClient;

        private AttestationSigner[] _signers;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttestationClient"/> class.
        /// </summary>
        /// <param name="endpoint">Uri for the Microsoft Azure Attestation Service Instance to use.</param>
        /// <param name="credential">Credentials to be used in the Client.</param>
#pragma warning disable CA1801
        public AttestationAdministrativeClient(Uri endpoint, TokenCredential credential): this(endpoint, credential, new AttestationClientOptions())
        {
        }
#pragma warning restore

        /// <summary>
        /// Initializes a new instance of the <see cref="AttestationClient"/> class.
        /// </summary>
        /// <param name="endpoint">Uri for the Microsoft Azure Attestation Service Instance to use.</param>
        /// <param name="credential">Credentials to be used in the Client.</param>
        /// <param name="options"><see cref="AttestationClientOptions"/> used to configure the API client.</param>
#pragma warning disable CA1801
        public AttestationAdministrativeClient(Uri endpoint, TokenCredential credential, AttestationClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            _options = options;

            // Add the authentication policy to our builder.
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, GetDefaultScope()));

            // Initialize the ClientDiagnostics.
            _clientDiagnostics = new ClientDiagnostics(options);

            _endpoint = endpoint;

            // Initialize the Policy Rest Client.
            _policyClient = new PolicyRestClient(_clientDiagnostics, _pipeline, _endpoint.AbsoluteUri, options.Version);

            // Initialize the Certificates Rest Client.
            _policyManagementClient = new PolicyCertificatesRestClient(_clientDiagnostics, _pipeline, _endpoint.AbsoluteUri, options.Version);

            // Initialize the Certificates Rest Client.
            _attestationClient = new AttestationClient(endpoint, credential, options);
        }
#pragma warning restore
        /// <summary>
        /// Parameterless constructor for mocking.
        /// </summary>
        protected AttestationAdministrativeClient()
        {
        }

#pragma warning disable CA1822
#pragma warning disable CA1801
        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="attestationType">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{StoredAttestationPolicy}"/> with the policy for the specified attestation type.</returns>
        public virtual AttestationResponse<StoredAttestationPolicy> GetPolicy(AttestationType attestationType, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(AttestationAdministrativeClient)}.{nameof(GetPolicy)}");
            scope.Start();
            try
            {
                var result = _policyClient.Get(attestationType, cancellationToken);
                var token = new AttestationToken<StoredAttestationPolicy>(result.Value.Token);
                return new AttestationResponse<StoredAttestationPolicy>(result.GetRawResponse(), token);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="attestationType">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{StoredAttestationPolicy}"/> with the policy for the specified attestation type.</returns>
        public virtual async Task<AttestationResponse<StoredAttestationPolicy>> GetPolicyAsync(AttestationType attestationType, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(AttestationAdministrativeClient)}.{nameof(GetPolicy)}");
            scope.Start();
            try
            {
                var result = await _policyClient.GetAsync(attestationType, cancellationToken).ConfigureAwait(false);
                var token = new AttestationToken<StoredAttestationPolicy>(result.Value.Token);
                if (_options.ValidateAttestationTokens)
                {
                    token.ValidateToken(GetSigners());
                }
                return new AttestationResponse<StoredAttestationPolicy>(result.GetRawResponse(), token);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="attestationType"><see cref="AttestationType"/> whose policy should be set.</param>
        /// <param name="policyToSet">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyResult}"/> with the policy for the specified attestation type.</returns>
        public virtual AttestationResponse<PolicyResult> SetPolicy(AttestationType attestationType, AttestationToken<StoredAttestationPolicy> policyToSet, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="attestationType"><see cref="AttestationType"/> whose policy should be set.</param>
        /// <param name="policyToSet">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyResult}"/> with the policy for the specified attestation type.</returns>
        public virtual Task<AttestationResponse<PolicyResult>> SetPolicyAsync(AttestationType attestationType, AttestationToken<StoredAttestationPolicy> policyToSet, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="attestationType"><see cref="AttestationType"/> whose policy should be set.</param>
        /// <param name="policyToSet">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyResult}"/> with the policy for the specified attestation type.</returns>
        public virtual AttestationResponse<PolicyResult> ResetPolicy(AttestationType attestationType, AttestationToken policyToSet = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="attestationType"><see cref="AttestationType"/> whose policy should be set.</param>
        /// <param name="policyToSet">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyCertificatesModificationResult}"/> with the policy for the specified attestation type.</returns>
        public virtual Task<AttestationResponse<PolicyResult>> ResetPolicyAsync(AttestationType attestationType, AttestationToken policyToSet = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="certificateToAdd">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyCertificatesModificationResult}"/> with the policy for the specified attestation type.</returns>
        public virtual AttestationResponse<PolicyCertificatesModificationResult> AddPolicyManagementCertificate(AttestationToken<X509Certificate2> certificateToAdd, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="certificateToAdd">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyCertificatesModificationResult}"/> with the policy for the specified attestation type.</returns>
        public virtual Task<AttestationResponse<PolicyCertificatesModificationResult>> AddPolicyManagementCertificateAsync(AttestationToken<X509Certificate2> certificateToAdd, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the attesttion policy for the specified <see cref="AttestationType"/>.
        /// </summary>
        /// <param name="certificateToAdd">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyCertificatesModificationResult}"/> with the policy for the specified attestation type.</returns>
        public virtual AttestationResponse<PolicyCertificatesModificationResult> RemovePolicyManagementCertificate(AttestationToken<X509Certificate2> certificateToAdd, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Removes one of the attestation policy management certificates.
        /// </summary>
        /// <param name="certificateToAdd">Attestation Type to retrive.</param>
        /// <param name="cancellationToken"></param>
        /// <returns>An <see cref="AttestationResponse{PolicyCertificatesModificationResult}"/> with the policy for the specified attestation type.</returns>
        public virtual Task<AttestationResponse<PolicyCertificatesModificationResult>> RemovePolicyManagementCertificateAsync(AttestationToken<X509Certificate2> certificateToAdd, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the set of policy management certificates currently configured for the attestation service.
        ///
        /// If the service is running in AAD mode, this list will be empty.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token used to cancel the operation.</param>
        /// <returns>A set of <see cref="X509Certificate2"/> objects representing the set of root certificates for policy management.</returns>
        public virtual AttestationResponse<PolicyCertificatesResult> GetPolicyManagementCertificates(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the set of policy management certificates currently configured for the attestation service.
        ///
        /// If the service is running in AAD mode, this list will be empty.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token used to cancel the operation.</param>
        /// <returns>A set of <see cref="X509Certificate2"/> objects representing the set of root certificates for policy management.</returns>
        public virtual Task<AttestationResponse<PolicyCertificatesResult>> GetPolicyManagementCertificatesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

#pragma warning restore

        // A helper method to construct the default scope based on the service endpoint.
        private static string GetDefaultScope() => $"https://attest.azure.net";

        private AttestationSigner[] GetSigners()
        {
            lock (this)
            {
                if (_signers == null)
                {
                    _signers = _attestationClient.GetSigningCertificates();
                }

                return _signers;
            }
        }

    }
}
