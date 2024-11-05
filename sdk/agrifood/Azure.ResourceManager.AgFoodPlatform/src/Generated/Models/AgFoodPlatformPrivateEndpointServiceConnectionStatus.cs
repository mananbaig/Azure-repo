// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct AgFoodPlatformPrivateEndpointServiceConnectionStatus : IEquatable<AgFoodPlatformPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgFoodPlatformPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgFoodPlatformPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static AgFoodPlatformPrivateEndpointServiceConnectionStatus Pending { get; } = new AgFoodPlatformPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static AgFoodPlatformPrivateEndpointServiceConnectionStatus Approved { get; } = new AgFoodPlatformPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static AgFoodPlatformPrivateEndpointServiceConnectionStatus Rejected { get; } = new AgFoodPlatformPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="AgFoodPlatformPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(AgFoodPlatformPrivateEndpointServiceConnectionStatus left, AgFoodPlatformPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgFoodPlatformPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(AgFoodPlatformPrivateEndpointServiceConnectionStatus left, AgFoodPlatformPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgFoodPlatformPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator AgFoodPlatformPrivateEndpointServiceConnectionStatus(string value) => new AgFoodPlatformPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgFoodPlatformPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgFoodPlatformPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
