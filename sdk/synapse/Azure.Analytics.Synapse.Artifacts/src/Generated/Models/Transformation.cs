// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A data flow transformation. </summary>
    public partial class Transformation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Transformation"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Transformation(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="Transformation"/>. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        /// <param name="dataset"> Dataset reference. </param>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="flowlet"> Flowlet Reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Transformation(string name, string description, DatasetReference dataset, LinkedServiceReference linkedService, DataFlowReference flowlet, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Description = description;
            Dataset = dataset;
            LinkedService = linkedService;
            Flowlet = flowlet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Transformation"/> for deserialization. </summary>
        internal Transformation()
        {
        }

        /// <summary> Transformation name. </summary>
        public string Name { get; set; }
        /// <summary> Transformation description. </summary>
        public string Description { get; set; }
        /// <summary> Dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary> Linked service reference. </summary>
        public LinkedServiceReference LinkedService { get; set; }
        /// <summary> Flowlet Reference. </summary>
        public DataFlowReference Flowlet { get; set; }
    }
}
