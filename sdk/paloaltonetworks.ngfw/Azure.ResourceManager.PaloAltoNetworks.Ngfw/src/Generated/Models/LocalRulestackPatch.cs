// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The type used for update operations of the LocalRulestackResource. </summary>
    public partial class LocalRulestackPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LocalRulestackPatch"/>. </summary>
        public LocalRulestackPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackPatch"/>. </summary>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="properties"> The updatable properties of the LocalRulestackResource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LocalRulestackPatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, LocalRulestackUpdateProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Identity = identity;
            Tags = tags;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The updatable properties of the LocalRulestackResource. </summary>
        public LocalRulestackUpdateProperties Properties { get; set; }
    }
}
