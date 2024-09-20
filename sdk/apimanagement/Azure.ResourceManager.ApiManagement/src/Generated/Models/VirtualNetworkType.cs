// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only. </summary>
    public readonly partial struct VirtualNetworkType : IEquatable<VirtualNetworkType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ExternalValue = "External";
        private const string InternalValue = "Internal";

        /// <summary> The service is not part of any Virtual Network. </summary>
        public static VirtualNetworkType None { get; } = new VirtualNetworkType(NoneValue);
        /// <summary> The service is part of Virtual Network and it is accessible from Internet. </summary>
        public static VirtualNetworkType External { get; } = new VirtualNetworkType(ExternalValue);
        /// <summary> The service is part of Virtual Network and it is only accessible from within the virtual network. </summary>
        public static VirtualNetworkType Internal { get; } = new VirtualNetworkType(InternalValue);
        /// <summary> Determines if two <see cref="VirtualNetworkType"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkType left, VirtualNetworkType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkType"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkType left, VirtualNetworkType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkType"/>. </summary>
        public static implicit operator VirtualNetworkType(string value) => new VirtualNetworkType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
