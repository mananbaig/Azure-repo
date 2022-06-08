// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> String dictionary resource. </summary>
    public partial class StringDictionary : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="StringDictionary"/>. </summary>
        public StringDictionary()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StringDictionary"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="properties"> Settings. </param>
        internal StringDictionary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, IDictionary<string, string> properties) : base(id, name, resourceType, systemData, kind)
        {
            Properties = properties;
        }

        /// <summary> Settings. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}
