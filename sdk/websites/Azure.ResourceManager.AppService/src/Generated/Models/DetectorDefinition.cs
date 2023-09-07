// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing detector definition. </summary>
    public partial class DetectorDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DetectorDefinition"/>. </summary>
        public DetectorDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DetectorDefinition"/>. </summary>
        /// <param name="displayName"> Display name of the detector. </param>
        /// <param name="description"> Description of the detector. </param>
        /// <param name="rank"> Detector Rank. </param>
        /// <param name="isEnabled"> Flag representing whether detector is enabled or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectorDefinition(string displayName, string description, double? rank, bool? isEnabled, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            Rank = rank;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Display name of the detector. </summary>
        public string DisplayName { get; }
        /// <summary> Description of the detector. </summary>
        public string Description { get; }
        /// <summary> Detector Rank. </summary>
        public double? Rank { get; }
        /// <summary> Flag representing whether detector is enabled or not. </summary>
        public bool? IsEnabled { get; }
    }
}
