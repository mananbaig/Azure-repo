// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Encryption type of the capacity pool, set encryption type for data at rest for this pool and all volumes in it. This value can only be set when creating new pool. </summary>
    public readonly partial struct CapacityPoolEncryptionType : IEquatable<CapacityPoolEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CapacityPoolEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CapacityPoolEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleValue = "Single";
        private const string DoubleValue = "Double";

        /// <summary> EncryptionType Single, volumes will use single encryption at rest. </summary>
        public static CapacityPoolEncryptionType Single { get; } = new CapacityPoolEncryptionType(SingleValue);
        /// <summary> EncryptionType Double, volumes will use double encryption at rest. </summary>
        public static CapacityPoolEncryptionType Double { get; } = new CapacityPoolEncryptionType(DoubleValue);
        /// <summary> Determines if two <see cref="CapacityPoolEncryptionType"/> values are the same. </summary>
        public static bool operator ==(CapacityPoolEncryptionType left, CapacityPoolEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CapacityPoolEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(CapacityPoolEncryptionType left, CapacityPoolEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CapacityPoolEncryptionType"/>. </summary>
        public static implicit operator CapacityPoolEncryptionType(string value) => new CapacityPoolEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CapacityPoolEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CapacityPoolEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
