// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Operational status of the resource. </summary>
    public readonly partial struct ResourceOperationalStatus : IEquatable<ResourceOperationalStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceOperationalStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceOperationalStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string UnknownValue = "Unknown";
        private const string HealthyValue = "Healthy";
        private const string UnhealthyValue = "Unhealthy";
        private const string UpdatingValue = "Updating";
        private const string RunningValue = "Running";
        private const string StoppedValue = "Stopped";
        private const string StoppedDeallocatedValue = "Stopped (deallocated)";

        /// <summary> Invalid. </summary>
        public static ResourceOperationalStatus Invalid { get; } = new ResourceOperationalStatus(InvalidValue);
        /// <summary> Unknown. </summary>
        public static ResourceOperationalStatus Unknown { get; } = new ResourceOperationalStatus(UnknownValue);
        /// <summary> Healthy. </summary>
        public static ResourceOperationalStatus Healthy { get; } = new ResourceOperationalStatus(HealthyValue);
        /// <summary> Unhealthy. </summary>
        public static ResourceOperationalStatus Unhealthy { get; } = new ResourceOperationalStatus(UnhealthyValue);
        /// <summary> Updating. </summary>
        public static ResourceOperationalStatus Updating { get; } = new ResourceOperationalStatus(UpdatingValue);
        /// <summary> Running. </summary>
        public static ResourceOperationalStatus Running { get; } = new ResourceOperationalStatus(RunningValue);
        /// <summary> Stopped. </summary>
        public static ResourceOperationalStatus Stopped { get; } = new ResourceOperationalStatus(StoppedValue);
        /// <summary> Stopped (deallocated). </summary>
        public static ResourceOperationalStatus StoppedDeallocated { get; } = new ResourceOperationalStatus(StoppedDeallocatedValue);
        /// <summary> Determines if two <see cref="ResourceOperationalStatus"/> values are the same. </summary>
        public static bool operator ==(ResourceOperationalStatus left, ResourceOperationalStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceOperationalStatus"/> values are not the same. </summary>
        public static bool operator !=(ResourceOperationalStatus left, ResourceOperationalStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceOperationalStatus"/>. </summary>
        public static implicit operator ResourceOperationalStatus(string value) => new ResourceOperationalStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceOperationalStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceOperationalStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
