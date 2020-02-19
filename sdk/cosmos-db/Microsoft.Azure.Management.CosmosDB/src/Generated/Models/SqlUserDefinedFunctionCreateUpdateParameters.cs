// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters to create and update Cosmos DB userDefinedFunction.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlUserDefinedFunctionCreateUpdateParameters : ARMResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SqlUserDefinedFunctionCreateUpdateParameters class.
        /// </summary>
        public SqlUserDefinedFunctionCreateUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SqlUserDefinedFunctionCreateUpdateParameters class.
        /// </summary>
        /// <param name="resource">The standard JSON format of a
        /// userDefinedFunction</param>
        /// <param name="options">A key-value pair of options to be applied for
        /// the request. This corresponds to the headers sent with the
        /// request.</param>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        public SqlUserDefinedFunctionCreateUpdateParameters(SqlUserDefinedFunctionResource resource, IDictionary<string, string> options, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type, location, tags)
        {
            Resource = resource;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the standard JSON format of a userDefinedFunction
        /// </summary>
        [JsonProperty(PropertyName = "properties.resource")]
        public SqlUserDefinedFunctionResource Resource { get; set; }

        /// <summary>
        /// Gets or sets a key-value pair of options to be applied for the
        /// request. This corresponds to the headers sent with the request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.options")]
        public IDictionary<string, string> Options { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Resource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Resource");
            }
            if (Options == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Options");
            }
            if (Resource != null)
            {
                Resource.Validate();
            }
        }
    }
}
