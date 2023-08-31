// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Extension sidecars to be added to the deployment. </summary>
    public partial class DeploymentExtensionSpec
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeploymentExtensionSpec"/>. </summary>
        /// <param name="name"> Name of the extension. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DeploymentExtensionSpec(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentExtensionSpec"/>. </summary>
        /// <param name="name"> Name of the extension. </param>
        /// <param name="extensionType"> Type of extension to be added. </param>
        /// <param name="version"> Version of the extension being used. </param>
        /// <param name="settings"> Settings for the extension. </param>
        /// <param name="protectedSettings"> Protected settings for the extension. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeploymentExtensionSpec(string name, string extensionType, string version, BinaryData settings, BinaryData protectedSettings, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ExtensionType = extensionType;
            Version = version;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentExtensionSpec"/> for deserialization. </summary>
        internal DeploymentExtensionSpec()
        {
        }

        /// <summary> Name of the extension. </summary>
        public string Name { get; set; }
        /// <summary> Type of extension to be added. </summary>
        public string ExtensionType { get; set; }
        /// <summary> Version of the extension being used. </summary>
        public string Version { get; set; }
        /// <summary>
        /// Settings for the extension.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Settings { get; set; }
        /// <summary>
        /// Protected settings for the extension.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ProtectedSettings { get; set; }
    }
}
