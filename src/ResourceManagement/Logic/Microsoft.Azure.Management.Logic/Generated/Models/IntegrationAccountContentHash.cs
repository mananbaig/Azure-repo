// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class IntegrationAccountContentHash
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountContentHash
        /// class.
        /// </summary>
        public IntegrationAccountContentHash() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountContentHash
        /// class.
        /// </summary>
        public IntegrationAccountContentHash(string algorithm = default(string), string value = default(string))
        {
            Algorithm = algorithm;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the conetnt hash algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// Gets or sets the content hash value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
