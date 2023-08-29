// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Eligible child resource. </summary>
    public partial class EligibleChildResource
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EligibleChildResource"/>. </summary>
        internal EligibleChildResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EligibleChildResource"/>. </summary>
        /// <param name="id"> The resource scope Id. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EligibleChildResource(string id, string name, string resourceType, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> The resource scope Id. </summary>
        public string Id { get; }
        /// <summary> The resource name. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
    }
}
