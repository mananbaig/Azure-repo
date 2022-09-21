// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The RoleType. </summary>
    public readonly partial struct RoleType : IEquatable<RoleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IoTValue = "IOT";
        private const string AsaValue = "ASA";
        private const string FunctionsValue = "Functions";
        private const string CognitiveValue = "Cognitive";
        private const string MecValue = "MEC";
        private const string CloudEdgeManagementValue = "CloudEdgeManagement";
        private const string KubernetesValue = "Kubernetes";

        /// <summary> IOT. </summary>
        public static RoleType IoT { get; } = new RoleType(IoTValue);
        /// <summary> ASA. </summary>
        public static RoleType Asa { get; } = new RoleType(AsaValue);
        /// <summary> Functions. </summary>
        public static RoleType Functions { get; } = new RoleType(FunctionsValue);
        /// <summary> Cognitive. </summary>
        public static RoleType Cognitive { get; } = new RoleType(CognitiveValue);
        /// <summary> MEC. </summary>
        public static RoleType Mec { get; } = new RoleType(MecValue);
        /// <summary> CloudEdgeManagement. </summary>
        public static RoleType CloudEdgeManagement { get; } = new RoleType(CloudEdgeManagementValue);
        /// <summary> Kubernetes. </summary>
        public static RoleType Kubernetes { get; } = new RoleType(KubernetesValue);
        /// <summary> Determines if two <see cref="RoleType"/> values are the same. </summary>
        public static bool operator ==(RoleType left, RoleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleType"/> values are not the same. </summary>
        public static bool operator !=(RoleType left, RoleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleType"/>. </summary>
        public static implicit operator RoleType(string value) => new RoleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
