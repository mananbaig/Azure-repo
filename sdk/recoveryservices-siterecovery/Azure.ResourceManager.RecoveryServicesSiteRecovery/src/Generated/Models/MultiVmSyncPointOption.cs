// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </summary>
    public readonly partial struct MultiVmSyncPointOption : IEquatable<MultiVmSyncPointOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MultiVmSyncPointOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MultiVmSyncPointOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UseMultiVmSyncRecoveryPointValue = "UseMultiVmSyncRecoveryPoint";
        private const string UsePerVmRecoveryPointValue = "UsePerVmRecoveryPoint";

        /// <summary> UseMultiVmSyncRecoveryPoint. </summary>
        public static MultiVmSyncPointOption UseMultiVmSyncRecoveryPoint { get; } = new MultiVmSyncPointOption(UseMultiVmSyncRecoveryPointValue);
        /// <summary> UsePerVmRecoveryPoint. </summary>
        public static MultiVmSyncPointOption UsePerVmRecoveryPoint { get; } = new MultiVmSyncPointOption(UsePerVmRecoveryPointValue);
        /// <summary> Determines if two <see cref="MultiVmSyncPointOption"/> values are the same. </summary>
        public static bool operator ==(MultiVmSyncPointOption left, MultiVmSyncPointOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MultiVmSyncPointOption"/> values are not the same. </summary>
        public static bool operator !=(MultiVmSyncPointOption left, MultiVmSyncPointOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MultiVmSyncPointOption"/>. </summary>
        public static implicit operator MultiVmSyncPointOption(string value) => new MultiVmSyncPointOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MultiVmSyncPointOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MultiVmSyncPointOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
