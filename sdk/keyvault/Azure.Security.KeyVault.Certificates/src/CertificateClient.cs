﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault.Certificates
{
    /// <summary>
    /// The CertificateClient provides synchronous and asynchronous methods to manage <see cref="KeyVaultCertificate"/>s in Azure Key Vault. The client
    /// supports creating, retrieving, updating, deleting, purging, backing up, restoring and listing the <see cref="KeyVaultCertificate"/>, along with managing
    /// certificate <see cref="CertificateIssuer"/>s and <see cref="CertificateContact"/>s. The client also supports listing <see cref="DeletedCertificate"/> for a soft-delete
    /// enabled key vault.
    /// </summary>
    public class CertificateClient
    {
        internal const string CertificatesPath = "/certificates/";
        internal const string DeletedCertificatesPath = "/deletedcertificates/";
        private const string IssuersPath = "/certificates/issuers/";
        private const string ContactsPath = "/contacts/";

        private readonly KeyVaultPipeline _pipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateClient"/> class for mocking.
        /// </summary>
        protected CertificateClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateClient"/> class for the specified vault.
        /// </summary>
        /// <param name="vaultUri">A <see cref="Uri"/> to the vault on which the client operates. Appears as "DNS Name" in the Azure portal.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to authenticate requests to the vault, such as DefaultAzureCredential.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vaultUri"/> or <paramref name="credential"/> is null.</exception>
        public CertificateClient(Uri vaultUri, TokenCredential credential)
            : this(vaultUri, credential, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateClient"/> class for the specified vault.
        /// </summary>
        /// <param name="vaultUri">A <see cref="Uri"/> to the vault on which the client operates. Appears as "DNS Name" in the Azure portal.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to authenticate requests to the vault, such as DefaultAzureCredential.</param>
        /// <param name="options"><see cref="CertificateClientOptions"/> that allow to configure the management of the request sent to Key Vault.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vaultUri"/> or <paramref name="credential"/> is null.</exception>
        public CertificateClient(Uri vaultUri, TokenCredential credential, CertificateClientOptions options)
        {
            Argument.AssertNotNull(vaultUri, nameof(vaultUri));
            Argument.AssertNotNull(credential, nameof(credential));

            options ??= new CertificateClientOptions();

            HttpPipeline pipeline = HttpPipelineBuilder.Build(options, new ChallengeBasedAuthenticationPolicy(credential));

            _pipeline = new KeyVaultPipeline(vaultUri, options.GetVersionString(), pipeline, new ClientDiagnostics(options));
        }

        /// <summary>
        /// Gets the <see cref="Uri"/> of the vault used to create this instance of the <see cref="CertificateClient"/>.
        /// </summary>
        public virtual Uri VaultUri => _pipeline.VaultUri;

        /// <summary>
        /// Starts a long running operation to create a <see cref="KeyVaultCertificate"/> in the vault with the specified certificate policy.
        /// </summary>
        /// <remarks>
        /// If no certificate with the specified name exists it will be created, otherwise a new version of the existing certificate will be created. This operation requires the certificates/create permission.
        /// </remarks>
        /// <param name="certificateName">The name of the certificate to create</param>
        /// <param name="policy">The <see cref="CertificatePolicy"/> which governs the proprerties and lifecycle of the created certificate</param>
        /// <param name="enabled">Specifies whether the certificate should be created in an enabled state. If null, the server default will be used.</param>
        /// <param name="tags">Tags to be applied to the created certificate</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="CertificateOperation"/> which contians details on the create operation, and can be used to retrieve updated status</returns>
        public virtual CertificateOperation StartCreateCertificate(string certificateName, CertificatePolicy policy, bool? enabled = default, IDictionary<string, string> tags = default, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(policy, nameof(policy));

            var parameters = new CertificateCreateParameters(policy, enabled, tags);

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.StartCreateCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = _pipeline.SendRequest(RequestMethod.Post, parameters, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/create");

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Starts a long running operation to create a <see cref="KeyVaultCertificate"/> in the vault with the specified certificate policy.
        /// </summary>
        /// <remarks>
        /// If no certificate with the specified name exists it will be created, otherwise a new version of the existing certificate will be created. This operation requires the certificates/create permission.
        /// </remarks>
        /// <param name="certificateName">The name of the certificate to create</param>
        /// <param name="policy">The <see cref="CertificatePolicy"/> which governs the proprerties and lifecycle of the created certificate</param>
        /// <param name="enabled">Specifies whether the certificate should be created in an enabled state. If null, the server default will be used.</param>
        /// <param name="tags">Tags to be applied to the created certificate</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="CertificateOperation"/> which contians details on the create operation, and can be used to retrieve updated status</returns>
        public virtual async Task<CertificateOperation> StartCreateCertificateAsync(string certificateName, CertificatePolicy policy, bool? enabled = default, IDictionary<string, string> tags = default, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(policy, nameof(policy));

            var parameters = new CertificateCreateParameters(policy, enabled, tags);

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.StartCreateCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = await _pipeline.SendRequestAsync(RequestMethod.Post, parameters, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/create").ConfigureAwait(false);

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the latest version of the <see cref="KeyVaultCertificate"/> along with it's <see cref="CertificatePolicy"/>. This operation requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to retrieve</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A response containing the certificate and policy as a <see cref="KeyVaultCertificateWithPolicy"/> instance</returns>
        public virtual Response<KeyVaultCertificateWithPolicy> GetCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Get, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, certificateName);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the latest version of the <see cref="KeyVaultCertificate"/> along with it's <see cref="CertificatePolicy"/>. This operation requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to retrieve</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A response containing the certificate and policy as a <see cref="KeyVaultCertificateWithPolicy"/> instance</returns>
        public virtual async Task<Response<KeyVaultCertificateWithPolicy>> GetCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Get, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, certificateName).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific version of the <see cref="KeyVaultCertificate"/>. This operation requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to retrieve</param>
        /// <param name="version">Ther version of the <see cref="KeyVaultCertificate"/> to retrieve</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The requested <see cref="KeyVaultCertificate"/></returns>
        public virtual Response<KeyVaultCertificate> GetCertificateVersion(string certificateName, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificateVersion");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Get, () => new KeyVaultCertificate(), cancellationToken, CertificatesPath, certificateName, "/", version);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific version of the <see cref="KeyVaultCertificate"/>. This operation requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to retrieve</param>
        /// <param name="version">Ther version of the <see cref="KeyVaultCertificate"/> to retrieve</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The requested <see cref="KeyVaultCertificate"/></returns>
        public virtual async Task<Response<KeyVaultCertificate>> GetCertificateVersionAsync(string certificateName, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificateVersion");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Get, () => new KeyVaultCertificate(), cancellationToken, CertificatesPath, certificateName, "/", version).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified <see cref="KeyVaultCertificate"/> with the specified values for its mutable properties. This operation requires the certificates/update permission.
        /// </summary>
        /// <param name="properties">The <see cref="CertificateProperties"/> object with updated properties.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated <see cref="KeyVaultCertificate"/></returns>
        public virtual Response<KeyVaultCertificate> UpdateCertificateProperties(CertificateProperties properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            var parameters = new CertificateUpdateParameters(properties);

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.UpdateCertificateProperties");
            scope.AddAttribute("certificate", properties.Name);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Patch, parameters, () => new KeyVaultCertificate(), cancellationToken, CertificatesPath, properties.Name, "/", properties.Version);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified <see cref="KeyVaultCertificate"/> with the specified values for its mutable properties. This operation requires the certificates/update permission.
        /// </summary>
        /// <param name="properties">The <see cref="CertificateProperties"/> object with updated properties.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated <see cref="KeyVaultCertificate"/></returns>
        public virtual async Task<Response<KeyVaultCertificate>> UpdateCertificatePropertiesAsync(CertificateProperties properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            var parameters = new CertificateUpdateParameters(properties);

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.UpdateCertificateProperties");
            scope.AddAttribute("certificate", properties.Name);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Patch, parameters, () => new KeyVaultCertificate(), cancellationToken, CertificatesPath, properties.Name, "/", properties.Version).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes all versions of the specified <see cref="KeyVaultCertificate"/>. If the vault is soft delete enabled, the <see cref="KeyVaultCertificate"/> will be marked for perminent deletion
        /// and can be recovered with <see cref="StartRecoverDeletedCertificate"/>, or purged with <see cref="PurgeDeletedCertificate"/>. This operation requires the certificates/delete permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to delete</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>
        /// A <see cref="DeleteCertificateOperation"/> to wait on this long-running operation.
        /// If the Key Vault is soft delete-enabled, you only need to wait for the operation to complete if you need to recover or purge the certificate;
        /// otherwise, the certificate is deleted automatically on the <see cref="DeletedCertificate.ScheduledPurgeDate"/>.
        /// </returns>
        public virtual DeleteCertificateOperation StartDeleteCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.StartDeleteCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<DeletedCertificate> response = _pipeline.SendRequest(RequestMethod.Delete, () => new DeletedCertificate(), cancellationToken, CertificatesPath, certificateName);
                return new DeleteCertificateOperation(_pipeline, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes all versions of the specified <see cref="KeyVaultCertificate"/>. If the vault is soft delete enabled, the <see cref="KeyVaultCertificate"/> will be marked for perminent deletion
        /// and can be recovered with <see cref="StartRecoverDeletedCertificate"/>, or purged with <see cref="PurgeDeletedCertificate"/>. This operation requires the certificates/delete permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to delete</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>
        /// A <see cref="DeleteCertificateOperation"/> to wait on this long-running operation.
        /// If the Key Vault is soft delete-enabled, you only need to wait for the operation to complete if you need to recover or purge the certificate;
        /// otherwise, the certificate is deleted automatically on the <see cref="DeletedCertificate.ScheduledPurgeDate"/>.
        /// </returns>
        public virtual async Task<DeleteCertificateOperation> StartDeleteCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.StartDeleteCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<DeletedCertificate> response = await _pipeline.SendRequestAsync(RequestMethod.Delete, () => new DeletedCertificate(), cancellationToken, CertificatesPath, certificateName).ConfigureAwait(false);
                return new DeleteCertificateOperation(_pipeline, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the specified deleted <see cref="KeyVaultCertificate"/>. This operation is only applicable in vaults enabled for soft-delete, and
        /// requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="DeletedCertificate"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The details of the <see cref="DeletedCertificate"/></returns>
        public virtual Response<DeletedCertificate> GetDeletedCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetDeletedCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Get, () => new DeletedCertificate(), cancellationToken, DeletedCertificatesPath, certificateName);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the specified deleted <see cref="KeyVaultCertificate"/>. This operation is only applicable in vaults enabled for soft-delete, and
        /// requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="DeletedCertificate"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The details of the <see cref="DeletedCertificate"/></returns>
        public virtual async Task<Response<DeletedCertificate>> GetDeletedCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetDeletedCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Get, () => new DeletedCertificate(), cancellationToken, DeletedCertificatesPath, certificateName).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recovers the <see cref="DeletedCertificate"/> to its pre-deleted state. This operation is only applicable in vaults enabled for soft-delete, and
        /// requires the certificates/recover permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="DeletedCertificate"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="RecoverDeletedCertificateOperation"/> to wait on this long-running operation.</returns>
        public virtual RecoverDeletedCertificateOperation StartRecoverDeletedCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.StartRecoverDeletedCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<KeyVaultCertificateWithPolicy> response = _pipeline.SendRequest(RequestMethod.Post, () => new KeyVaultCertificateWithPolicy(), cancellationToken, DeletedCertificatesPath, certificateName, "/recover");
                return new RecoverDeletedCertificateOperation(_pipeline, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recovers the <see cref="DeletedCertificate"/> to its pre-deleted state. This operation is only applicable in vaults enabled for soft-delete, and
        /// requires the certificates/recover permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="DeletedCertificate"/></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="RecoverDeletedCertificateOperation"/> to wait on this long-running operation.</returns>
        public virtual async Task<RecoverDeletedCertificateOperation> StartRecoverDeletedCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.StartRecoverDeletedCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<KeyVaultCertificateWithPolicy> response = await _pipeline.SendRequestAsync(RequestMethod.Post, () => new KeyVaultCertificateWithPolicy(), cancellationToken, DeletedCertificatesPath, certificateName, "/recover").ConfigureAwait(false);
                return new RecoverDeletedCertificateOperation(_pipeline, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently and irreversibly deletes the specified deleted certificate, without the possibility of recovery. This operation is only applicable in vaults enabled for soft-delete, and
        /// requires the certificates/purge permission. The operation is not available if the DeletedCertificate.RecoveryLevel of the DeletedCertificate does not specify 'Purgeable'.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="DeletedCertificate"/> to perminantly delete</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The http response from the service</returns>
        public virtual Response PurgeDeletedCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.PurgeDeletedCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Delete, cancellationToken, DeletedCertificatesPath, certificateName);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently and irreversibly deletes the specified deleted certificate, without the possibility of recovery. This operation is only applicable in vaults enabled for soft-delete, and
        /// requires the certificates/purge permission. The operation is not available if the DeletedCertificate.RecoveryLevel of the DeletedCertificate does not specify 'Purgeable'.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="DeletedCertificate"/> to perminantly delete</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        public virtual async Task<Response> PurgeDeletedCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.PurgeDeletedCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Delete, cancellationToken, DeletedCertificatesPath, certificateName).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a backup of the certificate, including all versions, which can be used to restore the certificate to the state at the time of the backup in the case the certificate is deleted, or to
        /// restore the certificate to a different vault in the same region as the original value. This operation requires the certificate/backup permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to backup</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The certificate backup</returns>
        public virtual Response<byte[]> BackupCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.BackupCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateBackup> backup = _pipeline.SendRequest(RequestMethod.Post, () => new CertificateBackup(), cancellationToken, CertificatesPath, certificateName, "/backup");

                return Response.FromValue(backup.Value.Value, backup.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a backup of the certificate, including all versions, which can be used to restore the certificate to the state at the time of the backup in the case the certificate is deleted, or to
        /// restore the certificate to a different vault in the same region as the original value. This operation requires the certificate/backup permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to backup</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The certificate backup</returns>
        public virtual async Task<Response<byte[]>> BackupCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.BackupCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateBackup> backup = await _pipeline.SendRequestAsync(RequestMethod.Post, () => new CertificateBackup(), cancellationToken, CertificatesPath, certificateName, "/backup").ConfigureAwait(false);

                return Response.FromValue(backup.Value.Value, backup.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restores a <see cref="KeyVaultCertificate"/>, including all versions, from a backup created from the <see cref="BackupCertificate"/> or <see cref="BackupCertificateAsync"/>. The backup must be restored
        /// to a vault in the same region as its original vault. This operation requires the certificate/restore permission.
        /// </summary>
        /// <param name="backup">The backup of the <see cref="KeyVaultCertificate"/> to restore</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The restored certificate and policy</returns>
        public virtual Response<KeyVaultCertificateWithPolicy> RestoreCertificateBackup(byte[] backup, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(backup, nameof(backup));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.RestoreCertificateBackup");
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Post, new CertificateBackup { Value = backup }, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, "/restore");
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restores a <see cref="KeyVaultCertificate"/>, including all versions, from a backup created from the <see cref="BackupCertificate"/> or <see cref="BackupCertificateAsync"/>. The backup must be restored
        /// to a vault in the same region as its original vault. This operation requires the certificate/restore permission.
        /// </summary>
        /// <param name="backup">The backup of the <see cref="KeyVaultCertificate"/> to restore</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The restored certificate and policy</returns>
        public virtual async Task<Response<KeyVaultCertificateWithPolicy>> RestoreCertificateBackupAsync(byte[] backup, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(backup, nameof(backup));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.RestoreCertificateBackup");
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Post, new CertificateBackup { Value = backup }, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, "/restore").ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Imports a pre-existing certificate to the key vault. The specified certificate must be in PFX or PEM format, and must contain the private key as well as the x509 certificates. This operation requires the
        /// certifcates/import permission.
        /// </summary>
        /// <param name="certificateImportOptions">The details of the certificate to import to the key vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The imported certificate and policy</returns>
        public virtual Response<KeyVaultCertificateWithPolicy> ImportCertificate(ImportCertificateOptions certificateImportOptions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(certificateImportOptions, nameof(certificateImportOptions));
            Argument.AssertNotNullOrEmpty(certificateImportOptions.Name, nameof(certificateImportOptions.Name));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.ImportCertificate");
            scope.AddAttribute("certificate", certificateImportOptions.Name);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Post, certificateImportOptions, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, "/", certificateImportOptions.Name, "/import");
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Imports a pre-existing certificate to the key vault. The specified certificate must be in PFX or PEM format, and must contain the private key as well as the x509 certificates. This operation requires the
        /// certifcates/import permission.
        /// </summary>
        /// <param name="certificateImportOptions">The details of the certificate to import to the key vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The imported certificate and policy</returns>
        public virtual async Task<Response<KeyVaultCertificateWithPolicy>> ImportCertificateAsync(ImportCertificateOptions certificateImportOptions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(certificateImportOptions, nameof(certificateImportOptions));
            Argument.AssertNotNullOrEmpty(certificateImportOptions.Name, nameof(certificateImportOptions.Name));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.ImportCertificate");
            scope.AddAttribute("certificate", certificateImportOptions.Name);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Post, certificateImportOptions, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, "/", certificateImportOptions.Name, "/import").ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the properties of all certificates in the specified vault. You can use the returned <see cref="CertificateProperties.Name"/> in subsequent calls to <see cref="GetCertificate(string, CancellationToken)"/>.
        /// This operation requires the certificates/list permission.
        /// </summary>
        /// <param name="includePending">Specifies whether to include certificates in a pending state as well</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of certificate metadata</returns>
        public virtual Pageable<CertificateProperties> GetPropertiesOfCertificates(bool includePending = default, CancellationToken cancellationToken = default)
        {
            Uri firstPageUri = _pipeline.CreateFirstPageUri(CertificatesPath, ("includePending", includePending.ToString(CultureInfo.InvariantCulture).ToLowerInvariant()));

            return PageResponseEnumerator.CreateEnumerable(nextLink => _pipeline.GetPage(firstPageUri, nextLink, () => new CertificateProperties(), "Azure.Security.KeyVault.Keys.KeyClient.GetPropertiesOfCertificates", cancellationToken));
        }

        /// <summary>
        /// Lists the properties of all certificates in the specified vault. You can use the returned <see cref="CertificateProperties.Name"/> in subsequent calls to <see cref="GetCertificateAsync(string, CancellationToken)"/>.
        /// This operation requires the certificates/list permission.
        /// </summary>
        /// <param name="includePending">Specifies whether to include certificates in a pending state as well</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of certificate metadata</returns>
        public virtual AsyncPageable<CertificateProperties> GetPropertiesOfCertificatesAsync(bool includePending = default, CancellationToken cancellationToken = default)
        {
            Uri firstPageUri = _pipeline.CreateFirstPageUri(CertificatesPath, ("includePending", includePending.ToString(CultureInfo.InvariantCulture).ToLowerInvariant()));

            return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => _pipeline.GetPageAsync(firstPageUri, nextLink, () => new CertificateProperties(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetPropertiesOfCertificates", cancellationToken));
        }

        /// <summary>
        /// Lists the properties of all versions of the specified certificate in the specified vault. You can use the returned <see cref="CertificateProperties.Name"/> in subsequent calls to <see cref="GetCertificateVersion(string, string, CancellationToken)"/>.
        /// This operation requires the certificates/list permission.
        /// </summary>
        /// <param name="certificateName">The name of the certificate to retrieve the versions of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of the certificate's versions</returns>
        public virtual Pageable<CertificateProperties> GetPropertiesOfCertificateVersions(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            Uri firstPageUri = _pipeline.CreateFirstPageUri($"{CertificatesPath}{certificateName}/versions");

            return PageResponseEnumerator.CreateEnumerable(nextLink => _pipeline.GetPage(firstPageUri, nextLink, () => new CertificateProperties(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetPropertiesOfCertificateVersions", cancellationToken));
        }

        /// <summary>
        /// Lists the properties of all versions of the specified certificate in the specified vault. You can use the returned <see cref="CertificateProperties.Name"/> in subsequent calls to <see cref="GetCertificateVersionAsync(string, string, CancellationToken)"/>.
        /// This operation requires the certificates/list permission.
        /// </summary>
        /// <param name="certificateName">The name of the certificate to retrieve the versions of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of the certificate's versions</returns>
        public virtual AsyncPageable<CertificateProperties> GetPropertiesOfCertificateVersionsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            Uri firstPageUri = _pipeline.CreateFirstPageUri($"{CertificatesPath}{certificateName}/versions");

            return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => _pipeline.GetPageAsync(firstPageUri, nextLink, () => new CertificateProperties(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetPropertiesOfCertificateVersions", cancellationToken));
        }

        /// <summary>
        /// Enumerates the deleted certificates in the vault. This operation is only available on soft-delete enabled vaults, and requires the certificates/list/get permissions.
        /// </summary>
        /// <param name="includePending">Specifies whether to include certificates in a delete pending state as well</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of deleted certificates</returns>
        public virtual Pageable<DeletedCertificate> GetDeletedCertificates(bool includePending = default, CancellationToken cancellationToken = default)
        {
            Uri firstPageUri = _pipeline.CreateFirstPageUri(DeletedCertificatesPath, ("includePending", includePending.ToString(CultureInfo.InvariantCulture).ToLowerInvariant()));

            return PageResponseEnumerator.CreateEnumerable(nextLink => _pipeline.GetPage(firstPageUri, nextLink, () => new DeletedCertificate(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetDeletedCertificates", cancellationToken));
        }

        /// <summary>
        /// Enumerates the deleted certificates in the vault. This operation is only available on soft-delete enabled vaults, and requires the certificates/list/get permissions.
        /// </summary>
        /// <param name="includePending">Specifies whether to include certificates in a delete pending state as well</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of deleted certificates</returns>
        public virtual AsyncPageable<DeletedCertificate> GetDeletedCertificatesAsync(bool includePending = default, CancellationToken cancellationToken = default)
        {
            Uri firstPageUri = _pipeline.CreateFirstPageUri(DeletedCertificatesPath, ("includePending", includePending.ToString(CultureInfo.InvariantCulture).ToLowerInvariant()));

            return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => _pipeline.GetPageAsync(firstPageUri, nextLink, () => new DeletedCertificate(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetDeletedCertificates", cancellationToken));
        }

        //
        // Policy
        //

        /// <summary>
        /// Retrieves the <see cref="CertificatePolicy"/> of the specified certificate. This operation requires the certificate/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the certificate to retrieve the policy of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The <see cref="CertificatePolicy"/> of the specified certificate</returns>
        public virtual Response<CertificatePolicy> GetCertificatePolicy(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificatePolicy");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Get, () => new CertificatePolicy(), cancellationToken, CertificatesPath, certificateName, "/policy");
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the <see cref="CertificatePolicy"/> of the specified certificate. This operation requires the certificate/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the certificate to retrieve the policy of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The <see cref="CertificatePolicy"/> of the specified certificate</returns>
        public virtual async Task<Response<CertificatePolicy>> GetCertificatePolicyAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificatePolicy");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Get, () => new CertificatePolicy(), cancellationToken, CertificatesPath, certificateName, "/policy").ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the <see cref="CertificatePolicy"/> of the specified certificate. This operation requires the certificate/update permission.
        /// </summary>
        /// <param name="certificateName">The name of the certificate to update the policy of</param>
        /// <param name="policy">The updated policy for the specified certificate</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated certificate policy</returns>
        public virtual Response<CertificatePolicy> UpdateCertificatePolicy(string certificateName, CertificatePolicy policy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.UpdateCertificatePolicy");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Patch, policy, () => new CertificatePolicy(), cancellationToken, CertificatesPath, certificateName, "/policy");
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the <see cref="CertificatePolicy"/> of the specified certificate. This operation requires the certificate/update permission.
        /// </summary>
        /// <param name="certificateName">The name of the certificate to update the policy of</param>
        /// <param name="policy">The updated policy for the specified certificate</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated certificate policy</returns>
        public virtual async Task<Response<CertificatePolicy>> UpdateCertificatePolicyAsync(string certificateName, CertificatePolicy policy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.UpdateCertificatePolicy");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Patch, policy, () => new CertificatePolicy(), cancellationToken, CertificatesPath, certificateName, "/policy").ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        //
        // Issuer
        //

        /// <summary>
        /// Creates or replaces a certificate <see cref="CertificateIssuer"/> in the key vault. This operation requires the certificates/setissuers permission.
        /// </summary>
        /// <param name="issuer">The <see cref="CertificateIssuer"/> to add or replace in the vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The created certificate issuer</returns>
        public virtual Response<CertificateIssuer> CreateIssuer(CertificateIssuer issuer, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(issuer, nameof(issuer));
            Argument.AssertNotNullOrEmpty(issuer.Name, nameof(issuer.Name));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.CreateIssuer");
            scope.AddAttribute("issuer", issuer.Name);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Put, issuer, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuer.Name);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or replaces a certificate <see cref="CertificateIssuer"/> in the key vault. This operation requires the certificates/setissuers permission.
        /// </summary>
        /// <param name="issuer">The <see cref="CertificateIssuer"/> to add or replace in the vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The created certificate issuer</returns>
        public virtual async Task<Response<CertificateIssuer>> CreateIssuerAsync(CertificateIssuer issuer, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(issuer, nameof(issuer));
            Argument.AssertNotNullOrEmpty(issuer.Name, nameof(issuer.Name));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.CreateIssuer");
            scope.AddAttribute("issuer", issuer.Name);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Put, issuer, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuer.Name).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the specified certificate <see cref="CertificateIssuer"/> from the vault. This operation requires the certificates/getissuers permission.
        /// </summary>
        /// <param name="issuerName">The name of the <see cref="CertificateIssuer"/> to retreive</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The retrieved certificate issuer</returns>
        public virtual Response<CertificateIssuer> GetIssuer(string issuerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issuerName, nameof(issuerName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetIssuer");
            scope.AddAttribute("issuer", issuerName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Get, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuerName);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the specified certificate <see cref="CertificateIssuer"/> from the vault. This operation requires the certificates/getissuers permission.
        /// </summary>
        /// <param name="issuerName">The name of the <see cref="CertificateIssuer"/> to retreive</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The retrieved certificate issuer</returns>
        public virtual async Task<Response<CertificateIssuer>> GetIssuerAsync(string issuerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issuerName, nameof(issuerName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetIssuer");
            scope.AddAttribute("issuer", issuerName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Get, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuerName).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified certificate <see cref="CertificateIssuer"/> in the vault, only updating the specified fields, others will remain unchanged. This operation requires the certificates/setissuers permission.
        /// </summary>
        /// <param name="issuer">The <see cref="CertificateIssuer"/> to update in the vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated certificate issuer</returns>
        public virtual Response<CertificateIssuer> UpdateIssuer(CertificateIssuer issuer, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(issuer, nameof(issuer));
            Argument.AssertNotNullOrEmpty(issuer.Name, nameof(issuer.Name));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.UpdateIssuer");
            scope.AddAttribute("issuer", issuer.Name);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Patch, issuer, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuer.Name);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the specified certificate <see cref="CertificateIssuer"/> in the vault, only updating the specified fields, others will remain unchanged. This operation requires the certificates/setissuers permission.
        /// </summary>
        /// <param name="issuer">The <see cref="CertificateIssuer"/> to update in the vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated certificate issuer</returns>
        public virtual async Task<Response<CertificateIssuer>> UpdateIssuerAsync(CertificateIssuer issuer, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(issuer, nameof(issuer));
            Argument.AssertNotNullOrEmpty(issuer.Name, nameof(issuer.Name));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.UpdateIssuer");
            scope.AddAttribute("issuer", issuer.Name);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Patch, issuer, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuer.Name).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified certificate <see cref="CertificateIssuer"/> from the vault. This operation requires the certificates/deleteissuers permission.
        /// </summary>
        /// <param name="issuerName">The name of the <see cref="CertificateIssuer"/> to delete</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The deleted certificate issuer</returns>
        public virtual Response<CertificateIssuer> DeleteIssuer(string issuerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issuerName, nameof(issuerName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.DeleteIssuer");
            scope.AddAttribute("issuer", issuerName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Delete, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuerName);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified certificate <see cref="CertificateIssuer"/> from the vault. This operation requires the certificates/deleteissuers permission.
        /// </summary>
        /// <param name="issuerName">The name of the <see cref="CertificateIssuer"/> to delete</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The deleted certificate issuer</returns>
        public virtual async Task<Response<CertificateIssuer>> DeleteIssuerAsync(string issuerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issuerName, nameof(issuerName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.DeleteIssuer");
            scope.AddAttribute("issuer", issuerName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Delete, () => new CertificateIssuer(), cancellationToken, IssuersPath, issuerName).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the properties of all issuers in the specified vault. You can use the returned <see cref="CertificateProperties.Name"/> in subsequent calls to <see cref="GetIssuer(string, CancellationToken)"/>.
        /// This operation requires the certificates/getissuers permission.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of certificate issuers metadata</returns>
        public virtual Pageable<IssuerProperties> GetPropertiesOfIssuers(CancellationToken cancellationToken = default)
        {
            Uri firstPageUri = _pipeline.CreateFirstPageUri(IssuersPath);

            return PageResponseEnumerator.CreateEnumerable(nextLink => _pipeline.GetPage(firstPageUri, nextLink, () => new IssuerProperties(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetPropertiesOfIssuers", cancellationToken));
        }

        /// <summary>
        /// Lists the properties of all issuers in the specified vault. You can use the returned <see cref="CertificateProperties.Name"/> in subsequent calls to <see cref="GetIssuer(string, CancellationToken)"/>.
        /// This operation requires the certificates/getissuers permission.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An enumerable collection of certificate issuers metadata</returns>
        public virtual AsyncPageable<IssuerProperties> GetPropertiesOfIssuersAsync(CancellationToken cancellationToken = default)
        {
            Uri firstPageUri = _pipeline.CreateFirstPageUri(IssuersPath);

            return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => _pipeline.GetPageAsync(firstPageUri, nextLink, () => new IssuerProperties(), "Azure.Security.KeyVaultCertificates.CertificateClient.GetPropertiesOfIssuers", cancellationToken));
        }

        //
        // Operations
        //

        /// <summary>
        /// Gets a pending <see cref="CertificateOperation"/> from the key vault. This operation requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to retrieve the current pending operation of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The given certificates current pending operation</returns>
        public virtual CertificateOperation GetCertificateOperation(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificateOperation");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = _pipeline.SendRequest(RequestMethod.Get, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending");

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a pending <see cref="CertificateOperation"/> from the key vault. This operation requires the certificates/get permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to retrieve the current pending operation of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The given certificates current pending operation</returns>
        public virtual async Task<CertificateOperation> GetCertificateOperationAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetCertificateOperation");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = await _pipeline.SendRequestAsync(RequestMethod.Get, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending").ConfigureAwait(false);

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a pending <see cref="CertificateOperation"/> in the key vault. This operation requires the certificates/update permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to cancel the current pending operation of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The canceled certificate operation</returns>
        public virtual CertificateOperation CancelCertificateOperation(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            var parameters = new CertificateOperationUpdateParameters(true);

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.CancelCertificateOperation");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = _pipeline.SendRequest(RequestMethod.Patch, parameters, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending");

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a pending <see cref="CertificateOperation"/> in the key vault. This operation requires the certificates/update permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to cancel the current pending operation of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The canceled certificate operation</returns>
        public virtual async Task<CertificateOperation> CancelCertificateOperationAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            var parameters = new CertificateOperationUpdateParameters(true);

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.CancelCertificateOperation");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = await _pipeline.SendRequestAsync(RequestMethod.Patch, parameters, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending").ConfigureAwait(false);

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a pending <see cref="CertificateOperation"/> in the key vault. This operation requires the certificates/delete permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to delete the current pending operation of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The deleted certificate operation</returns>
        public virtual CertificateOperation DeleteCertificateOperation(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.DeleteCertificateOperation");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = _pipeline.SendRequest(RequestMethod.Delete, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending");

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a pending <see cref="CertificateOperation"/> in the key vault. This operation requires the certificates/delete permission.
        /// </summary>
        /// <param name="certificateName">The name of the <see cref="KeyVaultCertificate"/> to delete the current pending operation of</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The deleted certificate operation</returns>
        public virtual async Task<CertificateOperation> DeleteCertificateOperationAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.DeleteCertificateOperation");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                Response<CertificateOperationProperties> response = await _pipeline.SendRequestAsync(RequestMethod.Delete, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending").ConfigureAwait(false);

                return new CertificateOperation(response, this);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        //
        // Contacts
        //

        /// <summary>
        /// Sets the certificate <see cref="CertificateContact"/>s for the key vault, replacing any existing contacts. This operation requires the certificates/managecontacts permission.
        /// </summary>
        /// <param name="contacts">The certificate contacts for the vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated certificate contacts of the vault</returns>
        public virtual Response<IList<CertificateContact>> SetContacts(IEnumerable<CertificateContact> contacts, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(contacts, nameof(contacts));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.SetContacts");
            scope.Start();

            try
            {
                Response<ContactList> contactList = _pipeline.SendRequest(RequestMethod.Put, new ContactList(contacts), () => new ContactList(), cancellationToken, ContactsPath);

                return Response.FromValue(contactList.Value.ToList(), contactList.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets the certificate <see cref="CertificateContact"/>s for the key vault, replacing any existing contacts. This operation requires the certificates/managecontacts permission.
        /// </summary>
        /// <param name="contacts">The certificate contacts for the vault</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The updated certificate contacts of the vault</returns>
        public virtual async Task<Response<IList<CertificateContact>>> SetContactsAsync(IEnumerable<CertificateContact> contacts, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(contacts, nameof(contacts));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.SetContacts");
            scope.Start();

            try
            {
                Response<ContactList> contactList = await _pipeline.SendRequestAsync(RequestMethod.Put, new ContactList(contacts), () => new ContactList(), cancellationToken, ContactsPath).ConfigureAwait(false);

                return Response.FromValue(contactList.Value.ToList(), contactList.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the certificate <see cref="CertificateContact"/>s for the key vaults. This operation requires the certificates/managecontacts permission.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The certificate contacts of the vault</returns>
        public virtual Response<IList<CertificateContact>> GetContacts(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetContacts");
            scope.Start();

            try
            {
                Response<ContactList> contactList = _pipeline.SendRequest(RequestMethod.Get, () => new ContactList(), cancellationToken, ContactsPath);

                return Response.FromValue(contactList.Value.ToList(), contactList.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the certificate <see cref="CertificateContact"/>s for the key vaults. This operation requires the certificates/managecontacts permission.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The certificate contacts of the vault</returns>
        public virtual async Task<Response<IList<CertificateContact>>> GetContactsAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetContacts");
            scope.Start();

            try
            {
                Response<ContactList> contactList = await _pipeline.SendRequestAsync(RequestMethod.Get, () => new ContactList(), cancellationToken, ContactsPath).ConfigureAwait(false);

                return Response.FromValue(contactList.Value.ToList(), contactList.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delets all certificate <see cref="CertificateContact"/>s from the key vault, replacing any existing contacts. This operation requires the certificates/managecontacts permission.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The certificate contacts deleted from the vault</returns>
        public virtual Response<IList<CertificateContact>> DeleteContacts(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.DeleteContacts");
            scope.Start();

            try
            {
                Response<ContactList> contactList = _pipeline.SendRequest(RequestMethod.Delete, () => new ContactList(), cancellationToken, ContactsPath);

                return Response.FromValue(contactList.Value.ToList(), contactList.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delets all certificate <see cref="CertificateContact"/>s from the key vault, replacing any existing contacts. This operation requires the certificates/managecontacts permission.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The certificate contacts deleted from the vault</returns>
        public virtual async Task<Response<IList<CertificateContact>>> DeleteContactsAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.DeleteContacts");
            scope.Start();

            try
            {
                Response<ContactList> contactList = await _pipeline.SendRequestAsync(RequestMethod.Delete, () => new ContactList(), cancellationToken, ContactsPath).ConfigureAwait(false);

                return Response.FromValue(contactList.Value.ToList(), contactList.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Merges a certificate or a certificate chain with a key pair currently available in the service. This operation requires the certificate/create permission.
        /// </summary>
        /// <param name="certificateMergeOptions">The details of the certificate or certificate chain to merge into the key vault.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The merged certificate.</returns>
        public virtual Response<KeyVaultCertificateWithPolicy> MergeCertificate(MergeCertificateOptions certificateMergeOptions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(certificateMergeOptions, nameof(certificateMergeOptions));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.MergeCertificate");
            scope.AddAttribute("certificate", certificateMergeOptions.Name);
            scope.Start();

            try
            {
                Response<KeyVaultCertificateWithPolicy> certificate = _pipeline.SendRequest(RequestMethod.Post, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, certificateMergeOptions.Name, "/pending/merge");

                return Response.FromValue(certificate.Value, certificate.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Merges a certificate or a certificate chain with a key pair currently available in the service. This operation requires the certificate/create permission.
        /// </summary>
        /// <param name="certificateMergeOptions">The details of the certificate or certificate chain to merge into the key vault.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>The merged certificate.</returns>
        public virtual async Task<Response<KeyVaultCertificateWithPolicy>> MergeCertificateAsync(MergeCertificateOptions certificateMergeOptions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(certificateMergeOptions, nameof(certificateMergeOptions));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.MergeCertificate");
            scope.AddAttribute("certificate", certificateMergeOptions.Name);
            scope.Start();

            try
            {
                Response<KeyVaultCertificateWithPolicy> certificate = await _pipeline.SendRequestAsync(RequestMethod.Post, () => new KeyVaultCertificateWithPolicy(), cancellationToken, CertificatesPath, certificateMergeOptions.Name, "/pending/merge").ConfigureAwait(false);

                return Response.FromValue(certificate.Value, certificate.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal virtual Response<CertificateOperationProperties> GetPendingCertificate(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetPendingCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return _pipeline.SendRequest(RequestMethod.Get, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending");
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal virtual async Task<Response<CertificateOperationProperties>> GetPendingCertificateAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Certificates.CertificateClient.GetPendingCertificate");
            scope.AddAttribute("certificate", certificateName);
            scope.Start();

            try
            {
                return await _pipeline.SendRequestAsync(RequestMethod.Get, () => new CertificateOperationProperties(), cancellationToken, CertificatesPath, certificateName, "/pending").ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
