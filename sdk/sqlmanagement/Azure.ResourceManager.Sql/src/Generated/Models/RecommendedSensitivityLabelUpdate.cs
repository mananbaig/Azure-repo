// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A recommended sensitivity label update operation. </summary>
    public partial class RecommendedSensitivityLabelUpdate : ProxyResource
    {
        /// <summary> Initializes a new instance of RecommendedSensitivityLabelUpdate. </summary>
        public RecommendedSensitivityLabelUpdate()
        {
        }

        /// <summary> Initializes a new instance of RecommendedSensitivityLabelUpdate. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="op"> . </param>
        /// <param name="schema"> Schema name of the column to update. </param>
        /// <param name="table"> Table name of the column to update. </param>
        /// <param name="column"> Column name to update. </param>
        internal RecommendedSensitivityLabelUpdate(string id, string name, string type, RecommendedSensitivityLabelUpdateKind? op, string schema, string table, string column) : base(id, name, type)
        {
            Op = op;
            Schema = schema;
            Table = table;
            Column = column;
        }

        public RecommendedSensitivityLabelUpdateKind? Op { get; set; }
        /// <summary> Schema name of the column to update. </summary>
        public string Schema { get; set; }
        /// <summary> Table name of the column to update. </summary>
        public string Table { get; set; }
        /// <summary> Column name to update. </summary>
        public string Column { get; set; }
    }
}
