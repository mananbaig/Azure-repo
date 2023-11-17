// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DefenderEasm.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DefenderEasm
{
    /// <summary>
    /// A class representing the EasmLabel data model.
    /// Label details
    /// </summary>
    public partial class EasmLabelData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EasmLabelData"/>. </summary>
        public EasmLabelData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EasmLabelData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="displayName"> Label display name. </param>
        /// <param name="color"> Label color. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EasmLabelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EasmResourceProvisioningState? provisioningState, string displayName, string color, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DisplayName = displayName;
            Color = color;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource provisioning state. </summary>
        public EasmResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Label display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Label color. </summary>
        public string Color { get; set; }
    }
}
