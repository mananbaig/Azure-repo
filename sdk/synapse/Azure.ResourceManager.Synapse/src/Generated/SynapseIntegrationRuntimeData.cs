// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseIntegrationRuntime data model.
    /// Integration runtime resource type.
    /// </summary>
    public partial class SynapseIntegrationRuntimeData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeData"/>. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntime"/> and <see cref="SynapseSelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SynapseIntegrationRuntimeData(SynapseIntegrationRuntimeProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntime"/> and <see cref="SynapseSelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseIntegrationRuntimeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SynapseIntegrationRuntimeProperties properties, ETag? etag, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeData"/> for deserialization. </summary>
        internal SynapseIntegrationRuntimeData()
        {
        }

        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="SynapseIntegrationRuntimeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseManagedIntegrationRuntime"/> and <see cref="SynapseSelfHostedIntegrationRuntime"/>.
        /// </summary>
        public SynapseIntegrationRuntimeProperties Properties { get; set; }
        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
    }
}
