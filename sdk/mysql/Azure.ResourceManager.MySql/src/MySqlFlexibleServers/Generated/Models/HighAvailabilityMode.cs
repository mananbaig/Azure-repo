// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> High availability mode for a server. </summary>
    public readonly partial struct HighAvailabilityMode : IEquatable<HighAvailabilityMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HighAvailabilityMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HighAvailabilityMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string ZoneRedundantValue = "ZoneRedundant";
        private const string SameZoneValue = "SameZone";

        /// <summary> Disabled. </summary>
        public static HighAvailabilityMode Disabled { get; } = new HighAvailabilityMode(DisabledValue);
        /// <summary> ZoneRedundant. </summary>
        public static HighAvailabilityMode ZoneRedundant { get; } = new HighAvailabilityMode(ZoneRedundantValue);
        /// <summary> SameZone. </summary>
        public static HighAvailabilityMode SameZone { get; } = new HighAvailabilityMode(SameZoneValue);
        /// <summary> Determines if two <see cref="HighAvailabilityMode"/> values are the same. </summary>
        public static bool operator ==(HighAvailabilityMode left, HighAvailabilityMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HighAvailabilityMode"/> values are not the same. </summary>
        public static bool operator !=(HighAvailabilityMode left, HighAvailabilityMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HighAvailabilityMode"/>. </summary>
        public static implicit operator HighAvailabilityMode(string value) => new HighAvailabilityMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HighAvailabilityMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HighAvailabilityMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
