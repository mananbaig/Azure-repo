// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedNetwork.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tag Object
    /// </summary>
    public partial class TagObject
    {
        /// <summary>
        /// Initializes a new instance of the TagObject class.
        /// </summary>
        public TagObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagObject class.
        /// </summary>
        /// <param name="key">Resource Key</param>
        /// <param name="value">Resource Value</param>
        public TagObject(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource Key
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets resource Value
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
