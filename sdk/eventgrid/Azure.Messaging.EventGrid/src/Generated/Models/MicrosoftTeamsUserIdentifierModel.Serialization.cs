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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MicrosoftTeamsUserIdentifierModel : IUtf8JsonSerializable, IModelJsonSerializable<MicrosoftTeamsUserIdentifierModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MicrosoftTeamsUserIdentifierModel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MicrosoftTeamsUserIdentifierModel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MicrosoftTeamsUserIdentifierModel>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("userId"u8);
            writer.WriteStringValue(UserId);
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud.Value.ToString());
            }
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

        internal static MicrosoftTeamsUserIdentifierModel DeserializeMicrosoftTeamsUserIdentifierModel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userId = default;
            Optional<bool> isAnonymous = default;
            Optional<CommunicationCloudEnvironmentModel> cloud = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloud = new CommunicationCloudEnvironmentModel(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MicrosoftTeamsUserIdentifierModel(userId, Optional.ToNullable(isAnonymous), Optional.ToNullable(cloud), serializedAdditionalRawData);
        }

        MicrosoftTeamsUserIdentifierModel IModelJsonSerializable<MicrosoftTeamsUserIdentifierModel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MicrosoftTeamsUserIdentifierModel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftTeamsUserIdentifierModel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MicrosoftTeamsUserIdentifierModel>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MicrosoftTeamsUserIdentifierModel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MicrosoftTeamsUserIdentifierModel IModelSerializable<MicrosoftTeamsUserIdentifierModel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MicrosoftTeamsUserIdentifierModel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMicrosoftTeamsUserIdentifierModel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MicrosoftTeamsUserIdentifierModel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MicrosoftTeamsUserIdentifierModel"/> to convert. </param>
        public static implicit operator RequestContent(MicrosoftTeamsUserIdentifierModel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MicrosoftTeamsUserIdentifierModel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMicrosoftTeamsUserIdentifierModel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
