// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureTableDataFeed. </summary>
    internal partial class AzureTableDataFeed : DataFeedDetail
    {
        /// <summary> Initializes a new instance of <see cref="AzureTableDataFeed"/>. </summary>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="granularityName"> granularity of the time series. </param>
        /// <param name="metrics"> measure list. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <param name="dataSourceParameter"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFeedName"/>, <paramref name="metrics"/> or <paramref name="dataSourceParameter"/> is null. </exception>
        public AzureTableDataFeed(string dataFeedName, DataFeedGranularityType granularityName, IEnumerable<DataFeedMetric> metrics, DateTimeOffset dataStartFrom, AzureTableParameter dataSourceParameter) : base(dataFeedName, granularityName, metrics, dataStartFrom)
        {
            Argument.AssertNotNull(dataFeedName, nameof(dataFeedName));
            Argument.AssertNotNull(metrics, nameof(metrics));
            Argument.AssertNotNull(dataSourceParameter, nameof(dataSourceParameter));

            DataSourceParameter = dataSourceParameter;
            DataSourceType = DataFeedSourceKind.AzureTable;
        }

        /// <summary> Initializes a new instance of <see cref="AzureTableDataFeed"/>. </summary>
        /// <param name="dataSourceType"> data source type. </param>
        /// <param name="dataFeedId"> data feed unique id. </param>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="dataFeedDescription"> data feed description. </param>
        /// <param name="granularityName"> granularity of the time series. </param>
        /// <param name="granularityAmount"> if granularity is custom,it is required. </param>
        /// <param name="metrics"> measure list. </param>
        /// <param name="dimension"> dimension list. </param>
        /// <param name="timestampColumn"> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <param name="startOffsetInSeconds"> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </param>
        /// <param name="maxConcurrency"> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </param>
        /// <param name="minRetryIntervalInSeconds"> the min retry interval for failed data ingestion tasks. </param>
        /// <param name="stopRetryAfterInSeconds"> stop retry data ingestion after the data slice first schedule time in seconds. </param>
        /// <param name="needRollup"> mark if the data feed need rollup. </param>
        /// <param name="rollUpMethod"> roll up method. </param>
        /// <param name="rollUpColumns"> roll up columns. </param>
        /// <param name="allUpIdentification"> the identification value for the row of calculated all-up value. </param>
        /// <param name="fillMissingPointType"> the type of fill missing point for anomaly detection. </param>
        /// <param name="fillMissingPointValue"> the value of fill missing point for anomaly detection. </param>
        /// <param name="viewMode"> data feed access mode, default is Private. </param>
        /// <param name="admins"> data feed administrator. </param>
        /// <param name="viewers"> data feed viewer. </param>
        /// <param name="isAdmin"> the query user is one of data feed administrator or not. </param>
        /// <param name="creator"> data feed creator. </param>
        /// <param name="status"> data feed status. </param>
        /// <param name="createdTime"> data feed created time. </param>
        /// <param name="actionLinkTemplate"> action link for alert. </param>
        /// <param name="authenticationType"> authentication type for corresponding data source. </param>
        /// <param name="credentialId"> The credential entity id. </param>
        /// <param name="dataSourceParameter"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureTableDataFeed(DataFeedSourceKind dataSourceType, string dataFeedId, string dataFeedName, string dataFeedDescription, DataFeedGranularityType granularityName, int? granularityAmount, IList<DataFeedMetric> metrics, IList<DataFeedDimension> dimension, string timestampColumn, DateTimeOffset dataStartFrom, long? startOffsetInSeconds, int? maxConcurrency, long? minRetryIntervalInSeconds, long? stopRetryAfterInSeconds, DataFeedRollupType? needRollup, DataFeedAutoRollupMethod? rollUpMethod, IList<string> rollUpColumns, string allUpIdentification, DataFeedMissingDataPointFillType? fillMissingPointType, double? fillMissingPointValue, DataFeedAccessMode? viewMode, IList<string> admins, IList<string> viewers, bool? isAdmin, string creator, DataFeedStatus? status, DateTimeOffset? createdTime, string actionLinkTemplate, AuthenticationTypeEnum? authenticationType, string credentialId, AzureTableParameter dataSourceParameter, Dictionary<string, BinaryData> rawData) : base(dataSourceType, dataFeedId, dataFeedName, dataFeedDescription, granularityName, granularityAmount, metrics, dimension, timestampColumn, dataStartFrom, startOffsetInSeconds, maxConcurrency, minRetryIntervalInSeconds, stopRetryAfterInSeconds, needRollup, rollUpMethod, rollUpColumns, allUpIdentification, fillMissingPointType, fillMissingPointValue, viewMode, admins, viewers, isAdmin, creator, status, createdTime, actionLinkTemplate, authenticationType, credentialId, rawData)
        {
            DataSourceParameter = dataSourceParameter;
            DataSourceType = dataSourceType;
        }

        /// <summary> Initializes a new instance of <see cref="AzureTableDataFeed"/> for deserialization. </summary>
        internal AzureTableDataFeed()
        {
        }

        /// <summary> Gets or sets the data source parameter. </summary>
        public AzureTableParameter DataSourceParameter { get; set; }
    }
}
