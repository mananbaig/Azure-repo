// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Set of export policy rules. </summary>
    internal partial class VolumePatchPropertiesExportPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VolumePatchPropertiesExportPolicy"/>. </summary>
        public VolumePatchPropertiesExportPolicy()
        {
            Rules = new ChangeTrackingList<NetAppVolumeExportPolicyRule>();
        }

        /// <summary> Initializes a new instance of <see cref="VolumePatchPropertiesExportPolicy"/>. </summary>
        /// <param name="rules"> Export policy rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VolumePatchPropertiesExportPolicy(IList<NetAppVolumeExportPolicyRule> rules, Dictionary<string, BinaryData> rawData)
        {
            Rules = rules;
            _rawData = rawData;
        }

        /// <summary> Export policy rule. </summary>
        public IList<NetAppVolumeExportPolicyRule> Rules { get; }
    }
}
