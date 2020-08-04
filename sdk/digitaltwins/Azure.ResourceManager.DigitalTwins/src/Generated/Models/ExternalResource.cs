// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> Definition of a Resource. </summary>
    public partial class ExternalResource
    {
        /// <summary> Initializes a new instance of ExternalResource. </summary>
        internal ExternalResource()
        {
        }

        /// <summary> Initializes a new instance of ExternalResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> Extension resource name. </param>
        /// <param name="type"> The resource type. </param>
        internal ExternalResource(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> The resource identifier. </summary>
        public string Id { get; }
        /// <summary> Extension resource name. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public string Type { get; }
    }
}
