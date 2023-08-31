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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspaceGetNotebookKeysResult : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningWorkspaceGetNotebookKeysResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningWorkspaceGetNotebookKeysResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningWorkspaceGetNotebookKeysResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static MachineLearningWorkspaceGetNotebookKeysResult DeserializeMachineLearningWorkspaceGetNotebookKeysResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryAccessKey = default;
            Optional<string> secondaryAccessKey = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryAccessKey"u8))
                {
                    primaryAccessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryAccessKey"u8))
                {
                    secondaryAccessKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningWorkspaceGetNotebookKeysResult(primaryAccessKey.Value, secondaryAccessKey.Value, rawData);
        }

        MachineLearningWorkspaceGetNotebookKeysResult IModelJsonSerializable<MachineLearningWorkspaceGetNotebookKeysResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspaceGetNotebookKeysResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningWorkspaceGetNotebookKeysResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningWorkspaceGetNotebookKeysResult IModelSerializable<MachineLearningWorkspaceGetNotebookKeysResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningWorkspaceGetNotebookKeysResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningWorkspaceGetNotebookKeysResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningWorkspaceGetNotebookKeysResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningWorkspaceGetNotebookKeysResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
