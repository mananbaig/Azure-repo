// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> The time grain specifies the aggregation interval for the metric. Expressed as a duration 'PT1M', 'PT1H', etc. </summary>
    public readonly partial struct TimeGrain : IEquatable<TimeGrain>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TimeGrain"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TimeGrain(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PT5SValue = "PT5S";
        private const string PT10SValue = "PT10S";
        private const string PT1MValue = "PT1M";
        private const string PT5MValue = "PT5M";
        private const string PT1HValue = "PT1H";

        /// <summary> 5 seconds, available only if test run duration is less than 10 minutes. </summary>
        public static TimeGrain PT5S { get; } = new TimeGrain(PT5SValue);
        /// <summary> 10 seconds, available only if test run duration is less than 10 minutes. </summary>
        public static TimeGrain PT10S { get; } = new TimeGrain(PT10SValue);
        /// <summary> 1 minute. </summary>
        public static TimeGrain PT1M { get; } = new TimeGrain(PT1MValue);
        /// <summary> 5 minutes, available only if test run duration is greater than 1 minute. </summary>
        public static TimeGrain PT5M { get; } = new TimeGrain(PT5MValue);
        /// <summary> 1 hour, available only if test run duration is greater than 1 minute. </summary>
        public static TimeGrain PT1H { get; } = new TimeGrain(PT1HValue);
        /// <summary> Determines if two <see cref="TimeGrain"/> values are the same. </summary>
        public static bool operator ==(TimeGrain left, TimeGrain right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TimeGrain"/> values are not the same. </summary>
        public static bool operator !=(TimeGrain left, TimeGrain right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TimeGrain"/>. </summary>
        public static implicit operator TimeGrain(string value) => new TimeGrain(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TimeGrain other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TimeGrain other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
