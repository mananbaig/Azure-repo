// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentTranslation
{
    /// <summary> Storage type of the input documents source string. </summary>
    public readonly partial struct StorageInputType : IEquatable<StorageInputType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="StorageInputType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageInputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FolderValue = "Folder";
        private const string FileValue = "File";

        /// <summary> Folder. </summary>
        public static StorageInputType Folder { get; } = new StorageInputType(FolderValue);
        /// <summary> File. </summary>
        public static StorageInputType File { get; } = new StorageInputType(FileValue);
        /// <summary> Determines if two <see cref="StorageInputType"/> values are the same. </summary>
        public static bool operator ==(StorageInputType left, StorageInputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageInputType"/> values are not the same. </summary>
        public static bool operator !=(StorageInputType left, StorageInputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageInputType"/>. </summary>
        public static implicit operator StorageInputType(string value) => new StorageInputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageInputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageInputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
