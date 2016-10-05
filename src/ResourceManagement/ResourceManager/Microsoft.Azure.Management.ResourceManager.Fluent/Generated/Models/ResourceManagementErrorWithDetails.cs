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

    public partial class ResourceManagementErrorWithDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementErrorWithDetails class.
        /// </summary>
        public ResourceManagementErrorWithDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementErrorWithDetails class.
        /// </summary>
        /// <param name="code">The error code returned from the server.</param>
        /// <param name="message">The error message returned from the
        /// server.</param>
        /// <param name="target">The target of the error.</param>
        /// <param name="details">Validation error.</param>
        public ResourceManagementErrorWithDetails(string code, string message, string target = default(string), System.Collections.Generic.IList<ResourceManagementErrorWithDetails> details = default(System.Collections.Generic.IList<ResourceManagementErrorWithDetails>))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary>
        /// Gets or sets the error code returned from the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the error message returned from the server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the target of the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets validation error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "details")]
        public System.Collections.Generic.IList<ResourceManagementErrorWithDetails> Details { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Message");
            }
            if (this.Details != null)
            {
                foreach (var element in this.Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
