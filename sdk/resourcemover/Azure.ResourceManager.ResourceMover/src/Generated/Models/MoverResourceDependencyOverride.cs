// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the dependency override of the move resource. </summary>
    public partial class MoverResourceDependencyOverride
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoverResourceDependencyOverride"/>. </summary>
        public MoverResourceDependencyOverride()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceDependencyOverride"/>. </summary>
        /// <param name="id"> Gets or sets the ARM ID of the dependent resource. </param>
        /// <param name="targetId">
        /// Gets or sets the resource ARM id of either the MoveResource or the resource ARM ID of
        /// the dependent resource.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceDependencyOverride(ResourceIdentifier id, ResourceIdentifier targetId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            TargetId = targetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the ARM ID of the dependent resource. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary>
        /// Gets or sets the resource ARM id of either the MoveResource or the resource ARM ID of
        /// the dependent resource.
        /// </summary>
        public ResourceIdentifier TargetId { get; set; }
    }
}
