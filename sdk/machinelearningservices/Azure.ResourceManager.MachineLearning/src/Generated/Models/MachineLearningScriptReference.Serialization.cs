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
    public partial class MachineLearningScriptReference : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningScriptReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningScriptReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningScriptReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ScriptSource))
            {
                writer.WritePropertyName("scriptSource"u8);
                writer.WriteStringValue(ScriptSource);
            }
            if (Optional.IsDefined(ScriptData))
            {
                writer.WritePropertyName("scriptData"u8);
                writer.WriteStringValue(ScriptData);
            }
            if (Optional.IsDefined(ScriptArguments))
            {
                writer.WritePropertyName("scriptArguments"u8);
                writer.WriteStringValue(ScriptArguments);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout);
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

        internal static MachineLearningScriptReference DeserializeMachineLearningScriptReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> scriptSource = default;
            Optional<string> scriptData = default;
            Optional<string> scriptArguments = default;
            Optional<string> timeout = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptSource"u8))
                {
                    scriptSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptData"u8))
                {
                    scriptData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptArguments"u8))
                {
                    scriptArguments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    timeout = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningScriptReference(scriptSource.Value, scriptData.Value, scriptArguments.Value, timeout.Value, rawData);
        }

        MachineLearningScriptReference IModelJsonSerializable<MachineLearningScriptReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningScriptReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningScriptReference>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningScriptReference IModelSerializable<MachineLearningScriptReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningScriptReference(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningScriptReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningScriptReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningScriptReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
