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

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    public partial class ContainerServiceFleetUpdateGroupStatus : IUtf8JsonSerializable, IJsonModel<ContainerServiceFleetUpdateGroupStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceFleetUpdateGroupStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceFleetUpdateGroupStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ContainerServiceFleetUpdateGroupStatus>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ContainerServiceFleetUpdateGroupStatus>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteObjectValue(Status);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Members))
                {
                    writer.WritePropertyName("members"u8);
                    writer.WriteStartArray();
                    foreach (var item in Members)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
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

        ContainerServiceFleetUpdateGroupStatus IJsonModel<ContainerServiceFleetUpdateGroupStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateGroupStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceFleetUpdateGroupStatus(document.RootElement, options);
        }

        internal static ContainerServiceFleetUpdateGroupStatus DeserializeContainerServiceFleetUpdateGroupStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerServiceFleetUpdateStatus> status = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<MemberUpdateStatus>> members = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ContainerServiceFleetUpdateStatus.DeserializeContainerServiceFleetUpdateStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("members"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MemberUpdateStatus> array = new List<MemberUpdateStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MemberUpdateStatus.DeserializeMemberUpdateStatus(item));
                    }
                    members = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceFleetUpdateGroupStatus(status.Value, name.Value, Optional.ToList(members), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceFleetUpdateGroupStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateGroupStatus)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ContainerServiceFleetUpdateGroupStatus IPersistableModel<ContainerServiceFleetUpdateGroupStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateGroupStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeContainerServiceFleetUpdateGroupStatus(document.RootElement, options);
        }

        string IPersistableModel<ContainerServiceFleetUpdateGroupStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
