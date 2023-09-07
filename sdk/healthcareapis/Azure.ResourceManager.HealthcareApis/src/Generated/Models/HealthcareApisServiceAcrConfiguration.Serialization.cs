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

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceAcrConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<HealthcareApisServiceAcrConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HealthcareApisServiceAcrConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HealthcareApisServiceAcrConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceAcrConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoginServers))
            {
                writer.WritePropertyName("loginServers"u8);
                writer.WriteStartArray();
                foreach (var item in LoginServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OciArtifacts))
            {
                writer.WritePropertyName("ociArtifacts"u8);
                writer.WriteStartArray();
                foreach (var item in OciArtifacts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HealthcareApisServiceOciArtifactEntry>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static HealthcareApisServiceAcrConfiguration DeserializeHealthcareApisServiceAcrConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> loginServers = default;
            Optional<IList<HealthcareApisServiceOciArtifactEntry>> ociArtifacts = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    loginServers = array;
                    continue;
                }
                if (property.NameEquals("ociArtifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisServiceOciArtifactEntry> array = new List<HealthcareApisServiceOciArtifactEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisServiceOciArtifactEntry.DeserializeHealthcareApisServiceOciArtifactEntry(item));
                    }
                    ociArtifacts = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HealthcareApisServiceAcrConfiguration(Optional.ToList(loginServers), Optional.ToList(ociArtifacts), serializedAdditionalRawData);
        }

        HealthcareApisServiceAcrConfiguration IModelJsonSerializable<HealthcareApisServiceAcrConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceAcrConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceAcrConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HealthcareApisServiceAcrConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceAcrConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HealthcareApisServiceAcrConfiguration IModelSerializable<HealthcareApisServiceAcrConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HealthcareApisServiceAcrConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHealthcareApisServiceAcrConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HealthcareApisServiceAcrConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HealthcareApisServiceAcrConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(HealthcareApisServiceAcrConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HealthcareApisServiceAcrConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HealthcareApisServiceAcrConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHealthcareApisServiceAcrConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
