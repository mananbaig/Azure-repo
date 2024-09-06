// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The type of the owner the hunt is assigned to.
    /// Serialized Name: OwnerType
    /// </summary>
    public readonly partial struct SecurityInsightsIncidentOwnerType : IEquatable<SecurityInsightsIncidentOwnerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentOwnerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsIncidentOwnerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string UserValue = "User";
        private const string GroupValue = "Group";

        /// <summary>
        /// The hunt owner type is unknown
        /// Serialized Name: OwnerType.Unknown
        /// </summary>
        public static SecurityInsightsIncidentOwnerType Unknown { get; } = new SecurityInsightsIncidentOwnerType(UnknownValue);
        /// <summary>
        /// The hunt owner type is an AAD user
        /// Serialized Name: OwnerType.User
        /// </summary>
        public static SecurityInsightsIncidentOwnerType User { get; } = new SecurityInsightsIncidentOwnerType(UserValue);
        /// <summary>
        /// The hunt owner type is an AAD group
        /// Serialized Name: OwnerType.Group
        /// </summary>
        public static SecurityInsightsIncidentOwnerType Group { get; } = new SecurityInsightsIncidentOwnerType(GroupValue);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentOwnerType"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsIncidentOwnerType left, SecurityInsightsIncidentOwnerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsIncidentOwnerType"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsIncidentOwnerType left, SecurityInsightsIncidentOwnerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsIncidentOwnerType"/>. </summary>
        public static implicit operator SecurityInsightsIncidentOwnerType(string value) => new SecurityInsightsIncidentOwnerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsIncidentOwnerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsIncidentOwnerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
