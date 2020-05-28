// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped encryption key will be used. &apos;Service&apos; key type implies that a default service key is used. </summary>
    public readonly partial struct KeyType : IEquatable<KeyType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KeyType"/> values are the same. </summary>
        public KeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceValue = "Service";
        private const string AccountValue = "Account";

        /// <summary> Service. </summary>
        public static KeyType Service { get; } = new KeyType(ServiceValue);
        /// <summary> Account. </summary>
        public static KeyType Account { get; } = new KeyType(AccountValue);
        /// <summary> Determines if two <see cref="KeyType"/> values are the same. </summary>
        public static bool operator ==(KeyType left, KeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyType"/> values are not the same. </summary>
        public static bool operator !=(KeyType left, KeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyType"/>. </summary>
        public static implicit operator KeyType(string value) => new KeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
