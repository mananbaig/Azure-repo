// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class RuntimeScriptAction : IUtf8JsonSerializable, IJsonModel<RuntimeScriptAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuntimeScriptAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RuntimeScriptAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RuntimeScriptAction>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RuntimeScriptAction>)} interface");
            }

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
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ApplicationName))
                {
                    writer.WritePropertyName("applicationName"u8);
                    writer.WriteStringValue(ApplicationName);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RuntimeScriptAction IJsonModel<RuntimeScriptAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RuntimeScriptAction)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuntimeScriptAction(document.RootElement, options);
        }

        internal static RuntimeScriptAction DeserializeRuntimeScriptAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Uri uri = default;
            Optional<string> parameters = default;
            IList<string> roles = default;
            Optional<string> applicationName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RuntimeScriptAction(name, uri, parameters.Value, roles, applicationName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RuntimeScriptAction>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RuntimeScriptAction)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RuntimeScriptAction IPersistableModel<RuntimeScriptAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RuntimeScriptAction)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRuntimeScriptAction(document.RootElement, options);
        }

        string IPersistableModel<RuntimeScriptAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
