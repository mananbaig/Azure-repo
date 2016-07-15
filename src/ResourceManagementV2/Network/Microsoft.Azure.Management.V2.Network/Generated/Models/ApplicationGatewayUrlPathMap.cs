// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// UrlPathMap of application gateway
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayUrlPathMap : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayUrlPathMap
        /// class.
        /// </summary>
        public ApplicationGatewayUrlPathMap() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayUrlPathMap
        /// class.
        /// </summary>
        /// <param name="defaultBackendAddressPool">Gets or sets default
        /// backend address pool resource of URL path map </param>
        /// <param name="defaultBackendHttpSettings">Gets or sets default
        /// backend http settings resource of URL path map </param>
        /// <param name="pathRules">Gets or sets path rule of URL path map
        /// resource</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// backend http settings resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayUrlPathMap(String id = default(String), SubResource defaultBackendAddressPool = default(SubResource), SubResource defaultBackendHttpSettings = default(SubResource), IList<ApplicationGatewayPathRule> pathRules = default(IList<ApplicationGatewayPathRule>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            DefaultBackendAddressPool = defaultBackendAddressPool;
            DefaultBackendHttpSettings = defaultBackendHttpSettings;
            PathRules = pathRules;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets default backend address pool resource of URL path map
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultBackendAddressPool")]
        public SubResource DefaultBackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets default backend http settings resource of URL path
        /// map
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultBackendHttpSettings")]
        public SubResource DefaultBackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets path rule of URL path map resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.pathRules")]
        public IList<ApplicationGatewayPathRule> PathRules { get; set; }

        /// <summary>
        /// Gets provisioning state of the backend http settings resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
