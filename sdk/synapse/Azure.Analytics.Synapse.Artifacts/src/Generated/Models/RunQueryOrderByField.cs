// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Parameter name to be used for order by. The allowed parameters to order by for pipeline runs are PipelineName, RunStart, RunEnd and Status; for activity runs are ActivityName, ActivityRunStart, ActivityRunEnd and Status; for trigger runs are TriggerName, TriggerRunTimestamp and Status. </summary>
    public readonly partial struct RunQueryOrderByField : IEquatable<RunQueryOrderByField>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunQueryOrderByField"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunQueryOrderByField(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunStartValue = "RunStart";
        private const string RunEndValue = "RunEnd";
        private const string PipelineNameValue = "PipelineName";
        private const string StatusValue = "Status";
        private const string ActivityNameValue = "ActivityName";
        private const string ActivityRunStartValue = "ActivityRunStart";
        private const string ActivityRunEndValue = "ActivityRunEnd";
        private const string TriggerNameValue = "TriggerName";
        private const string TriggerRunTimestampValue = "TriggerRunTimestamp";

        /// <summary> RunStart. </summary>
        public static RunQueryOrderByField RunStart { get; } = new RunQueryOrderByField(RunStartValue);
        /// <summary> RunEnd. </summary>
        public static RunQueryOrderByField RunEnd { get; } = new RunQueryOrderByField(RunEndValue);
        /// <summary> PipelineName. </summary>
        public static RunQueryOrderByField PipelineName { get; } = new RunQueryOrderByField(PipelineNameValue);
        /// <summary> Status. </summary>
        public static RunQueryOrderByField Status { get; } = new RunQueryOrderByField(StatusValue);
        /// <summary> ActivityName. </summary>
        public static RunQueryOrderByField ActivityName { get; } = new RunQueryOrderByField(ActivityNameValue);
        /// <summary> ActivityRunStart. </summary>
        public static RunQueryOrderByField ActivityRunStart { get; } = new RunQueryOrderByField(ActivityRunStartValue);
        /// <summary> ActivityRunEnd. </summary>
        public static RunQueryOrderByField ActivityRunEnd { get; } = new RunQueryOrderByField(ActivityRunEndValue);
        /// <summary> TriggerName. </summary>
        public static RunQueryOrderByField TriggerName { get; } = new RunQueryOrderByField(TriggerNameValue);
        /// <summary> TriggerRunTimestamp. </summary>
        public static RunQueryOrderByField TriggerRunTimestamp { get; } = new RunQueryOrderByField(TriggerRunTimestampValue);
        /// <summary> Determines if two <see cref="RunQueryOrderByField"/> values are the same. </summary>
        public static bool operator ==(RunQueryOrderByField left, RunQueryOrderByField right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunQueryOrderByField"/> values are not the same. </summary>
        public static bool operator !=(RunQueryOrderByField left, RunQueryOrderByField right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunQueryOrderByField"/>. </summary>
        public static implicit operator RunQueryOrderByField(string value) => new RunQueryOrderByField(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunQueryOrderByField other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunQueryOrderByField other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
