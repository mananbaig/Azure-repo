// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Guest configuration assignment is an association between a machine and
    /// guest configuration.
    /// </summary>
    public partial class GuestConfigurationAssignment : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the GuestConfigurationAssignment
        /// class.
        /// </summary>
        public GuestConfigurationAssignment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GuestConfigurationAssignment
        /// class.
        /// </summary>
        /// <param name="id">ARM resource id of the guest configuration
        /// assignment.</param>
        /// <param name="name">Name of the guest configuration
        /// assignment.</param>
        /// <param name="location">Region where the VM is located.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="properties">Properties of the Guest configuration
        /// assignment.</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        public GuestConfigurationAssignment(string id = default(string), string name = default(string), string location = default(string), string type = default(string), GuestConfigurationAssignmentProperties properties = default(GuestConfigurationAssignmentProperties), SystemData systemData = default(SystemData))
            : base(id, name, location, type)
        {
            Properties = properties;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the Guest configuration assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public GuestConfigurationAssignmentProperties Properties { get; set; }

        /// <summary>
        /// Gets azure Resource Manager metadata containing createdBy and
        /// modifiedBy information.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
