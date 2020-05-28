// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The virtual wan security provider type. </summary>
    public readonly partial struct VirtualWanSecurityProviderType : IEquatable<VirtualWanSecurityProviderType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VirtualWanSecurityProviderType"/> values are the same. </summary>
        public VirtualWanSecurityProviderType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExternalValue = "External";
        private const string NativeValue = "Native";

        /// <summary> External. </summary>
        public static VirtualWanSecurityProviderType External { get; } = new VirtualWanSecurityProviderType(ExternalValue);
        /// <summary> Native. </summary>
        public static VirtualWanSecurityProviderType Native { get; } = new VirtualWanSecurityProviderType(NativeValue);
        /// <summary> Determines if two <see cref="VirtualWanSecurityProviderType"/> values are the same. </summary>
        public static bool operator ==(VirtualWanSecurityProviderType left, VirtualWanSecurityProviderType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualWanSecurityProviderType"/> values are not the same. </summary>
        public static bool operator !=(VirtualWanSecurityProviderType left, VirtualWanSecurityProviderType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualWanSecurityProviderType"/>. </summary>
        public static implicit operator VirtualWanSecurityProviderType(string value) => new VirtualWanSecurityProviderType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualWanSecurityProviderType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualWanSecurityProviderType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
