// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    /// <summary> The DailyHistoricalRecordsResult. </summary>
    public partial class DailyHistoricalRecordsResult
    {
        /// <summary> Initializes a new instance of <see cref="DailyHistoricalRecordsResult"/>. </summary>
        internal DailyHistoricalRecordsResult()
        {
            HistoricalRecords = new ChangeTrackingList<DailyHistoricalRecords>();
        }

        /// <summary> Initializes a new instance of <see cref="DailyHistoricalRecordsResult"/>. </summary>
        /// <param name="historicalRecords"> Historical records for each requested day. </param>
        /// <param name="nextLink"> The is the link to the next page of the features returned. If it's the last page, no this field. </param>
        internal DailyHistoricalRecordsResult(IReadOnlyList<DailyHistoricalRecords> historicalRecords, string nextLink)
        {
            HistoricalRecords = historicalRecords;
            NextLink = nextLink;
        }

        /// <summary> Historical records for each requested day. </summary>
        public IReadOnlyList<DailyHistoricalRecords> HistoricalRecords { get; }
        /// <summary> The is the link to the next page of the features returned. If it's the last page, no this field. </summary>
        public string NextLink { get; }
    }
}
