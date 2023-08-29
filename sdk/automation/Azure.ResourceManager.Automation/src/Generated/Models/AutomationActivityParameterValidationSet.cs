// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the activity parameter validation set. </summary>
    public partial class AutomationActivityParameterValidationSet
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationActivityParameterValidationSet"/>. </summary>
        internal AutomationActivityParameterValidationSet()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationActivityParameterValidationSet"/>. </summary>
        /// <param name="memberValue"> Gets or sets the name of the activity parameter validation set member. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationActivityParameterValidationSet(string memberValue, Dictionary<string, BinaryData> rawData)
        {
            MemberValue = memberValue;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the name of the activity parameter validation set member. </summary>
        public string MemberValue { get; }
    }
}
