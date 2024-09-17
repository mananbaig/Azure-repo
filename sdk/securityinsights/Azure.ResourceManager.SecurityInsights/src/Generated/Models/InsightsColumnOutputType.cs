// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Insights Column type. </summary>
    public readonly partial struct InsightsColumnOutputType : IEquatable<InsightsColumnOutputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InsightsColumnOutputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InsightsColumnOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NumberValue = "Number";
        private const string StringValue = "String";
        private const string DateValue = "Date";
        private const string EntityValue = "Entity";

        /// <summary> Number. </summary>
        public static InsightsColumnOutputType Number { get; } = new InsightsColumnOutputType(NumberValue);
        /// <summary> String. </summary>
        public static InsightsColumnOutputType String { get; } = new InsightsColumnOutputType(StringValue);
        /// <summary> Date. </summary>
        public static InsightsColumnOutputType Date { get; } = new InsightsColumnOutputType(DateValue);
        /// <summary> Entity. </summary>
        public static InsightsColumnOutputType Entity { get; } = new InsightsColumnOutputType(EntityValue);
        /// <summary> Determines if two <see cref="InsightsColumnOutputType"/> values are the same. </summary>
        public static bool operator ==(InsightsColumnOutputType left, InsightsColumnOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InsightsColumnOutputType"/> values are not the same. </summary>
        public static bool operator !=(InsightsColumnOutputType left, InsightsColumnOutputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InsightsColumnOutputType"/>. </summary>
        public static implicit operator InsightsColumnOutputType(string value) => new InsightsColumnOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InsightsColumnOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InsightsColumnOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
