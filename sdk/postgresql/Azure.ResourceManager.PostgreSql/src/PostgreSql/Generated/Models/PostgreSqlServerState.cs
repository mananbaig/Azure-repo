// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> A state of a server that is visible to user. </summary>
    public readonly partial struct PostgreSqlServerState : IEquatable<PostgreSqlServerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlServerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadyValue = "Ready";
        private const string DroppingValue = "Dropping";
        private const string DisabledValue = "Disabled";
        private const string InaccessibleValue = "Inaccessible";

        /// <summary> Ready. </summary>
        public static PostgreSqlServerState Ready { get; } = new PostgreSqlServerState(ReadyValue);
        /// <summary> Dropping. </summary>
        public static PostgreSqlServerState Dropping { get; } = new PostgreSqlServerState(DroppingValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlServerState Disabled { get; } = new PostgreSqlServerState(DisabledValue);
        /// <summary> Inaccessible. </summary>
        public static PostgreSqlServerState Inaccessible { get; } = new PostgreSqlServerState(InaccessibleValue);
        /// <summary> Determines if two <see cref="PostgreSqlServerState"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlServerState left, PostgreSqlServerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlServerState"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlServerState left, PostgreSqlServerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlServerState"/>. </summary>
        public static implicit operator PostgreSqlServerState(string value) => new PostgreSqlServerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlServerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlServerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
