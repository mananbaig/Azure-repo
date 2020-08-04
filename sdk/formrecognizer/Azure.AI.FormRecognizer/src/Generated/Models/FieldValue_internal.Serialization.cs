// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class FieldValue_internal
    {
        internal static FieldValue_internal DeserializeFieldValue_internal(JsonElement element)
        {
            FieldValueType type = default;
            Optional<string> valueString = default;
            Optional<DateTimeOffset> valueDate = default;
            Optional<TimeSpan> valueTime = default;
            Optional<string> valuePhoneNumber = default;
            Optional<float> valueNumber = default;
            Optional<long> valueInteger = default;
            Optional<IReadOnlyList<FieldValue_internal>> valueArray = default;
            Optional<IReadOnlyDictionary<string, FieldValue_internal>> valueObject = default;
            Optional<string> text = default;
            Optional<IReadOnlyList<float>> boundingBox = default;
            Optional<float> confidence = default;
            Optional<IReadOnlyList<string>> elements = default;
            Optional<int> page = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToFieldValueType();
                    continue;
                }
                if (property.NameEquals("valueString"))
                {
                    valueString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueDate"))
                {
                    valueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("valueTime"))
                {
                    valueTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("valuePhoneNumber"))
                {
                    valuePhoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueNumber"))
                {
                    valueNumber = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("valueInteger"))
                {
                    valueInteger = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("valueArray"))
                {
                    List<FieldValue_internal> array = new List<FieldValue_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeFieldValue_internal(item));
                    }
                    valueArray = array;
                    continue;
                }
                if (property.NameEquals("valueObject"))
                {
                    Dictionary<string, FieldValue_internal> dictionary = new Dictionary<string, FieldValue_internal>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeFieldValue_internal(property0.Value));
                    }
                    valueObject = dictionary;
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elements"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    elements = array;
                    continue;
                }
                if (property.NameEquals("page"))
                {
                    page = property.Value.GetInt32();
                    continue;
                }
            }
            return new FieldValue_internal(type, valueString.Value, Optional.ToNullable(valueDate), Optional.ToNullable(valueTime), valuePhoneNumber.Value, Optional.ToNullable(valueNumber), Optional.ToNullable(valueInteger), Optional.ToList(valueArray), Optional.ToDictionary(valueObject), text.Value, Optional.ToList(boundingBox), Optional.ToNullable(confidence), Optional.ToList(elements), Optional.ToNullable(page));
        }
    }
}
