// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Enable Geo-redundant or not for server backup. </summary>
    public readonly partial struct PostgreSqlGeoRedundantBackup : IEquatable<PostgreSqlGeoRedundantBackup>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlGeoRedundantBackup"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlGeoRedundantBackup(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PostgreSqlGeoRedundantBackup Enabled { get; } = new PostgreSqlGeoRedundantBackup(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlGeoRedundantBackup Disabled { get; } = new PostgreSqlGeoRedundantBackup(DisabledValue);
        /// <summary> Determines if two <see cref="PostgreSqlGeoRedundantBackup"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlGeoRedundantBackup left, PostgreSqlGeoRedundantBackup right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlGeoRedundantBackup"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlGeoRedundantBackup left, PostgreSqlGeoRedundantBackup right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlGeoRedundantBackup"/>. </summary>
        public static implicit operator PostgreSqlGeoRedundantBackup(string value) => new PostgreSqlGeoRedundantBackup(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlGeoRedundantBackup other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlGeoRedundantBackup other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
