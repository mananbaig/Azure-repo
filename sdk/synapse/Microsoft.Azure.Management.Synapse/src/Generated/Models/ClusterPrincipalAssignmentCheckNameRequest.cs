// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A principal assignment check name availability request.
    /// </summary>
    public partial class ClusterPrincipalAssignmentCheckNameRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ClusterPrincipalAssignmentCheckNameRequest class.
        /// </summary>
        public ClusterPrincipalAssignmentCheckNameRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ClusterPrincipalAssignmentCheckNameRequest class.
        /// </summary>
        /// <param name="name">Principal Assignment resource name.</param>
        public ClusterPrincipalAssignmentCheckNameRequest(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ClusterPrincipalAssignmentCheckNameRequest
        /// class.
        /// </summary>
        static ClusterPrincipalAssignmentCheckNameRequest()
        {
            Type = "Microsoft.Synapse/workspaces/kustoPools/principalAssignments";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets principal Assignment resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of resource,
        /// Microsoft.Synapse/workspaces/kustoPools/principalAssignments.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
