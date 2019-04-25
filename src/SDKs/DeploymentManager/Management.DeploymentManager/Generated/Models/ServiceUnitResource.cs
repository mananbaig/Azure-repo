// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the response of a service unit resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceUnitResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceUnitResource class.
        /// </summary>
        public ServiceUnitResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceUnitResource class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="targetResourceGroup">The Azure Resource Group to which
        /// the resources in the service unit belong to or should be deployed
        /// to.</param>
        /// <param name="deploymentMode">Describes the type of ARM deployment
        /// to be performed on the resource. Possible values include:
        /// 'Incremental', 'Complete'</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="artifacts">The artifacts for the service unit.</param>
        public ServiceUnitResource(string location, string targetResourceGroup, DeploymentMode deploymentMode, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ServiceUnitArtifacts artifacts = default(ServiceUnitArtifacts))
            : base(location, id, name, type, tags)
        {
            TargetResourceGroup = targetResourceGroup;
            DeploymentMode = deploymentMode;
            Artifacts = artifacts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Resource Group to which the resources in the
        /// service unit belong to or should be deployed to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceGroup")]
        public string TargetResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets describes the type of ARM deployment to be performed
        /// on the resource. Possible values include: 'Incremental', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentMode")]
        public DeploymentMode DeploymentMode { get; set; }

        /// <summary>
        /// Gets or sets the artifacts for the service unit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifacts")]
        public ServiceUnitArtifacts Artifacts { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TargetResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceGroup");
            }
        }
    }
}
