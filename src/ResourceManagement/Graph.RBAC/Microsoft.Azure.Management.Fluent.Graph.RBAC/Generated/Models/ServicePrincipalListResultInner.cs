// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Models
{
    using System.Linq;

    /// <summary>
    /// Server response for get tenant service principals API call
    /// </summary>
    public partial class ServicePrincipalListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalListResultInner
        /// class.
        /// </summary>
        public ServicePrincipalListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalListResultInner
        /// class.
        /// </summary>
        /// <param name="value">the list of service principals.</param>
        /// <param name="odatanextLink">the URL to get the next set of
        /// results.</param>
        public ServicePrincipalListResultInner(System.Collections.Generic.IList<ServicePrincipalInner> value = default(System.Collections.Generic.IList<ServicePrincipalInner>), string odatanextLink = default(string))
        {
            Value = value;
            OdatanextLink = odatanextLink;
        }

        /// <summary>
        /// Gets or sets the list of service principals.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<ServicePrincipalInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "odata.nextLink")]
        public string OdatanextLink { get; set; }

    }
}
