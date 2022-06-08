// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the MSDeployStatus data model. </summary>
    public partial class MSDeployStatusData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="MSDeployStatusData"/>. </summary>
        public MSDeployStatusData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MSDeployStatusData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="deployer"> Username of deployer. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="startOn"> Start time of deploy operation. </param>
        /// <param name="endOn"> End time of deploy operation. </param>
        /// <param name="complete"> Whether the deployment operation has completed. </param>
        internal MSDeployStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string deployer, MSDeployProvisioningState? provisioningState, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? complete) : base(id, name, resourceType, systemData, kind)
        {
            Deployer = deployer;
            ProvisioningState = provisioningState;
            StartOn = startOn;
            EndOn = endOn;
            Complete = complete;
        }

        /// <summary> Username of deployer. </summary>
        public string Deployer { get; }
        /// <summary> Provisioning state. </summary>
        public MSDeployProvisioningState? ProvisioningState { get; }
        /// <summary> Start time of deploy operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of deploy operation. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Whether the deployment operation has completed. </summary>
        public bool? Complete { get; }
    }
}
