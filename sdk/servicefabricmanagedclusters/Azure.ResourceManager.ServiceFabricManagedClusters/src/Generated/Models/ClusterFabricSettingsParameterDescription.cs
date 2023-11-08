// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a parameter in fabric settings of the cluster. </summary>
    public partial class ClusterFabricSettingsParameterDescription
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClusterFabricSettingsParameterDescription"/>. </summary>
        /// <param name="name"> The parameter name of fabric setting. </param>
        /// <param name="value"> The parameter value of fabric setting. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public ClusterFabricSettingsParameterDescription(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterFabricSettingsParameterDescription"/>. </summary>
        /// <param name="name"> The parameter name of fabric setting. </param>
        /// <param name="value"> The parameter value of fabric setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterFabricSettingsParameterDescription(string name, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterFabricSettingsParameterDescription"/> for deserialization. </summary>
        internal ClusterFabricSettingsParameterDescription()
        {
        }

        /// <summary> The parameter name of fabric setting. </summary>
        public string Name { get; set; }
        /// <summary> The parameter value of fabric setting. </summary>
        public string Value { get; set; }
    }
}
