// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ARM provisioning state of the job execution. </summary>
    public readonly partial struct JobExecutionProvisioningState : IEquatable<JobExecutionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobExecutionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobExecutionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatedValue = "Created";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Created. </summary>
        public static JobExecutionProvisioningState Created { get; } = new JobExecutionProvisioningState(CreatedValue);
        /// <summary> InProgress. </summary>
        public static JobExecutionProvisioningState InProgress { get; } = new JobExecutionProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static JobExecutionProvisioningState Succeeded { get; } = new JobExecutionProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static JobExecutionProvisioningState Failed { get; } = new JobExecutionProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static JobExecutionProvisioningState Canceled { get; } = new JobExecutionProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="JobExecutionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(JobExecutionProvisioningState left, JobExecutionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobExecutionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(JobExecutionProvisioningState left, JobExecutionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobExecutionProvisioningState"/>. </summary>
        public static implicit operator JobExecutionProvisioningState(string value) => new JobExecutionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobExecutionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobExecutionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
