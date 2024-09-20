// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The TransparentDataEncryptionName. </summary>
    public readonly partial struct TransparentDataEncryptionName : IEquatable<TransparentDataEncryptionName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TransparentDataEncryptionName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TransparentDataEncryptionName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static TransparentDataEncryptionName Current { get; } = new TransparentDataEncryptionName(CurrentValue);
        /// <summary> Determines if two <see cref="TransparentDataEncryptionName"/> values are the same. </summary>
        public static bool operator ==(TransparentDataEncryptionName left, TransparentDataEncryptionName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TransparentDataEncryptionName"/> values are not the same. </summary>
        public static bool operator !=(TransparentDataEncryptionName left, TransparentDataEncryptionName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TransparentDataEncryptionName"/>. </summary>
        public static implicit operator TransparentDataEncryptionName(string value) => new TransparentDataEncryptionName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TransparentDataEncryptionName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TransparentDataEncryptionName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
