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
    /// A class representing the AppPlatformSupportedBuildpack data model.
    /// Supported buildpack resource payload
    /// </summary>
    public partial class AppPlatformSupportedBuildpackData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformSupportedBuildpackData"/>. </summary>
        public AppPlatformSupportedBuildpackData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSupportedBuildpackData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Supported buildpack resource properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformSupportedBuildpackData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SupportedBuildpackResourceProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Supported buildpack resource properties. </summary>
        internal SupportedBuildpackResourceProperties Properties { get; set; }
        /// <summary> The id of supported buildpack. </summary>
        public string SupportedBuildpackId
        {
            get => Properties is null ? default : Properties.BuildpackId;
            set
            {
                if (Properties is null)
                    Properties = new SupportedBuildpackResourceProperties();
                Properties.BuildpackId = value;
            }
        }
    }
}
