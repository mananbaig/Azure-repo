// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Identifies an object. </summary>
    public partial class AppServiceDomainNameIdentifier
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceDomainNameIdentifier"/>. </summary>
        public AppServiceDomainNameIdentifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceDomainNameIdentifier"/>. </summary>
        /// <param name="name"> Name of the object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceDomainNameIdentifier(string name, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the object. </summary>
        public string Name { get; set; }
    }
}
