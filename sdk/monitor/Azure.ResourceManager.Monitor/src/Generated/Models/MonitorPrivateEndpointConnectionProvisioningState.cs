// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct MonitorPrivateEndpointConnectionProvisioningState : IEquatable<MonitorPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static MonitorPrivateEndpointConnectionProvisioningState Succeeded { get; } = new MonitorPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static MonitorPrivateEndpointConnectionProvisioningState Creating { get; } = new MonitorPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static MonitorPrivateEndpointConnectionProvisioningState Deleting { get; } = new MonitorPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static MonitorPrivateEndpointConnectionProvisioningState Failed { get; } = new MonitorPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="MonitorPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MonitorPrivateEndpointConnectionProvisioningState left, MonitorPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MonitorPrivateEndpointConnectionProvisioningState left, MonitorPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator MonitorPrivateEndpointConnectionProvisioningState(string value) => new MonitorPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
