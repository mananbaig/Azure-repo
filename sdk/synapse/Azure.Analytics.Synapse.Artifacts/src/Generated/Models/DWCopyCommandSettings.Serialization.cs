// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DWCopyCommandSettingsConverter))]
    public partial class DWCopyCommandSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DefaultValues))
            {
                writer.WritePropertyName("defaultValues"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalOptions))
            {
                writer.WritePropertyName("additionalOptions"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalOptions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static DWCopyCommandSettings DeserializeDWCopyCommandSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DWCopyCommandDefaultValue> defaultValues = default;
            IDictionary<string, string> additionalOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DWCopyCommandDefaultValue> array = new List<DWCopyCommandDefaultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DWCopyCommandDefaultValue.DeserializeDWCopyCommandDefaultValue(item));
                    }
                    defaultValues = array;
                    continue;
                }
                if (property.NameEquals("additionalOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalOptions = dictionary;
                    continue;
                }
            }
            return new DWCopyCommandSettings(defaultValues ?? new ChangeTrackingList<DWCopyCommandDefaultValue>(), additionalOptions ?? new ChangeTrackingDictionary<string, string>());
        }

        internal partial class DWCopyCommandSettingsConverter : JsonConverter<DWCopyCommandSettings>
        {
            public override void Write(Utf8JsonWriter writer, DWCopyCommandSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DWCopyCommandSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDWCopyCommandSettings(document.RootElement);
            }
        }
    }
}
