// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update connection type operation. </summary>
    public partial class AutomationConnectionTypeCreateOrUpdateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionTypeCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the connection type. </param>
        /// <param name="fieldDefinitions"> Gets or sets the field definitions of the connection type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="fieldDefinitions"/> is null. </exception>
        public AutomationConnectionTypeCreateOrUpdateContent(string name, IDictionary<string, AutomationConnectionFieldDefinition> fieldDefinitions)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(fieldDefinitions, nameof(fieldDefinitions));

            Name = name;
            FieldDefinitions = fieldDefinitions;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionTypeCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the connection type. </param>
        /// <param name="isGlobal"> Gets or sets a Boolean value to indicate if the connection type is global. </param>
        /// <param name="fieldDefinitions"> Gets or sets the field definitions of the connection type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationConnectionTypeCreateOrUpdateContent(string name, bool? isGlobal, IDictionary<string, AutomationConnectionFieldDefinition> fieldDefinitions, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            IsGlobal = isGlobal;
            FieldDefinitions = fieldDefinitions;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionTypeCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationConnectionTypeCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the connection type. </summary>
        public string Name { get; }
        /// <summary> Gets or sets a Boolean value to indicate if the connection type is global. </summary>
        public bool? IsGlobal { get; set; }
        /// <summary> Gets or sets the field definitions of the connection type. </summary>
        public IDictionary<string, AutomationConnectionFieldDefinition> FieldDefinitions { get; }
    }
}
