// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    [PersistableModelProxy(typeof(UnknownServicePlacementPolicy))]
    public partial class ManagedServicePlacementPolicy : IUtf8JsonSerializable, IJsonModel<ManagedServicePlacementPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicePlacementPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServicePlacementPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ServicePlacementPolicyType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        ManagedServicePlacementPolicy IJsonModel<ManagedServicePlacementPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicePlacementPolicy(document.RootElement, options);
        }

        internal static ManagedServicePlacementPolicy DeserializeManagedServicePlacementPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "InvalidDomain": return ServicePlacementInvalidDomainPolicy.DeserializeServicePlacementInvalidDomainPolicy(element);
                    case "NonPartiallyPlaceService": return ServicePlacementNonPartiallyPlaceServicePolicy.DeserializeServicePlacementNonPartiallyPlaceServicePolicy(element);
                    case "PreferredPrimaryDomain": return ServicePlacementPreferPrimaryDomainPolicy.DeserializeServicePlacementPreferPrimaryDomainPolicy(element);
                    case "RequiredDomain": return ServicePlacementRequiredDomainPolicy.DeserializeServicePlacementRequiredDomainPolicy(element);
                    case "RequiredDomainDistribution": return ServicePlacementRequireDomainDistributionPolicy.DeserializeServicePlacementRequireDomainDistributionPolicy(element);
                }
            }
            return UnknownServicePlacementPolicy.DeserializeUnknownServicePlacementPolicy(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ServicePlacementPolicyType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ServicePlacementPolicyType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ManagedServicePlacementPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support '{options.Format}' format.");
            }
        }

        ManagedServicePlacementPolicy IPersistableModel<ManagedServicePlacementPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicePlacementPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServicePlacementPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedServicePlacementPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServicePlacementPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
