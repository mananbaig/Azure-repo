// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Represents the collection configuration - a customizable description of performance counters, metrics, and full telemetry documents to be collected by the SDK. </summary>
    internal partial class CollectionConfigurationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CollectionConfigurationInfo"/>. </summary>
        internal CollectionConfigurationInfo()
        {
            Metrics = new ChangeTrackingList<DerivedMetricInfo>();
            DocumentStreams = new ChangeTrackingList<DocumentStreamInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionConfigurationInfo"/>. </summary>
        /// <param name="etag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="metrics"> An array of metric configuration info. </param>
        /// <param name="documentStreams"> An array of document stream configuration info. </param>
        /// <param name="quotaInfo"> Control document quotas for QuickPulse. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CollectionConfigurationInfo(string etag, IReadOnlyList<DerivedMetricInfo> metrics, IReadOnlyList<DocumentStreamInfo> documentStreams, QuotaConfigurationInfo quotaInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Etag = etag;
            Metrics = metrics;
            DocumentStreams = documentStreams;
            QuotaInfo = quotaInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An encoded string that indicates whether the collection configuration is changed. </summary>
        public string Etag { get; }
        /// <summary> An array of metric configuration info. </summary>
        public IReadOnlyList<DerivedMetricInfo> Metrics { get; }
        /// <summary> An array of document stream configuration info. </summary>
        public IReadOnlyList<DocumentStreamInfo> DocumentStreams { get; }
        /// <summary> Control document quotas for QuickPulse. </summary>
        public QuotaConfigurationInfo QuotaInfo { get; }
    }
}
