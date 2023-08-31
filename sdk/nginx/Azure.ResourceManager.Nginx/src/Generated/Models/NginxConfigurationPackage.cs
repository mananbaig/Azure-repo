// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxConfigurationPackage. </summary>
    internal partial class NginxConfigurationPackage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationPackage"/>. </summary>
        public NginxConfigurationPackage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationPackage"/>. </summary>
        /// <param name="data"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxConfigurationPackage(string data, Dictionary<string, BinaryData> rawData)
        {
            Data = data;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the data. </summary>
        public string Data { get; set; }
    }
}
