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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeRemoteSupportSettings : IUtf8JsonSerializable, IModelJsonSerializable<EdgeRemoteSupportSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdgeRemoteSupportSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdgeRemoteSupportSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RemoteApplicationType))
            {
                writer.WritePropertyName("remoteApplicationType"u8);
                writer.WriteStringValue(RemoteApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(AccessLevel))
            {
                writer.WritePropertyName("accessLevel"u8);
                writer.WriteStringValue(AccessLevel.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeStampInUTC"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        internal static EdgeRemoteSupportSettings DeserializeEdgeRemoteSupportSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeRemoteApplicationType> remoteApplicationType = default;
            Optional<EdgeRemoteApplicationAccessLevel> accessLevel = default;
            Optional<DateTimeOffset> expirationTimeStampInUtc = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("remoteApplicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteApplicationType = new EdgeRemoteApplicationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessLevel = new EdgeRemoteApplicationAccessLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expirationTimeStampInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeStampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdgeRemoteSupportSettings(Optional.ToNullable(remoteApplicationType), Optional.ToNullable(accessLevel), Optional.ToNullable(expirationTimeStampInUtc), rawData);
        }

        EdgeRemoteSupportSettings IModelJsonSerializable<EdgeRemoteSupportSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeRemoteSupportSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdgeRemoteSupportSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdgeRemoteSupportSettings IModelSerializable<EdgeRemoteSupportSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdgeRemoteSupportSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EdgeRemoteSupportSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EdgeRemoteSupportSettings"/> to convert. </param>
        public static implicit operator RequestContent(EdgeRemoteSupportSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EdgeRemoteSupportSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EdgeRemoteSupportSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdgeRemoteSupportSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
