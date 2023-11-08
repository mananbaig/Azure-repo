// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment script execution logs. </summary>
    internal partial class ScriptLogsList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScriptLogsList"/>. </summary>
        internal ScriptLogsList()
        {
            Value = new ChangeTrackingList<ScriptLogData>();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptLogsList"/>. </summary>
        /// <param name="value"> Deployment scripts logs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptLogsList(IReadOnlyList<ScriptLogData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Deployment scripts logs. </summary>
        public IReadOnlyList<ScriptLogData> Value { get; }
    }
}
