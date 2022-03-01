// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Container network interface child resource. </summary>
    public partial class ContainerNetworkInterface : SubResource
    {
        /// <summary> Initializes a new instance of ContainerNetworkInterface. </summary>
        public ContainerNetworkInterface()
        {
            IPConfigurations = new ChangeTrackingList<ContainerNetworkInterfaceIPConfiguration>();
        }

        /// <summary> Initializes a new instance of ContainerNetworkInterface. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource. This name can be used to access the resource. </param>
        /// <param name="type"> Sub Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="containerNetworkInterfaceConfiguration"> Container network interface configuration from which this container network interface is created. </param>
        /// <param name="container"> Reference to the container to which this container network interface is attached. </param>
        /// <param name="ipConfigurations"> Reference to the ip configuration on this container nic. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface resource. </param>
        internal ContainerNetworkInterface(string id, string name, string type, string etag, ContainerNetworkInterfaceConfiguration containerNetworkInterfaceConfiguration, WritableSubResource container, IReadOnlyList<ContainerNetworkInterfaceIPConfiguration> ipConfigurations, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Type = type;
            Etag = etag;
            ContainerNetworkInterfaceConfiguration = containerNetworkInterfaceConfiguration;
            Container = container;
            IPConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> Sub Resource type. </summary>
        public string Type { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Container network interface configuration from which this container network interface is created. </summary>
        public ContainerNetworkInterfaceConfiguration ContainerNetworkInterfaceConfiguration { get; }
        /// <summary> Reference to the container to which this container network interface is attached. </summary>
        internal WritableSubResource Container { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ContainerId
        {
            get => Container is null ? default : Container.Id;
            set
            {
                if (Container is null)
                    Container = new WritableSubResource();
                Container.Id = value;
            }
        }

        /// <summary> Reference to the ip configuration on this container nic. </summary>
        public IReadOnlyList<ContainerNetworkInterfaceIPConfiguration> IPConfigurations { get; }
        /// <summary> The provisioning state of the container network interface resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
