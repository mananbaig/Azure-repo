// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the DataShareTrigger data model.
    /// A Trigger data transfer object.
    /// Please note <see cref="DataShareTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ScheduledTrigger"/>.
    /// </summary>
    public partial class DataShareTriggerData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataShareTriggerData"/>. </summary>
        public DataShareTriggerData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataShareTriggerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of synchronization on trigger. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataShareTriggerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggerKind kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Kind of synchronization on trigger. </summary>
        internal TriggerKind Kind { get; set; }
    }
}
