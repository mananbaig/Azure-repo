// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Response for CheckConnectionSharedKey Api servive call
    /// </summary>
    public partial class ConnectionSharedKeyResultInner
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKeyResultInner
        /// class.
        /// </summary>
        public ConnectionSharedKeyResultInner() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKeyResultInner
        /// class.
        /// </summary>
        /// <param name="value">The virtual network connection shared key
        /// value</param>
        public ConnectionSharedKeyResultInner(string value = default(string))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the virtual network connection shared key value
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
