// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL table column item.
    /// </summary>
    public partial class USqlTableColumn
    {
        /// <summary>
        /// Initializes a new instance of the USqlTableColumn class.
        /// </summary>
        public USqlTableColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the USqlTableColumn class.
        /// </summary>
        /// <param name="name">the name of the column in the table.</param>
        /// <param name="type">the object type of the specified column (such as
        /// System.String).</param>
        public USqlTableColumn(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the column in the table.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the object type of the specified column (such as
        /// System.String).
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
