// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The current state of the vpn connection. </summary>
    public readonly partial struct VpnConnectionStatus : IEquatable<VpnConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VpnConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ConnectingValue = "Connecting";
        private const string ConnectedValue = "Connected";
        private const string NotConnectedValue = "NotConnected";

        /// <summary> Unknown. </summary>
        public static VpnConnectionStatus Unknown { get; } = new VpnConnectionStatus(UnknownValue);
        /// <summary> Connecting. </summary>
        public static VpnConnectionStatus Connecting { get; } = new VpnConnectionStatus(ConnectingValue);
        /// <summary> Connected. </summary>
        public static VpnConnectionStatus Connected { get; } = new VpnConnectionStatus(ConnectedValue);
        /// <summary> NotConnected. </summary>
        public static VpnConnectionStatus NotConnected { get; } = new VpnConnectionStatus(NotConnectedValue);
        /// <summary> Determines if two <see cref="VpnConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(VpnConnectionStatus left, VpnConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(VpnConnectionStatus left, VpnConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VpnConnectionStatus"/>. </summary>
        public static implicit operator VpnConnectionStatus(string value) => new VpnConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
