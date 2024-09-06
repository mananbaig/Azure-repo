// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Grouping matching method. When method is Selected at least one of groupByEntities, groupByAlertDetails, groupByCustomDetails must be provided and not empty.
    /// Serialized Name: MatchingMethod
    /// </summary>
    public readonly partial struct SecurityInsightsGroupingMatchingMethod : IEquatable<SecurityInsightsGroupingMatchingMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsGroupingMatchingMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsGroupingMatchingMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllEntitiesValue = "AllEntities";
        private const string AnyAlertValue = "AnyAlert";
        private const string SelectedValue = "Selected";

        /// <summary>
        /// Grouping alerts into a single incident if all the entities match
        /// Serialized Name: MatchingMethod.AllEntities
        /// </summary>
        public static SecurityInsightsGroupingMatchingMethod AllEntities { get; } = new SecurityInsightsGroupingMatchingMethod(AllEntitiesValue);
        /// <summary>
        /// Grouping any alerts triggered by this rule into a single incident
        /// Serialized Name: MatchingMethod.AnyAlert
        /// </summary>
        public static SecurityInsightsGroupingMatchingMethod AnyAlert { get; } = new SecurityInsightsGroupingMatchingMethod(AnyAlertValue);
        /// <summary>
        /// Grouping alerts into a single incident if the selected entities, custom details and alert details match
        /// Serialized Name: MatchingMethod.Selected
        /// </summary>
        public static SecurityInsightsGroupingMatchingMethod Selected { get; } = new SecurityInsightsGroupingMatchingMethod(SelectedValue);
        /// <summary> Determines if two <see cref="SecurityInsightsGroupingMatchingMethod"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsGroupingMatchingMethod left, SecurityInsightsGroupingMatchingMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsGroupingMatchingMethod"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsGroupingMatchingMethod left, SecurityInsightsGroupingMatchingMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsGroupingMatchingMethod"/>. </summary>
        public static implicit operator SecurityInsightsGroupingMatchingMethod(string value) => new SecurityInsightsGroupingMatchingMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsGroupingMatchingMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsGroupingMatchingMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
