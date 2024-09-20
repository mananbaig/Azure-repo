// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Storage type of import source. </summary>
    public readonly partial struct ImportSourceStorageType : IEquatable<ImportSourceStorageType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImportSourceStorageType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImportSourceStorageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureBlobValue = "AzureBlob";

        /// <summary> AzureBlob. </summary>
        public static ImportSourceStorageType AzureBlob { get; } = new ImportSourceStorageType(AzureBlobValue);
        /// <summary> Determines if two <see cref="ImportSourceStorageType"/> values are the same. </summary>
        public static bool operator ==(ImportSourceStorageType left, ImportSourceStorageType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImportSourceStorageType"/> values are not the same. </summary>
        public static bool operator !=(ImportSourceStorageType left, ImportSourceStorageType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImportSourceStorageType"/>. </summary>
        public static implicit operator ImportSourceStorageType(string value) => new ImportSourceStorageType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImportSourceStorageType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImportSourceStorageType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
