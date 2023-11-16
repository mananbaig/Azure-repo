// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The DefaultRolloutProperties. </summary>
    public partial class DefaultRolloutProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DefaultRolloutProperties"/>. </summary>
        public DefaultRolloutProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefaultRolloutProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="specification"></param>
        /// <param name="status"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefaultRolloutProperties(ProviderHubProvisioningState? provisioningState, DefaultRolloutSpecification specification, DefaultRolloutStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Specification = specification;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the specification. </summary>
        public DefaultRolloutSpecification Specification { get; set; }
        /// <summary> Gets or sets the status. </summary>
        public DefaultRolloutStatus Status { get; set; }
    }
}
