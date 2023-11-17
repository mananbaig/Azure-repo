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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HDInsightIdentityProfile : IUtf8JsonSerializable, IJsonModel<HDInsightIdentityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightIdentityProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightIdentityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HDInsightIdentityProfile>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HDInsightIdentityProfile>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("msiResourceId"u8);
            writer.WriteStringValue(MsiResourceId);
            writer.WritePropertyName("msiClientId"u8);
            writer.WriteStringValue(MsiClientId);
            writer.WritePropertyName("msiObjectId"u8);
            writer.WriteStringValue(MsiObjectId);
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

        HDInsightIdentityProfile IJsonModel<HDInsightIdentityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightIdentityProfile(document.RootElement, options);
        }

        internal static HDInsightIdentityProfile DeserializeHDInsightIdentityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier msiResourceId = default;
            string msiClientId = default;
            string msiObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("msiResourceId"u8))
                {
                    msiResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("msiClientId"u8))
                {
                    msiClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("msiObjectId"u8))
                {
                    msiObjectId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightIdentityProfile(msiResourceId, msiClientId, msiObjectId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightIdentityProfile>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HDInsightIdentityProfile IPersistableModel<HDInsightIdentityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightIdentityProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHDInsightIdentityProfile(document.RootElement, options);
        }

        string IPersistableModel<HDInsightIdentityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
