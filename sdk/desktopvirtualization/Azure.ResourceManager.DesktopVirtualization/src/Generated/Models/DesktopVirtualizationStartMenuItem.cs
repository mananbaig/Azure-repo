// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents a StartMenuItem definition. </summary>
    public partial class DesktopVirtualizationStartMenuItem : ResourceData
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DesktopVirtualizationStartMenuItem"/>. </summary>
        public DesktopVirtualizationStartMenuItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DesktopVirtualizationStartMenuItem"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="appAlias"> Alias of StartMenuItem. </param>
        /// <param name="filePath"> Path to the file of StartMenuItem. </param>
        /// <param name="commandLineArguments"> Command line arguments for StartMenuItem. </param>
        /// <param name="iconPath"> Path to the icon. </param>
        /// <param name="iconIndex"> Index of the icon. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DesktopVirtualizationStartMenuItem(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string appAlias, string filePath, string commandLineArguments, string iconPath, int? iconIndex, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AppAlias = appAlias;
            FilePath = filePath;
            CommandLineArguments = commandLineArguments;
            IconPath = iconPath;
            IconIndex = iconIndex;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Alias of StartMenuItem. </summary>
        [WirePath("properties.appAlias")]
        public string AppAlias { get; set; }
        /// <summary> Path to the file of StartMenuItem. </summary>
        [WirePath("properties.filePath")]
        public string FilePath { get; set; }
        /// <summary> Command line arguments for StartMenuItem. </summary>
        [WirePath("properties.commandLineArguments")]
        public string CommandLineArguments { get; set; }
        /// <summary> Path to the icon. </summary>
        [WirePath("properties.iconPath")]
        public string IconPath { get; set; }
        /// <summary> Index of the icon. </summary>
        [WirePath("properties.iconIndex")]
        public int? IconIndex { get; set; }
    }
}
