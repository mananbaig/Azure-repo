// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The category of the health error. </summary>
    public readonly partial struct HealthErrorCategory : IEquatable<HealthErrorCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HealthErrorCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HealthErrorCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ReplicationValue = "Replication";
        private const string TestFailoverValue = "TestFailover";
        private const string ConfigurationValue = "Configuration";
        private const string FabricInfrastructureValue = "FabricInfrastructure";
        private const string VersionExpiryValue = "VersionExpiry";
        private const string AgentAutoUpdateInfraValue = "AgentAutoUpdateInfra";
        private const string AgentAutoUpdateArtifactDeletedValue = "AgentAutoUpdateArtifactDeleted";
        private const string AgentAutoUpdateRunAsAccountValue = "AgentAutoUpdateRunAsAccount";
        private const string AgentAutoUpdateRunAsAccountExpiryValue = "AgentAutoUpdateRunAsAccountExpiry";
        private const string AgentAutoUpdateRunAsAccountExpiredValue = "AgentAutoUpdateRunAsAccountExpired";

        /// <summary> None. </summary>
        public static HealthErrorCategory None { get; } = new HealthErrorCategory(NoneValue);
        /// <summary> Replication. </summary>
        public static HealthErrorCategory Replication { get; } = new HealthErrorCategory(ReplicationValue);
        /// <summary> TestFailover. </summary>
        public static HealthErrorCategory TestFailover { get; } = new HealthErrorCategory(TestFailoverValue);
        /// <summary> Configuration. </summary>
        public static HealthErrorCategory Configuration { get; } = new HealthErrorCategory(ConfigurationValue);
        /// <summary> FabricInfrastructure. </summary>
        public static HealthErrorCategory FabricInfrastructure { get; } = new HealthErrorCategory(FabricInfrastructureValue);
        /// <summary> VersionExpiry. </summary>
        public static HealthErrorCategory VersionExpiry { get; } = new HealthErrorCategory(VersionExpiryValue);
        /// <summary> AgentAutoUpdateInfra. </summary>
        public static HealthErrorCategory AgentAutoUpdateInfra { get; } = new HealthErrorCategory(AgentAutoUpdateInfraValue);
        /// <summary> AgentAutoUpdateArtifactDeleted. </summary>
        public static HealthErrorCategory AgentAutoUpdateArtifactDeleted { get; } = new HealthErrorCategory(AgentAutoUpdateArtifactDeletedValue);
        /// <summary> AgentAutoUpdateRunAsAccount. </summary>
        public static HealthErrorCategory AgentAutoUpdateRunAsAccount { get; } = new HealthErrorCategory(AgentAutoUpdateRunAsAccountValue);
        /// <summary> AgentAutoUpdateRunAsAccountExpiry. </summary>
        public static HealthErrorCategory AgentAutoUpdateRunAsAccountExpiry { get; } = new HealthErrorCategory(AgentAutoUpdateRunAsAccountExpiryValue);
        /// <summary> AgentAutoUpdateRunAsAccountExpired. </summary>
        public static HealthErrorCategory AgentAutoUpdateRunAsAccountExpired { get; } = new HealthErrorCategory(AgentAutoUpdateRunAsAccountExpiredValue);
        /// <summary> Determines if two <see cref="HealthErrorCategory"/> values are the same. </summary>
        public static bool operator ==(HealthErrorCategory left, HealthErrorCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HealthErrorCategory"/> values are not the same. </summary>
        public static bool operator !=(HealthErrorCategory left, HealthErrorCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HealthErrorCategory"/>. </summary>
        public static implicit operator HealthErrorCategory(string value) => new HealthErrorCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HealthErrorCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HealthErrorCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
