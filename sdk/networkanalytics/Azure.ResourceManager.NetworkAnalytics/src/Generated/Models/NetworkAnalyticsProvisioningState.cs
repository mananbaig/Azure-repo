// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The status of the current operation. </summary>
    public readonly partial struct NetworkAnalyticsProvisioningState : IEquatable<NetworkAnalyticsProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkAnalyticsProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkAnalyticsProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string AcceptedValue = "Accepted";

        /// <summary> Represents a succeeded operation. </summary>
        public static NetworkAnalyticsProvisioningState Succeeded { get; } = new NetworkAnalyticsProvisioningState(SucceededValue);
        /// <summary> Represents a failed operation. </summary>
        public static NetworkAnalyticsProvisioningState Failed { get; } = new NetworkAnalyticsProvisioningState(FailedValue);
        /// <summary> Represents a canceled operation. </summary>
        public static NetworkAnalyticsProvisioningState Canceled { get; } = new NetworkAnalyticsProvisioningState(CanceledValue);
        /// <summary> Represents a pending operation. </summary>
        public static NetworkAnalyticsProvisioningState Provisioning { get; } = new NetworkAnalyticsProvisioningState(ProvisioningValue);
        /// <summary> Represents a pending operation. </summary>
        public static NetworkAnalyticsProvisioningState Updating { get; } = new NetworkAnalyticsProvisioningState(UpdatingValue);
        /// <summary> Represents an operation under deletion. </summary>
        public static NetworkAnalyticsProvisioningState Deleting { get; } = new NetworkAnalyticsProvisioningState(DeletingValue);
        /// <summary> Represents an accepted operation. </summary>
        public static NetworkAnalyticsProvisioningState Accepted { get; } = new NetworkAnalyticsProvisioningState(AcceptedValue);
        /// <summary> Determines if two <see cref="NetworkAnalyticsProvisioningState"/> values are the same. </summary>
        public static bool operator ==(NetworkAnalyticsProvisioningState left, NetworkAnalyticsProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkAnalyticsProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(NetworkAnalyticsProvisioningState left, NetworkAnalyticsProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkAnalyticsProvisioningState"/>. </summary>
        public static implicit operator NetworkAnalyticsProvisioningState(string value) => new NetworkAnalyticsProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkAnalyticsProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkAnalyticsProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
