// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A rule which is evaluated upon event interception. The rule is configured by comparing a specific value from the event model to an expected value. This comparison is done by using one of the supported operators set. </summary>
    public partial class AutomationTriggeringRule
    {
        /// <summary> Initializes a new instance of AutomationTriggeringRule. </summary>
        public AutomationTriggeringRule()
        {
        }

        /// <summary> Initializes a new instance of AutomationTriggeringRule. </summary>
        /// <param name="propertyJPath"> The JPath of the entity model property that should be checked. </param>
        /// <param name="propertyType"> The data type of the compared operands (string, integer, floating point number or a boolean [true/false]]. </param>
        /// <param name="expectedValue"> The expected value. </param>
        /// <param name="operator"> A valid comparer operator to use. A case-insensitive comparison will be applied for String PropertyType. </param>
        internal AutomationTriggeringRule(string propertyJPath, PropertyType? propertyType, string expectedValue, Operator? @operator)
        {
            PropertyJPath = propertyJPath;
            PropertyType = propertyType;
            ExpectedValue = expectedValue;
            Operator = @operator;
        }

        /// <summary> The JPath of the entity model property that should be checked. </summary>
        public string PropertyJPath { get; set; }
        /// <summary> The data type of the compared operands (string, integer, floating point number or a boolean [true/false]]. </summary>
        public PropertyType? PropertyType { get; set; }
        /// <summary> The expected value. </summary>
        public string ExpectedValue { get; set; }
        /// <summary> A valid comparer operator to use. A case-insensitive comparison will be applied for String PropertyType. </summary>
        public Operator? Operator { get; set; }
    }
}
