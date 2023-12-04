// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Mapping data flow. </summary>
    public partial class DataFactoryMappingDataFlowProperties : DataFactoryDataFlowProperties
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryMappingDataFlowProperties"/>. </summary>
        public DataFactoryMappingDataFlowProperties()
        {
            Sources = new ChangeTrackingList<DataFlowSource>();
            Sinks = new ChangeTrackingList<DataFlowSink>();
            Transformations = new ChangeTrackingList<DataFlowTransformation>();
            ScriptLines = new ChangeTrackingList<string>();
            DataFlowType = "MappingDataFlow";
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryMappingDataFlowProperties"/>. </summary>
        /// <param name="dataFlowType"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sources"> List of sources in data flow. </param>
        /// <param name="sinks"> List of sinks in data flow. </param>
        /// <param name="transformations"> List of transformations in data flow. </param>
        /// <param name="script"> DataFlow script. </param>
        /// <param name="scriptLines"> Data flow script lines. </param>
        internal DataFactoryMappingDataFlowProperties(string dataFlowType, string description, IList<BinaryData> annotations, DataFlowFolder folder, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<DataFlowSource> sources, IList<DataFlowSink> sinks, IList<DataFlowTransformation> transformations, string script, IList<string> scriptLines) : base(dataFlowType, description, annotations, folder, serializedAdditionalRawData)
        {
            Sources = sources;
            Sinks = sinks;
            Transformations = transformations;
            Script = script;
            ScriptLines = scriptLines;
            DataFlowType = dataFlowType ?? "MappingDataFlow";
        }

        /// <summary> List of sources in data flow. </summary>
        public IList<DataFlowSource> Sources { get; }
        /// <summary> List of sinks in data flow. </summary>
        public IList<DataFlowSink> Sinks { get; }
        /// <summary> List of transformations in data flow. </summary>
        public IList<DataFlowTransformation> Transformations { get; }
        /// <summary> DataFlow script. </summary>
        public string Script { get; set; }
        /// <summary> Data flow script lines. </summary>
        public IList<string> ScriptLines { get; }
    }
}
