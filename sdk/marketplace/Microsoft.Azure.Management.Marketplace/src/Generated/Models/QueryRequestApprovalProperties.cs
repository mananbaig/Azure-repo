// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details to get the request plans statuses
    /// </summary>
    public partial class QueryRequestApprovalProperties
    {
        /// <summary>
        /// Initializes a new instance of the QueryRequestApprovalProperties
        /// class.
        /// </summary>
        public QueryRequestApprovalProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryRequestApprovalProperties
        /// class.
        /// </summary>
        /// <param name="properties">The details to get the request plans
        /// statuses</param>
        public QueryRequestApprovalProperties(RequestDetails properties = default(RequestDetails))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the details to get the request plans statuses
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RequestDetails Properties { get; set; }

    }
}
