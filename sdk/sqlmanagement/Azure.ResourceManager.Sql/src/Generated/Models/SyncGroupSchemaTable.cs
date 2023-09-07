// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of table in sync group schema. </summary>
    public partial class SyncGroupSchemaTable
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchemaTable"/>. </summary>
        public SyncGroupSchemaTable()
        {
            Columns = new ChangeTrackingList<SyncGroupSchemaTableColumn>();
        }

        /// <summary> Initializes a new instance of <see cref="SyncGroupSchemaTable"/>. </summary>
        /// <param name="columns"> List of columns in sync group schema. </param>
        /// <param name="quotedName"> Quoted name of sync group schema table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncGroupSchemaTable(IList<SyncGroupSchemaTableColumn> columns, string quotedName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Columns = columns;
            QuotedName = quotedName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of columns in sync group schema. </summary>
        public IList<SyncGroupSchemaTableColumn> Columns { get; }
        /// <summary> Quoted name of sync group schema table. </summary>
        public string QuotedName { get; set; }
    }
}
