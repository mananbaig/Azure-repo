// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing the ServiceFabricApplication data model.
    /// The application resource.
    /// </summary>
    public partial class ServiceFabricApplicationData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ServiceFabricApplicationData(AzureLocation location) : base(location)
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
            Metrics = new ChangeTrackingList<ApplicationMetricDescription>();
            ManagedIdentities = new ChangeTrackingList<ApplicationUserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Describes the managed identities for an Azure resource. </param>
        /// <param name="typeVersion"> The version of the application type as defined in the application manifest. </param>
        /// <param name="parameters"> List of application parameters with overridden values from their default values specified in the application manifest. </param>
        /// <param name="upgradePolicy"> Describes the policy for a monitored application upgrade. </param>
        /// <param name="minimumNodes"> The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. </param>
        /// <param name="maximumNodes"> The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. </param>
        /// <param name="removeApplicationCapacity"> Remove the current application capacity settings. </param>
        /// <param name="metrics"> List of application capacity metric description. </param>
        /// <param name="managedIdentities"> List of user assigned identities for the application, each mapped to a friendly name. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="typeName"> The application type name as defined in the application manifest. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string typeVersion, IDictionary<string, string> parameters, ApplicationUpgradePolicy upgradePolicy, long? minimumNodes, long? maximumNodes, bool? removeApplicationCapacity, IList<ApplicationMetricDescription> metrics, IList<ApplicationUserAssignedIdentity> managedIdentities, string provisioningState, string typeName, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            TypeVersion = typeVersion;
            Parameters = parameters;
            UpgradePolicy = upgradePolicy;
            MinimumNodes = minimumNodes;
            MaximumNodes = maximumNodes;
            RemoveApplicationCapacity = removeApplicationCapacity;
            Metrics = metrics;
            ManagedIdentities = managedIdentities;
            ProvisioningState = provisioningState;
            TypeName = typeName;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationData"/> for deserialization. </summary>
        internal ServiceFabricApplicationData()
        {
        }

        /// <summary> Describes the managed identities for an Azure resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The version of the application type as defined in the application manifest. </summary>
        public string TypeVersion { get; set; }
        /// <summary> List of application parameters with overridden values from their default values specified in the application manifest. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Describes the policy for a monitored application upgrade. </summary>
        public ApplicationUpgradePolicy UpgradePolicy { get; set; }
        /// <summary> The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. </summary>
        public long? MinimumNodes { get; set; }
        /// <summary> The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. </summary>
        public long? MaximumNodes { get; set; }
        /// <summary> Remove the current application capacity settings. </summary>
        public bool? RemoveApplicationCapacity { get; set; }
        /// <summary> List of application capacity metric description. </summary>
        public IList<ApplicationMetricDescription> Metrics { get; }
        /// <summary> List of user assigned identities for the application, each mapped to a friendly name. </summary>
        public IList<ApplicationUserAssignedIdentity> ManagedIdentities { get; }
        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The application type name as defined in the application manifest. </summary>
        public string TypeName { get; set; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
