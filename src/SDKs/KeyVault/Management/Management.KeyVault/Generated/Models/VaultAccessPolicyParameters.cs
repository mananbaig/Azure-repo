// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters for updating the access policy in a vault
    /// </summary>
    public partial class VaultAccessPolicyParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the VaultAccessPolicyParameters
        /// class.
        /// </summary>
        public VaultAccessPolicyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultAccessPolicyParameters
        /// class.
        /// </summary>
        /// <param name="properties">Properties of the access policy</param>
        /// <param name="id">The resource id of the access policy.</param>
        /// <param name="name">The resource name of the access policy.</param>
        /// <param name="type">The resource name of the access policy.</param>
        /// <param name="location">The resource type of the the access
        /// policy.</param>
        public VaultAccessPolicyParameters(VaultAccessPolicyProperties properties, string id = default(string), string name = default(string), string type = default(string), string location = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource id of the access policy.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the resource name of the access policy.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource name of the access policy.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the resource type of the the access policy.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets properties of the access policy
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VaultAccessPolicyProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
