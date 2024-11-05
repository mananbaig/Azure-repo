// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A value indicating whether security update required. </summary>
    public readonly partial struct SiteRecoveryAgentVersionStatus : IEquatable<SiteRecoveryAgentVersionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAgentVersionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SiteRecoveryAgentVersionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SupportedValue = "Supported";
        private const string NotSupportedValue = "NotSupported";
        private const string DeprecatedValue = "Deprecated";
        private const string UpdateRequiredValue = "UpdateRequired";
        private const string SecurityUpdateRequiredValue = "SecurityUpdateRequired";

        /// <summary> Supported. </summary>
        public static SiteRecoveryAgentVersionStatus Supported { get; } = new SiteRecoveryAgentVersionStatus(SupportedValue);
        /// <summary> NotSupported. </summary>
        public static SiteRecoveryAgentVersionStatus NotSupported { get; } = new SiteRecoveryAgentVersionStatus(NotSupportedValue);
        /// <summary> Deprecated. </summary>
        public static SiteRecoveryAgentVersionStatus Deprecated { get; } = new SiteRecoveryAgentVersionStatus(DeprecatedValue);
        /// <summary> UpdateRequired. </summary>
        public static SiteRecoveryAgentVersionStatus UpdateRequired { get; } = new SiteRecoveryAgentVersionStatus(UpdateRequiredValue);
        /// <summary> SecurityUpdateRequired. </summary>
        public static SiteRecoveryAgentVersionStatus SecurityUpdateRequired { get; } = new SiteRecoveryAgentVersionStatus(SecurityUpdateRequiredValue);
        /// <summary> Determines if two <see cref="SiteRecoveryAgentVersionStatus"/> values are the same. </summary>
        public static bool operator ==(SiteRecoveryAgentVersionStatus left, SiteRecoveryAgentVersionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SiteRecoveryAgentVersionStatus"/> values are not the same. </summary>
        public static bool operator !=(SiteRecoveryAgentVersionStatus left, SiteRecoveryAgentVersionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SiteRecoveryAgentVersionStatus"/>. </summary>
        public static implicit operator SiteRecoveryAgentVersionStatus(string value) => new SiteRecoveryAgentVersionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SiteRecoveryAgentVersionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SiteRecoveryAgentVersionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
