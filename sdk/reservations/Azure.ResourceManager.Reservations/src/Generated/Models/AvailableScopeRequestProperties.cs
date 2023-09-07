// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Available scope request properties. </summary>
    internal partial class AvailableScopeRequestProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableScopeRequestProperties"/>. </summary>
        public AvailableScopeRequestProperties()
        {
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableScopeRequestProperties"/>. </summary>
        /// <param name="scopes"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableScopeRequestProperties(IList<string> scopes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scopes = scopes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the scopes. </summary>
        public IList<string> Scopes { get; }
    }
}
