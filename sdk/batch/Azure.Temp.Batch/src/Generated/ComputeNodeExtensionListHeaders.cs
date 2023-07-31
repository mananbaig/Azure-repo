// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Temp.Batch
{
    internal partial class ComputeNodeExtensionListHeaders
    {
        private readonly Response _response;
        public ComputeNodeExtensionListHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The client-request-id provided by the client during the request. This will be returned only if the return-client-request-id parameter was set to true. </summary>
        public Guid? ClientRequestId => _response.Headers.TryGetValue("client-request-id", out Guid? value) ? value : null;
        /// <summary> A unique identifier for the request that was made to the Batch service. If a request is consistently failing and you have verified that the request is properly formulated, you may use this value to report the error to Microsoft. In your report, include the value of this request ID, the approximate time that the request was made, the Batch Account against which the request was made, and the region that Account resides in. </summary>
        public Guid? RequestId => _response.Headers.TryGetValue("request-id", out Guid? value) ? value : null;
        /// <summary> The time at which the resource was last modified. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
    }
}
