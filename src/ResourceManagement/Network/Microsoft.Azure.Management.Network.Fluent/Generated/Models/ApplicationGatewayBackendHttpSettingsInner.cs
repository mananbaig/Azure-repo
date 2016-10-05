// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Backend address pool settings of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayBackendHttpSettingsInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHttpSettingsInner class.
        /// </summary>
        public ApplicationGatewayBackendHttpSettingsInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHttpSettingsInner class.
        /// </summary>
        /// <param name="port">Port</param>
        /// <param name="protocol">Protocol. Possible values include: 'Http',
        /// 'Https'</param>
        /// <param name="cookieBasedAffinity">Cookie affinity. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="requestTimeout">Request timeout</param>
        /// <param name="probe">Probe resource of application gateway </param>
        /// <param name="authenticationCertificates">Array of references to
        /// Application Gateway Authentication Certificates</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource Updating/Deleting/Failed</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayBackendHttpSettingsInner(string id = default(string), int? port = default(int?), string protocol = default(string), string cookieBasedAffinity = default(string), int? requestTimeout = default(int?), Microsoft.Rest.Azure.SubResource probe = default(Microsoft.Rest.Azure.SubResource), System.Collections.Generic.IList<Microsoft.Rest.Azure.SubResource> authenticationCertificates = default(System.Collections.Generic.IList<Microsoft.Rest.Azure.SubResource>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Port = port;
            Protocol = protocol;
            CookieBasedAffinity = cookieBasedAffinity;
            RequestTimeout = requestTimeout;
            Probe = probe;
            AuthenticationCertificates = authenticationCertificates;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets port
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets protocol. Possible values include: 'Http', 'Https'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets cookie affinity. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.cookieBasedAffinity")]
        public string CookieBasedAffinity { get; set; }

        /// <summary>
        /// Gets or sets request timeout
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestTimeout")]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets probe resource of application gateway
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.probe")]
        public Microsoft.Rest.Azure.SubResource Probe { get; set; }

        /// <summary>
        /// Gets or sets array of references to Application Gateway
        /// Authentication Certificates
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authenticationCertificates")]
        public System.Collections.Generic.IList<Microsoft.Rest.Azure.SubResource> AuthenticationCertificates { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
