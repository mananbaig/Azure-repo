// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IoT Connector definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IotConnector
    {
        /// <summary>
        /// Initializes a new instance of the IotConnector class.
        /// </summary>
        public IotConnector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotConnector class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="identity">Setting indicating whether the service has a
        /// managed identity associated with it.</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Deleting', 'Succeeded', 'Creating', 'Accepted',
        /// 'Verifying', 'Updating', 'Failed', 'Canceled', 'Deprovisioned',
        /// 'Moving', 'Suspended', 'Warned', 'SystemMaintenance'</param>
        /// <param name="ingestionEndpointConfiguration">Source
        /// configuration.</param>
        /// <param name="deviceMapping">Device Mappings.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        public IotConnector(IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), ServiceManagedIdentityIdentity identity = default(ServiceManagedIdentityIdentity), string provisioningState = default(string), IotEventHubIngestionEndpointConfiguration ingestionEndpointConfiguration = default(IotEventHubIngestionEndpointConfiguration), IotMappingProperties deviceMapping = default(IotMappingProperties), SystemData systemData = default(SystemData))
        {
            Tags = tags;
            Location = location;
            Identity = identity;
            ProvisioningState = provisioningState;
            IngestionEndpointConfiguration = ingestionEndpointConfiguration;
            DeviceMapping = deviceMapping;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets setting indicating whether the service has a managed
        /// identity associated with it.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ServiceManagedIdentityIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state. Possible values include:
        /// 'Deleting', 'Succeeded', 'Creating', 'Accepted', 'Verifying',
        /// 'Updating', 'Failed', 'Canceled', 'Deprovisioned', 'Moving',
        /// 'Suspended', 'Warned', 'SystemMaintenance'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets source configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingestionEndpointConfiguration")]
        public IotEventHubIngestionEndpointConfiguration IngestionEndpointConfiguration { get; set; }

        /// <summary>
        /// Gets or sets device Mappings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceMapping")]
        public IotMappingProperties DeviceMapping { get; set; }

        /// <summary>
        /// Gets or sets metadata pertaining to creation and last modification
        /// of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
