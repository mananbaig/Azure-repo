// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The access key regenerate action content. </summary>
    public partial class LogicWorkflowRegenerateActionContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRegenerateActionContent"/>. </summary>
        public LogicWorkflowRegenerateActionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRegenerateActionContent"/>. </summary>
        /// <param name="keyType"> The key type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowRegenerateActionContent(LogicKeyType? keyType, Dictionary<string, BinaryData> rawData)
        {
            KeyType = keyType;
            _rawData = rawData;
        }

        /// <summary> The key type. </summary>
        public LogicKeyType? KeyType { get; set; }
    }
}
