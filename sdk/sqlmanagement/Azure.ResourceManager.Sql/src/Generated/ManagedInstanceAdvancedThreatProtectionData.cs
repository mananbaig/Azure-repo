// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceAdvancedThreatProtection data model.
    /// A managed instance Advanced Threat Protection.
    /// </summary>
    public partial class ManagedInstanceAdvancedThreatProtectionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceAdvancedThreatProtectionData"/>. </summary>
        public ManagedInstanceAdvancedThreatProtectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceAdvancedThreatProtectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the Advanced Threat Protection, whether it is enabled or disabled or a state has not been applied yet on the specific database or server. </param>
        /// <param name="createdOn"> Specifies the UTC creation time of the policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceAdvancedThreatProtectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AdvancedThreatProtectionState? state, DateTimeOffset? createdOn, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the state of the Advanced Threat Protection, whether it is enabled or disabled or a state has not been applied yet on the specific database or server. </summary>
        public AdvancedThreatProtectionState? State { get; set; }
        /// <summary> Specifies the UTC creation time of the policy. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
