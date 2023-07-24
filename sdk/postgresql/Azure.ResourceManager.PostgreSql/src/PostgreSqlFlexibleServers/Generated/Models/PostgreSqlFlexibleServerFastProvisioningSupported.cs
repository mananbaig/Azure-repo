// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Gets a value indicating whether fast provisioning is supported. "Enabled" means fast provisioning is supported. "Disabled" stands for fast provisioning is not supported. </summary>
    public readonly partial struct PostgreSqlFlexibleServerFastProvisioningSupported : IEquatable<PostgreSqlFlexibleServerFastProvisioningSupported>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerFastProvisioningSupported"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerFastProvisioningSupported(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PostgreSqlFlexibleServerFastProvisioningSupported Enabled { get; } = new PostgreSqlFlexibleServerFastProvisioningSupported(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlFlexibleServerFastProvisioningSupported Disabled { get; } = new PostgreSqlFlexibleServerFastProvisioningSupported(DisabledValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerFastProvisioningSupported"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerFastProvisioningSupported left, PostgreSqlFlexibleServerFastProvisioningSupported right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerFastProvisioningSupported"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerFastProvisioningSupported left, PostgreSqlFlexibleServerFastProvisioningSupported right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerFastProvisioningSupported"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerFastProvisioningSupported(string value) => new PostgreSqlFlexibleServerFastProvisioningSupported(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerFastProvisioningSupported other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerFastProvisioningSupported other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
