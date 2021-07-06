// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.MetricsAdvisor.Models;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> Model factory for read-only models. </summary>
    internal static partial class MicrosoftAzureMetricsAdvisorRestAPIOpenAPIV2ModelFactory
    {
        /// <summary> Initializes a new instance of AnomalyAlertConfiguration. </summary>
        /// <param name="id"> anomaly alerting configuration unique id. </param>
        /// <param name="name"> anomaly alerting configuration name. </param>
        /// <param name="description"> anomaly alerting configuration description. </param>
        /// <param name="crossMetricsOperator">
        /// cross metrics operator
        /// 
        /// 
        /// 
        /// should be specified when setting up multiple metric alerting configurations.
        /// </param>
        /// <param name="dimensionsToSplitAlert"> dimensions used to split alert. </param>
        /// <param name="idsOfHooksToAlert"> hook unique ids. </param>
        /// <param name="metricAlertConfigurations"> Anomaly alerting configurations. </param>
        /// <returns> A new <see cref="Models.AnomalyAlertConfiguration"/> instance for mocking. </returns>
        public static AnomalyAlertConfiguration AnomalyAlertConfiguration(string id = null, string name = null, string description = null, MetricAlertConfigurationsOperator? crossMetricsOperator = null, IEnumerable<string> dimensionsToSplitAlert = null, IEnumerable<string> idsOfHooksToAlert = null, IEnumerable<MetricAlertConfiguration> metricAlertConfigurations = null)
        {
            dimensionsToSplitAlert ??= new List<string>();
            idsOfHooksToAlert ??= new List<string>();
            metricAlertConfigurations ??= new List<MetricAlertConfiguration>();

            return new AnomalyAlertConfiguration(id, name, description, crossMetricsOperator, dimensionsToSplitAlert?.ToList(), idsOfHooksToAlert?.ToList(), metricAlertConfigurations?.ToList());
        }

        /// <summary> Initializes a new instance of AnomalyAlert. </summary>
        /// <param name="id"> alert id. </param>
        /// <param name="timestamp"> anomaly time. </param>
        /// <param name="createdOn"> created time. </param>
        /// <param name="lastModified"> modified time. </param>
        /// <returns> A new <see cref="Models.AnomalyAlert"/> instance for mocking. </returns>
        public static AnomalyAlert AnomalyAlert(string id = null, DateTimeOffset timestamp = default, DateTimeOffset createdOn = default, DateTimeOffset lastModified = default)
        {
            return new AnomalyAlert(id, timestamp, createdOn, lastModified);
        }

        /// <summary> Initializes a new instance of AnomalyDetectionConfiguration. </summary>
        /// <param name="id"> anomaly detection configuration unique id. </param>
        /// <param name="name"> anomaly detection configuration name. </param>
        /// <param name="description"> anomaly detection configuration description. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="wholeSeriesDetectionConditions"> . </param>
        /// <param name="seriesGroupDetectionConditions"> detection configuration for series group. </param>
        /// <param name="seriesDetectionConditions"> detection configuration for specific series. </param>
        /// <returns> A new <see cref="Models.AnomalyDetectionConfiguration"/> instance for mocking. </returns>
        public static AnomalyDetectionConfiguration AnomalyDetectionConfiguration(string id = null, string name = null, string description = null, string metricId = null, MetricWholeSeriesDetectionCondition wholeSeriesDetectionConditions = null, IEnumerable<MetricSeriesGroupDetectionCondition> seriesGroupDetectionConditions = null, IEnumerable<MetricSingleSeriesDetectionCondition> seriesDetectionConditions = null)
        {
            seriesGroupDetectionConditions ??= new List<MetricSeriesGroupDetectionCondition>();
            seriesDetectionConditions ??= new List<MetricSingleSeriesDetectionCondition>();

            return new AnomalyDetectionConfiguration(id, name, description, metricId, wholeSeriesDetectionConditions, seriesGroupDetectionConditions?.ToList(), seriesDetectionConditions?.ToList());
        }

        /// <summary> Initializes a new instance of IncidentRootCause. </summary>
        /// <param name="seriesKey"> . </param>
        /// <param name="paths"> drilling down path from query anomaly to root cause. </param>
        /// <param name="contributionScore"> score of the root cause. </param>
        /// <param name="description"> description of the root cause. </param>
        /// <returns> A new <see cref="Models.IncidentRootCause"/> instance for mocking. </returns>
        public static IncidentRootCause IncidentRootCause(DimensionKey seriesKey = null, IEnumerable<string> paths = null, double contributionScore = default, string description = null)
        {
            paths ??= new List<string>();

            return new IncidentRootCause(seriesKey, paths?.ToList(), contributionScore, description);
        }

        /// <summary> Initializes a new instance of DataFeedMetric. </summary>
        /// <param name="id"> metric id. </param>
        /// <param name="name"> metric name. </param>
        /// <param name="displayName"> metric display name. </param>
        /// <param name="description"> metric description. </param>
        /// <returns> A new <see cref="Models.DataFeedMetric"/> instance for mocking. </returns>
        public static DataFeedMetric DataFeedMetric(string id = null, string name = null, string displayName = null, string description = null)
        {
            return new DataFeedMetric(id, name, displayName, description);
        }

        /// <summary> Initializes a new instance of DataFeedIngestionStatus. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest ingestion task status for this data slice. </param>
        /// <param name="message"> the trimmed message of last ingestion job. </param>
        /// <returns> A new <see cref="Models.DataFeedIngestionStatus"/> instance for mocking. </returns>
        public static DataFeedIngestionStatus DataFeedIngestionStatus(DateTimeOffset timestamp = default, IngestionStatusType status = default, string message = null)
        {
            return new DataFeedIngestionStatus(timestamp, status, message);
        }

        /// <summary> Initializes a new instance of DataFeedIngestionProgress. </summary>
        /// <param name="latestSuccessTimestamp">
        /// the timestamp of latest success ingestion job.
        /// 
        /// null indicates not available.
        /// </param>
        /// <param name="latestActiveTimestamp">
        /// the timestamp of latest ingestion job with status update.
        /// 
        /// null indicates not available.
        /// </param>
        /// <returns> A new <see cref="Models.DataFeedIngestionProgress"/> instance for mocking. </returns>
        public static DataFeedIngestionProgress DataFeedIngestionProgress(DateTimeOffset? latestSuccessTimestamp = null, DateTimeOffset? latestActiveTimestamp = null)
        {
            return new DataFeedIngestionProgress(latestSuccessTimestamp, latestActiveTimestamp);
        }

        /// <summary> Initializes a new instance of EnrichmentStatus. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest enrichment status for this data slice. </param>
        /// <param name="message"> the trimmed message describes details of the enrichment status. </param>
        /// <returns> A new <see cref="Models.EnrichmentStatus"/> instance for mocking. </returns>
        public static EnrichmentStatus EnrichmentStatus(DateTimeOffset timestamp = default, string status = null, string message = null)
        {
            return new EnrichmentStatus(timestamp, status, message);
        }
    }
}
