// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Network access of key vault. The possible values are `Public` and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault disables public access and enables private link. The default value is `Public`. </summary>
    public readonly partial struct ManagedClusterKeyVaultNetworkAccessType : IEquatable<ManagedClusterKeyVaultNetworkAccessType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterKeyVaultNetworkAccessType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedClusterKeyVaultNetworkAccessType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "Public";
        private const string PrivateValue = "Private";

        /// <summary> Public. </summary>
        public static ManagedClusterKeyVaultNetworkAccessType Public { get; } = new ManagedClusterKeyVaultNetworkAccessType(PublicValue);
        /// <summary> Private. </summary>
        public static ManagedClusterKeyVaultNetworkAccessType Private { get; } = new ManagedClusterKeyVaultNetworkAccessType(PrivateValue);
        /// <summary> Determines if two <see cref="ManagedClusterKeyVaultNetworkAccessType"/> values are the same. </summary>
        public static bool operator ==(ManagedClusterKeyVaultNetworkAccessType left, ManagedClusterKeyVaultNetworkAccessType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedClusterKeyVaultNetworkAccessType"/> values are not the same. </summary>
        public static bool operator !=(ManagedClusterKeyVaultNetworkAccessType left, ManagedClusterKeyVaultNetworkAccessType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedClusterKeyVaultNetworkAccessType"/>. </summary>
        public static implicit operator ManagedClusterKeyVaultNetworkAccessType(string value) => new ManagedClusterKeyVaultNetworkAccessType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedClusterKeyVaultNetworkAccessType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedClusterKeyVaultNetworkAccessType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
