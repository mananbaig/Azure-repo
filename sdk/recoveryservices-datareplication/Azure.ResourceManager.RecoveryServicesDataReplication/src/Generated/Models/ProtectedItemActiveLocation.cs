// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Gets or sets the location of the protected item. </summary>
    public readonly partial struct ProtectedItemActiveLocation : IEquatable<ProtectedItemActiveLocation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProtectedItemActiveLocation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProtectedItemActiveLocation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string RecoveryValue = "Recovery";

        /// <summary> Primary. </summary>
        public static ProtectedItemActiveLocation Primary { get; } = new ProtectedItemActiveLocation(PrimaryValue);
        /// <summary> Recovery. </summary>
        public static ProtectedItemActiveLocation Recovery { get; } = new ProtectedItemActiveLocation(RecoveryValue);
        /// <summary> Determines if two <see cref="ProtectedItemActiveLocation"/> values are the same. </summary>
        public static bool operator ==(ProtectedItemActiveLocation left, ProtectedItemActiveLocation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProtectedItemActiveLocation"/> values are not the same. </summary>
        public static bool operator !=(ProtectedItemActiveLocation left, ProtectedItemActiveLocation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProtectedItemActiveLocation"/>. </summary>
        public static implicit operator ProtectedItemActiveLocation(string value) => new ProtectedItemActiveLocation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProtectedItemActiveLocation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProtectedItemActiveLocation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
