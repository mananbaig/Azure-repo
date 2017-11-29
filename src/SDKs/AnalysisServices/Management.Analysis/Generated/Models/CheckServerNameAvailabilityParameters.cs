// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Analysis;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of server name request body.
    /// </summary>
    public partial class CheckServerNameAvailabilityParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckServerNameAvailabilityParameters class.
        /// </summary>
        public CheckServerNameAvailabilityParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckServerNameAvailabilityParameters class.
        /// </summary>
        /// <param name="name">Name for checking availability.</param>
        /// <param name="type">The resource type of azure analysis
        /// services.</param>
        public CheckServerNameAvailabilityParameters(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name for checking availability.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the resource type of azure analysis services.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                if (Name.Length > 63)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 63);
                }
                if (Name.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 3);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[a-z][a-z0-9]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[a-z][a-z0-9]*$");
                }
            }
        }
    }
}
