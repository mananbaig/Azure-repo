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

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxDeploymentUpdateProperties : IUtf8JsonSerializable, IModelJsonSerializable<NginxDeploymentUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NginxDeploymentUpdateProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NginxDeploymentUpdateProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableDiagnosticsSupport))
            {
                writer.WritePropertyName("enableDiagnosticsSupport"u8);
                writer.WriteBooleanValue(EnableDiagnosticsSupport.Value);
            }
            if (Optional.IsDefined(Logging))
            {
                writer.WritePropertyName("logging"u8);
                if (Logging is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NginxLogging>)Logging).Serialize(writer, options);
                }
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

        internal static NginxDeploymentUpdateProperties DeserializeNginxDeploymentUpdateProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enableDiagnosticsSupport = default;
            Optional<NginxLogging> logging = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDiagnosticsSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDiagnosticsSupport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("logging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logging = NginxLogging.DeserializeNginxLogging(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NginxDeploymentUpdateProperties(Optional.ToNullable(enableDiagnosticsSupport), logging.Value, rawData);
        }

        NginxDeploymentUpdateProperties IModelJsonSerializable<NginxDeploymentUpdateProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxDeploymentUpdateProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NginxDeploymentUpdateProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NginxDeploymentUpdateProperties IModelSerializable<NginxDeploymentUpdateProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNginxDeploymentUpdateProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NginxDeploymentUpdateProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NginxDeploymentUpdateProperties"/> to convert. </param>
        public static implicit operator RequestContent(NginxDeploymentUpdateProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NginxDeploymentUpdateProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NginxDeploymentUpdateProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNginxDeploymentUpdateProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
