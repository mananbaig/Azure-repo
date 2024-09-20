// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Command type. </summary>
    internal readonly partial struct CommandType : IEquatable<CommandType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommandType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommandType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MigrateSyncCompleteDatabaseValue = "Migrate.Sync.Complete.Database";
        private const string MigrateSqlServerAzureDBSqlMICompleteValue = "Migrate.SqlServer.AzureDbSqlMi.Complete";
        private const string CancelValue = "cancel";
        private const string FinishValue = "finish";
        private const string RestartValue = "restart";

        /// <summary> Migrate.Sync.Complete.Database. </summary>
        public static CommandType MigrateSyncCompleteDatabase { get; } = new CommandType(MigrateSyncCompleteDatabaseValue);
        /// <summary> Migrate.SqlServer.AzureDbSqlMi.Complete. </summary>
        public static CommandType MigrateSqlServerAzureDBSqlMIComplete { get; } = new CommandType(MigrateSqlServerAzureDBSqlMICompleteValue);
        /// <summary> cancel. </summary>
        public static CommandType Cancel { get; } = new CommandType(CancelValue);
        /// <summary> finish. </summary>
        public static CommandType Finish { get; } = new CommandType(FinishValue);
        /// <summary> restart. </summary>
        public static CommandType Restart { get; } = new CommandType(RestartValue);
        /// <summary> Determines if two <see cref="CommandType"/> values are the same. </summary>
        public static bool operator ==(CommandType left, CommandType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommandType"/> values are not the same. </summary>
        public static bool operator !=(CommandType left, CommandType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommandType"/>. </summary>
        public static implicit operator CommandType(string value) => new CommandType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommandType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommandType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
