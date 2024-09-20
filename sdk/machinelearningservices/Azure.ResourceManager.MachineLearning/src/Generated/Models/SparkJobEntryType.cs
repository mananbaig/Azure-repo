// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The SparkJobEntryType. </summary>
    internal readonly partial struct SparkJobEntryType : IEquatable<SparkJobEntryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkJobEntryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkJobEntryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SparkJobPythonEntryValue = "SparkJobPythonEntry";
        private const string SparkJobScalaEntryValue = "SparkJobScalaEntry";

        /// <summary> SparkJobPythonEntry. </summary>
        public static SparkJobEntryType SparkJobPythonEntry { get; } = new SparkJobEntryType(SparkJobPythonEntryValue);
        /// <summary> SparkJobScalaEntry. </summary>
        public static SparkJobEntryType SparkJobScalaEntry { get; } = new SparkJobEntryType(SparkJobScalaEntryValue);
        /// <summary> Determines if two <see cref="SparkJobEntryType"/> values are the same. </summary>
        public static bool operator ==(SparkJobEntryType left, SparkJobEntryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkJobEntryType"/> values are not the same. </summary>
        public static bool operator !=(SparkJobEntryType left, SparkJobEntryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkJobEntryType"/>. </summary>
        public static implicit operator SparkJobEntryType(string value) => new SparkJobEntryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkJobEntryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkJobEntryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
