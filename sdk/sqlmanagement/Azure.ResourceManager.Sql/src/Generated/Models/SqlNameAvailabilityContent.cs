// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A request to check whether the specified name for a resource is available. </summary>
    public partial class SqlNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlNameAvailabilityContent"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SqlNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = SqlNameAvailabilityResourceType.MicrosoftSqlServers;
        }

        /// <summary> Initializes a new instance of <see cref="SqlNameAvailabilityContent"/>. </summary>
        /// <param name="name"></param>
        /// <param name="resourceType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlNameAvailabilityContent(string name, SqlNameAvailabilityResourceType resourceType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlNameAvailabilityContent"/> for deserialization. </summary>
        internal SqlNameAvailabilityContent()
        {
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the resource type. </summary>
        public SqlNameAvailabilityResourceType ResourceType { get; }
    }
}
