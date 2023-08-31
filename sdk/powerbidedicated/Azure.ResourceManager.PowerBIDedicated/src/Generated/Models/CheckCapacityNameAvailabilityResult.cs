// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> The checking result of capacity name availability. </summary>
    public partial class CheckCapacityNameAvailabilityResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CheckCapacityNameAvailabilityResult"/>. </summary>
        internal CheckCapacityNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CheckCapacityNameAvailabilityResult"/>. </summary>
        /// <param name="nameAvailable"> Indicator of availability of the capacity name. </param>
        /// <param name="reason"> The reason of unavailability. </param>
        /// <param name="message"> The detailed message of the request unavailability. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckCapacityNameAvailabilityResult(bool? nameAvailable, string reason, string message, Dictionary<string, BinaryData> rawData)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Indicator of availability of the capacity name. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason of unavailability. </summary>
        public string Reason { get; }
        /// <summary> The detailed message of the request unavailability. </summary>
        public string Message { get; }
    }
}
