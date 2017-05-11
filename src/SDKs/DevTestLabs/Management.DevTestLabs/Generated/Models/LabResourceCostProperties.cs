// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of a resource cost item.
    /// </summary>
    public partial class LabResourceCostProperties
    {
        /// <summary>
        /// Initializes a new instance of the LabResourceCostProperties class.
        /// </summary>
        public LabResourceCostProperties() { }

        /// <summary>
        /// Initializes a new instance of the LabResourceCostProperties class.
        /// </summary>
        public LabResourceCostProperties(string resourcename = default(string), string resourceUId = default(string), double? resourceCost = default(double?), string resourceType = default(string), string resourceOwner = default(string), string resourcePricingTier = default(string), string resourceStatus = default(string), string resourceId = default(string), string externalResourceId = default(string))
        {
            Resourcename = resourcename;
            ResourceUId = resourceUId;
            ResourceCost = resourceCost;
            ResourceType = resourceType;
            ResourceOwner = resourceOwner;
            ResourcePricingTier = resourcePricingTier;
            ResourceStatus = resourceStatus;
            ResourceId = resourceId;
            ExternalResourceId = externalResourceId;
        }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourcename")]
        public string Resourcename { get; set; }

        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceUId")]
        public string ResourceUId { get; set; }

        /// <summary>
        /// The cost component of the resource cost item.
        /// </summary>
        [JsonProperty(PropertyName = "resourceCost")]
        public double? ResourceCost { get; set; }

        /// <summary>
        /// The logical resource type (ex. virtualmachine, storageaccount)
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// The owner of the resource (ex. janedoe@microsoft.com)
        /// </summary>
        [JsonProperty(PropertyName = "resourceOwner")]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// The category of the resource (ex. Premium_LRS, Standard_DS1)
        /// </summary>
        [JsonProperty(PropertyName = "resourcePricingTier")]
        public string ResourcePricingTier { get; set; }

        /// <summary>
        /// The status of the resource (ex. Active)
        /// </summary>
        [JsonProperty(PropertyName = "resourceStatus")]
        public string ResourceStatus { get; set; }

        /// <summary>
        /// The ID of the resource
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// The ID of the external resource
        /// </summary>
        [JsonProperty(PropertyName = "externalResourceId")]
        public string ExternalResourceId { get; set; }

    }
}
