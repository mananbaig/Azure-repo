// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> VM or VMSS node profile. </summary>
    public partial class NodeProfile
    {
        /// <summary> Initializes a new instance of <see cref="NodeProfile"/>. </summary>
        /// <param name="nodeSku"> VM SKU for node(s). </param>
        /// <param name="osImage"> OS image used for creating the nodes. </param>
        /// <param name="osDisk"> OS disk details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeSku"/>, <paramref name="osImage"/> or <paramref name="osDisk"/> is null. </exception>
        public NodeProfile(string nodeSku, OSImageProfile osImage, DiskInfo osDisk)
        {
            if (nodeSku == null)
            {
                throw new ArgumentNullException(nameof(nodeSku));
            }
            if (osImage == null)
            {
                throw new ArgumentNullException(nameof(osImage));
            }
            if (osDisk == null)
            {
                throw new ArgumentNullException(nameof(osDisk));
            }

            NodeSku = nodeSku;
            OSImage = osImage;
            OSDisk = osDisk;
            DataDisks = new ChangeTrackingList<DiskInfo>();
            NodeResourceIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NodeProfile"/>. </summary>
        /// <param name="name"> VM or VMSS name. </param>
        /// <param name="nodeSku"> VM SKU for node(s). </param>
        /// <param name="osImage"> OS image used for creating the nodes. </param>
        /// <param name="osDisk"> OS disk details. </param>
        /// <param name="dataDisks"> Data disks details. This property is not in use right now. </param>
        /// <param name="nodeResourceIds"> VM/VMSS resource ARM Ids. </param>
        internal NodeProfile(string name, string nodeSku, OSImageProfile osImage, DiskInfo osDisk, IList<DiskInfo> dataDisks, IReadOnlyList<ResourceIdentifier> nodeResourceIds)
        {
            Name = name;
            NodeSku = nodeSku;
            OSImage = osImage;
            OSDisk = osDisk;
            DataDisks = dataDisks;
            NodeResourceIds = nodeResourceIds;
        }

        /// <summary> VM or VMSS name. </summary>
        public string Name { get; set; }
        /// <summary> VM SKU for node(s). </summary>
        public string NodeSku { get; set; }
        /// <summary> OS image used for creating the nodes. </summary>
        public OSImageProfile OSImage { get; set; }
        /// <summary> OS disk details. </summary>
        public DiskInfo OSDisk { get; set; }
        /// <summary> Data disks details. This property is not in use right now. </summary>
        public IList<DiskInfo> DataDisks { get; }
        /// <summary> VM/VMSS resource ARM Ids. </summary>
        public IReadOnlyList<ResourceIdentifier> NodeResourceIds { get; }
    }
}
