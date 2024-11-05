// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> State of the total counts of change enumeration activity. </summary>
    public readonly partial struct CloudEndpointChangeEnumerationTotalCountsState : IEquatable<CloudEndpointChangeEnumerationTotalCountsState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudEndpointChangeEnumerationTotalCountsState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudEndpointChangeEnumerationTotalCountsState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CalculatingValue = "Calculating";
        private const string FinalValue = "Final";

        /// <summary> Calculating. </summary>
        public static CloudEndpointChangeEnumerationTotalCountsState Calculating { get; } = new CloudEndpointChangeEnumerationTotalCountsState(CalculatingValue);
        /// <summary> Final. </summary>
        public static CloudEndpointChangeEnumerationTotalCountsState Final { get; } = new CloudEndpointChangeEnumerationTotalCountsState(FinalValue);
        /// <summary> Determines if two <see cref="CloudEndpointChangeEnumerationTotalCountsState"/> values are the same. </summary>
        public static bool operator ==(CloudEndpointChangeEnumerationTotalCountsState left, CloudEndpointChangeEnumerationTotalCountsState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudEndpointChangeEnumerationTotalCountsState"/> values are not the same. </summary>
        public static bool operator !=(CloudEndpointChangeEnumerationTotalCountsState left, CloudEndpointChangeEnumerationTotalCountsState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CloudEndpointChangeEnumerationTotalCountsState"/>. </summary>
        public static implicit operator CloudEndpointChangeEnumerationTotalCountsState(string value) => new CloudEndpointChangeEnumerationTotalCountsState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudEndpointChangeEnumerationTotalCountsState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudEndpointChangeEnumerationTotalCountsState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
