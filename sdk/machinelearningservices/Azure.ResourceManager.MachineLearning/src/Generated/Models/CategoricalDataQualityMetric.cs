// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CategoricalDataQualityMetric. </summary>
    public readonly partial struct CategoricalDataQualityMetric : IEquatable<CategoricalDataQualityMetric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CategoricalDataQualityMetric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CategoricalDataQualityMetric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NullValueRateValue = "NullValueRate";
        private const string DataTypeErrorRateValue = "DataTypeErrorRate";
        private const string OutOfBoundsRateValue = "OutOfBoundsRate";

        /// <summary> Calculates the rate of null values. </summary>
        public static CategoricalDataQualityMetric NullValueRate { get; } = new CategoricalDataQualityMetric(NullValueRateValue);
        /// <summary> Calculates the rate of data type errors. </summary>
        public static CategoricalDataQualityMetric DataTypeErrorRate { get; } = new CategoricalDataQualityMetric(DataTypeErrorRateValue);
        /// <summary> Calculates the rate values are out of bounds. </summary>
        public static CategoricalDataQualityMetric OutOfBoundsRate { get; } = new CategoricalDataQualityMetric(OutOfBoundsRateValue);
        /// <summary> Determines if two <see cref="CategoricalDataQualityMetric"/> values are the same. </summary>
        public static bool operator ==(CategoricalDataQualityMetric left, CategoricalDataQualityMetric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CategoricalDataQualityMetric"/> values are not the same. </summary>
        public static bool operator !=(CategoricalDataQualityMetric left, CategoricalDataQualityMetric right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CategoricalDataQualityMetric"/>. </summary>
        public static implicit operator CategoricalDataQualityMetric(string value) => new CategoricalDataQualityMetric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CategoricalDataQualityMetric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CategoricalDataQualityMetric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
