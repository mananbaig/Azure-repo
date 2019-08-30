// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedNetwork.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Update Tags of Managed Network
    /// </summary>
    public partial class ManagedNetworkUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ManagedNetworkUpdate class.
        /// </summary>
        public ManagedNetworkUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedNetworkUpdate class.
        /// </summary>
        /// <param name="tags">Updates the tags property of the Managed
        /// Network</param>
        public ManagedNetworkUpdate(IList<string> tags = default(IList<string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets updates the tags property of the Managed Network
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

    }
}
