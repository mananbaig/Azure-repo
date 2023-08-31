// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Url configuration of the Actions set in Application Gateway. </summary>
    public partial class ApplicationGatewayUrlConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayUrlConfiguration"/>. </summary>
        public ApplicationGatewayUrlConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayUrlConfiguration"/>. </summary>
        /// <param name="modifiedPath"> Url path which user has provided for url rewrite. Null means no path will be updated. Default value is null. </param>
        /// <param name="modifiedQueryString"> Query string which user has provided for url rewrite. Null means no query string will be updated. Default value is null. </param>
        /// <param name="reroute"> If set as true, it will re-evaluate the url path map provided in path based request routing rules using modified path. Default value is false. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayUrlConfiguration(string modifiedPath, string modifiedQueryString, bool? reroute, Dictionary<string, BinaryData> rawData)
        {
            ModifiedPath = modifiedPath;
            ModifiedQueryString = modifiedQueryString;
            Reroute = reroute;
            _rawData = rawData;
        }

        /// <summary> Url path which user has provided for url rewrite. Null means no path will be updated. Default value is null. </summary>
        public string ModifiedPath { get; set; }
        /// <summary> Query string which user has provided for url rewrite. Null means no query string will be updated. Default value is null. </summary>
        public string ModifiedQueryString { get; set; }
        /// <summary> If set as true, it will re-evaluate the url path map provided in path based request routing rules using modified path. Default value is false. </summary>
        public bool? Reroute { get; set; }
    }
}
