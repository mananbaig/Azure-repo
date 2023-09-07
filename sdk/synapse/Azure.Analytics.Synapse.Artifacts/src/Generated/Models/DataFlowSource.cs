// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Transformation for data flow source. </summary>
    public partial class DataFlowSource : Transformation
    {
        /// <summary> Initializes a new instance of <see cref="DataFlowSource"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataFlowSource(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowSource"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        /// <param name="dataset"> Dataset reference. </param>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="flowlet"> Flowlet Reference. </param>
        /// <param name="schemaLinkedService"> Schema linked service reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlowSource(string name, string description, DatasetReference dataset, LinkedServiceReference linkedService, DataFlowReference flowlet, LinkedServiceReference schemaLinkedService, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(name, description, dataset, linkedService, flowlet, serializedAdditionalRawData)
        {
            SchemaLinkedService = schemaLinkedService;
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowSource"/> for deserialization. </summary>
        internal DataFlowSource()
        {
        }

        /// <summary> Schema linked service reference. </summary>
        public LinkedServiceReference SchemaLinkedService { get; set; }
    }
}
