// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Information about JIT request. </summary>
    public partial class JitRequestPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JitRequestPatch"/>. </summary>
        public JitRequestPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="JitRequestPatch"/>. </summary>
        /// <param name="tags"> Jit request tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitRequestPatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Jit request tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
