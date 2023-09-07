// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the TemplateSpecVersion data model.
    /// Template Spec Version object.
    /// </summary>
    public partial class TemplateSpecVersionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TemplateSpecVersionData"/>. </summary>
        /// <param name="location"> The location of the Template Spec Version. It must match the location of the parent Template Spec. </param>
        public TemplateSpecVersionData(AzureLocation location)
        {
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            LinkedTemplates = new ChangeTrackingList<LinkedTemplateArtifact>();
        }

        /// <summary> Initializes a new instance of <see cref="TemplateSpecVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the Template Spec Version. It must match the location of the parent Template Spec. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="description"> Template Spec version description. </param>
        /// <param name="linkedTemplates"> An array of linked template artifacts. </param>
        /// <param name="metadata"> The version metadata. Metadata is an open-ended object and is typically a collection of key-value pairs. </param>
        /// <param name="mainTemplate"> The main Azure Resource Manager template content. </param>
        /// <param name="uiFormDefinition"> The Azure Resource Manager template UI definition content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TemplateSpecVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, IDictionary<string, string> tags, string description, IList<LinkedTemplateArtifact> linkedTemplates, BinaryData metadata, BinaryData mainTemplate, BinaryData uiFormDefinition, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Tags = tags;
            Description = description;
            LinkedTemplates = linkedTemplates;
            Metadata = metadata;
            MainTemplate = mainTemplate;
            UiFormDefinition = uiFormDefinition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TemplateSpecVersionData"/> for deserialization. </summary>
        internal TemplateSpecVersionData()
        {
        }

        /// <summary> The location of the Template Spec Version. It must match the location of the parent Template Spec. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Template Spec version description. </summary>
        public string Description { get; set; }
        /// <summary> An array of linked template artifacts. </summary>
        public IList<LinkedTemplateArtifact> LinkedTemplates { get; }
        /// <summary>
        /// The version metadata. Metadata is an open-ended object and is typically a collection of key-value pairs.
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
        public BinaryData Metadata { get; set; }
        /// <summary>
        /// The main Azure Resource Manager template content.
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
        public BinaryData MainTemplate { get; set; }
        /// <summary>
        /// The Azure Resource Manager template UI definition content.
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
        public BinaryData UiFormDefinition { get; set; }
    }
}
