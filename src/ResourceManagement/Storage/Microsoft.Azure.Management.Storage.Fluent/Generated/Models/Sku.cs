// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The SKU of the storage account.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Gets or sets the sku name. Required for account
        /// creation, optional for update. Note that in older versions, sku
        /// name was called accountType. Possible values include:
        /// 'Standard_LRS', 'Standard_GRS', 'Standard_RAGRS', 'Standard_ZRS',
        /// 'Premium_LRS'</param>
        /// <param name="tier">Gets the sku tier. This is based on the SKU
        /// name. Possible values include: 'Standard', 'Premium'</param>
        public Sku(SkuName name, SkuTier? tier = default(SkuTier?))
        {
            Name = name;
            Tier = tier;
        }

        /// <summary>
        /// Gets or sets the sku name. Required for account creation, optional
        /// for update. Note that in older versions, sku name was called
        /// accountType. Possible values include: 'Standard_LRS',
        /// 'Standard_GRS', 'Standard_RAGRS', 'Standard_ZRS', 'Premium_LRS'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public SkuName Name { get; set; }

        /// <summary>
        /// Gets the sku tier. This is based on the SKU name. Possible values
        /// include: 'Standard', 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
