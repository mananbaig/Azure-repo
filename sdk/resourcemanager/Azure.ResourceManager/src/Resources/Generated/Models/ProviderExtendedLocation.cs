// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The provider extended location. </summary>
    public partial class ProviderExtendedLocation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProviderExtendedLocation"/>. </summary>
        internal ProviderExtendedLocation()
        {
            ExtendedLocations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderExtendedLocation"/>. </summary>
        /// <param name="location"> The azure location. </param>
        /// <param name="providerExtendedLocationType"> The extended location type. </param>
        /// <param name="extendedLocations"> The extended locations for the azure location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderExtendedLocation(AzureLocation? location, string providerExtendedLocationType, IReadOnlyList<string> extendedLocations, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            ProviderExtendedLocationType = providerExtendedLocationType;
            ExtendedLocations = extendedLocations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The azure location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The extended location type. </summary>
        public string ProviderExtendedLocationType { get; }
        /// <summary> The extended locations for the azure location. </summary>
        public IReadOnlyList<string> ExtendedLocations { get; }
    }
}
