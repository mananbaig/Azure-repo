// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Routing.Models
{
    /// <summary> The AlternativeRouteType. </summary>
    public readonly partial struct AlternativeRouteType : IEquatable<AlternativeRouteType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlternativeRouteType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlternativeRouteType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnyRouteValue = "anyRoute";
        private const string BetterRouteValue = "betterRoute";

        /// <summary> Allow any alternative route to be returned irrespective of how it compares to the reference route in terms of optimality. </summary>
        public static AlternativeRouteType AnyRoute { get; } = new AlternativeRouteType(AnyRouteValue);
        /// <summary> Return an alternative route only if it is better than the reference route according to the given planning criteria. </summary>
        public static AlternativeRouteType BetterRoute { get; } = new AlternativeRouteType(BetterRouteValue);
        /// <summary> Determines if two <see cref="AlternativeRouteType"/> values are the same. </summary>
        public static bool operator ==(AlternativeRouteType left, AlternativeRouteType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlternativeRouteType"/> values are not the same. </summary>
        public static bool operator !=(AlternativeRouteType left, AlternativeRouteType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlternativeRouteType"/>. </summary>
        public static implicit operator AlternativeRouteType(string value) => new AlternativeRouteType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlternativeRouteType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlternativeRouteType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
