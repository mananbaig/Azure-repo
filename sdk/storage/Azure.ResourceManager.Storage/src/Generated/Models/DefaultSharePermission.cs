// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Default share permission for users using Kerberos authentication if RBAC role is not assigned. </summary>
    public readonly partial struct DefaultSharePermission : IEquatable<DefaultSharePermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DefaultSharePermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DefaultSharePermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string StorageFileDataSmbShareReaderValue = "StorageFileDataSmbShareReader";
        private const string StorageFileDataSmbShareContributorValue = "StorageFileDataSmbShareContributor";
        private const string StorageFileDataSmbShareElevatedContributorValue = "StorageFileDataSmbShareElevatedContributor";
        private const string StorageFileDataSmbShareOwnerValue = "StorageFileDataSmbShareOwner";

        /// <summary> None. </summary>
        public static DefaultSharePermission None { get; } = new DefaultSharePermission(NoneValue);
        /// <summary> StorageFileDataSmbShareReader. </summary>
        public static DefaultSharePermission StorageFileDataSmbShareReader { get; } = new DefaultSharePermission(StorageFileDataSmbShareReaderValue);
        /// <summary> StorageFileDataSmbShareContributor. </summary>
        public static DefaultSharePermission StorageFileDataSmbShareContributor { get; } = new DefaultSharePermission(StorageFileDataSmbShareContributorValue);
        /// <summary> StorageFileDataSmbShareElevatedContributor. </summary>
        public static DefaultSharePermission StorageFileDataSmbShareElevatedContributor { get; } = new DefaultSharePermission(StorageFileDataSmbShareElevatedContributorValue);
        /// <summary> StorageFileDataSmbShareOwner. </summary>
        public static DefaultSharePermission StorageFileDataSmbShareOwner { get; } = new DefaultSharePermission(StorageFileDataSmbShareOwnerValue);
        /// <summary> Determines if two <see cref="DefaultSharePermission"/> values are the same. </summary>
        public static bool operator ==(DefaultSharePermission left, DefaultSharePermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DefaultSharePermission"/> values are not the same. </summary>
        public static bool operator !=(DefaultSharePermission left, DefaultSharePermission right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DefaultSharePermission"/>. </summary>
        public static implicit operator DefaultSharePermission(string value) => new DefaultSharePermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DefaultSharePermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DefaultSharePermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
