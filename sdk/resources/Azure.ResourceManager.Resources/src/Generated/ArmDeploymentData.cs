// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ArmDeployment data model.
    /// Deployment information.
    /// </summary>
    public partial class ArmDeploymentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentData"/>. </summary>
        internal ArmDeploymentData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> the location of the deployment. </param>
        /// <param name="properties"> Deployment properties. </param>
        /// <param name="tags"> Deployment tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ArmDeploymentPropertiesExtended properties, IReadOnlyDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Properties = properties;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> the location of the deployment. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Deployment properties. </summary>
        public ArmDeploymentPropertiesExtended Properties { get; }
        /// <summary> Deployment tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
