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
    public partial class DataFactoryDataFlowStartDebugSessionResult : IUtf8JsonSerializable, IModelJsonSerializable<DataFactoryDataFlowStartDebugSessionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFactoryDataFlowStartDebugSessionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFactoryDataFlowStartDebugSessionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JobVersion))
            {
                writer.WritePropertyName("jobVersion"u8);
                writer.WriteStringValue(JobVersion);
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

        internal static DataFactoryDataFlowStartDebugSessionResult DeserializeDataFactoryDataFlowStartDebugSessionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jobVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobVersion"u8))
                {
                    jobVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataFactoryDataFlowStartDebugSessionResult(jobVersion.Value, rawData);
        }

        DataFactoryDataFlowStartDebugSessionResult IModelJsonSerializable<DataFactoryDataFlowStartDebugSessionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataFlowStartDebugSessionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFactoryDataFlowStartDebugSessionResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFactoryDataFlowStartDebugSessionResult IModelSerializable<DataFactoryDataFlowStartDebugSessionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFactoryDataFlowStartDebugSessionResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFactoryDataFlowStartDebugSessionResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFactoryDataFlowStartDebugSessionResult"/> to convert. </param>
        public static implicit operator RequestContent(DataFactoryDataFlowStartDebugSessionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFactoryDataFlowStartDebugSessionResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFactoryDataFlowStartDebugSessionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFactoryDataFlowStartDebugSessionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
