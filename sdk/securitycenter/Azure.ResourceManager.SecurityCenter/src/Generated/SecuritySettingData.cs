// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecuritySetting data model.
    /// The kind of the security setting
    /// Please note <see cref="SecuritySettingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SecurityAlertSyncSettings"/> and <see cref="DataExportSettings"/>.
    /// </summary>
    public partial class SecuritySettingData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySettingData"/>. </summary>
        public SecuritySettingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> the kind of the settings string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SettingKind kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> the kind of the settings string. </summary>
        internal SettingKind Kind { get; set; }
    }
}
