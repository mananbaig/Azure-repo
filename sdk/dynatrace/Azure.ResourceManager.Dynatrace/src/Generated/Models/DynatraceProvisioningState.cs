// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Provisioning state of the monitoring resource. </summary>
    public readonly partial struct DynatraceProvisioningState : IEquatable<DynatraceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynatraceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynatraceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletedValue = "Deleted";
        private const string NotSpecifiedValue = "NotSpecified";

        /// <summary> Accepted. </summary>
        public static DynatraceProvisioningState Accepted { get; } = new DynatraceProvisioningState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static DynatraceProvisioningState Creating { get; } = new DynatraceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static DynatraceProvisioningState Updating { get; } = new DynatraceProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static DynatraceProvisioningState Deleting { get; } = new DynatraceProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static DynatraceProvisioningState Succeeded { get; } = new DynatraceProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DynatraceProvisioningState Failed { get; } = new DynatraceProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DynatraceProvisioningState Canceled { get; } = new DynatraceProvisioningState(CanceledValue);
        /// <summary> Deleted. </summary>
        public static DynatraceProvisioningState Deleted { get; } = new DynatraceProvisioningState(DeletedValue);
        /// <summary> NotSpecified. </summary>
        public static DynatraceProvisioningState NotSpecified { get; } = new DynatraceProvisioningState(NotSpecifiedValue);
        /// <summary> Determines if two <see cref="DynatraceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DynatraceProvisioningState left, DynatraceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynatraceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DynatraceProvisioningState left, DynatraceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DynatraceProvisioningState"/>. </summary>
        public static implicit operator DynatraceProvisioningState(string value) => new DynatraceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynatraceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynatraceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
