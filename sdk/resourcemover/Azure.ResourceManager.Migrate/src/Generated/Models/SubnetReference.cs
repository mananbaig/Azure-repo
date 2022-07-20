// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines reference to subnet. </summary>
    public partial class SubnetReference : ProxyResourceReference
    {
        /// <summary> Initializes a new instance of SubnetReference. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceArmResourceId"/> is null. </exception>
        public SubnetReference(string sourceArmResourceId) : base(sourceArmResourceId)
        {
            if (sourceArmResourceId == null)
            {
                throw new ArgumentNullException(nameof(sourceArmResourceId));
            }
        }

        /// <summary> Initializes a new instance of SubnetReference. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <param name="name"> Gets the name of the proxy resource on the target side. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceArmResourceId"/> is null. </exception>
        internal SubnetReference(string sourceArmResourceId, string name) : base(sourceArmResourceId, name)
        {
            if (sourceArmResourceId == null)
            {
                throw new ArgumentNullException(nameof(sourceArmResourceId));
            }
        }
    }
}
