// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The polling frequency for the TAXII server.
    /// Serialized Name: PollingFrequency
    /// </summary>
    public readonly partial struct PollingFrequency : IEquatable<PollingFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PollingFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PollingFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnceAMinuteValue = "OnceAMinute";
        private const string OnceAnHourValue = "OnceAnHour";
        private const string OnceADayValue = "OnceADay";

        /// <summary>
        /// Once a minute
        /// Serialized Name: PollingFrequency.OnceAMinute
        /// </summary>
        public static PollingFrequency OnceAMinute { get; } = new PollingFrequency(OnceAMinuteValue);
        /// <summary>
        /// Once an hour
        /// Serialized Name: PollingFrequency.OnceAnHour
        /// </summary>
        public static PollingFrequency OnceAnHour { get; } = new PollingFrequency(OnceAnHourValue);
        /// <summary>
        /// Once a day
        /// Serialized Name: PollingFrequency.OnceADay
        /// </summary>
        public static PollingFrequency OnceADay { get; } = new PollingFrequency(OnceADayValue);
        /// <summary> Determines if two <see cref="PollingFrequency"/> values are the same. </summary>
        public static bool operator ==(PollingFrequency left, PollingFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PollingFrequency"/> values are not the same. </summary>
        public static bool operator !=(PollingFrequency left, PollingFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PollingFrequency"/>. </summary>
        public static implicit operator PollingFrequency(string value) => new PollingFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PollingFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PollingFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
