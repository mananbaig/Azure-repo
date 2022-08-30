// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> The reason why the given name is not available. </summary>
    public readonly partial struct LegerNameUnavailableReason : IEquatable<LegerNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LegerNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LegerNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static LegerNameUnavailableReason Invalid { get; } = new LegerNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static LegerNameUnavailableReason AlreadyExists { get; } = new LegerNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="LegerNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(LegerNameUnavailableReason left, LegerNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LegerNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(LegerNameUnavailableReason left, LegerNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LegerNameUnavailableReason"/>. </summary>
        public static implicit operator LegerNameUnavailableReason(string value) => new LegerNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LegerNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LegerNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
