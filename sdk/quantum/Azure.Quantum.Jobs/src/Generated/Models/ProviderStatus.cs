// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Providers status. </summary>
    public partial class ProviderStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProviderStatus"/>. </summary>
        internal ProviderStatus()
        {
            Targets = new ChangeTrackingList<TargetStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderStatus"/>. </summary>
        /// <param name="id"> Provider id. </param>
        /// <param name="currentAvailability"> Provider availability. </param>
        /// <param name="targets"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderStatus(string id, ProviderAvailability? currentAvailability, IReadOnlyList<TargetStatus> targets, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CurrentAvailability = currentAvailability;
            Targets = targets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provider id. </summary>
        public string Id { get; }
        /// <summary> Provider availability. </summary>
        public ProviderAvailability? CurrentAvailability { get; }
        /// <summary> Gets the targets. </summary>
        public IReadOnlyList<TargetStatus> Targets { get; }
    }
}
