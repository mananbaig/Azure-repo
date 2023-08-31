// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Email
{
    /// <summary> The error detail. </summary>
    internal partial class ErrorDetail
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/>. </summary>
        internal ErrorDetail()
        {
            Details = new ChangeTrackingList<ErrorDetail>();
            AdditionalInfo = new ChangeTrackingList<ErrorAdditionalInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="target"> The error target. </param>
        /// <param name="details"> The error details. </param>
        /// <param name="additionalInfo"> The error additional info. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorDetail(string code, string message, string target, IReadOnlyList<ErrorDetail> details, IReadOnlyList<ErrorAdditionalInfo> additionalInfo, Dictionary<string, BinaryData> rawData)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            AdditionalInfo = additionalInfo;
            _rawData = rawData;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error target. </summary>
        public string Target { get; }
        /// <summary> The error details. </summary>
        public IReadOnlyList<ErrorDetail> Details { get; }
        /// <summary> The error additional info. </summary>
        public IReadOnlyList<ErrorAdditionalInfo> AdditionalInfo { get; }
    }
}
