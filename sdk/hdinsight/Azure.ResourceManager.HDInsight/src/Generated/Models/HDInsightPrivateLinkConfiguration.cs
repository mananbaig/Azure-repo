// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The private link configuration. </summary>
    public partial class HDInsightPrivateLinkConfiguration
    {
        /// <summary> Initializes a new instance of HDInsightPrivateLinkConfiguration. </summary>
        /// <param name="name"> The name of private link configuration. </param>
        /// <param name="groupId"> The HDInsight private linkable sub-resource name to apply the private link configuration to. For example, 'headnode', 'gateway', 'edgenode'. </param>
        /// <param name="ipConfigurations"> The IP configurations for the private link service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="groupId"/> or <paramref name="ipConfigurations"/> is null. </exception>
        public HDInsightPrivateLinkConfiguration(string name, string groupId, IEnumerable<HDInsightIPConfiguration> ipConfigurations)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(groupId, nameof(groupId));
            Argument.AssertNotNull(ipConfigurations, nameof(ipConfigurations));

            Name = name;
            GroupId = groupId;
            IPConfigurations = ipConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of HDInsightPrivateLinkConfiguration. </summary>
        /// <param name="id"> The private link configuration id. </param>
        /// <param name="name"> The name of private link configuration. </param>
        /// <param name="resourceType"> The type of the private link configuration. </param>
        /// <param name="groupId"> The HDInsight private linkable sub-resource name to apply the private link configuration to. For example, 'headnode', 'gateway', 'edgenode'. </param>
        /// <param name="provisioningState"> The private link configuration provisioning state, which only appears in the response. </param>
        /// <param name="ipConfigurations"> The IP configurations for the private link service. </param>
        internal HDInsightPrivateLinkConfiguration(string id, string name, ResourceType? resourceType, string groupId, HDInsightPrivateLinkConfigurationProvisioningState? provisioningState, IList<HDInsightIPConfiguration> ipConfigurations)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            IPConfigurations = ipConfigurations;
        }

        /// <summary> The private link configuration id. </summary>
        public string Id { get; }
        /// <summary> The name of private link configuration. </summary>
        public string Name { get; set; }
        /// <summary> The type of the private link configuration. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The HDInsight private linkable sub-resource name to apply the private link configuration to. For example, 'headnode', 'gateway', 'edgenode'. </summary>
        public string GroupId { get; set; }
        /// <summary> The private link configuration provisioning state, which only appears in the response. </summary>
        public HDInsightPrivateLinkConfigurationProvisioningState? ProvisioningState { get; }
        /// <summary> The IP configurations for the private link service. </summary>
        public IList<HDInsightIPConfiguration> IPConfigurations { get; }
    }
}
