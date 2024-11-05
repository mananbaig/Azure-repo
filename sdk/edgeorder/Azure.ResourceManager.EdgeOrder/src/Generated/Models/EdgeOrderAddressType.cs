// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Type of address. </summary>
    public readonly partial struct EdgeOrderAddressType : IEquatable<EdgeOrderAddressType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderAddressType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeOrderAddressType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ResidentialValue = "Residential";
        private const string CommercialValue = "Commercial";

        /// <summary> Address type not known. </summary>
        public static EdgeOrderAddressType None { get; } = new EdgeOrderAddressType(NoneValue);
        /// <summary> Residential Address. </summary>
        public static EdgeOrderAddressType Residential { get; } = new EdgeOrderAddressType(ResidentialValue);
        /// <summary> Commercial Address. </summary>
        public static EdgeOrderAddressType Commercial { get; } = new EdgeOrderAddressType(CommercialValue);
        /// <summary> Determines if two <see cref="EdgeOrderAddressType"/> values are the same. </summary>
        public static bool operator ==(EdgeOrderAddressType left, EdgeOrderAddressType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeOrderAddressType"/> values are not the same. </summary>
        public static bool operator !=(EdgeOrderAddressType left, EdgeOrderAddressType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EdgeOrderAddressType"/>. </summary>
        public static implicit operator EdgeOrderAddressType(string value) => new EdgeOrderAddressType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeOrderAddressType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeOrderAddressType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
