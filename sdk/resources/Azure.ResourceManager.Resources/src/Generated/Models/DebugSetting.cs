// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The debug setting. </summary>
    internal partial class DebugSetting
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DebugSetting"/>. </summary>
        public DebugSetting()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DebugSetting"/>. </summary>
        /// <param name="detailLevel"> Specifies the type of information to log for debugging. The permitted values are none, requestContent, responseContent, or both requestContent and responseContent separated by a comma. The default is none. When setting this value, carefully consider the type of information you are passing in during deployment. By logging information about the request or response, you could potentially expose sensitive data that is retrieved through the deployment operations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DebugSetting(string detailLevel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DetailLevel = detailLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the type of information to log for debugging. The permitted values are none, requestContent, responseContent, or both requestContent and responseContent separated by a comma. The default is none. When setting this value, carefully consider the type of information you are passing in during deployment. By logging information about the request or response, you could potentially expose sensitive data that is retrieved through the deployment operations. </summary>
        public string DetailLevel { get; set; }
    }
}
