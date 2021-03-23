// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Rule results.
    /// </summary>
    public partial class RuleResults : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RuleResults class.
        /// </summary>
        public RuleResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleResults class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        public RuleResults(string id = default(string), string name = default(string), string type = default(string), RuleResultsProperties properties = default(RuleResultsProperties))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RuleResultsProperties Properties { get; set; }

    }
}
