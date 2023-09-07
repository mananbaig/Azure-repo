// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Localizable String object containing the name and a localized value. </summary>
    public partial class SignalRServiceUsageName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRServiceUsageName"/>. </summary>
        internal SignalRServiceUsageName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRServiceUsageName"/>. </summary>
        /// <param name="value"> The identifier of the usage. </param>
        /// <param name="localizedValue"> Localized name of the usage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRServiceUsageName(string value, string localizedValue, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            LocalizedValue = localizedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identifier of the usage. </summary>
        public string Value { get; }
        /// <summary> Localized name of the usage. </summary>
        public string LocalizedValue { get; }
    }
}
