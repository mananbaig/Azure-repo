// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterJobExceptionTriggered event. </summary>
    public partial class AcsRouterJobExceptionTriggeredEventData : AcsRouterJobEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterJobExceptionTriggeredEventData"/>. </summary>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="labels"/> or <paramref name="tags"/> is null. </exception>
        internal AcsRouterJobExceptionTriggeredEventData(IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags) : base(labels, tags)
        {
            Argument.AssertNotNull(labels, nameof(labels));
            Argument.AssertNotNull(tags, nameof(tags));
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobExceptionTriggeredEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queueId"> Router Job events Queue Id. </param>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        /// <param name="ruleKey"> Router Job Exception Triggered Rule Key. </param>
        /// <param name="exceptionRuleId"> Router Job Exception Triggered Rule Id. </param>
        internal AcsRouterJobExceptionTriggeredEventData(string jobId, string channelReference, string channelId, IDictionary<string, BinaryData> serializedAdditionalRawData, string queueId, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags, string ruleKey, string exceptionRuleId) : base(jobId, channelReference, channelId, serializedAdditionalRawData, queueId, labels, tags)
        {
            RuleKey = ruleKey;
            ExceptionRuleId = exceptionRuleId;
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobExceptionTriggeredEventData"/> for deserialization. </summary>
        internal AcsRouterJobExceptionTriggeredEventData()
        {
        }

        /// <summary> Router Job Exception Triggered Rule Key. </summary>
        public string RuleKey { get; }
        /// <summary> Router Job Exception Triggered Rule Id. </summary>
        public string ExceptionRuleId { get; }
    }
}
