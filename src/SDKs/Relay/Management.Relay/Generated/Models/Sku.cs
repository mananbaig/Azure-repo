// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sku of the Namespace.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="tier">The tier of this particular SKU. Possible values
        /// include: 'Standard'</param>
        public Sku(SkuTier? tier = default(SkuTier?))
        {
            Tier = tier;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for Sku class.
        /// </summary>
        static Sku()
        {
            Name = "Standard";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tier of this particular SKU. Possible values
        /// include: 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; set; }

        /// <summary>
        /// Name of this Sku
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public static string Name { get; private set; }

    }
}
