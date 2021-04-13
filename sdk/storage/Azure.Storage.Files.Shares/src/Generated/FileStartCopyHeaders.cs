// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.Storage.Files.Shares.Models;

namespace Azure.Storage.Files.Shares
{
    internal partial class FileStartCopyHeaders
    {
        private readonly Response _response;
        public FileStartCopyHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date/time that the copy operation to the destination file completed. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> String identifier for this copy operation. Use with Get File or Get File Properties to check the status of this copy operation, or pass to Abort Copy File to abort a pending copy. </summary>
        public string CopyId => _response.Headers.TryGetValue("x-ms-copy-id", out string value) ? value : null;
        /// <summary> State of the copy operation identified by x-ms-copy-id. </summary>
        public CopyStatus? CopyStatus => _response.Headers.TryGetValue("x-ms-copy-status", out string value) ? value.ToCopyStatus() : null;
    }
}
