// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulePropertyArrayChangedConditionSupportedChangeType. </summary>
    public readonly partial struct AutomationRulePropertyArrayChangedConditionSupportedChangeType : IEquatable<AutomationRulePropertyArrayChangedConditionSupportedChangeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyArrayChangedConditionSupportedChangeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRulePropertyArrayChangedConditionSupportedChangeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddedValue = "Added";

        /// <summary> Evaluate the condition on items added to the array. </summary>
        public static AutomationRulePropertyArrayChangedConditionSupportedChangeType Added { get; } = new AutomationRulePropertyArrayChangedConditionSupportedChangeType(AddedValue);
        /// <summary> Determines if two <see cref="AutomationRulePropertyArrayChangedConditionSupportedChangeType"/> values are the same. </summary>
        public static bool operator ==(AutomationRulePropertyArrayChangedConditionSupportedChangeType left, AutomationRulePropertyArrayChangedConditionSupportedChangeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRulePropertyArrayChangedConditionSupportedChangeType"/> values are not the same. </summary>
        public static bool operator !=(AutomationRulePropertyArrayChangedConditionSupportedChangeType left, AutomationRulePropertyArrayChangedConditionSupportedChangeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationRulePropertyArrayChangedConditionSupportedChangeType"/>. </summary>
        public static implicit operator AutomationRulePropertyArrayChangedConditionSupportedChangeType(string value) => new AutomationRulePropertyArrayChangedConditionSupportedChangeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRulePropertyArrayChangedConditionSupportedChangeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRulePropertyArrayChangedConditionSupportedChangeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
