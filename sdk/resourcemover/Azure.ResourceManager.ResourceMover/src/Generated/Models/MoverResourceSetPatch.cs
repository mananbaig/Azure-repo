// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the request body for updating move collection. </summary>
    public partial class MoverResourceSetPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoverResourceSetPatch"/>. </summary>
        public MoverResourceSetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceSetPatch"/>. </summary>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="identity"> Defines the MSI properties of the Move Collection. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceSetPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Defines the MSI properties of the Move Collection. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
