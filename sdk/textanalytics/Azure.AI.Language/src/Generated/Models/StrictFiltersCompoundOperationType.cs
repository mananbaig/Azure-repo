// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Models
{
    /// <summary> Optional field. Set to &apos;OR&apos; for using OR operation for strict filters. </summary>
    public readonly partial struct StrictFiltersCompoundOperationType : IEquatable<StrictFiltersCompoundOperationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="StrictFiltersCompoundOperationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StrictFiltersCompoundOperationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ANDValue = "AND";
        private const string ORValue = "OR";

        /// <summary> AND. </summary>
        public static StrictFiltersCompoundOperationType AND { get; } = new StrictFiltersCompoundOperationType(ANDValue);
        /// <summary> OR. </summary>
        public static StrictFiltersCompoundOperationType OR { get; } = new StrictFiltersCompoundOperationType(ORValue);
        /// <summary> Determines if two <see cref="StrictFiltersCompoundOperationType"/> values are the same. </summary>
        public static bool operator ==(StrictFiltersCompoundOperationType left, StrictFiltersCompoundOperationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StrictFiltersCompoundOperationType"/> values are not the same. </summary>
        public static bool operator !=(StrictFiltersCompoundOperationType left, StrictFiltersCompoundOperationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StrictFiltersCompoundOperationType"/>. </summary>
        public static implicit operator StrictFiltersCompoundOperationType(string value) => new StrictFiltersCompoundOperationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StrictFiltersCompoundOperationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StrictFiltersCompoundOperationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
