// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents an operator in a ConditionClause.
    /// Serialized Name: Operator
    /// </summary>
    public readonly partial struct ConditionClauseOperator : IEquatable<ConditionClauseOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConditionClauseOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConditionClauseOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "Equals";
        private const string NotEqualsValue = "NotEquals";
        private const string LessThanValue = "LessThan";
        private const string LessThanEqualValue = "LessThanEqual";
        private const string GreaterThanValue = "GreaterThan";
        private const string GreaterThanEqualValue = "GreaterThanEqual";
        private const string StringContainsValue = "StringContains";
        private const string StringNotContainsValue = "StringNotContains";
        private const string StringStartsWithValue = "StringStartsWith";
        private const string StringNotStartsWithValue = "StringNotStartsWith";
        private const string StringEndsWithValue = "StringEndsWith";
        private const string StringNotEndsWithValue = "StringNotEndsWith";
        private const string StringIsEmptyValue = "StringIsEmpty";
        private const string IsNullValue = "IsNull";
        private const string IsTrueValue = "IsTrue";
        private const string IsFalseValue = "IsFalse";
        private const string ArrayContainsValue = "ArrayContains";
        private const string ArrayNotContainsValue = "ArrayNotContains";
        private const string OnOrAfterRelativeValue = "OnOrAfterRelative";
        private const string AfterRelativeValue = "AfterRelative";
        private const string OnOrBeforeRelativeValue = "OnOrBeforeRelative";
        private const string BeforeRelativeValue = "BeforeRelative";
        private const string OnOrAfterAbsoluteValue = "OnOrAfterAbsolute";
        private const string AfterAbsoluteValue = "AfterAbsolute";
        private const string OnOrBeforeAbsoluteValue = "OnOrBeforeAbsolute";
        private const string BeforeAbsoluteValue = "BeforeAbsolute";

        /// <summary>
        /// Equals
        /// Serialized Name: Operator.Equals
        /// </summary>
        public static ConditionClauseOperator EqualsValue { get; } = new ConditionClauseOperator(EqualsValueValue);
        /// <summary>
        /// NotEquals
        /// Serialized Name: Operator.NotEquals
        /// </summary>
        public static ConditionClauseOperator NotEquals { get; } = new ConditionClauseOperator(NotEqualsValue);
        /// <summary>
        /// LessThan
        /// Serialized Name: Operator.LessThan
        /// </summary>
        public static ConditionClauseOperator LessThan { get; } = new ConditionClauseOperator(LessThanValue);
        /// <summary>
        /// LessThanEqual
        /// Serialized Name: Operator.LessThanEqual
        /// </summary>
        public static ConditionClauseOperator LessThanEqual { get; } = new ConditionClauseOperator(LessThanEqualValue);
        /// <summary>
        /// GreaterThan
        /// Serialized Name: Operator.GreaterThan
        /// </summary>
        public static ConditionClauseOperator GreaterThan { get; } = new ConditionClauseOperator(GreaterThanValue);
        /// <summary>
        /// GreaterThanEqual
        /// Serialized Name: Operator.GreaterThanEqual
        /// </summary>
        public static ConditionClauseOperator GreaterThanEqual { get; } = new ConditionClauseOperator(GreaterThanEqualValue);
        /// <summary>
        /// StringContains
        /// Serialized Name: Operator.StringContains
        /// </summary>
        public static ConditionClauseOperator StringContains { get; } = new ConditionClauseOperator(StringContainsValue);
        /// <summary>
        /// StringNotContains
        /// Serialized Name: Operator.StringNotContains
        /// </summary>
        public static ConditionClauseOperator StringNotContains { get; } = new ConditionClauseOperator(StringNotContainsValue);
        /// <summary>
        /// StringStartsWith
        /// Serialized Name: Operator.StringStartsWith
        /// </summary>
        public static ConditionClauseOperator StringStartsWith { get; } = new ConditionClauseOperator(StringStartsWithValue);
        /// <summary>
        /// StringNotStartsWith
        /// Serialized Name: Operator.StringNotStartsWith
        /// </summary>
        public static ConditionClauseOperator StringNotStartsWith { get; } = new ConditionClauseOperator(StringNotStartsWithValue);
        /// <summary>
        /// StringEndsWith
        /// Serialized Name: Operator.StringEndsWith
        /// </summary>
        public static ConditionClauseOperator StringEndsWith { get; } = new ConditionClauseOperator(StringEndsWithValue);
        /// <summary>
        /// StringNotEndsWith
        /// Serialized Name: Operator.StringNotEndsWith
        /// </summary>
        public static ConditionClauseOperator StringNotEndsWith { get; } = new ConditionClauseOperator(StringNotEndsWithValue);
        /// <summary>
        /// StringIsEmpty
        /// Serialized Name: Operator.StringIsEmpty
        /// </summary>
        public static ConditionClauseOperator StringIsEmpty { get; } = new ConditionClauseOperator(StringIsEmptyValue);
        /// <summary>
        /// IsNull
        /// Serialized Name: Operator.IsNull
        /// </summary>
        public static ConditionClauseOperator IsNull { get; } = new ConditionClauseOperator(IsNullValue);
        /// <summary>
        /// IsTrue
        /// Serialized Name: Operator.IsTrue
        /// </summary>
        public static ConditionClauseOperator IsTrue { get; } = new ConditionClauseOperator(IsTrueValue);
        /// <summary>
        /// IsFalse
        /// Serialized Name: Operator.IsFalse
        /// </summary>
        public static ConditionClauseOperator IsFalse { get; } = new ConditionClauseOperator(IsFalseValue);
        /// <summary>
        /// ArrayContains
        /// Serialized Name: Operator.ArrayContains
        /// </summary>
        public static ConditionClauseOperator ArrayContains { get; } = new ConditionClauseOperator(ArrayContainsValue);
        /// <summary>
        /// ArrayNotContains
        /// Serialized Name: Operator.ArrayNotContains
        /// </summary>
        public static ConditionClauseOperator ArrayNotContains { get; } = new ConditionClauseOperator(ArrayNotContainsValue);
        /// <summary>
        /// OnOrAfterRelative
        /// Serialized Name: Operator.OnOrAfterRelative
        /// </summary>
        public static ConditionClauseOperator OnOrAfterRelative { get; } = new ConditionClauseOperator(OnOrAfterRelativeValue);
        /// <summary>
        /// AfterRelative
        /// Serialized Name: Operator.AfterRelative
        /// </summary>
        public static ConditionClauseOperator AfterRelative { get; } = new ConditionClauseOperator(AfterRelativeValue);
        /// <summary>
        /// OnOrBeforeRelative
        /// Serialized Name: Operator.OnOrBeforeRelative
        /// </summary>
        public static ConditionClauseOperator OnOrBeforeRelative { get; } = new ConditionClauseOperator(OnOrBeforeRelativeValue);
        /// <summary>
        /// BeforeRelative
        /// Serialized Name: Operator.BeforeRelative
        /// </summary>
        public static ConditionClauseOperator BeforeRelative { get; } = new ConditionClauseOperator(BeforeRelativeValue);
        /// <summary>
        /// OnOrAfterAbsolute
        /// Serialized Name: Operator.OnOrAfterAbsolute
        /// </summary>
        public static ConditionClauseOperator OnOrAfterAbsolute { get; } = new ConditionClauseOperator(OnOrAfterAbsoluteValue);
        /// <summary>
        /// AfterAbsolute
        /// Serialized Name: Operator.AfterAbsolute
        /// </summary>
        public static ConditionClauseOperator AfterAbsolute { get; } = new ConditionClauseOperator(AfterAbsoluteValue);
        /// <summary>
        /// OnOrBeforeAbsolute
        /// Serialized Name: Operator.OnOrBeforeAbsolute
        /// </summary>
        public static ConditionClauseOperator OnOrBeforeAbsolute { get; } = new ConditionClauseOperator(OnOrBeforeAbsoluteValue);
        /// <summary>
        /// BeforeAbsolute
        /// Serialized Name: Operator.BeforeAbsolute
        /// </summary>
        public static ConditionClauseOperator BeforeAbsolute { get; } = new ConditionClauseOperator(BeforeAbsoluteValue);
        /// <summary> Determines if two <see cref="ConditionClauseOperator"/> values are the same. </summary>
        public static bool operator ==(ConditionClauseOperator left, ConditionClauseOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConditionClauseOperator"/> values are not the same. </summary>
        public static bool operator !=(ConditionClauseOperator left, ConditionClauseOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConditionClauseOperator"/>. </summary>
        public static implicit operator ConditionClauseOperator(string value) => new ConditionClauseOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConditionClauseOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConditionClauseOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
