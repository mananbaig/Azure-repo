// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents Activity timeline item.
    /// Serialized Name: ActivityTimelineItem
    /// </summary>
    public partial class ActivityTimelineItem : EntityTimelineItem
    {
        /// <summary> Initializes a new instance of <see cref="ActivityTimelineItem"/>. </summary>
        /// <param name="queryId">
        /// The activity query id.
        /// Serialized Name: ActivityTimelineItem.queryId
        /// </param>
        /// <param name="bucketStartOn">
        /// The grouping bucket start time.
        /// Serialized Name: ActivityTimelineItem.bucketStartTimeUTC
        /// </param>
        /// <param name="bucketEndOn">
        /// The grouping bucket end time.
        /// Serialized Name: ActivityTimelineItem.bucketEndTimeUTC
        /// </param>
        /// <param name="firstActivityOn">
        /// The time of the first activity in the grouping bucket.
        /// Serialized Name: ActivityTimelineItem.firstActivityTimeUTC
        /// </param>
        /// <param name="lastActivityOn">
        /// The time of the last activity in the grouping bucket.
        /// Serialized Name: ActivityTimelineItem.lastActivityTimeUTC
        /// </param>
        /// <param name="content">
        /// The activity timeline content.
        /// Serialized Name: ActivityTimelineItem.content
        /// </param>
        /// <param name="title">
        /// The activity timeline title.
        /// Serialized Name: ActivityTimelineItem.title
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/>, <paramref name="content"/> or <paramref name="title"/> is null. </exception>
        internal ActivityTimelineItem(string queryId, DateTimeOffset bucketStartOn, DateTimeOffset bucketEndOn, DateTimeOffset firstActivityOn, DateTimeOffset lastActivityOn, string content, string title)
        {
            Argument.AssertNotNull(queryId, nameof(queryId));
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(title, nameof(title));

            QueryId = queryId;
            BucketStartOn = bucketStartOn;
            BucketEndOn = bucketEndOn;
            FirstActivityOn = firstActivityOn;
            LastActivityOn = lastActivityOn;
            Content = content;
            Title = title;
            Kind = EntityTimelineKind.Activity;
        }

        /// <summary> Initializes a new instance of <see cref="ActivityTimelineItem"/>. </summary>
        /// <param name="kind">
        /// The entity query kind type.
        /// Serialized Name: EntityTimelineItem.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queryId">
        /// The activity query id.
        /// Serialized Name: ActivityTimelineItem.queryId
        /// </param>
        /// <param name="bucketStartOn">
        /// The grouping bucket start time.
        /// Serialized Name: ActivityTimelineItem.bucketStartTimeUTC
        /// </param>
        /// <param name="bucketEndOn">
        /// The grouping bucket end time.
        /// Serialized Name: ActivityTimelineItem.bucketEndTimeUTC
        /// </param>
        /// <param name="firstActivityOn">
        /// The time of the first activity in the grouping bucket.
        /// Serialized Name: ActivityTimelineItem.firstActivityTimeUTC
        /// </param>
        /// <param name="lastActivityOn">
        /// The time of the last activity in the grouping bucket.
        /// Serialized Name: ActivityTimelineItem.lastActivityTimeUTC
        /// </param>
        /// <param name="content">
        /// The activity timeline content.
        /// Serialized Name: ActivityTimelineItem.content
        /// </param>
        /// <param name="title">
        /// The activity timeline title.
        /// Serialized Name: ActivityTimelineItem.title
        /// </param>
        internal ActivityTimelineItem(EntityTimelineKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string queryId, DateTimeOffset bucketStartOn, DateTimeOffset bucketEndOn, DateTimeOffset firstActivityOn, DateTimeOffset lastActivityOn, string content, string title) : base(kind, serializedAdditionalRawData)
        {
            QueryId = queryId;
            BucketStartOn = bucketStartOn;
            BucketEndOn = bucketEndOn;
            FirstActivityOn = firstActivityOn;
            LastActivityOn = lastActivityOn;
            Content = content;
            Title = title;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="ActivityTimelineItem"/> for deserialization. </summary>
        internal ActivityTimelineItem()
        {
        }

        /// <summary>
        /// The activity query id.
        /// Serialized Name: ActivityTimelineItem.queryId
        /// </summary>
        public string QueryId { get; }
        /// <summary>
        /// The grouping bucket start time.
        /// Serialized Name: ActivityTimelineItem.bucketStartTimeUTC
        /// </summary>
        public DateTimeOffset BucketStartOn { get; }
        /// <summary>
        /// The grouping bucket end time.
        /// Serialized Name: ActivityTimelineItem.bucketEndTimeUTC
        /// </summary>
        public DateTimeOffset BucketEndOn { get; }
        /// <summary>
        /// The time of the first activity in the grouping bucket.
        /// Serialized Name: ActivityTimelineItem.firstActivityTimeUTC
        /// </summary>
        public DateTimeOffset FirstActivityOn { get; }
        /// <summary>
        /// The time of the last activity in the grouping bucket.
        /// Serialized Name: ActivityTimelineItem.lastActivityTimeUTC
        /// </summary>
        public DateTimeOffset LastActivityOn { get; }
        /// <summary>
        /// The activity timeline content.
        /// Serialized Name: ActivityTimelineItem.content
        /// </summary>
        public string Content { get; }
        /// <summary>
        /// The activity timeline title.
        /// Serialized Name: ActivityTimelineItem.title
        /// </summary>
        public string Title { get; }
    }
}
