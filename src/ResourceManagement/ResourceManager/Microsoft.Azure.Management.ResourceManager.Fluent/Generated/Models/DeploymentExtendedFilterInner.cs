// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resource.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment filter.
    /// </summary>
    public partial class DeploymentExtendedFilterInner
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentExtendedFilterInner
        /// class.
        /// </summary>
        public DeploymentExtendedFilterInner() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentExtendedFilterInner
        /// class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state.</param>
        public DeploymentExtendedFilterInner(string provisioningState = default(string))
        {
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the provisioning state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
