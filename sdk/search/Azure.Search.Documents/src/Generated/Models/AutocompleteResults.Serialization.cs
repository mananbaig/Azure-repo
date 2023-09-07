// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Search.Documents.Models
{
    public partial class AutocompleteResults : IUtf8JsonSerializable, IModelJsonSerializable<AutocompleteResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutocompleteResults>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutocompleteResults>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutocompleteResults>(this, options.Format);

            writer.WriteStartObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AutocompleteResults DeserializeAutocompleteResults(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> searchCoverage = default;
            IReadOnlyList<AutocompleteItem> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.coverage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<AutocompleteItem> array = new List<AutocompleteItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutocompleteItem.DeserializeAutocompleteItem(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutocompleteResults(Optional.ToNullable(searchCoverage), value, serializedAdditionalRawData);
        }

        AutocompleteResults IModelJsonSerializable<AutocompleteResults>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutocompleteResults>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutocompleteResults(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutocompleteResults>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutocompleteResults>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutocompleteResults IModelSerializable<AutocompleteResults>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutocompleteResults>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutocompleteResults(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutocompleteResults"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutocompleteResults"/> to convert. </param>
        public static implicit operator RequestContent(AutocompleteResults model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutocompleteResults"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutocompleteResults(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutocompleteResults(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
