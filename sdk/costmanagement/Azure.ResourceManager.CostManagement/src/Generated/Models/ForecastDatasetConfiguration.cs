// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The configuration of dataset in the forecast. </summary>
    internal partial class ForecastDatasetConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ForecastDatasetConfiguration"/>. </summary>
        public ForecastDatasetConfiguration()
        {
            Columns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ForecastDatasetConfiguration"/>. </summary>
        /// <param name="columns"> Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then forecast includes all columns. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ForecastDatasetConfiguration(IList<string> columns, Dictionary<string, BinaryData> rawData)
        {
            Columns = columns;
            _rawData = rawData;
        }

        /// <summary> Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then forecast includes all columns. </summary>
        public IList<string> Columns { get; }
    }
}
