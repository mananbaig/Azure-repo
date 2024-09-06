// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The AutomationRuleBooleanConditionSupportedOperator.
    /// Serialized Name: AutomationRuleBooleanConditionSupportedOperator
    /// </summary>
    public readonly partial struct AutomationRuleBooleanConditionSupportedOperator : IEquatable<AutomationRuleBooleanConditionSupportedOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationRuleBooleanConditionSupportedOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationRuleBooleanConditionSupportedOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AndValue = "And";
        private const string OrValue = "Or";

        /// <summary>
        /// Evaluates as true if all the item conditions are evaluated as true
        /// Serialized Name: AutomationRuleBooleanConditionSupportedOperator.And
        /// </summary>
        public static AutomationRuleBooleanConditionSupportedOperator And { get; } = new AutomationRuleBooleanConditionSupportedOperator(AndValue);
        /// <summary>
        /// Evaluates as true if at least one of the item conditions are evaluated as true
        /// Serialized Name: AutomationRuleBooleanConditionSupportedOperator.Or
        /// </summary>
        public static AutomationRuleBooleanConditionSupportedOperator Or { get; } = new AutomationRuleBooleanConditionSupportedOperator(OrValue);
        /// <summary> Determines if two <see cref="AutomationRuleBooleanConditionSupportedOperator"/> values are the same. </summary>
        public static bool operator ==(AutomationRuleBooleanConditionSupportedOperator left, AutomationRuleBooleanConditionSupportedOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationRuleBooleanConditionSupportedOperator"/> values are not the same. </summary>
        public static bool operator !=(AutomationRuleBooleanConditionSupportedOperator left, AutomationRuleBooleanConditionSupportedOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationRuleBooleanConditionSupportedOperator"/>. </summary>
        public static implicit operator AutomationRuleBooleanConditionSupportedOperator(string value) => new AutomationRuleBooleanConditionSupportedOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationRuleBooleanConditionSupportedOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationRuleBooleanConditionSupportedOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
