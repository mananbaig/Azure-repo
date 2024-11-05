// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Access to be allowed or denied. </summary>
    public readonly partial struct NetworkAccess : IEquatable<NetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static NetworkAccess Allow { get; } = new NetworkAccess(AllowValue);
        /// <summary> Deny. </summary>
        public static NetworkAccess Deny { get; } = new NetworkAccess(DenyValue);
        /// <summary> Determines if two <see cref="NetworkAccess"/> values are the same. </summary>
        public static bool operator ==(NetworkAccess left, NetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(NetworkAccess left, NetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkAccess"/>. </summary>
        public static implicit operator NetworkAccess(string value) => new NetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
