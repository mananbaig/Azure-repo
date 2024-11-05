// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The password name "password1" or "password2". </summary>
    public readonly partial struct ContainerRegistryTokenPasswordName : IEquatable<ContainerRegistryTokenPasswordName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTokenPasswordName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryTokenPasswordName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Password1Value = "password1";
        private const string Password2Value = "password2";

        /// <summary> password1. </summary>
        public static ContainerRegistryTokenPasswordName Password1 { get; } = new ContainerRegistryTokenPasswordName(Password1Value);
        /// <summary> password2. </summary>
        public static ContainerRegistryTokenPasswordName Password2 { get; } = new ContainerRegistryTokenPasswordName(Password2Value);
        /// <summary> Determines if two <see cref="ContainerRegistryTokenPasswordName"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryTokenPasswordName left, ContainerRegistryTokenPasswordName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryTokenPasswordName"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryTokenPasswordName left, ContainerRegistryTokenPasswordName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerRegistryTokenPasswordName"/>. </summary>
        public static implicit operator ContainerRegistryTokenPasswordName(string value) => new ContainerRegistryTokenPasswordName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryTokenPasswordName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryTokenPasswordName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
