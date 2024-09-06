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
    /// Represents a cloud application entity.
    /// Serialized Name: CloudApplicationEntity
    /// </summary>
    public partial class SecurityInsightsCloudApplicationEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsCloudApplicationEntity"/>. </summary>
        public SecurityInsightsCloudApplicationEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.CloudApplication;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsCloudApplicationEntity"/>. </summary>
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
        /// Serialized Name: CloudApplicationEntity.properties.additionalData
        /// </param>
        /// <param name="friendlyName">
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated.
        /// Serialized Name: CloudApplicationEntity.properties.friendlyName
        /// </param>
        /// <param name="appId">
        /// The technical identifier of the application.
        /// Serialized Name: CloudApplicationEntity.properties.appId
        /// </param>
        /// <param name="appName">
        /// The name of the related cloud application.
        /// Serialized Name: CloudApplicationEntity.properties.appName
        /// </param>
        /// <param name="instanceName">
        /// The user defined instance name of the cloud application. It is often used to distinguish between several applications of the same type that a customer has.
        /// Serialized Name: CloudApplicationEntity.properties.instanceName
        /// </param>
        internal SecurityInsightsCloudApplicationEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, int? appId, string appName, string instanceName) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AppId = appId;
            AppName = appName;
            InstanceName = instanceName;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// Serialized Name: CloudApplicationEntity.properties.additionalData
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
        /// Serialized Name: CloudApplicationEntity.properties.friendlyName
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The technical identifier of the application.
        /// Serialized Name: CloudApplicationEntity.properties.appId
        /// </summary>
        public int? AppId { get; }
        /// <summary>
        /// The name of the related cloud application.
        /// Serialized Name: CloudApplicationEntity.properties.appName
        /// </summary>
        public string AppName { get; }
        /// <summary>
        /// The user defined instance name of the cloud application. It is often used to distinguish between several applications of the same type that a customer has.
        /// Serialized Name: CloudApplicationEntity.properties.instanceName
        /// </summary>
        public string InstanceName { get; }
    }
}
