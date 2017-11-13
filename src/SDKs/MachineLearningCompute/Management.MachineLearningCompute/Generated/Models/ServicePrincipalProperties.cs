// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningCompute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Azure service principal used by Kubernetes for configuring load
    /// balancers
    /// </summary>
    public partial class ServicePrincipalProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServicePrincipalProperties class.
        /// </summary>
        public ServicePrincipalProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicePrincipalProperties class.
        /// </summary>
        /// <param name="clientId">The service principal client ID</param>
        /// <param name="secret">The service principal secret. This is not
        /// returned in response of GET/PUT on the resource. To see this please
        /// call listKeys.</param>
        public ServicePrincipalProperties(string clientId, string secret)
        {
            ClientId = clientId;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service principal client ID
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the service principal secret. This is not returned in
        /// response of GET/PUT on the resource. To see this please call
        /// listKeys.
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (Secret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Secret");
            }
        }
    }
}
