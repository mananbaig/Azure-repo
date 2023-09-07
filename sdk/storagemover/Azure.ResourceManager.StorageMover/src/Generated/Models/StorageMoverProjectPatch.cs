// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The Project resource. </summary>
    public partial class StorageMoverProjectPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageMoverProjectPatch"/>. </summary>
        public StorageMoverProjectPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageMoverProjectPatch"/>. </summary>
        /// <param name="description"> A description for the Project. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageMoverProjectPatch(string description, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A description for the Project. </summary>
        public string Description { get; set; }
    }
}
