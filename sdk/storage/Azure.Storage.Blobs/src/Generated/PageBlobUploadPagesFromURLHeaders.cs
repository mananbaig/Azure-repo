// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Blobs
{
    internal class PageBlobUploadPagesFromURLHeaders
    {
        private readonly Response _response;
        public PageBlobUploadPagesFromURLHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the container was last modified. Any operation that modifies the blob, including an update of the blob&apos;s metadata or properties, changes the last-modified time of the blob. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> If the blob has an MD5 hash and this operation is to read the full blob, this response header is returned so that the client can check for message content integrity. </summary>
        public byte[] ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out byte[] value) ? value : null;
        /// <summary> This header is returned so that the client can check for message content integrity. The value of this header is computed by the Blob service; it is not necessarily the same value specified in the request headers. </summary>
        public byte[] XMsContentCrc64 => _response.Headers.TryGetValue("x-ms-content-crc64", out byte[] value) ? value : null;
        /// <summary> The current sequence number for the page blob. </summary>
        public long? BlobSequenceNumber => _response.Headers.TryGetValue("x-ms-blob-sequence-number", out long? value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
        /// <summary> The SHA-256 hash of the encryption key used to encrypt the blob. This header is only returned when the blob was encrypted with a customer-provided key. </summary>
        public string EncryptionKeySha256 => _response.Headers.TryGetValue("x-ms-encryption-key-sha256", out string value) ? value : null;
        /// <summary> Returns the name of the encryption scope used to encrypt the blob contents and application metadata.  Note that the absence of this header implies use of the default account encryption scope. </summary>
        public string EncryptionScope => _response.Headers.TryGetValue("x-ms-encryption-scope", out string value) ? value : null;
        public string ErrorCode => _response.Headers.TryGetValue("x-ms-error-code", out string value) ? value : null;
    }
}
