// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Type of Network Interface resource. </summary>
    public readonly partial struct NetworkInterfaceNicType : IEquatable<NetworkInterfaceNicType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceNicType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkInterfaceNicType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string ElasticValue = "Elastic";

        /// <summary> Standard. </summary>
        public static NetworkInterfaceNicType Standard { get; } = new NetworkInterfaceNicType(StandardValue);
        /// <summary> Elastic. </summary>
        public static NetworkInterfaceNicType Elastic { get; } = new NetworkInterfaceNicType(ElasticValue);
        /// <summary> Determines if two <see cref="NetworkInterfaceNicType"/> values are the same. </summary>
        public static bool operator ==(NetworkInterfaceNicType left, NetworkInterfaceNicType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkInterfaceNicType"/> values are not the same. </summary>
        public static bool operator !=(NetworkInterfaceNicType left, NetworkInterfaceNicType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkInterfaceNicType"/>. </summary>
        public static implicit operator NetworkInterfaceNicType(string value) => new NetworkInterfaceNicType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkInterfaceNicType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkInterfaceNicType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
