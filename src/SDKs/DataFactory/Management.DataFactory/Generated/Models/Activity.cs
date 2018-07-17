// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A pipeline activity.
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        public Activity(string name, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IDictionary<string, string> userProperties = default(IDictionary<string, string>))
        {
            AdditionalProperties = additionalProperties;
            Name = name;
            Description = description;
            DependsOn = dependsOn;
            UserProperties = userProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets activity name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets activity description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets activity depends on condition.
        /// </summary>
        [JsonProperty(PropertyName = "dependsOn")]
        public IList<ActivityDependency> DependsOn { get; set; }

        /// <summary>
        /// Gets or sets activity user properties.
        /// </summary>
        [JsonProperty(PropertyName = "userProperties")]
        public IDictionary<string, string> UserProperties { get; set; }

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
            if (DependsOn != null)
            {
                foreach (var element in DependsOn)
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
