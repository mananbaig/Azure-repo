// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Log Collection Session details of the cluster. </summary>
    public partial class LogCollectionSession
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogCollectionSession"/>. </summary>
        internal LogCollectionSession()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogCollectionSession"/>. </summary>
        /// <param name="logStartOn"> Start Time of the logs when it was collected. </param>
        /// <param name="logEndOn"> End Time of the logs when it was collected. </param>
        /// <param name="timeCollected"> Duration of logs collected. </param>
        /// <param name="logSize"> Size of the logs collected. </param>
        /// <param name="logCollectionStatus"> LogCollection status. </param>
        /// <param name="logCollectionJobType"> LogCollection job type. </param>
        /// <param name="correlationId"> CorrelationId of the log collection. </param>
        /// <param name="endTimeCollected"> End Time of the logs when it was collected. </param>
        /// <param name="logCollectionError"> Log Collection Error details of the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogCollectionSession(DateTimeOffset? logStartOn, DateTimeOffset? logEndOn, DateTimeOffset? timeCollected, long? logSize, LogCollectionStatus? logCollectionStatus, LogCollectionJobType? logCollectionJobType, string correlationId, DateTimeOffset? endTimeCollected, LogCollectionError logCollectionError, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LogStartOn = logStartOn;
            LogEndOn = logEndOn;
            TimeCollected = timeCollected;
            LogSize = logSize;
            LogCollectionStatus = logCollectionStatus;
            LogCollectionJobType = logCollectionJobType;
            CorrelationId = correlationId;
            EndTimeCollected = endTimeCollected;
            LogCollectionError = logCollectionError;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Start Time of the logs when it was collected. </summary>
        [WirePath("logStartTime")]
        public DateTimeOffset? LogStartOn { get; }
        /// <summary> End Time of the logs when it was collected. </summary>
        [WirePath("logEndTime")]
        public DateTimeOffset? LogEndOn { get; }
        /// <summary> Duration of logs collected. </summary>
        [WirePath("timeCollected")]
        public DateTimeOffset? TimeCollected { get; }
        /// <summary> Size of the logs collected. </summary>
        [WirePath("logSize")]
        public long? LogSize { get; }
        /// <summary> LogCollection status. </summary>
        [WirePath("logCollectionStatus")]
        public LogCollectionStatus? LogCollectionStatus { get; }
        /// <summary> LogCollection job type. </summary>
        [WirePath("logCollectionJobType")]
        public LogCollectionJobType? LogCollectionJobType { get; }
        /// <summary> CorrelationId of the log collection. </summary>
        [WirePath("correlationId")]
        public string CorrelationId { get; }
        /// <summary> End Time of the logs when it was collected. </summary>
        [WirePath("endTimeCollected")]
        public DateTimeOffset? EndTimeCollected { get; }
        /// <summary> Log Collection Error details of the cluster. </summary>
        [WirePath("logCollectionError")]
        public LogCollectionError LogCollectionError { get; }
    }
}
