// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Unit for the dimensions of weight. </summary>
    public readonly partial struct ProductWeightMeasurementUnit : IEquatable<ProductWeightMeasurementUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProductWeightMeasurementUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProductWeightMeasurementUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LbsValue = "LBS";
        private const string KgsValue = "KGS";

        /// <summary> Pounds. </summary>
        public static ProductWeightMeasurementUnit Lbs { get; } = new ProductWeightMeasurementUnit(LbsValue);
        /// <summary> Kilograms. </summary>
        public static ProductWeightMeasurementUnit Kgs { get; } = new ProductWeightMeasurementUnit(KgsValue);
        /// <summary> Determines if two <see cref="ProductWeightMeasurementUnit"/> values are the same. </summary>
        public static bool operator ==(ProductWeightMeasurementUnit left, ProductWeightMeasurementUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProductWeightMeasurementUnit"/> values are not the same. </summary>
        public static bool operator !=(ProductWeightMeasurementUnit left, ProductWeightMeasurementUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProductWeightMeasurementUnit"/>. </summary>
        public static implicit operator ProductWeightMeasurementUnit(string value) => new ProductWeightMeasurementUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProductWeightMeasurementUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProductWeightMeasurementUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
