// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Storage type. </summary>
    public readonly partial struct BackupStorageType : IEquatable<BackupStorageType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupStorageType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupStorageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string GeoRedundantValue = "GeoRedundant";
        private const string LocallyRedundantValue = "LocallyRedundant";
        private const string ZoneRedundantValue = "ZoneRedundant";
        private const string ReadAccessGeoZoneRedundantValue = "ReadAccessGeoZoneRedundant";

        /// <summary> Invalid. </summary>
        public static BackupStorageType Invalid { get; } = new BackupStorageType(InvalidValue);
        /// <summary> GeoRedundant. </summary>
        public static BackupStorageType GeoRedundant { get; } = new BackupStorageType(GeoRedundantValue);
        /// <summary> LocallyRedundant. </summary>
        public static BackupStorageType LocallyRedundant { get; } = new BackupStorageType(LocallyRedundantValue);
        /// <summary> ZoneRedundant. </summary>
        public static BackupStorageType ZoneRedundant { get; } = new BackupStorageType(ZoneRedundantValue);
        /// <summary> ReadAccessGeoZoneRedundant. </summary>
        public static BackupStorageType ReadAccessGeoZoneRedundant { get; } = new BackupStorageType(ReadAccessGeoZoneRedundantValue);
        /// <summary> Determines if two <see cref="BackupStorageType"/> values are the same. </summary>
        public static bool operator ==(BackupStorageType left, BackupStorageType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupStorageType"/> values are not the same. </summary>
        public static bool operator !=(BackupStorageType left, BackupStorageType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupStorageType"/>. </summary>
        public static implicit operator BackupStorageType(string value) => new BackupStorageType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupStorageType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupStorageType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
