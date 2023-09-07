// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GraphServices.Models
{
    /// <summary> Request payload used to update an existing resource's tags. </summary>
    public partial class GraphServicesTagUpdate
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GraphServicesTagUpdate"/>. </summary>
        public GraphServicesTagUpdate()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="GraphServicesTagUpdate"/>. </summary>
        /// <param name="tags"> List of key value pairs that describe the resource. This will overwrite the existing tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GraphServicesTagUpdate(IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of key value pairs that describe the resource. This will overwrite the existing tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
