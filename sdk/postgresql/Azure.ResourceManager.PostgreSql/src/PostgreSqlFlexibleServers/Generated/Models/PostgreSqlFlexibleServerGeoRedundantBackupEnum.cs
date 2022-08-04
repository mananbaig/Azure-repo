// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A value indicating whether Geo-Redundant backup is enabled on the server. </summary>
    public readonly partial struct PostgreSqlFlexibleServerGeoRedundantBackupEnum : IEquatable<PostgreSqlFlexibleServerGeoRedundantBackupEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerGeoRedundantBackupEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerGeoRedundantBackupEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PostgreSqlFlexibleServerGeoRedundantBackupEnum Enabled { get; } = new PostgreSqlFlexibleServerGeoRedundantBackupEnum(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlFlexibleServerGeoRedundantBackupEnum Disabled { get; } = new PostgreSqlFlexibleServerGeoRedundantBackupEnum(DisabledValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerGeoRedundantBackupEnum"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerGeoRedundantBackupEnum left, PostgreSqlFlexibleServerGeoRedundantBackupEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerGeoRedundantBackupEnum"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerGeoRedundantBackupEnum left, PostgreSqlFlexibleServerGeoRedundantBackupEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerGeoRedundantBackupEnum"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerGeoRedundantBackupEnum(string value) => new PostgreSqlFlexibleServerGeoRedundantBackupEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerGeoRedundantBackupEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerGeoRedundantBackupEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
