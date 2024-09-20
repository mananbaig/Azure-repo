// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after the bypass property has been evaluated. </summary>
    public readonly partial struct KeyVaultNetworkRuleAction : IEquatable<KeyVaultNetworkRuleAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultNetworkRuleAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultNetworkRuleAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static KeyVaultNetworkRuleAction Allow { get; } = new KeyVaultNetworkRuleAction(AllowValue);
        /// <summary> Deny. </summary>
        public static KeyVaultNetworkRuleAction Deny { get; } = new KeyVaultNetworkRuleAction(DenyValue);
        /// <summary> Determines if two <see cref="KeyVaultNetworkRuleAction"/> values are the same. </summary>
        public static bool operator ==(KeyVaultNetworkRuleAction left, KeyVaultNetworkRuleAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultNetworkRuleAction"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultNetworkRuleAction left, KeyVaultNetworkRuleAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyVaultNetworkRuleAction"/>. </summary>
        public static implicit operator KeyVaultNetworkRuleAction(string value) => new KeyVaultNetworkRuleAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultNetworkRuleAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultNetworkRuleAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
