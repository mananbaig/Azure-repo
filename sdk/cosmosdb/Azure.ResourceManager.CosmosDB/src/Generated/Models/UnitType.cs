// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The unit of the metric. </summary>
    public readonly partial struct UnitType : IEquatable<UnitType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="UnitType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UnitType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";
        private const string BytesValue = "Bytes";
        private const string SecondsValue = "Seconds";
        private const string PercentValue = "Percent";
        private const string CountPerSecondValue = "CountPerSecond";
        private const string BytesPerSecondValue = "BytesPerSecond";
        private const string MillisecondsValue = "Milliseconds";

        /// <summary> Count. </summary>
        public static UnitType Count { get; } = new UnitType(CountValue);
        /// <summary> Bytes. </summary>
        public static UnitType Bytes { get; } = new UnitType(BytesValue);
        /// <summary> Seconds. </summary>
        public static UnitType Seconds { get; } = new UnitType(SecondsValue);
        /// <summary> Percent. </summary>
        public static UnitType Percent { get; } = new UnitType(PercentValue);
        /// <summary> CountPerSecond. </summary>
        public static UnitType CountPerSecond { get; } = new UnitType(CountPerSecondValue);
        /// <summary> BytesPerSecond. </summary>
        public static UnitType BytesPerSecond { get; } = new UnitType(BytesPerSecondValue);
        /// <summary> Milliseconds. </summary>
        public static UnitType Milliseconds { get; } = new UnitType(MillisecondsValue);
        /// <summary> Determines if two <see cref="UnitType"/> values are the same. </summary>
        public static bool operator ==(UnitType left, UnitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UnitType"/> values are not the same. </summary>
        public static bool operator !=(UnitType left, UnitType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UnitType"/>. </summary>
        public static implicit operator UnitType(string value) => new UnitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UnitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UnitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
