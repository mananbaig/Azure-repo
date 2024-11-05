// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> property to enable or disable resource provider inbound network traffic from public clients. </summary>
    public readonly partial struct VaultPublicNetworkAccess : IEquatable<VaultPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VaultPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VaultPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static VaultPublicNetworkAccess Enabled { get; } = new VaultPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static VaultPublicNetworkAccess Disabled { get; } = new VaultPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="VaultPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(VaultPublicNetworkAccess left, VaultPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VaultPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(VaultPublicNetworkAccess left, VaultPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VaultPublicNetworkAccess"/>. </summary>
        public static implicit operator VaultPublicNetworkAccess(string value) => new VaultPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VaultPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VaultPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
