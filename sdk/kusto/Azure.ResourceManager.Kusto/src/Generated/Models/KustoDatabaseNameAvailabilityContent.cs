// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The result returned from a database check name availability request. </summary>
    public partial class KustoDatabaseNameAvailabilityContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KustoDatabaseNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> The type of resource, for instance Microsoft.Kusto/clusters/databases. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoDatabaseNameAvailabilityContent(string name, KustoDatabaseResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="KustoDatabaseNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> The type of resource, for instance Microsoft.Kusto/clusters/databases. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoDatabaseNameAvailabilityContent(string name, KustoDatabaseResourceType resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoDatabaseNameAvailabilityContent"/> for deserialization. </summary>
        internal KustoDatabaseNameAvailabilityContent()
        {
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, for instance Microsoft.Kusto/clusters/databases. </summary>
        public KustoDatabaseResourceType ResourceType { get; }
    }
}
