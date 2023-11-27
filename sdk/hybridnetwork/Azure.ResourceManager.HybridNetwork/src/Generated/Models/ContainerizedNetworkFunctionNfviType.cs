// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The network function type. </summary>
    internal readonly partial struct ContainerizedNetworkFunctionNfviType : IEquatable<ContainerizedNetworkFunctionNfviType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerizedNetworkFunctionNfviType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerizedNetworkFunctionNfviType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AzureArcKubernetesValue = "AzureArcKubernetes";

        /// <summary> Unknown. </summary>
        public static ContainerizedNetworkFunctionNfviType Unknown { get; } = new ContainerizedNetworkFunctionNfviType(UnknownValue);
        /// <summary> AzureArcKubernetes. </summary>
        public static ContainerizedNetworkFunctionNfviType AzureArcKubernetes { get; } = new ContainerizedNetworkFunctionNfviType(AzureArcKubernetesValue);
        /// <summary> Determines if two <see cref="ContainerizedNetworkFunctionNfviType"/> values are the same. </summary>
        public static bool operator ==(ContainerizedNetworkFunctionNfviType left, ContainerizedNetworkFunctionNfviType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerizedNetworkFunctionNfviType"/> values are not the same. </summary>
        public static bool operator !=(ContainerizedNetworkFunctionNfviType left, ContainerizedNetworkFunctionNfviType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerizedNetworkFunctionNfviType"/>. </summary>
        public static implicit operator ContainerizedNetworkFunctionNfviType(string value) => new ContainerizedNetworkFunctionNfviType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerizedNetworkFunctionNfviType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerizedNetworkFunctionNfviType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
