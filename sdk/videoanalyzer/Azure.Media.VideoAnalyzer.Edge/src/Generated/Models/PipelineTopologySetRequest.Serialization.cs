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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class PipelineTopologySetRequest : IUtf8JsonSerializable, IModelJsonSerializable<PipelineTopologySetRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PipelineTopologySetRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PipelineTopologySetRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PipelineTopologySetRequest>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("pipelineTopology"u8);
            if (PipelineTopology is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<PipelineTopology>)PipelineTopology).Serialize(writer, options);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        internal static PipelineTopologySetRequest DeserializePipelineTopologySetRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PipelineTopology pipelineTopology = default;
            string methodName = default;
            Optional<string> apiVersion = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineTopology"u8))
                {
                    pipelineTopology = PipelineTopology.DeserializePipelineTopology(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PipelineTopologySetRequest(methodName, apiVersion.Value, pipelineTopology, serializedAdditionalRawData);
        }

        PipelineTopologySetRequest IModelJsonSerializable<PipelineTopologySetRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PipelineTopologySetRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineTopologySetRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PipelineTopologySetRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PipelineTopologySetRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PipelineTopologySetRequest IModelSerializable<PipelineTopologySetRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PipelineTopologySetRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePipelineTopologySetRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PipelineTopologySetRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PipelineTopologySetRequest"/> to convert. </param>
        public static implicit operator RequestContent(PipelineTopologySetRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PipelineTopologySetRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PipelineTopologySetRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePipelineTopologySetRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
