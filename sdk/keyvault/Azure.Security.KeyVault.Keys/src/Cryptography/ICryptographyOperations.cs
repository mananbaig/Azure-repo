﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Azure.Security.KeyVault.Keys.Cryptography
{
    using Azure.Security.KeyVault.Cryptography;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    internal interface ICryptographyOperations
    {
        #region Decrypt

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="iv"></param>
        /// <param name="authenticationData"></param>
        /// <param name="authenticationTag"></param>
        /// <param name="algorithmKind"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<DecryptResult> DecryptAsync(byte[] ciphertext, byte[] iv, byte[] authenticationData, byte[] authenticationTag, EncryptionAlgorithmKind algorithmKind, CancellationToken token);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ciphertext"></param>
        /// <param name="iv"></param>
        /// <param name="authenticationData"></param>
        /// <param name="authenticationTag"></param>
        /// <param name="algorithmKind"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<DecryptResult> DecryptAsync(Stream ciphertext, byte[] iv, byte[] authenticationData, byte[] authenticationTag, EncryptionAlgorithmKind algorithmKind, CancellationToken token);
        #endregion

        #region Encrypt

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plaintext"></param>
        /// <param name="iv"></param>
        /// <param name="authenticationData"></param>
        /// <param name="algorithmKind"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<EncryptResult> EncryptAsync(byte[] plaintext, byte[] iv, byte[] authenticationData, EncryptionAlgorithmKind algorithmKind, CancellationToken token);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plaintext"></param>
        /// <param name="iv"></param>
        /// <param name="authenticationData"></param>
        /// <param name="algorithmKind"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<EncryptResult> EncryptAsync(Stream plaintext, byte[] iv, byte[] authenticationData, EncryptionAlgorithmKind algorithmKind, CancellationToken token);

        #endregion

        #region Wrap/UnWrap
        /// <summary>
        /// Encrypts the specified key material.
        /// </summary>
        /// <param name="key">The key material to encrypt</param>
        /// <param name="algorithmKind">The algorithm to use</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>A Tuple consisting of the encrypted key and the algorithm used</returns>
        /// <remarks>If the algorithm is not specified, an implementation should use its default algorithm</remarks>
        Task<WrapKeyResult> WrapKeyAsync(byte[] key, EncryptionAlgorithmKind algorithmKind, CancellationToken token);

        /// <summary>
        /// Decrypts the specified key material.
        /// </summary>
        /// <param name="encryptedKey">The encrypted key material</param>
        /// <param name="algorithmKind">The algorithm to use</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>The decrypted key material</returns>
        /// <remarks>If the algorithm is not specified, an implementation should use its default algorithm</remarks>
        Task<UnWrapKeyResult> UnwrapKeyAsync(byte[] encryptedKey, EncryptionAlgorithmKind algorithmKind, CancellationToken token);
        #endregion

        #region Sign/Verify
        /// <summary>
        /// Signs the specified digest.
        /// </summary>
        /// <param name="digest">The digest to sign</param>
        /// <param name="algorithmKind">The algorithm to use</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>A Tuple consisting of the signature and the algorithm used</returns>
        /// <remarks>If the algorithm is not specified, an implementation should use its default algorithm</remarks>
        Task<Tuple<byte[], string>> SignAsync(byte[] digest, EncryptionAlgorithmKind algorithmKind, CancellationToken token);
        /// <summary>
        /// Verifies the specified signature value
        /// </summary>
        /// <param name="digest">The digest</param>
        /// <param name="signature">The signature value</param>
        /// <param name="algorithmKind">The algorithm to use</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>A bool indicating whether the signature was successfully verified</returns>
        Task<bool> VerifyAsync(byte[] digest, byte[] signature, EncryptionAlgorithmKind algorithmKind, CancellationToken token);

        #endregion
    }
}
