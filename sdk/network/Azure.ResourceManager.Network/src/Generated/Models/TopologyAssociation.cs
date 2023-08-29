// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Resources that have an association with the parent resource. </summary>
    public partial class TopologyAssociation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TopologyAssociation"/>. </summary>
        internal TopologyAssociation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TopologyAssociation"/>. </summary>
        /// <param name="name"> The name of the resource that is associated with the parent resource. </param>
        /// <param name="resourceId"> The ID of the resource that is associated with the parent resource. </param>
        /// <param name="associationType"> The association type of the child resource to the parent resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TopologyAssociation(string name, ResourceIdentifier resourceId, AssociationType? associationType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceId = resourceId;
            AssociationType = associationType;
            _rawData = rawData;
        }

        /// <summary> The name of the resource that is associated with the parent resource. </summary>
        public string Name { get; }
        /// <summary> The ID of the resource that is associated with the parent resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The association type of the child resource to the parent resource. </summary>
        public AssociationType? AssociationType { get; }
    }
}
