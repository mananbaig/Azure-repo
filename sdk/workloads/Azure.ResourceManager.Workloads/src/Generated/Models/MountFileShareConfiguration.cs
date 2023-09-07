// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the file share configuration where the transport directory fileshare already exists, and user wishes to mount the fileshare as a part of the create infra flow. </summary>
    public partial class MountFileShareConfiguration : FileShareConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="MountFileShareConfiguration"/>. </summary>
        /// <param name="fileShareId"> The fileshare resource ID. </param>
        /// <param name="privateEndpointId"> The private endpoint resource ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileShareId"/> or <paramref name="privateEndpointId"/> is null. </exception>
        public MountFileShareConfiguration(ResourceIdentifier fileShareId, ResourceIdentifier privateEndpointId)
        {
            Argument.AssertNotNull(fileShareId, nameof(fileShareId));
            Argument.AssertNotNull(privateEndpointId, nameof(privateEndpointId));

            FileShareId = fileShareId;
            PrivateEndpointId = privateEndpointId;
            ConfigurationType = ConfigurationType.Mount;
        }

        /// <summary> Initializes a new instance of <see cref="MountFileShareConfiguration"/>. </summary>
        /// <param name="configurationType"> The type of file share config. </param>
        /// <param name="fileShareId"> The fileshare resource ID. </param>
        /// <param name="privateEndpointId"> The private endpoint resource ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MountFileShareConfiguration(ConfigurationType configurationType, ResourceIdentifier fileShareId, ResourceIdentifier privateEndpointId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(configurationType, serializedAdditionalRawData)
        {
            FileShareId = fileShareId;
            PrivateEndpointId = privateEndpointId;
            ConfigurationType = configurationType;
        }

        /// <summary> Initializes a new instance of <see cref="MountFileShareConfiguration"/> for deserialization. </summary>
        internal MountFileShareConfiguration()
        {
        }

        /// <summary> The fileshare resource ID. </summary>
        public ResourceIdentifier FileShareId { get; set; }
        /// <summary> The private endpoint resource ID. </summary>
        public ResourceIdentifier PrivateEndpointId { get; set; }
    }
}
