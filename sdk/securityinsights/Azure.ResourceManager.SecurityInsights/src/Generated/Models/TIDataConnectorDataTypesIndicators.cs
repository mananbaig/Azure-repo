// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Data type for indicators connection. </summary>
    internal partial class TIDataConnectorDataTypesIndicators : DataConnectorDataTypeCommon
    {
        /// <summary> Initializes a new instance of <see cref="TIDataConnectorDataTypesIndicators"/>. </summary>
        public TIDataConnectorDataTypesIndicators()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TIDataConnectorDataTypesIndicators"/>. </summary>
        /// <param name="state"> Describe whether this data type connection is enabled or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TIDataConnectorDataTypesIndicators(SecurityInsightsDataTypeConnectionState? state, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(state, serializedAdditionalRawData)
        {
        }
    }
}
