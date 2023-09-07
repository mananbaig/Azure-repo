// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Represents the error used to indicate why the target compute size is not applicable. </summary>
    public partial class SiteRecoveryComputeSizeErrorDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryComputeSizeErrorDetails"/>. </summary>
        internal SiteRecoveryComputeSizeErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryComputeSizeErrorDetails"/>. </summary>
        /// <param name="message"> The error message. </param>
        /// <param name="severity"> The severity of the error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryComputeSizeErrorDetails(string message, string severity, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            Severity = severity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The severity of the error. </summary>
        public string Severity { get; }
    }
}
