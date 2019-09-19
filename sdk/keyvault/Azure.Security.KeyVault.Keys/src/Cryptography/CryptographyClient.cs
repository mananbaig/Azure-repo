﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Cryptography;
using Azure.Core.Pipeline;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    /// <summary>
    /// A client used to perform cryptographic operations with Azure Key Vault keys
    /// </summary>
    public class CryptographyClient : IKeyEncryptionKey
    {
        private readonly Uri _keyId;
        private readonly KeyVaultPipeline _pipeline;
        private readonly RemoteCryptographyClient _remoteClient;
        private ICryptographyProvider _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptographyClient"/> class for mocking.
        /// </summary>
        protected CryptographyClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptographyClient"/> class.
        /// </summary>
        /// <param name="keyId">The <see cref="KeyBase.Id"/> of the <see cref="Key"/> which will be used for cryptographic operations.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> capable of providing an OAuth token.</param>
        /// <exception cref="ArgumentNullException"><paramref name="keyId"/> or <paramref name="credential"/> is null.</exception>
        public CryptographyClient(Uri keyId, TokenCredential credential)
            : this(keyId, credential, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptographyClient"/> class.
        /// </summary>
        /// <param name="keyId">The <see cref="KeyBase.Id"/> of the <see cref="Key"/> which will be used for cryptographic operations.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> capable of providing an OAuth token.</param>
        /// <param name="options">Options to configure the management of the request sent to Key Vault.</param>
        /// <exception cref="ArgumentNullException"><paramref name="keyId"/> or <paramref name="credential"/> is null.</exception>
        /// <exception cref="NotSupportedException">The <see cref="CryptographyClientOptions.Version"/> is not supported.</exception>
        public CryptographyClient(Uri keyId, TokenCredential credential, CryptographyClientOptions options) : this(keyId, credential, options, false)
        {
        }

        internal CryptographyClient(Uri keyId, TokenCredential credential, CryptographyClientOptions options, bool forceRemote)
        {
            Argument.AssertNotNull(keyId, nameof(keyId));
            Argument.AssertNotNull(credential, nameof(credential));

            _keyId = keyId;
            options ??= new CryptographyClientOptions();

            RemoteCryptographyClient remoteClient = new RemoteCryptographyClient(_keyId, credential, options);

            _pipeline = remoteClient.Pipeline;
            _remoteClient = remoteClient;

            if (forceRemote)
            {
                _client = remoteClient;
            }
        }

        internal CryptographyClient(JsonWebKey keyMaterial, TokenCredential credential, CryptographyClientOptions options)
        {
            Argument.AssertNotNull(keyMaterial, nameof(keyMaterial));
            Argument.AssertNotNull(credential, nameof(credential));

            if (string.IsNullOrEmpty(keyMaterial.KeyId))
            {
                throw new ArgumentException($"{nameof(keyMaterial.KeyId)} is required", nameof(keyMaterial));
            }

            _keyId = new Uri(keyMaterial.KeyId);
            options ??= new CryptographyClientOptions();

            RemoteCryptographyClient remoteClient = new RemoteCryptographyClient(_keyId, credential, options);

            _pipeline = remoteClient.Pipeline;
            _remoteClient = remoteClient;
            _client = LocalCryptographyClientFactory.Create(keyMaterial);
        }

        internal ICryptographyProvider RemoteClient => _remoteClient;

        /// <summary>
        /// Encrypts the specified plain text.
        /// </summary>
        /// <param name="algorithm">The <see cref="EncryptionAlgorithm"/> to use.</param>
        /// <param name="plaintext">The data to encrypt.</param>
        /// <param name="iv">
        /// The initialization vector. This should only be specified when using symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="authenticationData">
        /// The authentication data. This should only be specified when using authenticated symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the encrypt operation. The returned <see cref="EncryptResult"/> contains the encrypted data
        /// along with all other information needed to decrypt it. This information should be stored with the encrypted data.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<EncryptResult> EncryptAsync(EncryptionAlgorithm algorithm, byte[] plaintext, byte[] iv = default, byte[] authenticationData = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Encrypt");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                EncryptResult result = null;
                if (_client.SupportsOperation(KeyOperation.Encrypt))
                {
                    result = await _client.EncryptAsync(algorithm, plaintext, iv, authenticationData, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.EncryptAsync(algorithm, plaintext, iv, authenticationData, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Encrypts the specified plain text.
        /// </summary>
        /// <param name="algorithm">The <see cref="EncryptionAlgorithm"/> to use.</param>
        /// <param name="plaintext">The data to encrypt.</param>
        /// <param name="iv">
        /// The initialization vector. This should only be specified when using symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="authenticationData">
        /// The authentication data. This should only be specified when using authenticated symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the encrypt operation. The returned <see cref="EncryptResult"/> contains the encrypted data
        /// along with all other information needed to decrypt it. This information should be stored with the encrypted data.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual EncryptResult Encrypt(EncryptionAlgorithm algorithm, byte[] plaintext, byte[] iv = default, byte[] authenticationData = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Encrypt");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                EncryptResult result = null;
                if (_client.SupportsOperation(KeyOperation.Encrypt))
                {
                    result = _client.Encrypt(algorithm, plaintext, iv, authenticationData, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Encrypt(algorithm, plaintext, iv, authenticationData, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Decrypts the specified cipher text.
        /// </summary>
        /// <param name="algorithm">The <see cref="EncryptionAlgorithm"/> to use.</param>
        /// <param name="ciphertext">The encrypted data to decrypt.</param>
        /// <param name="iv">
        /// The initialization vector. This should only be specified when using symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="authenticationData">
        /// The authentication data. This should only be specified when using authenticated symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="authenticationTag">The authentication tag. This should only be specified when using authenticated
        /// symmetric encryption algorithms; otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the decrypt operation. The returned <see cref="DecryptResult"/> contains the encrypted data
        /// along with information regarding the algorithm and key used to decrypt it.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<DecryptResult> DecryptAsync(EncryptionAlgorithm algorithm, byte[] ciphertext, byte[] iv = default, byte[] authenticationData = default, byte[] authenticationTag = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Decrypt");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                DecryptResult result = null;
                if (_client.SupportsOperation(KeyOperation.Decrypt))
                {
                    result = await _client.DecryptAsync(algorithm, ciphertext, iv, authenticationData, authenticationTag, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.DecryptAsync(algorithm, ciphertext, iv, authenticationData, authenticationTag, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Decrypts the specified cipher text.
        /// </summary>
        /// <param name="algorithm">The <see cref="EncryptionAlgorithm"/> to use.</param>
        /// <param name="ciphertext">The encrypted data to decrypt.</param>
        /// <param name="iv">
        /// The initialization vector. This should only be specified when using symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="authenticationData">
        /// The authentication data. This should only be specified when using authenticated symmetric encryption algorithms;
        /// otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="authenticationTag">The authentication tag. This should only be specified when using authenticated
        /// symmetric encryption algorithms; otherwise, the caller must omit the parameter or pass null.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the decrypt operation. The returned <see cref="DecryptResult"/> contains the encrypted data
        /// along with information regarding the algorithm and key used to decrypt it.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual DecryptResult Decrypt(EncryptionAlgorithm algorithm, byte[] ciphertext, byte[] iv = default, byte[] authenticationData = default, byte[] authenticationTag = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Decrypt");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                DecryptResult result = null;
                if (_client.SupportsOperation(KeyOperation.Decrypt))
                {
                    result = _client.Decrypt(algorithm, ciphertext, iv, authenticationData, authenticationTag, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Decrypt(algorithm, ciphertext, iv, authenticationData, authenticationTag, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Encrypts the specified key material.
        /// </summary>
        /// <param name="algorithm">The <see cref="KeyWrapAlgorithm"/> to use.</param>
        /// <param name="key">The key material to encrypt.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the wrap operation. The returned <see cref="WrapResult"/> contains the wrapped key
        /// along with all other information needed to unwrap it. This information should be stored with the wrapped key.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<WrapResult> WrapKeyAsync(KeyWrapAlgorithm algorithm, byte[] key, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.WrapKey");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                WrapResult result = null;
                if (_client.SupportsOperation(KeyOperation.WrapKey))
                {
                    result = await _client.WrapKeyAsync(algorithm, key, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.WrapKeyAsync(algorithm, key, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Encrypts the specified key material.
        /// </summary>
        /// <param name="algorithm">The <see cref="KeyWrapAlgorithm"/> to use.</param>
        /// <param name="key">The key material to encrypt.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the wrap operation. The returned <see cref="WrapResult"/> contains the wrapped key
        /// along with all other information needed to unwrap it. This information should be stored with the wrapped key.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual WrapResult WrapKey(KeyWrapAlgorithm algorithm, byte[] key, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.WrapKey");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                WrapResult result = null;
                if (_client.SupportsOperation(KeyOperation.WrapKey))
                {
                    result =  _client.WrapKey(algorithm, key, cancellationToken);
                }

                if (result is null)
                {
                    result =  _remoteClient.WrapKey(algorithm, key, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Decrypts the specified encrypted key material.
        /// </summary>
        /// <param name="algorithm">The <see cref="KeyWrapAlgorithm"/> to use.</param>
        /// <param name="encryptedKey">The encrypted key material.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the unwrap operation. The returned <see cref="UnwrapResult"/> contains the key
        /// along with information regarding the algorithm and key used to unwrap it.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<UnwrapResult> UnwrapKeyAsync(KeyWrapAlgorithm algorithm, byte[] encryptedKey, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.UnwrapKey");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                UnwrapResult result = null;
                if (_client.SupportsOperation(KeyOperation.UnwrapKey))
                {
                    result = await _client.UnwrapKeyAsync(algorithm, encryptedKey, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.UnwrapKeyAsync(algorithm, encryptedKey, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Decrypts the specified encrypted key material.
        /// </summary>
        /// <param name="algorithm">The <see cref="KeyWrapAlgorithm"/> to use.</param>
        /// <param name="encryptedKey">The encrypted key material.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the unwrap operation. The returned <see cref="UnwrapResult"/> contains the key
        /// along with information regarding the algorithm and key used to unwrap it.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual UnwrapResult UnwrapKey(KeyWrapAlgorithm algorithm, byte[] encryptedKey, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.UnwrapKey");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                UnwrapResult result = null;
                if (_client.SupportsOperation(KeyOperation.UnwrapKey))
                {
                    result = _client.UnwrapKey(algorithm, encryptedKey, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.UnwrapKey(algorithm, encryptedKey, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Signs the specified digest.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use.</param>
        /// <param name="digest">The pre-hashed digest to sign. The hash algorithm used to compute the digest must be compatable with the specified algorithm.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the sign operation. The returned <see cref="SignResult"/> contains the signature
        /// along with all other information needed to verify it. This information should be stored with the signature.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<SignResult> SignAsync(SignatureAlgorithm algorithm, byte[] digest, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Sign");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                SignResult result = null;
                if (_client.SupportsOperation(KeyOperation.Sign))
                {
                    result = await _client.SignAsync(algorithm, digest, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.SignAsync(algorithm, digest, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Signs the specified digest.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use.</param>
        /// <param name="digest">The pre-hashed digest to sign. The hash algorithm used to compute the digest must be compatable with the specified algorithm.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the sign operation. The returned <see cref="SignResult"/> contains the signature
        /// along with all other information needed to verify it. This information should be stored with the signature.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual SignResult Sign(SignatureAlgorithm algorithm, byte[] digest, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Sign");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                SignResult result = null;
                if (_client.SupportsOperation(KeyOperation.Sign))
                {
                    result = _client.Sign(algorithm, digest, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Sign(algorithm, digest, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the specified signature.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use. This must be the same algorithm used to sign the digest.</param>
        /// <param name="digest">The pre-hashed digest corresponding to the signature. The hash algorithm used to compute the digest must be compatable with the specified algorithm.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the verify operation. If the signature is valid the <see cref="VerifyResult.IsValid"/> property of the returned <see cref="VerifyResult"/> will be set to true.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<VerifyResult> VerifyAsync(SignatureAlgorithm algorithm, byte[] digest, byte[] signature, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Verify");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                VerifyResult result = null;
                if (_client.SupportsOperation(KeyOperation.Verify))
                {
                    result = await _client.VerifyAsync(algorithm, digest, signature, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.VerifyAsync(algorithm, digest, signature, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the specified signature.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use. This must be the same algorithm used to sign the digest.</param>
        /// <param name="digest">The pre-hashed digest corresponding to the signature. The hash algorithm used to compute the digest must be compatable with the specified algorithm.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the verify operation. If the signature is valid the <see cref="VerifyResult.IsValid"/> property of the returned <see cref="VerifyResult"/> will be set to true.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual VerifyResult Verify(SignatureAlgorithm algorithm, byte[] digest, byte[] signature, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Verify");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                VerifyResult result = null;
                if (_client.SupportsOperation(KeyOperation.Verify))
                {
                    result = _client.Verify(algorithm, digest, signature, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Verify(algorithm, digest, signature, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Signs the specified data.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use.</param>
        /// <param name="data">The data to sign.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the sign operation. The returned <see cref="SignResult"/> contains the signature
        /// along with all other information needed to verify it. This information should be stored with the signature.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<SignResult> SignDataAsync(SignatureAlgorithm algorithm, byte[] data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.SignData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                SignResult result = null;
                if (_client.SupportsOperation(KeyOperation.Sign))
                {
                    result = await _client.SignAsync(algorithm, digest, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.SignAsync(algorithm, digest, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Signs the specified data.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use.</param>
        /// <param name="data">The data to sign.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the sign operation. The returned <see cref="SignResult"/> contains the signature
        /// along with all other information needed to verify it. This information should be stored with the signature.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual SignResult SignData(SignatureAlgorithm algorithm, byte[] data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.SignData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                SignResult result = null;
                if (_client.SupportsOperation(KeyOperation.Sign))
                {
                    result = _client.Sign(algorithm, digest, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Sign(algorithm, digest, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Signs the specified data.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use.</param>
        /// <param name="data">The data to sign.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the sign operation. The returned <see cref="SignResult"/> contains the signature
        /// along with all other information needed to verify it. This information should be stored with the signature.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is null.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<SignResult> SignDataAsync(SignatureAlgorithm algorithm, Stream data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.SignData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                SignResult result = null;
                if (_client.SupportsOperation(KeyOperation.Sign))
                {
                    result = await _client.SignAsync(algorithm, digest, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.SignAsync(algorithm, digest, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Signs the specified data.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use.</param>
        /// <param name="data">The data to sign.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the sign operation. The returned <see cref="SignResult"/> contains the signature
        /// along with all other information needed to verify it. This information should be stored with the signature.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is null.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual SignResult SignData(SignatureAlgorithm algorithm, Stream data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.SignData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                SignResult result = null;
                if (_client.SupportsOperation(KeyOperation.Sign))
                {
                    result = _client.Sign(algorithm, digest, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Sign(algorithm, digest, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the specified signature.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use. This must be the same algorithm used to sign the data.</param>
        /// <param name="data">The data corresponding to the signature.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the verify operation. If the signature is valid the <see cref="VerifyResult.IsValid"/> property of the returned <see cref="VerifyResult"/> will be set to true.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is null.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<VerifyResult> VerifyDataAsync(SignatureAlgorithm algorithm, byte[] data, byte[] signature, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.VerifyData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                VerifyResult result = null;
                if (_client.SupportsOperation(KeyOperation.Verify))
                {
                    result = await _client.VerifyAsync(algorithm, digest, signature, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.VerifyAsync(algorithm, digest, signature, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the specified signature.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use. This must be the same algorithm used to sign the data.</param>
        /// <param name="data">The data corresponding to the signature.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the verify operation. If the signature is valid the <see cref="VerifyResult.IsValid"/> property of the returned <see cref="VerifyResult"/> will be set to true.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is null.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual VerifyResult VerifyData(SignatureAlgorithm algorithm, byte[] data, byte[] signature, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.VerifyData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                VerifyResult result = null;
                if (_client.SupportsOperation(KeyOperation.Verify))
                {
                    result = _client.Verify(algorithm, digest, signature, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Verify(algorithm, digest, signature, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the specified signature.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use. This must be the same algorithm used to sign the data.</param>
        /// <param name="data">The data corresponding to the signature.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the verify operation. If the signature is valid the <see cref="VerifyResult.IsValid"/> property of the returned <see cref="VerifyResult"/> will be set to true.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is null.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual async Task<VerifyResult> VerifyDataAsync(SignatureAlgorithm algorithm, Stream data, byte[] signature, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.VerifyData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    await InitializeAsync(cancellationToken).ConfigureAwait(false);
                }

                VerifyResult result = null;
                if (_client.SupportsOperation(KeyOperation.Verify))
                {
                    result = await _client.VerifyAsync(algorithm, digest, signature, cancellationToken).ConfigureAwait(false);
                }

                if (result is null)
                {
                    result = await _remoteClient.VerifyAsync(algorithm, digest, signature, cancellationToken).ConfigureAwait(false);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the specified signature.
        /// </summary>
        /// <param name="algorithm">The <see cref="SignatureAlgorithm"/> to use. This must be the same algorithm used to sign the data.</param>
        /// <param name="data">The data corresponding to the signature.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the operation.</param>
        /// <returns>
        /// The result of the verify operation. If the signature is valid the <see cref="VerifyResult.IsValid"/> property of the returned <see cref="VerifyResult"/> will be set to true.
        /// </returns>
        /// <exception cref="ArgumentException">The specified <paramref name="algorithm"/> does not match the key corresponding to the key identifier.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is null.</exception>
        /// <exception cref="NotSupportedException">The operation is not supported with the specified key.</exception>
        /// <exception cref="RequestFailedException">The server returned an error.</exception>
        public virtual VerifyResult VerifyData(SignatureAlgorithm algorithm, Stream data, byte[] signature, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.VerifyData");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                byte[] digest = CreateDigest(algorithm, data);

                if (_client is null)
                {
                    Initialize(cancellationToken);
                }

                VerifyResult result = null;
                if (_client.SupportsOperation(KeyOperation.Verify))
                {
                    result = _client.Verify(algorithm, digest, signature, cancellationToken);
                }

                if (result is null)
                {
                    result = _remoteClient.Verify(algorithm, digest, signature, cancellationToken);
                }

                return result;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        Memory<byte> IKeyEncryptionKey.WrapKey(string algorithm, ReadOnlyMemory<byte> key, CancellationToken cancellationToken)
        {
            WrapResult result = WrapKey(new KeyWrapAlgorithm(algorithm), key.ToArray(), cancellationToken);

            return result.EncryptedKey;
        }

        /// <inheritdoc/>
        async Task<Memory<byte>> IKeyEncryptionKey.WrapKeyAsync(string algorithm, ReadOnlyMemory<byte> key, CancellationToken cancellationToken)
        {
            WrapResult result = await WrapKeyAsync(new KeyWrapAlgorithm(algorithm), key.ToArray(), cancellationToken).ConfigureAwait(false);

            return result.EncryptedKey;
        }

        /// <inheritdoc/>
        Memory<byte> IKeyEncryptionKey.UnwrapKey(string algorithm, ReadOnlyMemory<byte> encryptedKey, CancellationToken cancellationToken)
        {
            UnwrapResult result = UnwrapKey(new KeyWrapAlgorithm(algorithm), encryptedKey.ToArray(), cancellationToken);

            return result.Key;
        }

        /// <inheritdoc/>
        async Task<Memory<byte>> IKeyEncryptionKey.UnwrapKeyAsync(string algorithm, ReadOnlyMemory<byte> encryptedKey, CancellationToken cancellationToken)
        {
            UnwrapResult result = await UnwrapKeyAsync(new KeyWrapAlgorithm(algorithm), encryptedKey.ToArray(), cancellationToken).ConfigureAwait(false);

            return result.Key;
        }

        private static byte[] CreateDigest(SignatureAlgorithm algorithm, byte[] data)
        {
            using HashAlgorithm hashAlgo = algorithm.GetHashAlgorithm();
            return hashAlgo.ComputeHash(data);
        }

        private static byte[] CreateDigest(SignatureAlgorithm algorithm, Stream data)
        {
            using HashAlgorithm hashAlgo = algorithm.GetHashAlgorithm();
            return hashAlgo.ComputeHash(data);
        }

        private async ValueTask InitializeAsync(CancellationToken cancellationToken)
        {
            if (_client != null)
            {
                return;
            }

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Initialize");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                Response<Key> key = await _remoteClient.GetKeyAsync(cancellationToken).ConfigureAwait(false);
                _client = LocalCryptographyClientFactory.Create(key.Value.KeyMaterial);
            }
            catch (RequestFailedException e) when (e.Status == 403)
            {
                scope.AddAttribute("status", e.Status);

                _client = _remoteClient;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private void Initialize(CancellationToken cancellationToken)
        {
            if (_client != null)
            {
                return;
            }

            using DiagnosticScope scope = _pipeline.CreateScope("Azure.Security.KeyVault.Keys.Cryptography.CryptographyClient.Initialize");
            scope.AddAttribute("key", _keyId);
            scope.Start();

            try
            {
                Response<Key> key = _remoteClient.GetKey(cancellationToken);
                _client = LocalCryptographyClientFactory.Create(key.Value.KeyMaterial);
            }
            catch (RequestFailedException e) when (e.Status == 403)
            {
                scope.AddAttribute("status", e.Status);

                _client = _remoteClient;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private async ValueTask<TResult> InvokeAsync<TResult>(Func<ICryptographyProvider, ValueTask<TResult>> func, CancellationToken cancellationToken) where TResult : class
        {
            if (_client is null)
            {
                await InitializeAsync(cancellationToken).ConfigureAwait(false);
            }

            TResult result = null;
            if (_client.SupportsOperation(KeyOperation.Encrypt))
            {
                ValueTask<TResult> taskResult = func(_client);
                result = taskResult.Result;
            }

            if (result is null)
            {
                result = func(_remoteClient).Result;
            }

            return result;
        }

        private TResult Invoke<TResult>(Func<ICryptographyProvider, TResult> func, CancellationToken cancellationToken) where TResult : class
        {
            if (_client is null)
            {
                Initialize(cancellationToken);
            }

            TResult result = null;
            if (_client.SupportsOperation(KeyOperation.Encrypt))
            {
                result = func(_client);
            }

            if (result is null)
            {
                result = func(_remoteClient);
            }

            return result;
        }
    }
}
