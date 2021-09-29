// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The status of a job. </summary>
    public readonly partial struct JobStatus : IEquatable<JobStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string StartingValue = "Starting";
        private const string ProvisioningValue = "Provisioning";
        private const string PreparingValue = "Preparing";
        private const string QueuedValue = "Queued";
        private const string RunningValue = "Running";
        private const string FinalizingValue = "Finalizing";
        private const string CancelRequestedValue = "CancelRequested";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string NotRespondingValue = "NotResponding";
        private const string PausedValue = "Paused";
        private const string UnknownValue = "Unknown";

        /// <summary> NotStarted. </summary>
        public static JobStatus NotStarted { get; } = new JobStatus(NotStartedValue);
        /// <summary> Starting. </summary>
        public static JobStatus Starting { get; } = new JobStatus(StartingValue);
        /// <summary> Provisioning. </summary>
        public static JobStatus Provisioning { get; } = new JobStatus(ProvisioningValue);
        /// <summary> Preparing. </summary>
        public static JobStatus Preparing { get; } = new JobStatus(PreparingValue);
        /// <summary> Queued. </summary>
        public static JobStatus Queued { get; } = new JobStatus(QueuedValue);
        /// <summary> Running. </summary>
        public static JobStatus Running { get; } = new JobStatus(RunningValue);
        /// <summary> Finalizing. </summary>
        public static JobStatus Finalizing { get; } = new JobStatus(FinalizingValue);
        /// <summary> CancelRequested. </summary>
        public static JobStatus CancelRequested { get; } = new JobStatus(CancelRequestedValue);
        /// <summary> Completed. </summary>
        public static JobStatus Completed { get; } = new JobStatus(CompletedValue);
        /// <summary> Failed. </summary>
        public static JobStatus Failed { get; } = new JobStatus(FailedValue);
        /// <summary> Canceled. </summary>
        public static JobStatus Canceled { get; } = new JobStatus(CanceledValue);
        /// <summary> NotResponding. </summary>
        public static JobStatus NotResponding { get; } = new JobStatus(NotRespondingValue);
        /// <summary> Paused. </summary>
        public static JobStatus Paused { get; } = new JobStatus(PausedValue);
        /// <summary> Unknown. </summary>
        public static JobStatus Unknown { get; } = new JobStatus(UnknownValue);
        /// <summary> Determines if two <see cref="JobStatus"/> values are the same. </summary>
        public static bool operator ==(JobStatus left, JobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobStatus"/> values are not the same. </summary>
        public static bool operator !=(JobStatus left, JobStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobStatus"/>. </summary>
        public static implicit operator JobStatus(string value) => new JobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
