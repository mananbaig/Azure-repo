// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulePropertyConditionSupportedOperator. </summary>
    public readonly partial struct AutomationRulePropertyConditionSupportedOperator : IEquatable<AutomationRulePropertyConditionSupportedOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRulePropertyConditionSupportedOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRulePropertyConditionSupportedOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "Equals";
        private const string NotEqualsValue = "NotEquals";
        private const string ContainsValue = "Contains";
        private const string NotContainsValue = "NotContains";
        private const string StartsWithValue = "StartsWith";
        private const string NotStartsWithValue = "NotStartsWith";
        private const string EndsWithValue = "EndsWith";
        private const string NotEndsWithValue = "NotEndsWith";

        /// <summary> Evaluates if the property equals at least one of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator EqualsValue { get; } = new AutomationRulePropertyConditionSupportedOperator(EqualsValueValue);
        /// <summary> Evaluates if the property does not equal any of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator NotEquals { get; } = new AutomationRulePropertyConditionSupportedOperator(NotEqualsValue);
        /// <summary> Evaluates if the property contains at least one of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator Contains { get; } = new AutomationRulePropertyConditionSupportedOperator(ContainsValue);
        /// <summary> Evaluates if the property does not contain any of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator NotContains { get; } = new AutomationRulePropertyConditionSupportedOperator(NotContainsValue);
        /// <summary> Evaluates if the property starts with any of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator StartsWith { get; } = new AutomationRulePropertyConditionSupportedOperator(StartsWithValue);
        /// <summary> Evaluates if the property does not start with any of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator NotStartsWith { get; } = new AutomationRulePropertyConditionSupportedOperator(NotStartsWithValue);
        /// <summary> Evaluates if the property ends with any of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator EndsWith { get; } = new AutomationRulePropertyConditionSupportedOperator(EndsWithValue);
        /// <summary> Evaluates if the property does not end with any of the condition values. </summary>
        public static AutomationRulePropertyConditionSupportedOperator NotEndsWith { get; } = new AutomationRulePropertyConditionSupportedOperator(NotEndsWithValue);
        /// <summary> Determines if two <see cref="AutomationRulePropertyConditionSupportedOperator"/> values are the same. </summary>
        public static bool operator ==(AutomationRulePropertyConditionSupportedOperator left, AutomationRulePropertyConditionSupportedOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRulePropertyConditionSupportedOperator"/> values are not the same. </summary>
        public static bool operator !=(AutomationRulePropertyConditionSupportedOperator left, AutomationRulePropertyConditionSupportedOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationRulePropertyConditionSupportedOperator"/>. </summary>
        public static implicit operator AutomationRulePropertyConditionSupportedOperator(string value) => new AutomationRulePropertyConditionSupportedOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRulePropertyConditionSupportedOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRulePropertyConditionSupportedOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
