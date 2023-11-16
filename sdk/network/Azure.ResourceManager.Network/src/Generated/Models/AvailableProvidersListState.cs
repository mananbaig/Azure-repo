// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> State details. </summary>
    public partial class AvailableProvidersListState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvailableProvidersListState"/>. </summary>
        internal AvailableProvidersListState()
        {
            Providers = new ChangeTrackingList<string>();
            Cities = new ChangeTrackingList<AvailableProvidersListCity>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableProvidersListState"/>. </summary>
        /// <param name="stateName"> The state name. </param>
        /// <param name="providers"> A list of Internet service providers. </param>
        /// <param name="cities"> List of available cities or towns in the state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableProvidersListState(string stateName, IReadOnlyList<string> providers, IReadOnlyList<AvailableProvidersListCity> cities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StateName = stateName;
            Providers = providers;
            Cities = cities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The state name. </summary>
        public string StateName { get; }
        /// <summary> A list of Internet service providers. </summary>
        public IReadOnlyList<string> Providers { get; }
        /// <summary> List of available cities or towns in the state. </summary>
        public IReadOnlyList<AvailableProvidersListCity> Cities { get; }
    }
}
