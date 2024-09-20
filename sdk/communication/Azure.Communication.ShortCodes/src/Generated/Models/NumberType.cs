// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> The type of number e.g. 'ShortCode', 'AlphaId'. </summary>
    public readonly partial struct NumberType : IEquatable<NumberType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NumberType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NumberType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ShortCodeValue = "shortCode";
        private const string AlphaIdValue = "alphaId";

        /// <summary> shortCode. </summary>
        public static NumberType ShortCode { get; } = new NumberType(ShortCodeValue);
        /// <summary> alphaId. </summary>
        public static NumberType AlphaId { get; } = new NumberType(AlphaIdValue);
        /// <summary> Determines if two <see cref="NumberType"/> values are the same. </summary>
        public static bool operator ==(NumberType left, NumberType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NumberType"/> values are not the same. </summary>
        public static bool operator !=(NumberType left, NumberType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NumberType"/>. </summary>
        public static implicit operator NumberType(string value) => new NumberType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NumberType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NumberType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
