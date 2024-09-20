// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. </summary>
    public readonly partial struct SecurityRuleDirection : IEquatable<SecurityRuleDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityRuleDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityRuleDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static SecurityRuleDirection Inbound { get; } = new SecurityRuleDirection(InboundValue);
        /// <summary> Outbound. </summary>
        public static SecurityRuleDirection Outbound { get; } = new SecurityRuleDirection(OutboundValue);
        /// <summary> Determines if two <see cref="SecurityRuleDirection"/> values are the same. </summary>
        public static bool operator ==(SecurityRuleDirection left, SecurityRuleDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityRuleDirection"/> values are not the same. </summary>
        public static bool operator !=(SecurityRuleDirection left, SecurityRuleDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityRuleDirection"/>. </summary>
        public static implicit operator SecurityRuleDirection(string value) => new SecurityRuleDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityRuleDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityRuleDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
