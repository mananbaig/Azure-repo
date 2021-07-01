// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> time mode. </summary>
    public readonly partial struct AlertQueryTimeMode : IEquatable<AlertQueryTimeMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AlertQueryTimeMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertQueryTimeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnomalyDetectedOnValue = "AnomalyTime";
        private const string CreatedOnValue = "CreatedTime";
        private const string ModifiedOnValue = "ModifiedTime";
        /// <summary> Determines if two <see cref="AlertQueryTimeMode"/> values are the same. </summary>
        public static bool operator ==(AlertQueryTimeMode left, AlertQueryTimeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertQueryTimeMode"/> values are not the same. </summary>
        public static bool operator !=(AlertQueryTimeMode left, AlertQueryTimeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertQueryTimeMode"/>. </summary>
        public static implicit operator AlertQueryTimeMode(string value) => new AlertQueryTimeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertQueryTimeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertQueryTimeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
