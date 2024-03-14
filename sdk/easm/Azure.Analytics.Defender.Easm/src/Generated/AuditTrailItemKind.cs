// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The kind of asset. </summary>
    public readonly partial struct AuditTrailItemKind : IEquatable<AuditTrailItemKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuditTrailItemKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuditTrailItemKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AsValue = "as";
        private const string ContactValue = "contact";
        private const string DomainValue = "domain";
        private const string HostValue = "host";
        private const string IpAddressValue = "ipAddress";
        private const string IpBlockValue = "ipBlock";
        private const string PageValue = "page";
        private const string SslCertValue = "sslCert";

        /// <summary> as. </summary>
        public static AuditTrailItemKind As { get; } = new AuditTrailItemKind(AsValue);
        /// <summary> contact. </summary>
        public static AuditTrailItemKind Contact { get; } = new AuditTrailItemKind(ContactValue);
        /// <summary> domain. </summary>
        public static AuditTrailItemKind Domain { get; } = new AuditTrailItemKind(DomainValue);
        /// <summary> host. </summary>
        public static AuditTrailItemKind Host { get; } = new AuditTrailItemKind(HostValue);
        /// <summary> ipAddress. </summary>
        public static AuditTrailItemKind IpAddress { get; } = new AuditTrailItemKind(IpAddressValue);
        /// <summary> ipBlock. </summary>
        public static AuditTrailItemKind IpBlock { get; } = new AuditTrailItemKind(IpBlockValue);
        /// <summary> page. </summary>
        public static AuditTrailItemKind Page { get; } = new AuditTrailItemKind(PageValue);
        /// <summary> sslCert. </summary>
        public static AuditTrailItemKind SslCert { get; } = new AuditTrailItemKind(SslCertValue);
        /// <summary> Determines if two <see cref="AuditTrailItemKind"/> values are the same. </summary>
        public static bool operator ==(AuditTrailItemKind left, AuditTrailItemKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuditTrailItemKind"/> values are not the same. </summary>
        public static bool operator !=(AuditTrailItemKind left, AuditTrailItemKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AuditTrailItemKind"/>. </summary>
        public static implicit operator AuditTrailItemKind(string value) => new AuditTrailItemKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuditTrailItemKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuditTrailItemKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
