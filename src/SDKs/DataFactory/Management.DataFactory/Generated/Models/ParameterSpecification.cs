// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of a single parameter for an entity.
    /// </summary>
    public partial class ParameterSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ParameterSpecification class.
        /// </summary>
        public ParameterSpecification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParameterSpecification class.
        /// </summary>
        /// <param name="type">Parameter type. Possible values include:
        /// 'Object', 'String', 'Int', 'Float', 'Bool', 'Array'</param>
        /// <param name="defaultValue">Default value of parameter.</param>
        public ParameterSpecification(string type, object defaultValue = default(object))
        {
            Type = type;
            DefaultValue = defaultValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter type. Possible values include: 'Object',
        /// 'String', 'Int', 'Float', 'Bool', 'Array'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets default value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public object DefaultValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
