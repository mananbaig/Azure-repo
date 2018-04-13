// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The human-readable description of the operation.
    /// </summary>
    public partial class AzureMapsOperationsValueItemDisplay
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureMapsOperationsValueItemDisplay class.
        /// </summary>
        public AzureMapsOperationsValueItemDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureMapsOperationsValueItemDisplay class.
        /// </summary>
        /// <param name="provider">Service provider: Microsoft Azure
        /// Maps.</param>
        /// <param name="resource">Resource on which the operation is
        /// performed.</param>
        /// <param name="operation">The action that users can perform, based on
        /// their permission level.</param>
        /// <param name="description">The description of the operation.</param>
        public AzureMapsOperationsValueItemDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets service provider: Microsoft Azure Maps.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; private set; }

        /// <summary>
        /// Gets resource on which the operation is performed.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; private set; }

        /// <summary>
        /// Gets the action that users can perform, based on their permission
        /// level.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; private set; }

        /// <summary>
        /// Gets the description of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

    }
}
