// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Providers status. </summary>
    public partial class ProviderStatus
    {
        /// <summary> Initializes a new instance of ProviderStatus. </summary>
        internal ProviderStatus()
        {
            Targets = new ChangeTrackingList<TargetStatus>();
        }

        /// <summary> Initializes a new instance of ProviderStatus. </summary>
        /// <param name="id"> Provider id. </param>
        /// <param name="currentAvailability"> Provider availability. </param>
        /// <param name="targets"></param>
        internal ProviderStatus(string id, ProviderAvailability? currentAvailability, IReadOnlyList<TargetStatus> targets)
        {
            Id = id;
            CurrentAvailability = currentAvailability;
            Targets = targets;
        }

        /// <summary> Provider id. </summary>
        public string Id { get; }
        /// <summary> Provider availability. </summary>
        public ProviderAvailability? CurrentAvailability { get; }
        /// <summary> Gets the targets. </summary>
        public IReadOnlyList<TargetStatus> Targets { get; }
    }
}
