// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SecuritySolution. </summary>
    public partial class SecuritySolution : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySolution"/>. </summary>
        public SecuritySolution()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySolution"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="securityFamily"> The security family of the security solution. </param>
        /// <param name="provisioningState"> The security family provisioning State. </param>
        /// <param name="template"> The security solutions' template. </param>
        /// <param name="protectionStatus"> The security solutions' status. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySolution(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityFamily? securityFamily, SecurityFamilyProvisioningState? provisioningState, string template, string protectionStatus, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SecurityFamily = securityFamily;
            ProvisioningState = provisioningState;
            Template = template;
            ProtectionStatus = protectionStatus;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The security family of the security solution. </summary>
        public SecurityFamily? SecurityFamily { get; set; }
        /// <summary> The security family provisioning State. </summary>
        public SecurityFamilyProvisioningState? ProvisioningState { get; set; }
        /// <summary> The security solutions' template. </summary>
        public string Template { get; set; }
        /// <summary> The security solutions' status. </summary>
        public string ProtectionStatus { get; set; }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
