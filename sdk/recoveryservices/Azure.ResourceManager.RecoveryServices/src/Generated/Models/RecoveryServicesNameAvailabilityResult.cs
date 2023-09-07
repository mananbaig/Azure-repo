// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Response for check name availability API. Resource provider will set availability as true | false. </summary>
    public partial class RecoveryServicesNameAvailabilityResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesNameAvailabilityResult"/>. </summary>
        internal RecoveryServicesNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"></param>
        /// <param name="reason"></param>
        /// <param name="message"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryServicesNameAvailabilityResult(bool? isNameAvailable, string reason, string message, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the is name available. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> Gets the reason. </summary>
        public string Reason { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
