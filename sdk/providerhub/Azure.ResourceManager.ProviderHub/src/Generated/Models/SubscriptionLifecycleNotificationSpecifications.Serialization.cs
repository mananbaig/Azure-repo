// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class SubscriptionLifecycleNotificationSpecifications : IUtf8JsonSerializable, IJsonModel<SubscriptionLifecycleNotificationSpecifications>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionLifecycleNotificationSpecifications>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SubscriptionLifecycleNotificationSpecifications>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SubscriptionLifecycleNotificationSpecifications>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SubscriptionLifecycleNotificationSpecifications>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SubscriptionStateOverrideActions))
            {
                writer.WritePropertyName("subscriptionStateOverrideActions"u8);
                writer.WriteStartArray();
                foreach (var item in SubscriptionStateOverrideActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SoftDeleteTtl))
            {
                writer.WritePropertyName("softDeleteTTL"u8);
                writer.WriteStringValue(SoftDeleteTtl.Value, "P");
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

        SubscriptionLifecycleNotificationSpecifications IJsonModel<SubscriptionLifecycleNotificationSpecifications>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionLifecycleNotificationSpecifications)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionLifecycleNotificationSpecifications(document.RootElement, options);
        }

        internal static SubscriptionLifecycleNotificationSpecifications DeserializeSubscriptionLifecycleNotificationSpecifications(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SubscriptionStateOverrideAction>> subscriptionStateOverrideActions = default;
            Optional<TimeSpan> softDeleteTtl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionStateOverrideActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubscriptionStateOverrideAction> array = new List<SubscriptionStateOverrideAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubscriptionStateOverrideAction.DeserializeSubscriptionStateOverrideAction(item));
                    }
                    subscriptionStateOverrideActions = array;
                    continue;
                }
                if (property.NameEquals("softDeleteTTL"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteTtl = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionLifecycleNotificationSpecifications(Optional.ToList(subscriptionStateOverrideActions), Optional.ToNullable(softDeleteTtl), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionLifecycleNotificationSpecifications>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionLifecycleNotificationSpecifications)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SubscriptionLifecycleNotificationSpecifications IPersistableModel<SubscriptionLifecycleNotificationSpecifications>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionLifecycleNotificationSpecifications)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSubscriptionLifecycleNotificationSpecifications(document.RootElement, options);
        }

        string IPersistableModel<SubscriptionLifecycleNotificationSpecifications>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
