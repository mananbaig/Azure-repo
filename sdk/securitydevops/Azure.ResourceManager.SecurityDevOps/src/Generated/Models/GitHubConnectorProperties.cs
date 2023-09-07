// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> Properties of the ARM resource for /subscriptions/xxx/resourceGroups/xxx/providers/Microsoft.SecurityDevOps/gitHubConnectors. </summary>
    public partial class GitHubConnectorProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GitHubConnectorProperties"/>. </summary>
        public GitHubConnectorProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubConnectorProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="code"> Gets or sets one-time OAuth code to exchange for refresh and access tokens. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubConnectorProperties(ProvisioningState? provisioningState, string code, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Code = code;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets one-time OAuth code to exchange for refresh and access tokens. </summary>
        public string Code { get; set; }
    }
}
