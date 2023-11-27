// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The approval/rejection status of managed private endpoint connection. </summary>
    public readonly partial struct ManagedPrivateEndpointConnectionStatus : IEquatable<ManagedPrivateEndpointConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedPrivateEndpointConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static ManagedPrivateEndpointConnectionStatus Pending { get; } = new ManagedPrivateEndpointConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ManagedPrivateEndpointConnectionStatus Approved { get; } = new ManagedPrivateEndpointConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static ManagedPrivateEndpointConnectionStatus Rejected { get; } = new ManagedPrivateEndpointConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static ManagedPrivateEndpointConnectionStatus Disconnected { get; } = new ManagedPrivateEndpointConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="ManagedPrivateEndpointConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ManagedPrivateEndpointConnectionStatus left, ManagedPrivateEndpointConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedPrivateEndpointConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ManagedPrivateEndpointConnectionStatus left, ManagedPrivateEndpointConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedPrivateEndpointConnectionStatus"/>. </summary>
        public static implicit operator ManagedPrivateEndpointConnectionStatus(string value) => new ManagedPrivateEndpointConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedPrivateEndpointConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedPrivateEndpointConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
