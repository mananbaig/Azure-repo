// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The provisioning state, which only appears in the response. </summary>
    public readonly partial struct HDInsightPrivateEndpointConnectionProvisioningState : IEquatable<HDInsightPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string UpdatingValue = "Updating";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";

        /// <summary> InProgress. </summary>
        public static HDInsightPrivateEndpointConnectionProvisioningState InProgress { get; } = new HDInsightPrivateEndpointConnectionProvisioningState(InProgressValue);
        /// <summary> Updating. </summary>
        public static HDInsightPrivateEndpointConnectionProvisioningState Updating { get; } = new HDInsightPrivateEndpointConnectionProvisioningState(UpdatingValue);
        /// <summary> Failed. </summary>
        public static HDInsightPrivateEndpointConnectionProvisioningState Failed { get; } = new HDInsightPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static HDInsightPrivateEndpointConnectionProvisioningState Succeeded { get; } = new HDInsightPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static HDInsightPrivateEndpointConnectionProvisioningState Canceled { get; } = new HDInsightPrivateEndpointConnectionProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static HDInsightPrivateEndpointConnectionProvisioningState Deleting { get; } = new HDInsightPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="HDInsightPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(HDInsightPrivateEndpointConnectionProvisioningState left, HDInsightPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(HDInsightPrivateEndpointConnectionProvisioningState left, HDInsightPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator HDInsightPrivateEndpointConnectionProvisioningState(string value) => new HDInsightPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
