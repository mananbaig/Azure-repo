// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary> A class representing the WorkloadNetworkPortMirroringProfile data model. </summary>
    public partial class WorkloadNetworkPortMirroringProfileData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkloadNetworkPortMirroringProfileData. </summary>
        public WorkloadNetworkPortMirroringProfileData()
        {
        }

        /// <summary> Initializes a new instance of WorkloadNetworkPortMirroringProfileData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the port mirroring profile. </param>
        /// <param name="direction"> Direction of port mirroring profile. </param>
        /// <param name="source"> Source VM Group. </param>
        /// <param name="destination"> Destination VM Group. </param>
        /// <param name="status"> Port Mirroring Status. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        internal WorkloadNetworkPortMirroringProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, PortMirroringProfileDirection? direction, string source, string destination, PortMirroringProfileStatus? status, WorkloadNetworkPortMirroringProfileProvisioningState? provisioningState, long? revision) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Direction = direction;
            Source = source;
            Destination = destination;
            Status = status;
            ProvisioningState = provisioningState;
            Revision = revision;
        }

        /// <summary> Display name of the port mirroring profile. </summary>
        public string DisplayName { get; set; }
        /// <summary> Direction of port mirroring profile. </summary>
        public PortMirroringProfileDirection? Direction { get; set; }
        /// <summary> Source VM Group. </summary>
        public string Source { get; set; }
        /// <summary> Destination VM Group. </summary>
        public string Destination { get; set; }
        /// <summary> Port Mirroring Status. </summary>
        public PortMirroringProfileStatus? Status { get; }
        /// <summary> The provisioning state. </summary>
        public WorkloadNetworkPortMirroringProfileProvisioningState? ProvisioningState { get; }
        /// <summary> NSX revision number. </summary>
        public long? Revision { get; set; }
    }
}
