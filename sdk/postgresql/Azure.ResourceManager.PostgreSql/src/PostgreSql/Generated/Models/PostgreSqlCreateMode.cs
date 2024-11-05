// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The mode to create a new server. </summary>
    internal readonly partial struct PostgreSqlCreateMode : IEquatable<PostgreSqlCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string PointInTimeRestoreValue = "PointInTimeRestore";
        private const string GeoRestoreValue = "GeoRestore";
        private const string ReplicaValue = "Replica";

        /// <summary> Default. </summary>
        public static PostgreSqlCreateMode Default { get; } = new PostgreSqlCreateMode(DefaultValue);
        /// <summary> PointInTimeRestore. </summary>
        public static PostgreSqlCreateMode PointInTimeRestore { get; } = new PostgreSqlCreateMode(PointInTimeRestoreValue);
        /// <summary> GeoRestore. </summary>
        public static PostgreSqlCreateMode GeoRestore { get; } = new PostgreSqlCreateMode(GeoRestoreValue);
        /// <summary> Replica. </summary>
        public static PostgreSqlCreateMode Replica { get; } = new PostgreSqlCreateMode(ReplicaValue);
        /// <summary> Determines if two <see cref="PostgreSqlCreateMode"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlCreateMode left, PostgreSqlCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlCreateMode"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlCreateMode left, PostgreSqlCreateMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlCreateMode"/>. </summary>
        public static implicit operator PostgreSqlCreateMode(string value) => new PostgreSqlCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
