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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryIntegrationRuntimeDebugInfo : IUtf8JsonSerializable, IModelJsonSerializable<DataFactoryIntegrationRuntimeDebugInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFactoryIntegrationRuntimeDebugInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFactoryIntegrationRuntimeDebugInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataFactoryIntegrationRuntimeDebugInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static DataFactoryIntegrationRuntimeDebugInfo DeserializeDataFactoryIntegrationRuntimeDebugInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryIntegrationRuntimeProperties properties = default;
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = DataFactoryIntegrationRuntimeProperties.DeserializeDataFactoryIntegrationRuntimeProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataFactoryIntegrationRuntimeDebugInfo(name.Value, properties, rawData);
        }

        DataFactoryIntegrationRuntimeDebugInfo IModelJsonSerializable<DataFactoryIntegrationRuntimeDebugInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataFactoryIntegrationRuntimeDebugInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryIntegrationRuntimeDebugInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFactoryIntegrationRuntimeDebugInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataFactoryIntegrationRuntimeDebugInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFactoryIntegrationRuntimeDebugInfo IModelSerializable<DataFactoryIntegrationRuntimeDebugInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataFactoryIntegrationRuntimeDebugInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFactoryIntegrationRuntimeDebugInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataFactoryIntegrationRuntimeDebugInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataFactoryIntegrationRuntimeDebugInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFactoryIntegrationRuntimeDebugInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
