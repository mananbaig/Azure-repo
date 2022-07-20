// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the default is &apos;AzureServices&apos;. </summary>
    public readonly partial struct KeyVaultNetworkRuleBypassOption : IEquatable<KeyVaultNetworkRuleBypassOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultNetworkRuleBypassOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultNetworkRuleBypassOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureServicesValue = "AzureServices";
        private const string NoneValue = "None";

        /// <summary> AzureServices. </summary>
        public static KeyVaultNetworkRuleBypassOption AzureServices { get; } = new KeyVaultNetworkRuleBypassOption(AzureServicesValue);
        /// <summary> None. </summary>
        public static KeyVaultNetworkRuleBypassOption None { get; } = new KeyVaultNetworkRuleBypassOption(NoneValue);
        /// <summary> Determines if two <see cref="KeyVaultNetworkRuleBypassOption"/> values are the same. </summary>
        public static bool operator ==(KeyVaultNetworkRuleBypassOption left, KeyVaultNetworkRuleBypassOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultNetworkRuleBypassOption"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultNetworkRuleBypassOption left, KeyVaultNetworkRuleBypassOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyVaultNetworkRuleBypassOption"/>. </summary>
        public static implicit operator KeyVaultNetworkRuleBypassOption(string value) => new KeyVaultNetworkRuleBypassOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultNetworkRuleBypassOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultNetworkRuleBypassOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
