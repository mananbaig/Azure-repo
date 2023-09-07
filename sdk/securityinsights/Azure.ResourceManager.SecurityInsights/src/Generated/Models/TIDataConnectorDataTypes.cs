// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The available data types for TI (Threat Intelligence) data connector. </summary>
    internal partial class TIDataConnectorDataTypes
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TIDataConnectorDataTypes"/>. </summary>
        public TIDataConnectorDataTypes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TIDataConnectorDataTypes"/>. </summary>
        /// <param name="indicators"> Data type for indicators connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TIDataConnectorDataTypes(TIDataConnectorDataTypesIndicators indicators, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Indicators = indicators;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Data type for indicators connection. </summary>
        internal TIDataConnectorDataTypesIndicators Indicators { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        public SecurityInsightsDataTypeConnectionState? IndicatorsState
        {
            get => Indicators is null ? default : Indicators.State;
            set
            {
                if (Indicators is null)
                    Indicators = new TIDataConnectorDataTypesIndicators();
                Indicators.State = value;
            }
        }
    }
}
