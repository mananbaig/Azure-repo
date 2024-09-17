// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The KeyVaultRefreshState. </summary>
    public readonly partial struct KeyVaultRefreshState : IEquatable<KeyVaultRefreshState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultRefreshState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultRefreshState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> Entities for which KeyVault refresh failed. </summary>
        public static KeyVaultRefreshState True { get; } = new KeyVaultRefreshState(TrueValue);
        /// <summary> Entities for which KeyVault refresh succeeded. </summary>
        public static KeyVaultRefreshState False { get; } = new KeyVaultRefreshState(FalseValue);
        /// <summary> Determines if two <see cref="KeyVaultRefreshState"/> values are the same. </summary>
        public static bool operator ==(KeyVaultRefreshState left, KeyVaultRefreshState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultRefreshState"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultRefreshState left, KeyVaultRefreshState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyVaultRefreshState"/>. </summary>
        public static implicit operator KeyVaultRefreshState(string value) => new KeyVaultRefreshState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultRefreshState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultRefreshState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
