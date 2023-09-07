// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The sensitivity label. </summary>
    public partial class SensitivityLabel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SensitivityLabel"/>. </summary>
        public SensitivityLabel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SensitivityLabel"/>. </summary>
        /// <param name="displayName"> The name of the sensitivity label. </param>
        /// <param name="description"> The description of the sensitivity label. </param>
        /// <param name="rank"> The rank of the sensitivity label. </param>
        /// <param name="order"> The order of the sensitivity label. </param>
        /// <param name="enabled"> Indicates whether the label is enabled or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SensitivityLabel(string displayName, string description, SensitivityLabelRank? rank, int? order, bool? enabled, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            Rank = rank;
            Order = order;
            Enabled = enabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the sensitivity label. </summary>
        public string DisplayName { get; set; }
        /// <summary> The description of the sensitivity label. </summary>
        public string Description { get; set; }
        /// <summary> The rank of the sensitivity label. </summary>
        public SensitivityLabelRank? Rank { get; set; }
        /// <summary> The order of the sensitivity label. </summary>
        public int? Order { get; set; }
        /// <summary> Indicates whether the label is enabled or not. </summary>
        public bool? Enabled { get; set; }
    }
}
