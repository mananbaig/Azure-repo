// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SqlPoolSecurityAlertPolicyName. </summary>
    public readonly partial struct SqlPoolSecurityAlertPolicyName : IEquatable<SqlPoolSecurityAlertPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlPoolSecurityAlertPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlPoolSecurityAlertPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static SqlPoolSecurityAlertPolicyName Default { get; } = new SqlPoolSecurityAlertPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="SqlPoolSecurityAlertPolicyName"/> values are the same. </summary>
        public static bool operator ==(SqlPoolSecurityAlertPolicyName left, SqlPoolSecurityAlertPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlPoolSecurityAlertPolicyName"/> values are not the same. </summary>
        public static bool operator !=(SqlPoolSecurityAlertPolicyName left, SqlPoolSecurityAlertPolicyName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlPoolSecurityAlertPolicyName"/>. </summary>
        public static implicit operator SqlPoolSecurityAlertPolicyName(string value) => new SqlPoolSecurityAlertPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlPoolSecurityAlertPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlPoolSecurityAlertPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
