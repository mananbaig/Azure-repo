// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareV2 fabric provider specific settings. </summary>
    public partial class VMwareV2FabricCreationContent : FabricSpecificCreationContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareV2FabricCreationContent"/>. </summary>
        /// <param name="migrationSolutionId"> The ARM Id of the migration solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="migrationSolutionId"/> is null. </exception>
        public VMwareV2FabricCreationContent(ResourceIdentifier migrationSolutionId)
        {
            Argument.AssertNotNull(migrationSolutionId, nameof(migrationSolutionId));

            MigrationSolutionId = migrationSolutionId;
            InstanceType = "VMwareV2";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareV2FabricCreationContent"/>. </summary>
        /// <param name="instanceType"> Gets the class type. </param>
        /// <param name="vmwareSiteId"> The ARM Id of the VMware site. </param>
        /// <param name="physicalSiteId"> The ARM Id of the physical site. </param>
        /// <param name="migrationSolutionId"> The ARM Id of the migration solution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareV2FabricCreationContent(string instanceType, ResourceIdentifier vmwareSiteId, ResourceIdentifier physicalSiteId, ResourceIdentifier migrationSolutionId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            VMwareSiteId = vmwareSiteId;
            PhysicalSiteId = physicalSiteId;
            MigrationSolutionId = migrationSolutionId;
            InstanceType = instanceType ?? "VMwareV2";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareV2FabricCreationContent"/> for deserialization. </summary>
        internal VMwareV2FabricCreationContent()
        {
        }

        /// <summary> The ARM Id of the VMware site. </summary>
        public ResourceIdentifier VMwareSiteId { get; set; }
        /// <summary> The ARM Id of the physical site. </summary>
        public ResourceIdentifier PhysicalSiteId { get; set; }
        /// <summary> The ARM Id of the migration solution. </summary>
        public ResourceIdentifier MigrationSolutionId { get; }
    }
}
