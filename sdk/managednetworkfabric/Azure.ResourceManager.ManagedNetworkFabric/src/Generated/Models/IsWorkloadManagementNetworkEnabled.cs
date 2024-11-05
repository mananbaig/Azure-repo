// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> A workload management network is required for all the tenant (workload) traffic. This traffic is only dedicated for Tenant workloads which are required to access internet or any other MSFT/Public endpoints. </summary>
    public readonly partial struct IsWorkloadManagementNetworkEnabled : IEquatable<IsWorkloadManagementNetworkEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsWorkloadManagementNetworkEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsWorkloadManagementNetworkEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static IsWorkloadManagementNetworkEnabled True { get; } = new IsWorkloadManagementNetworkEnabled(TrueValue);
        /// <summary> False. </summary>
        public static IsWorkloadManagementNetworkEnabled False { get; } = new IsWorkloadManagementNetworkEnabled(FalseValue);
        /// <summary> Determines if two <see cref="IsWorkloadManagementNetworkEnabled"/> values are the same. </summary>
        public static bool operator ==(IsWorkloadManagementNetworkEnabled left, IsWorkloadManagementNetworkEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsWorkloadManagementNetworkEnabled"/> values are not the same. </summary>
        public static bool operator !=(IsWorkloadManagementNetworkEnabled left, IsWorkloadManagementNetworkEnabled right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IsWorkloadManagementNetworkEnabled"/>. </summary>
        public static implicit operator IsWorkloadManagementNetworkEnabled(string value) => new IsWorkloadManagementNetworkEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsWorkloadManagementNetworkEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsWorkloadManagementNetworkEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
