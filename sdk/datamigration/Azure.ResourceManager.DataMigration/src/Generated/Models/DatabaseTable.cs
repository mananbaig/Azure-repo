// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Table properties. </summary>
    public partial class DatabaseTable
    {
        /// <summary> Initializes a new instance of DatabaseTable. </summary>
        internal DatabaseTable()
        {
        }

        /// <summary> Initializes a new instance of DatabaseTable. </summary>
        /// <param name="hasRows"> Indicates whether table is empty or not. </param>
        /// <param name="name"> Schema-qualified name of the table. </param>
        internal DatabaseTable(bool? hasRows, string name)
        {
            HasRows = hasRows;
            Name = name;
        }

        /// <summary> Indicates whether table is empty or not. </summary>
        public bool? HasRows { get; }
        /// <summary> Schema-qualified name of the table. </summary>
        public string Name { get; }
    }
}
