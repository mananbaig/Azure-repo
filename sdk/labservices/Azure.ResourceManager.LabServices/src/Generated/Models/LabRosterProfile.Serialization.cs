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

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabRosterProfile : IUtf8JsonSerializable, IModelJsonSerializable<LabRosterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LabRosterProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LabRosterProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveDirectoryGroupId))
            {
                writer.WritePropertyName("activeDirectoryGroupId"u8);
                writer.WriteStringValue(ActiveDirectoryGroupId);
            }
            if (Optional.IsDefined(LtiContextId))
            {
                writer.WritePropertyName("ltiContextId"u8);
                writer.WriteStringValue(LtiContextId);
            }
            if (Optional.IsDefined(LmsInstance))
            {
                writer.WritePropertyName("lmsInstance"u8);
                writer.WriteStringValue(LmsInstance.AbsoluteUri);
            }
            if (Optional.IsDefined(LtiClientId))
            {
                writer.WritePropertyName("ltiClientId"u8);
                writer.WriteStringValue(LtiClientId);
            }
            if (Optional.IsDefined(LtiRosterEndpoint))
            {
                writer.WritePropertyName("ltiRosterEndpoint"u8);
                writer.WriteStringValue(LtiRosterEndpoint.AbsoluteUri);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static LabRosterProfile DeserializeLabRosterProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activeDirectoryGroupId = default;
            Optional<string> ltiContextId = default;
            Optional<Uri> lmsInstance = default;
            Optional<string> ltiClientId = default;
            Optional<Uri> ltiRosterEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryGroupId"u8))
                {
                    activeDirectoryGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiContextId"u8))
                {
                    ltiContextId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lmsInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lmsInstance = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ltiClientId"u8))
                {
                    ltiClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiRosterEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ltiRosterEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LabRosterProfile(activeDirectoryGroupId.Value, ltiContextId.Value, lmsInstance.Value, ltiClientId.Value, ltiRosterEndpoint.Value, rawData);
        }

        LabRosterProfile IModelJsonSerializable<LabRosterProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLabRosterProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LabRosterProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LabRosterProfile IModelSerializable<LabRosterProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLabRosterProfile(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LabRosterProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LabRosterProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLabRosterProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
