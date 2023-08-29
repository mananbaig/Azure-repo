// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformApp data model.
    /// App resource payload
    /// </summary>
    public partial class AppPlatformAppData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformAppData"/>. </summary>
        public AppPlatformAppData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformAppData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the App resource. </param>
        /// <param name="identity"> The Managed Identity type of the app resource. </param>
        /// <param name="location"> The GEO location of the application, always the same with its parent resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformAppData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformAppProperties properties, ManagedServiceIdentity identity, AzureLocation? location, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Identity = identity;
            Location = location;
            _rawData = rawData;
        }

        /// <summary> Properties of the App resource. </summary>
        public AppPlatformAppProperties Properties { get; set; }
        /// <summary> The Managed Identity type of the app resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The GEO location of the application, always the same with its parent resource. </summary>
        public AzureLocation? Location { get; set; }
    }
}
