// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeExtensionOptions. </summary>
    internal partial class ResourceTypeExtensionOptions
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeExtensionOptions"/>. </summary>
        public ResourceTypeExtensionOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeExtensionOptions"/>. </summary>
        /// <param name="resourceCreationBegin"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeExtensionOptions(ExtensionOptions resourceCreationBegin, Dictionary<string, BinaryData> rawData)
        {
            ResourceCreationBegin = resourceCreationBegin;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the resource creation begin. </summary>
        public ExtensionOptions ResourceCreationBegin { get; set; }
    }
}
