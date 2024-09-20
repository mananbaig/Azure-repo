// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The direction of the traffic. </summary>
    public readonly partial struct NetworkTrafficDirection : IEquatable<NetworkTrafficDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkTrafficDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkTrafficDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static NetworkTrafficDirection Inbound { get; } = new NetworkTrafficDirection(InboundValue);
        /// <summary> Outbound. </summary>
        public static NetworkTrafficDirection Outbound { get; } = new NetworkTrafficDirection(OutboundValue);
        /// <summary> Determines if two <see cref="NetworkTrafficDirection"/> values are the same. </summary>
        public static bool operator ==(NetworkTrafficDirection left, NetworkTrafficDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkTrafficDirection"/> values are not the same. </summary>
        public static bool operator !=(NetworkTrafficDirection left, NetworkTrafficDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkTrafficDirection"/>. </summary>
        public static implicit operator NetworkTrafficDirection(string value) => new NetworkTrafficDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkTrafficDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkTrafficDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
