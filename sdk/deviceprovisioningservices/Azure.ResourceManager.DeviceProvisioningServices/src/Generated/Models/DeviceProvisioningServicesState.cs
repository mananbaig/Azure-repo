// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Current state of the provisioning service. </summary>
    public readonly partial struct DeviceProvisioningServicesState : IEquatable<DeviceProvisioningServicesState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceProvisioningServicesState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActivatingValue = "Activating";
        private const string ActiveValue = "Active";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string ActivationFailedValue = "ActivationFailed";
        private const string DeletionFailedValue = "DeletionFailed";
        private const string TransitioningValue = "Transitioning";
        private const string SuspendingValue = "Suspending";
        private const string SuspendedValue = "Suspended";
        private const string ResumingValue = "Resuming";
        private const string FailingOverValue = "FailingOver";
        private const string FailoverFailedValue = "FailoverFailed";

        /// <summary> Activating. </summary>
        public static DeviceProvisioningServicesState Activating { get; } = new DeviceProvisioningServicesState(ActivatingValue);
        /// <summary> Active. </summary>
        public static DeviceProvisioningServicesState Active { get; } = new DeviceProvisioningServicesState(ActiveValue);
        /// <summary> Deleting. </summary>
        public static DeviceProvisioningServicesState Deleting { get; } = new DeviceProvisioningServicesState(DeletingValue);
        /// <summary> Deleted. </summary>
        public static DeviceProvisioningServicesState Deleted { get; } = new DeviceProvisioningServicesState(DeletedValue);
        /// <summary> ActivationFailed. </summary>
        public static DeviceProvisioningServicesState ActivationFailed { get; } = new DeviceProvisioningServicesState(ActivationFailedValue);
        /// <summary> DeletionFailed. </summary>
        public static DeviceProvisioningServicesState DeletionFailed { get; } = new DeviceProvisioningServicesState(DeletionFailedValue);
        /// <summary> Transitioning. </summary>
        public static DeviceProvisioningServicesState Transitioning { get; } = new DeviceProvisioningServicesState(TransitioningValue);
        /// <summary> Suspending. </summary>
        public static DeviceProvisioningServicesState Suspending { get; } = new DeviceProvisioningServicesState(SuspendingValue);
        /// <summary> Suspended. </summary>
        public static DeviceProvisioningServicesState Suspended { get; } = new DeviceProvisioningServicesState(SuspendedValue);
        /// <summary> Resuming. </summary>
        public static DeviceProvisioningServicesState Resuming { get; } = new DeviceProvisioningServicesState(ResumingValue);
        /// <summary> FailingOver. </summary>
        public static DeviceProvisioningServicesState FailingOver { get; } = new DeviceProvisioningServicesState(FailingOverValue);
        /// <summary> FailoverFailed. </summary>
        public static DeviceProvisioningServicesState FailoverFailed { get; } = new DeviceProvisioningServicesState(FailoverFailedValue);
        /// <summary> Determines if two <see cref="DeviceProvisioningServicesState"/> values are the same. </summary>
        public static bool operator ==(DeviceProvisioningServicesState left, DeviceProvisioningServicesState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceProvisioningServicesState"/> values are not the same. </summary>
        public static bool operator !=(DeviceProvisioningServicesState left, DeviceProvisioningServicesState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeviceProvisioningServicesState"/>. </summary>
        public static implicit operator DeviceProvisioningServicesState(string value) => new DeviceProvisioningServicesState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceProvisioningServicesState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceProvisioningServicesState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
