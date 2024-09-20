// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Open mode type enum. </summary>
    public readonly partial struct AutonomousDatabaseModeType : IEquatable<AutonomousDatabaseModeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseModeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutonomousDatabaseModeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadOnlyValue = "ReadOnly";
        private const string ReadWriteValue = "ReadWrite";

        /// <summary> ReadOnly mode. </summary>
        public static AutonomousDatabaseModeType ReadOnly { get; } = new AutonomousDatabaseModeType(ReadOnlyValue);
        /// <summary> ReadWrite mode. </summary>
        public static AutonomousDatabaseModeType ReadWrite { get; } = new AutonomousDatabaseModeType(ReadWriteValue);
        /// <summary> Determines if two <see cref="AutonomousDatabaseModeType"/> values are the same. </summary>
        public static bool operator ==(AutonomousDatabaseModeType left, AutonomousDatabaseModeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutonomousDatabaseModeType"/> values are not the same. </summary>
        public static bool operator !=(AutonomousDatabaseModeType left, AutonomousDatabaseModeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutonomousDatabaseModeType"/>. </summary>
        public static implicit operator AutonomousDatabaseModeType(string value) => new AutonomousDatabaseModeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutonomousDatabaseModeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutonomousDatabaseModeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
