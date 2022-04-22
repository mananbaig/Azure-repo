// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Extended location of the resource.
    /// </summary>
    public partial class ExtendedLocation
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedLocation class.
        /// </summary>
        public ExtendedLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedLocation class.
        /// </summary>
        /// <param name="name">The name of the extended location.</param>
        public ExtendedLocation(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ExtendedLocation class.
        /// </summary>
        static ExtendedLocation()
        {
            Type = "EdgeZone";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the extended location.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The extended location type.
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
