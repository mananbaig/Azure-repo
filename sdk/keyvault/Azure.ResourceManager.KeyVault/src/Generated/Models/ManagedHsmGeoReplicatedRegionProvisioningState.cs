// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct ManagedHsmGeoReplicatedRegionProvisioningState : IEquatable<ManagedHsmGeoReplicatedRegionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmGeoReplicatedRegionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedHsmGeoReplicatedRegionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreprovisioningValue = "Preprovisioning";
        private const string ProvisioningValue = "Provisioning";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";
        private const string CleanupValue = "Cleanup";

        /// <summary> Preprovisioning. </summary>
        public static ManagedHsmGeoReplicatedRegionProvisioningState Preprovisioning { get; } = new ManagedHsmGeoReplicatedRegionProvisioningState(PreprovisioningValue);
        /// <summary> Provisioning. </summary>
        public static ManagedHsmGeoReplicatedRegionProvisioningState Provisioning { get; } = new ManagedHsmGeoReplicatedRegionProvisioningState(ProvisioningValue);
        /// <summary> Succeeded. </summary>
        public static ManagedHsmGeoReplicatedRegionProvisioningState Succeeded { get; } = new ManagedHsmGeoReplicatedRegionProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ManagedHsmGeoReplicatedRegionProvisioningState Failed { get; } = new ManagedHsmGeoReplicatedRegionProvisioningState(FailedValue);
        /// <summary> Deleting. </summary>
        public static ManagedHsmGeoReplicatedRegionProvisioningState Deleting { get; } = new ManagedHsmGeoReplicatedRegionProvisioningState(DeletingValue);
        /// <summary> Cleanup. </summary>
        public static ManagedHsmGeoReplicatedRegionProvisioningState Cleanup { get; } = new ManagedHsmGeoReplicatedRegionProvisioningState(CleanupValue);
        /// <summary> Determines if two <see cref="ManagedHsmGeoReplicatedRegionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ManagedHsmGeoReplicatedRegionProvisioningState left, ManagedHsmGeoReplicatedRegionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedHsmGeoReplicatedRegionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ManagedHsmGeoReplicatedRegionProvisioningState left, ManagedHsmGeoReplicatedRegionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedHsmGeoReplicatedRegionProvisioningState"/>. </summary>
        public static implicit operator ManagedHsmGeoReplicatedRegionProvisioningState(string value) => new ManagedHsmGeoReplicatedRegionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedHsmGeoReplicatedRegionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedHsmGeoReplicatedRegionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
