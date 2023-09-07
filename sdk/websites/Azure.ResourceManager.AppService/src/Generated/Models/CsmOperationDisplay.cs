// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Meta data about operation used for display in portal. </summary>
    public partial class CsmOperationDisplay
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CsmOperationDisplay"/>. </summary>
        internal CsmOperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CsmOperationDisplay"/>. </summary>
        /// <param name="provider"></param>
        /// <param name="resource"></param>
        /// <param name="operation"></param>
        /// <param name="description"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CsmOperationDisplay(string provider, string resource, string operation, string description, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the provider. </summary>
        public string Provider { get; }
        /// <summary> Gets the resource. </summary>
        public string Resource { get; }
        /// <summary> Gets the operation. </summary>
        public string Operation { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
    }
}
