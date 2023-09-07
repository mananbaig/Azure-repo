// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ScriptLog data model.
    /// Script execution log object.
    /// </summary>
    public partial class ScriptLogData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScriptLogData"/>. </summary>
        public ScriptLogData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScriptLogData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="log"> Script execution logs in text format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptLogData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string log, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Log = log;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Script execution logs in text format. </summary>
        public string Log { get; }
    }
}
