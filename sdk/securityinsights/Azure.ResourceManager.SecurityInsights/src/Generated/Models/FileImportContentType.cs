// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The content type of this file.
    /// Serialized Name: FileImportContentType
    /// </summary>
    public readonly partial struct FileImportContentType : IEquatable<FileImportContentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileImportContentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileImportContentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicIndicatorValue = "BasicIndicator";
        private const string StixIndicatorValue = "StixIndicator";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary>
        /// File containing records with the core fields of an indicator, plus the observables to construct the STIX pattern.
        /// Serialized Name: FileImportContentType.BasicIndicator
        /// </summary>
        public static FileImportContentType BasicIndicator { get; } = new FileImportContentType(BasicIndicatorValue);
        /// <summary>
        /// File containing STIX indicators.
        /// Serialized Name: FileImportContentType.StixIndicator
        /// </summary>
        public static FileImportContentType StixIndicator { get; } = new FileImportContentType(StixIndicatorValue);
        /// <summary>
        /// File containing other records.
        /// Serialized Name: FileImportContentType.Unspecified
        /// </summary>
        public static FileImportContentType Unspecified { get; } = new FileImportContentType(UnspecifiedValue);
        /// <summary> Determines if two <see cref="FileImportContentType"/> values are the same. </summary>
        public static bool operator ==(FileImportContentType left, FileImportContentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileImportContentType"/> values are not the same. </summary>
        public static bool operator !=(FileImportContentType left, FileImportContentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileImportContentType"/>. </summary>
        public static implicit operator FileImportContentType(string value) => new FileImportContentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileImportContentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileImportContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
