// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The ExternalCloudProviderType. </summary>
    public readonly partial struct ExternalCloudProviderType : IEquatable<ExternalCloudProviderType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExternalCloudProviderType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExternalCloudProviderType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExternalSubscriptionsValue = "externalSubscriptions";
        private const string ExternalBillingAccountsValue = "externalBillingAccounts";

        /// <summary> externalSubscriptions. </summary>
        public static ExternalCloudProviderType ExternalSubscriptions { get; } = new ExternalCloudProviderType(ExternalSubscriptionsValue);
        /// <summary> externalBillingAccounts. </summary>
        public static ExternalCloudProviderType ExternalBillingAccounts { get; } = new ExternalCloudProviderType(ExternalBillingAccountsValue);
        /// <summary> Determines if two <see cref="ExternalCloudProviderType"/> values are the same. </summary>
        public static bool operator ==(ExternalCloudProviderType left, ExternalCloudProviderType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExternalCloudProviderType"/> values are not the same. </summary>
        public static bool operator !=(ExternalCloudProviderType left, ExternalCloudProviderType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExternalCloudProviderType"/>. </summary>
        public static implicit operator ExternalCloudProviderType(string value) => new ExternalCloudProviderType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExternalCloudProviderType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExternalCloudProviderType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
