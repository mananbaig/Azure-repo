// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    [ModelReaderProxy(typeof(UnknownPartition))]
    public partial class ManagedServicePartitionScheme : IUtf8JsonSerializable, IJsonModel<ManagedServicePartitionScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicePartitionScheme>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ManagedServicePartitionScheme>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ManagedServicePartitionScheme IJsonModel<ManagedServicePartitionScheme>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicePartitionScheme)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicePartitionScheme(document.RootElement, options);
        }

        internal static ManagedServicePartitionScheme DeserializeManagedServicePartitionScheme(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("partitionScheme", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Named": return NamedPartitionScheme.DeserializeNamedPartitionScheme(element);
                    case "Singleton": return SingletonPartitionScheme.DeserializeSingletonPartitionScheme(element);
                    case "UniformInt64Range": return UniformInt64RangePartitionScheme.DeserializeUniformInt64RangePartitionScheme(element);
                }
            }
            return UnknownPartition.DeserializeUnknownPartition(element);
        }

        BinaryData IModel<ManagedServicePartitionScheme>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicePartitionScheme)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedServicePartitionScheme IModel<ManagedServicePartitionScheme>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServicePartitionScheme)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedServicePartitionScheme(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ManagedServicePartitionScheme>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
