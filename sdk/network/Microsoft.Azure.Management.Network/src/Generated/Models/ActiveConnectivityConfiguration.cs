// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active connectivity configuration.
    /// </summary>
    public partial class ActiveConnectivityConfiguration : EffectiveConnectivityConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ActiveConnectivityConfiguration
        /// class.
        /// </summary>
        public ActiveConnectivityConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveConnectivityConfiguration
        /// class.
        /// </summary>
        /// <param name="connectivityTopology">Connectivity topology type.
        /// Possible values include: 'HubAndSpoke', 'Mesh'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="displayName">A friendly name for the resource.</param>
        /// <param name="description">A description of the connectivity
        /// configuration.</param>
        /// <param name="hubId">The hub vnet Id.</param>
        /// <param name="isGlobal">Flag if global mesh is supported. Possible
        /// values include: 'False', 'True'</param>
        /// <param name="appliesToGroups">Groups for configuration</param>
        /// <param name="provisioningState">The provisioning state of the
        /// connectivity configuration resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="deleteExistingPeering">Flag if need to remove current
        /// existing peerings. Possible values include: 'False', 'True'</param>
        /// <param name="configurationGroups">Effective configuration
        /// groups.</param>
        /// <param name="commitTime">Deployment time string.</param>
        /// <param name="region">Deployment region.</param>
        public ActiveConnectivityConfiguration(string connectivityTopology, string id = default(string), string displayName = default(string), string description = default(string), string hubId = default(string), string isGlobal = default(string), IList<ConnectivityGroupItem> appliesToGroups = default(IList<ConnectivityGroupItem>), string provisioningState = default(string), string deleteExistingPeering = default(string), IList<ConfigurationGroup> configurationGroups = default(IList<ConfigurationGroup>), System.DateTime? commitTime = default(System.DateTime?), string region = default(string))
            : base(connectivityTopology, id, displayName, description, hubId, isGlobal, appliesToGroups, provisioningState, deleteExistingPeering, configurationGroups)
        {
            CommitTime = commitTime;
            Region = region;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets deployment time string.
        /// </summary>
        [JsonProperty(PropertyName = "commitTime")]
        public System.DateTime? CommitTime { get; set; }

        /// <summary>
        /// Gets or sets deployment region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
