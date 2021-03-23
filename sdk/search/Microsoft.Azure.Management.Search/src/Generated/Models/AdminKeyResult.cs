// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response containing the primary and secondary admin API keys for a
    /// given Azure Cognitive Search service.
    /// </summary>
    public partial class AdminKeyResult
    {
        /// <summary>
        /// Initializes a new instance of the AdminKeyResult class.
        /// </summary>
        public AdminKeyResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminKeyResult class.
        /// </summary>
        /// <param name="primaryKey">The primary admin API key of the search
        /// service.</param>
        /// <param name="secondaryKey">The secondary admin API key of the
        /// search service.</param>
        public AdminKeyResult(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the primary admin API key of the search service.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; private set; }

        /// <summary>
        /// Gets the secondary admin API key of the search service.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; private set; }

    }
}
