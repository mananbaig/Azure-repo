// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Support information for the content item.
    /// </summary>
    public partial class MetadataSupport
    {
        /// <summary>
        /// Initializes a new instance of the MetadataSupport class.
        /// </summary>
        public MetadataSupport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetadataSupport class.
        /// </summary>
        /// <param name="tier">Type of support for content item. Possible
        /// values include: 'Microsoft', 'Partner', 'Community'</param>
        /// <param name="name">Name of the support contact. Company or
        /// person.</param>
        /// <param name="email">Email of support contact</param>
        /// <param name="link">Link for support help, like to support page to
        /// open a ticket etc.</param>
        public MetadataSupport(string tier, string name = default(string), string email = default(string), string link = default(string))
        {
            Tier = tier;
            Name = name;
            Email = email;
            Link = link;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of support for content item. Possible values
        /// include: 'Microsoft', 'Partner', 'Community'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets name of the support contact. Company or person.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets email of support contact
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets link for support help, like to support page to open a
        /// ticket etc.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tier");
            }
        }
    }
}
