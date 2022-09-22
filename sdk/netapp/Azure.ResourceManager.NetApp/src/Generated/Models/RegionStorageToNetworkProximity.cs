// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Provides storage to network proximity information in the region. </summary>
    public readonly partial struct RegionStorageToNetworkProximity : IEquatable<RegionStorageToNetworkProximity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RegionStorageToNetworkProximity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RegionStorageToNetworkProximity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string T1Value = "T1";
        private const string T2Value = "T2";
        private const string T1AndT2Value = "T1AndT2";

        /// <summary> Basic network connectivity. </summary>
        public static RegionStorageToNetworkProximity Default { get; } = new RegionStorageToNetworkProximity(DefaultValue);
        /// <summary> Standard T1 network connectivity. </summary>
        public static RegionStorageToNetworkProximity T1 { get; } = new RegionStorageToNetworkProximity(T1Value);
        /// <summary> Standard T2 network connectivity. </summary>
        public static RegionStorageToNetworkProximity T2 { get; } = new RegionStorageToNetworkProximity(T2Value);
        /// <summary> Standard T1 and T2 network connectivity. </summary>
        public static RegionStorageToNetworkProximity T1AndT2 { get; } = new RegionStorageToNetworkProximity(T1AndT2Value);
        /// <summary> Determines if two <see cref="RegionStorageToNetworkProximity"/> values are the same. </summary>
        public static bool operator ==(RegionStorageToNetworkProximity left, RegionStorageToNetworkProximity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RegionStorageToNetworkProximity"/> values are not the same. </summary>
        public static bool operator !=(RegionStorageToNetworkProximity left, RegionStorageToNetworkProximity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RegionStorageToNetworkProximity"/>. </summary>
        public static implicit operator RegionStorageToNetworkProximity(string value) => new RegionStorageToNetworkProximity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RegionStorageToNetworkProximity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RegionStorageToNetworkProximity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
