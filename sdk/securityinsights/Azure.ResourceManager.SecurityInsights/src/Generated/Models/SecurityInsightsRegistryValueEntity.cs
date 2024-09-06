// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents a registry value entity.
    /// Serialized Name: RegistryValueEntity
    /// </summary>
    public partial class SecurityInsightsRegistryValueEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsRegistryValueEntity"/>. </summary>
        public SecurityInsightsRegistryValueEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.RegistryValue;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsRegistryValueEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The kind of the entity.
        /// Serialized Name: Entity.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="additionalData">
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: RegistryValueEntity.properties.additionalData
        /// </param>
        /// <param name="friendlyName">
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: RegistryValueEntity.properties.friendlyName
        /// </param>
        /// <param name="keyEntityId">
        /// The registry key entity id.
        /// Serialized Name: RegistryValueEntity.properties.keyEntityId
        /// </param>
        /// <param name="valueData">
        /// String formatted representation of the value data.
        /// Serialized Name: RegistryValueEntity.properties.valueData
        /// </param>
        /// <param name="valueName">
        /// The registry value name.
        /// Serialized Name: RegistryValueEntity.properties.valueName
        /// </param>
        /// <param name="valueType">
        /// Specifies the data types to use when storing values in the registry, or identifies the data type of a value in the registry.
        /// Serialized Name: RegistryValueEntity.properties.valueType
        /// </param>
        internal SecurityInsightsRegistryValueEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string keyEntityId, string valueData, string valueName, SecurityInsightsRegistryValueKind? valueType) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            KeyEntityId = keyEntityId;
            ValueData = valueData;
            ValueName = valueName;
            ValueType = valueType;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: RegistryValueEntity.properties.additionalData
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: RegistryValueEntity.properties.friendlyName
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The registry key entity id.
        /// Serialized Name: RegistryValueEntity.properties.keyEntityId
        /// </summary>
        public string KeyEntityId { get; }
        /// <summary>
        /// String formatted representation of the value data.
        /// Serialized Name: RegistryValueEntity.properties.valueData
        /// </summary>
        public string ValueData { get; }
        /// <summary>
        /// The registry value name.
        /// Serialized Name: RegistryValueEntity.properties.valueName
        /// </summary>
        public string ValueName { get; }
        /// <summary>
        /// Specifies the data types to use when storing values in the registry, or identifies the data type of a value in the registry.
        /// Serialized Name: RegistryValueEntity.properties.valueType
        /// </summary>
        public SecurityInsightsRegistryValueKind? ValueType { get; }
    }
}
