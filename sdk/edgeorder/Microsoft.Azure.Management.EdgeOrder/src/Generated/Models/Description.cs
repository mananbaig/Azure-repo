// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeOrder.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description related properties of a product system.
    /// </summary>
    public partial class Description
    {
        /// <summary>
        /// Initializes a new instance of the Description class.
        /// </summary>
        public Description()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Description class.
        /// </summary>
        /// <param name="descriptionType">Type of description. Possible values
        /// include: 'Base'</param>
        /// <param name="shortDescription">Short description of the product
        /// system.</param>
        /// <param name="longDescription">Long description of the product
        /// system.</param>
        /// <param name="keywords">Keywords for the product system.</param>
        /// <param name="attributes">Attributes for the product system.</param>
        /// <param name="links">Links for the product system.</param>
        public Description(string descriptionType = default(string), string shortDescription = default(string), string longDescription = default(string), IList<string> keywords = default(IList<string>), IList<string> attributes = default(IList<string>), IList<Link> links = default(IList<Link>))
        {
            DescriptionType = descriptionType;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            Keywords = keywords;
            Attributes = attributes;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets type of description. Possible values include: 'Base'
        /// </summary>
        [JsonProperty(PropertyName = "descriptionType")]
        public string DescriptionType { get; private set; }

        /// <summary>
        /// Gets short description of the product system.
        /// </summary>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; private set; }

        /// <summary>
        /// Gets long description of the product system.
        /// </summary>
        [JsonProperty(PropertyName = "longDescription")]
        public string LongDescription { get; private set; }

        /// <summary>
        /// Gets keywords for the product system.
        /// </summary>
        [JsonProperty(PropertyName = "keywords")]
        public IList<string> Keywords { get; private set; }

        /// <summary>
        /// Gets attributes for the product system.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<string> Attributes { get; private set; }

        /// <summary>
        /// Gets links for the product system.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<Link> Links { get; private set; }

    }
}
