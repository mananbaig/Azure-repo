// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Immutability Settings of vault. </summary>
    internal partial class ImmutabilitySettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImmutabilitySettings"/>. </summary>
        public ImmutabilitySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImmutabilitySettings"/>. </summary>
        /// <param name="state"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImmutabilitySettings(ImmutabilityState? state, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the state. </summary>
        public ImmutabilityState? State { get; set; }
    }
}
