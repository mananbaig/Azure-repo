// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Temp.Batch.Models
{
    /// <summary> Parameter group. </summary>
    public partial class ComputeNodeDeleteUserOptions
    {
        /// <summary> Initializes a new instance of ComputeNodeDeleteUserOptions. </summary>
        public ComputeNodeDeleteUserOptions()
        {
        }

        /// <summary> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </summary>
        public int? Timeout { get; set; }
        /// <summary> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        public Guid? ClientRequestId { get; set; }
        /// <summary> Whether the server should return the client-request-id in the response. </summary>
        public bool? ReturnClientRequestId { get; set; }
        /// <summary> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </summary>
        public DateTimeOffset? OcpDate { get; set; }
    }
}
