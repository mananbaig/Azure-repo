// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A recommended sensitivity label update operation. </summary>
    public partial class RecommendedSensitivityLabelUpdate : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecommendedSensitivityLabelUpdate"/>. </summary>
        public RecommendedSensitivityLabelUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedSensitivityLabelUpdate"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="op"></param>
        /// <param name="schema"> Schema name of the column to update. </param>
        /// <param name="table"> Table name of the column to update. </param>
        /// <param name="column"> Column name to update. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecommendedSensitivityLabelUpdate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RecommendedSensitivityLabelUpdateKind? op, string schema, string table, string column, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Op = op;
            Schema = schema;
            Table = table;
            Column = column;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the op. </summary>
        public RecommendedSensitivityLabelUpdateKind? Op { get; set; }
        /// <summary> Schema name of the column to update. </summary>
        public string Schema { get; set; }
        /// <summary> Table name of the column to update. </summary>
        public string Table { get; set; }
        /// <summary> Column name to update. </summary>
        public string Column { get; set; }
    }
}
