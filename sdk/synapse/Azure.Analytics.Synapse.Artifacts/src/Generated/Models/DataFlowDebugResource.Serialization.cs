// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowDebugResourceConverter))]
    public partial class DataFlowDebugResource : IUtf8JsonSerializable, IModelJsonSerializable<DataFlowDebugResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFlowDebugResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFlowDebugResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugResource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DataFlow>)Properties).Serialize(writer, options);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static DataFlowDebugResource DeserializeDataFlowDebugResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFlow properties = default;
            Optional<string> name = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = DataFlow.DeserializeDataFlow(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataFlowDebugResource(name.Value, properties, serializedAdditionalRawData);
        }

        DataFlowDebugResource IModelJsonSerializable<DataFlowDebugResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowDebugResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFlowDebugResource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFlowDebugResource IModelSerializable<DataFlowDebugResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFlowDebugResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFlowDebugResource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFlowDebugResource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFlowDebugResource"/> to convert. </param>
        public static implicit operator RequestContent(DataFlowDebugResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFlowDebugResource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFlowDebugResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFlowDebugResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DataFlowDebugResourceConverter : JsonConverter<DataFlowDebugResource>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugResource(document.RootElement);
            }
        }
    }
}
