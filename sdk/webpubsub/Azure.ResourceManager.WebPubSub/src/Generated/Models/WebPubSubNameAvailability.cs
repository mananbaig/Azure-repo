// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Result of the request to check name availability. It contains a flag and possible reason of failure. </summary>
    public partial class WebPubSubNameAvailability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebPubSubNameAvailability"/>. </summary>
        internal WebPubSubNameAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebPubSubNameAvailability"/>. </summary>
        /// <param name="nameAvailable"> Indicates whether the name is available or not. </param>
        /// <param name="reason"> The reason of the availability. Required if name is not available. </param>
        /// <param name="message"> The message of the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebPubSubNameAvailability(bool? nameAvailable, string reason, string message, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the name is available or not. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason of the availability. Required if name is not available. </summary>
        public string Reason { get; }
        /// <summary> The message of the operation. </summary>
        public string Message { get; }
    }
}
