// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Buildpack Binding Launch Properties. </summary>
    public partial class BuildpackBindingLaunchProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BuildpackBindingLaunchProperties"/>. </summary>
        public BuildpackBindingLaunchProperties()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Secrets = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BuildpackBindingLaunchProperties"/>. </summary>
        /// <param name="properties"> Non-sensitive properties for launchProperties. </param>
        /// <param name="secrets"> Sensitive properties for launchProperties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildpackBindingLaunchProperties(IDictionary<string, string> properties, IDictionary<string, string> secrets, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            Secrets = secrets;
            _rawData = rawData;
        }

        /// <summary> Non-sensitive properties for launchProperties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Sensitive properties for launchProperties. </summary>
        public IDictionary<string, string> Secrets { get; }
    }
}
