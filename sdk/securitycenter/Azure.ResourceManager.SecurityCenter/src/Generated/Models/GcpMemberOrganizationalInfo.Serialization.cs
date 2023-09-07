// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpMemberOrganizationalInfo : IUtf8JsonSerializable, IModelJsonSerializable<GcpMemberOrganizationalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GcpMemberOrganizationalInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GcpMemberOrganizationalInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpMemberOrganizationalInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ParentHierarchyId))
            {
                writer.WritePropertyName("parentHierarchyId"u8);
                writer.WriteStringValue(ParentHierarchyId);
            }
            if (Optional.IsDefined(ManagementProjectNumber))
            {
                writer.WritePropertyName("managementProjectNumber"u8);
                writer.WriteStringValue(ManagementProjectNumber);
            }
            writer.WritePropertyName("organizationMembershipType"u8);
            writer.WriteStringValue(OrganizationMembershipType.ToString());
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static GcpMemberOrganizationalInfo DeserializeGcpMemberOrganizationalInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> parentHierarchyId = default;
            Optional<string> managementProjectNumber = default;
            OrganizationMembershipType organizationMembershipType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentHierarchyId"u8))
                {
                    parentHierarchyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementProjectNumber"u8))
                {
                    managementProjectNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GcpMemberOrganizationalInfo(organizationMembershipType, parentHierarchyId.Value, managementProjectNumber.Value, serializedAdditionalRawData);
        }

        GcpMemberOrganizationalInfo IModelJsonSerializable<GcpMemberOrganizationalInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpMemberOrganizationalInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpMemberOrganizationalInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GcpMemberOrganizationalInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpMemberOrganizationalInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GcpMemberOrganizationalInfo IModelSerializable<GcpMemberOrganizationalInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpMemberOrganizationalInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGcpMemberOrganizationalInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GcpMemberOrganizationalInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GcpMemberOrganizationalInfo"/> to convert. </param>
        public static implicit operator RequestContent(GcpMemberOrganizationalInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GcpMemberOrganizationalInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GcpMemberOrganizationalInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGcpMemberOrganizationalInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
