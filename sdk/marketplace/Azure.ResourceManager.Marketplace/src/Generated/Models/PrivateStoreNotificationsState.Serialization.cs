// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PrivateStoreNotificationsState : IUtf8JsonSerializable, IJsonModel<PrivateStoreNotificationsState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStoreNotificationsState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateStoreNotificationsState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreNotificationsState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StopSellNotifications))
            {
                writer.WritePropertyName("stopSellNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in StopSellNotifications)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NewNotifications))
            {
                writer.WritePropertyName("newNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in NewNotifications)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApprovalRequests))
            {
                writer.WritePropertyName("approvalRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ApprovalRequests)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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

        PrivateStoreNotificationsState IJsonModel<PrivateStoreNotificationsState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreNotificationsState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreNotificationsState(document.RootElement, options);
        }

        internal static PrivateStoreNotificationsState DeserializePrivateStoreNotificationsState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<StopSellNotifications> stopSellNotifications = default;
            IReadOnlyList<NewPlanNotification> newNotifications = default;
            IReadOnlyList<RequestApprovalsDetails> approvalRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopSellNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StopSellNotifications> array = new List<StopSellNotifications>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.StopSellNotifications.DeserializeStopSellNotifications(item, options));
                    }
                    stopSellNotifications = array;
                    continue;
                }
                if (property.NameEquals("newNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewPlanNotification> array = new List<NewPlanNotification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewPlanNotification.DeserializeNewPlanNotification(item, options));
                    }
                    newNotifications = array;
                    continue;
                }
                if (property.NameEquals("approvalRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RequestApprovalsDetails> array = new List<RequestApprovalsDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RequestApprovalsDetails.DeserializeRequestApprovalsDetails(item, options));
                    }
                    approvalRequests = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateStoreNotificationsState(stopSellNotifications ?? new ChangeTrackingList<StopSellNotifications>(), newNotifications ?? new ChangeTrackingList<NewPlanNotification>(), approvalRequests ?? new ChangeTrackingList<RequestApprovalsDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateStoreNotificationsState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreNotificationsState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateStoreNotificationsState IPersistableModel<PrivateStoreNotificationsState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreNotificationsState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateStoreNotificationsState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreNotificationsState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateStoreNotificationsState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
