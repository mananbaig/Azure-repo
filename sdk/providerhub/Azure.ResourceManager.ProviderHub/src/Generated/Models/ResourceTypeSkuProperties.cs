// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuProperties. </summary>
    public partial class ResourceTypeSkuProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuProperties"/>. </summary>
        /// <param name="skuSettings"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="skuSettings"/> is null. </exception>
        public ResourceTypeSkuProperties(IEnumerable<ResourceTypeSkuSetting> skuSettings)
        {
            Argument.AssertNotNull(skuSettings, nameof(skuSettings));

            SkuSettings = skuSettings.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuProperties"/>. </summary>
        /// <param name="skuSettings"></param>
        /// <param name="provisioningState"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeSkuProperties(IList<ResourceTypeSkuSetting> skuSettings, ProviderHubProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData)
        {
            SkuSettings = skuSettings;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuProperties"/> for deserialization. </summary>
        internal ResourceTypeSkuProperties()
        {
        }

        /// <summary> Gets the sku settings. </summary>
        public IList<ResourceTypeSkuSetting> SkuSettings { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
    }
}
