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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class RuntimeScriptAction : IUtf8JsonSerializable, IModelJsonSerializable<RuntimeScriptAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RuntimeScriptAction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RuntimeScriptAction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RuntimeScriptAction>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStringValue(Parameters);
            }
            writer.WritePropertyName("roles"u8);
            writer.WriteStartArray();
            foreach (var item in Roles)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static RuntimeScriptAction DeserializeRuntimeScriptAction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Uri uri = default;
            Optional<string> parameters = default;
            IList<string> roles = default;
            Optional<string> applicationName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    parameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    roles = array;
                    continue;
                }
                if (property.NameEquals("applicationName"u8))
                {
                    applicationName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RuntimeScriptAction(name, uri, parameters.Value, roles, applicationName.Value, serializedAdditionalRawData);
        }

        RuntimeScriptAction IModelJsonSerializable<RuntimeScriptAction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RuntimeScriptAction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRuntimeScriptAction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RuntimeScriptAction>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RuntimeScriptAction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RuntimeScriptAction IModelSerializable<RuntimeScriptAction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RuntimeScriptAction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRuntimeScriptAction(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RuntimeScriptAction"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RuntimeScriptAction"/> to convert. </param>
        public static implicit operator RequestContent(RuntimeScriptAction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RuntimeScriptAction"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RuntimeScriptAction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRuntimeScriptAction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
