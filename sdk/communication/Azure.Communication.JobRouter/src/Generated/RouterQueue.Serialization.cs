// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RouterQueue : IUtf8JsonSerializable, IJsonModel<RouterQueue>
    {
        void IJsonModel<RouterQueue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RouterQueue>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RouterQueue>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(_etag);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DistributionPolicyId))
            {
                writer.WritePropertyName("distributionPolicyId"u8);
                writer.WriteStringValue(DistributionPolicyId);
            }
            if (Optional.IsCollectionDefined(_labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in _labels)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ExceptionPolicyId))
            {
                writer.WritePropertyName("exceptionPolicyId"u8);
                writer.WriteStringValue(ExceptionPolicyId);
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

        RouterQueue IJsonModel<RouterQueue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouterQueue)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterQueue(document.RootElement, options);
        }

        internal static RouterQueue DeserializeRouterQueue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string etag = default;
            string id = default;
            Optional<string> name = default;
            Optional<string> distributionPolicyId = default;
            Optional<IDictionary<string, object>> labels = default;
            Optional<string> exceptionPolicyId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributionPolicyId"u8))
                {
                    distributionPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("exceptionPolicyId"u8))
                {
                    exceptionPolicyId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouterQueue(etag, id, name.Value, distributionPolicyId.Value, Optional.ToDictionary(labels), exceptionPolicyId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterQueue>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouterQueue)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RouterQueue IPersistableModel<RouterQueue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RouterQueue)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRouterQueue(document.RootElement, options);
        }

        string IPersistableModel<RouterQueue>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterQueue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterQueue(document.RootElement, ModelReaderWriterOptions.Wire);
        }
    }
}
