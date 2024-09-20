// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ReplicaType. </summary>
    public readonly partial struct ReplicaType : IEquatable<ReplicaType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicaType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicaType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string ReadableSecondaryValue = "ReadableSecondary";

        /// <summary> Primary. </summary>
        public static ReplicaType Primary { get; } = new ReplicaType(PrimaryValue);
        /// <summary> ReadableSecondary. </summary>
        public static ReplicaType ReadableSecondary { get; } = new ReplicaType(ReadableSecondaryValue);
        /// <summary> Determines if two <see cref="ReplicaType"/> values are the same. </summary>
        public static bool operator ==(ReplicaType left, ReplicaType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicaType"/> values are not the same. </summary>
        public static bool operator !=(ReplicaType left, ReplicaType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicaType"/>. </summary>
        public static implicit operator ReplicaType(string value) => new ReplicaType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicaType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicaType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
