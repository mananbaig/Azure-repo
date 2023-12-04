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

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class RoleAssignmentListResult : IUtf8JsonSerializable, IJsonModel<RoleAssignmentListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleAssignmentListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleAssignmentListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RoleAssignmentListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("roleAssignmentResponse"u8);
            writer.WriteStartArray();
            foreach (var item in RoleAssignmentResponse)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        RoleAssignmentListResult IJsonModel<RoleAssignmentListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RoleAssignmentListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleAssignmentListResult(document.RootElement, options);
        }

        internal static RoleAssignmentListResult DeserializeRoleAssignmentListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            IReadOnlyList<RoleAssignmentDetail> roleAssignmentResponse = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("roleAssignmentResponse"u8))
                {
                    List<RoleAssignmentDetail> array = new List<RoleAssignmentDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleAssignmentDetail.DeserializeRoleAssignmentDetail(item));
                    }
                    roleAssignmentResponse = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoleAssignmentListResult(count, roleAssignmentResponse, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleAssignmentListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RoleAssignmentListResult)} does not support '{options.Format}' format.");
            }
        }

        RoleAssignmentListResult IPersistableModel<RoleAssignmentListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleAssignmentListResult(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RoleAssignmentListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleAssignmentListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
