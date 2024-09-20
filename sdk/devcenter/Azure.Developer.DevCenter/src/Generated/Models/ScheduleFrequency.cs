// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> The frequency of task execution. </summary>
    public readonly partial struct ScheduleFrequency : IEquatable<ScheduleFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduleFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduleFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DailyValue = "Daily";

        /// <summary> The scheduled task will run every day. </summary>
        public static ScheduleFrequency Daily { get; } = new ScheduleFrequency(DailyValue);
        /// <summary> Determines if two <see cref="ScheduleFrequency"/> values are the same. </summary>
        public static bool operator ==(ScheduleFrequency left, ScheduleFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduleFrequency"/> values are not the same. </summary>
        public static bool operator !=(ScheduleFrequency left, ScheduleFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScheduleFrequency"/>. </summary>
        public static implicit operator ScheduleFrequency(string value) => new ScheduleFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduleFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduleFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
