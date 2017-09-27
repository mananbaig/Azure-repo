// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define a resource to query flow log status.
    /// </summary>
    public partial class FlowLogStatusParameters
    {
        /// <summary>
        /// Initializes a new instance of the FlowLogStatusParameters class.
        /// </summary>
        public FlowLogStatusParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlowLogStatusParameters class.
        /// </summary>
        /// <param name="targetResourceId">The target resource where getting
        /// the flow logging status.</param>
        public FlowLogStatusParameters(string targetResourceId)
        {
            TargetResourceId = targetResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target resource where getting the flow logging
        /// status.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
        }
    }
}
