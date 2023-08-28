// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The columns to be read out from the Office 365 table. </summary>
    public partial class Office365TableOutputColumn
    {
        /// <summary> Initializes a new instance of Office365TableOutputColumn. </summary>
        public Office365TableOutputColumn()
        {
        }

        /// <summary> Initializes a new instance of Office365TableOutputColumn. </summary>
        /// <param name="name"> Name of the table column. Type: string. </param>
        internal Office365TableOutputColumn(string name)
        {
            Name = name;
        }

        /// <summary> Name of the table column. Type: string. </summary>
        public string Name { get; set; }
    }
}
