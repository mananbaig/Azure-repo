// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing the CurrentUsagesBase data model.
    /// Resource usage.
    /// </summary>
    public partial class CurrentUsagesBaseData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CurrentUsagesBaseData"/>. </summary>
        internal CurrentUsagesBaseData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CurrentUsagesBaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Usage properties for the specified resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CurrentUsagesBaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, QuotaUsagesProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Usage properties for the specified resource. </summary>
        public QuotaUsagesProperties Properties { get; }
    }
}
