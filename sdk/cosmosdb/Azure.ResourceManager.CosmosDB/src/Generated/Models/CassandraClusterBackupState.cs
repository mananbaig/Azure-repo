// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The current state of the backup. </summary>
    public readonly partial struct CassandraClusterBackupState : IEquatable<CassandraClusterBackupState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CassandraClusterBackupState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CassandraClusterBackupState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitiatedValue = "Initiated";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Initiated. </summary>
        public static CassandraClusterBackupState Initiated { get; } = new CassandraClusterBackupState(InitiatedValue);
        /// <summary> InProgress. </summary>
        public static CassandraClusterBackupState InProgress { get; } = new CassandraClusterBackupState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static CassandraClusterBackupState Succeeded { get; } = new CassandraClusterBackupState(SucceededValue);
        /// <summary> Failed. </summary>
        public static CassandraClusterBackupState Failed { get; } = new CassandraClusterBackupState(FailedValue);
        /// <summary> Determines if two <see cref="CassandraClusterBackupState"/> values are the same. </summary>
        public static bool operator ==(CassandraClusterBackupState left, CassandraClusterBackupState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CassandraClusterBackupState"/> values are not the same. </summary>
        public static bool operator !=(CassandraClusterBackupState left, CassandraClusterBackupState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CassandraClusterBackupState"/>. </summary>
        public static implicit operator CassandraClusterBackupState(string value) => new CassandraClusterBackupState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CassandraClusterBackupState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CassandraClusterBackupState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
