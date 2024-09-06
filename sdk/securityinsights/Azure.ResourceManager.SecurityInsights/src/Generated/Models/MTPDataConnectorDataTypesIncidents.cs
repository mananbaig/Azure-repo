// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Incidents data type for Microsoft Threat Protection Platforms data connector.
    /// Serialized Name: MTPDataConnectorDataTypesIncidents
    /// </summary>
    internal partial class MTPDataConnectorDataTypesIncidents : DataConnectorDataTypeCommon
    {
        /// <summary> Initializes a new instance of <see cref="MTPDataConnectorDataTypesIncidents"/>. </summary>
        /// <param name="state">
        /// Describe whether this data type connection is enabled or not.
        /// Serialized Name: DataConnectorDataTypeCommon.state
        /// </param>
        public MTPDataConnectorDataTypesIncidents(SecurityInsightsDataTypeConnectionState state) : base(state)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MTPDataConnectorDataTypesIncidents"/>. </summary>
        /// <param name="state">
        /// Describe whether this data type connection is enabled or not.
        /// Serialized Name: DataConnectorDataTypeCommon.state
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MTPDataConnectorDataTypesIncidents(SecurityInsightsDataTypeConnectionState state, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(state, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MTPDataConnectorDataTypesIncidents"/> for deserialization. </summary>
        internal MTPDataConnectorDataTypesIncidents()
        {
        }
    }
}
