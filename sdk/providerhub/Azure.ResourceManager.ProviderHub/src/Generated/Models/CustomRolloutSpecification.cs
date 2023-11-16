// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CustomRolloutSpecification. </summary>
    public partial class CustomRolloutSpecification
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomRolloutSpecification"/>. </summary>
        /// <param name="canary"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="canary"/> is null. </exception>
        public CustomRolloutSpecification(TrafficRegions canary)
        {
            Argument.AssertNotNull(canary, nameof(canary));

            Canary = canary;
            ResourceTypeRegistrations = new ChangeTrackingList<ResourceTypeRegistrationData>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomRolloutSpecification"/>. </summary>
        /// <param name="canary"></param>
        /// <param name="providerRegistration"></param>
        /// <param name="resourceTypeRegistrations"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomRolloutSpecification(TrafficRegions canary, ProviderRegistrationData providerRegistration, IList<ResourceTypeRegistrationData> resourceTypeRegistrations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Canary = canary;
            ProviderRegistration = providerRegistration;
            ResourceTypeRegistrations = resourceTypeRegistrations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomRolloutSpecification"/> for deserialization. </summary>
        internal CustomRolloutSpecification()
        {
        }

        /// <summary> Gets or sets the canary. </summary>
        internal TrafficRegions Canary { get; set; }
        /// <summary> Gets the canary regions. </summary>
        public IList<AzureLocation> CanaryRegions
        {
            get
            {
                if (Canary is null)
                    Canary = new TrafficRegions();
                return Canary.Regions;
            }
        }

        /// <summary> Gets or sets the provider registration. </summary>
        public ProviderRegistrationData ProviderRegistration { get; set; }
        /// <summary> Gets the resource type registrations. </summary>
        public IList<ResourceTypeRegistrationData> ResourceTypeRegistrations { get; }
    }
}
