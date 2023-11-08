// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes a section in the fabric settings of the cluster. </summary>
    public partial class SettingsSectionDescription
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SettingsSectionDescription"/>. </summary>
        /// <param name="name"> The section name of the fabric settings. </param>
        /// <param name="parameters"> The collection of parameters in the section. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public SettingsSectionDescription(string name, IEnumerable<SettingsParameterDescription> parameters)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));

            Name = name;
            Parameters = parameters.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SettingsSectionDescription"/>. </summary>
        /// <param name="name"> The section name of the fabric settings. </param>
        /// <param name="parameters"> The collection of parameters in the section. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SettingsSectionDescription(string name, IList<SettingsParameterDescription> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SettingsSectionDescription"/> for deserialization. </summary>
        internal SettingsSectionDescription()
        {
        }

        /// <summary> The section name of the fabric settings. </summary>
        public string Name { get; set; }
        /// <summary> The collection of parameters in the section. </summary>
        public IList<SettingsParameterDescription> Parameters { get; }
    }
}
