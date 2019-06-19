// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CustomProviders.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A manifest file that defines the custom resource provider resources.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomRPManifest : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CustomRPManifest class.
        /// </summary>
        public CustomRPManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomRPManifest class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="actions">A list of actions that the custom resource
        /// provider implements.</param>
        /// <param name="resourceTypes">A list of resource types that the
        /// custom resource provider implements.</param>
        /// <param name="validations">A list of validations to run on the
        /// custom resource provider's requests.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource provider. Possible values include: 'Accepted', 'Deleting',
        /// 'Running', 'Succeeded', 'Failed'</param>
        public CustomRPManifest(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<CustomRPActionRouteDefinition> actions = default(IList<CustomRPActionRouteDefinition>), IList<CustomRPResourceTypeRouteDefinition> resourceTypes = default(IList<CustomRPResourceTypeRouteDefinition>), IList<CustomRPValidations> validations = default(IList<CustomRPValidations>), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            Actions = actions;
            ResourceTypes = resourceTypes;
            Validations = validations;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of actions that the custom resource provider
        /// implements.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<CustomRPActionRouteDefinition> Actions { get; set; }

        /// <summary>
        /// Gets or sets a list of resource types that the custom resource
        /// provider implements.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceTypes")]
        public IList<CustomRPResourceTypeRouteDefinition> ResourceTypes { get; set; }

        /// <summary>
        /// Gets or sets a list of validations to run on the custom resource
        /// provider's requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.validations")]
        public IList<CustomRPValidations> Validations { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource provider. Possible
        /// values include: 'Accepted', 'Deleting', 'Running', 'Succeeded',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
