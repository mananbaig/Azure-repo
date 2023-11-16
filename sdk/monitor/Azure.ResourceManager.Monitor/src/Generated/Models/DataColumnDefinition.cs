// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of custom data column. </summary>
    public partial class DataColumnDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataColumnDefinition"/>. </summary>
        public DataColumnDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataColumnDefinition"/>. </summary>
        /// <param name="name"> The name of the column. </param>
        /// <param name="definitionType"> The type of the column data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataColumnDefinition(string name, DataColumnDefinitionType? definitionType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DefinitionType = definitionType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the column. </summary>
        public string Name { get; set; }
        /// <summary> The type of the column data. </summary>
        public DataColumnDefinitionType? DefinitionType { get; set; }
    }
}
