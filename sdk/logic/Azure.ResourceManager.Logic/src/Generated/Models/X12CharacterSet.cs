// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 character set. </summary>
    public readonly partial struct X12CharacterSet : IEquatable<X12CharacterSet>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="X12CharacterSet"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public X12CharacterSet(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string BasicValue = "Basic";
        private const string ExtendedValue = "Extended";
        private const string Utf8Value = "UTF8";

        /// <summary> NotSpecified. </summary>
        public static X12CharacterSet NotSpecified { get; } = new X12CharacterSet(NotSpecifiedValue);
        /// <summary> Basic. </summary>
        public static X12CharacterSet Basic { get; } = new X12CharacterSet(BasicValue);
        /// <summary> Extended. </summary>
        public static X12CharacterSet Extended { get; } = new X12CharacterSet(ExtendedValue);
        /// <summary> UTF8. </summary>
        public static X12CharacterSet Utf8 { get; } = new X12CharacterSet(Utf8Value);
        /// <summary> Determines if two <see cref="X12CharacterSet"/> values are the same. </summary>
        public static bool operator ==(X12CharacterSet left, X12CharacterSet right) => left.Equals(right);
        /// <summary> Determines if two <see cref="X12CharacterSet"/> values are not the same. </summary>
        public static bool operator !=(X12CharacterSet left, X12CharacterSet right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="X12CharacterSet"/>. </summary>
        public static implicit operator X12CharacterSet(string value) => new X12CharacterSet(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is X12CharacterSet other && Equals(other);
        /// <inheritdoc />
        public bool Equals(X12CharacterSet other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
