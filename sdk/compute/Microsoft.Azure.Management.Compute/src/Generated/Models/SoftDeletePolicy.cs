// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the soft deletion policy of the gallery.
    /// </summary>
    public partial class SoftDeletePolicy
    {
        /// <summary>
        /// Initializes a new instance of the SoftDeletePolicy class.
        /// </summary>
        public SoftDeletePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SoftDeletePolicy class.
        /// </summary>
        /// <param name="isSoftDeleteEnabled">Enables soft-deletion for
        /// resources in this gallery, allowing them to be recovered within
        /// retention time.</param>
        public SoftDeletePolicy(bool? isSoftDeleteEnabled = default(bool?))
        {
            IsSoftDeleteEnabled = isSoftDeleteEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enables soft-deletion for resources in this gallery,
        /// allowing them to be recovered within retention time.
        /// </summary>
        [JsonProperty(PropertyName = "isSoftDeleteEnabled")]
        public bool? IsSoftDeleteEnabled { get; set; }

    }
}
