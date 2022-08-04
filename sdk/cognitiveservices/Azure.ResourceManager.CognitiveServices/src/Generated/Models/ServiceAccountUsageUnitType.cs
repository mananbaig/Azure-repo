// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The unit of the metric. </summary>
    public readonly partial struct ServiceAccountUsageUnitType : IEquatable<ServiceAccountUsageUnitType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceAccountUsageUnitType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceAccountUsageUnitType(string value)
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
        public static ServiceAccountUsageUnitType Count { get; } = new ServiceAccountUsageUnitType(CountValue);
        /// <summary> Bytes. </summary>
        public static ServiceAccountUsageUnitType Bytes { get; } = new ServiceAccountUsageUnitType(BytesValue);
        /// <summary> Seconds. </summary>
        public static ServiceAccountUsageUnitType Seconds { get; } = new ServiceAccountUsageUnitType(SecondsValue);
        /// <summary> Percent. </summary>
        public static ServiceAccountUsageUnitType Percent { get; } = new ServiceAccountUsageUnitType(PercentValue);
        /// <summary> CountPerSecond. </summary>
        public static ServiceAccountUsageUnitType CountPerSecond { get; } = new ServiceAccountUsageUnitType(CountPerSecondValue);
        /// <summary> BytesPerSecond. </summary>
        public static ServiceAccountUsageUnitType BytesPerSecond { get; } = new ServiceAccountUsageUnitType(BytesPerSecondValue);
        /// <summary> Milliseconds. </summary>
        public static ServiceAccountUsageUnitType Milliseconds { get; } = new ServiceAccountUsageUnitType(MillisecondsValue);
        /// <summary> Determines if two <see cref="ServiceAccountUsageUnitType"/> values are the same. </summary>
        public static bool operator ==(ServiceAccountUsageUnitType left, ServiceAccountUsageUnitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceAccountUsageUnitType"/> values are not the same. </summary>
        public static bool operator !=(ServiceAccountUsageUnitType left, ServiceAccountUsageUnitType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceAccountUsageUnitType"/>. </summary>
        public static implicit operator ServiceAccountUsageUnitType(string value) => new ServiceAccountUsageUnitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceAccountUsageUnitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceAccountUsageUnitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
