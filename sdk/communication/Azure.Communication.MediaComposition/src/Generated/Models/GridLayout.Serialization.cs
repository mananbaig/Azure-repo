// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.MediaComposition
{
    public partial class GridLayout : IUtf8JsonSerializable, IModelJsonSerializable<GridLayout>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GridLayout>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GridLayout>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GridLayout>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("rows"u8);
            writer.WriteNumberValue(Rows);
            writer.WritePropertyName("columns"u8);
            writer.WriteNumberValue(Columns);
            writer.WritePropertyName("inputIds"u8);
            writer.WriteStartArray();
            foreach (var item in InputIds)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    writer.WriteStringValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution"u8);
                writer.WriteObjectValue(Resolution);
            }
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            if (Optional.IsDefined(ScalingMode))
            {
                writer.WritePropertyName("scalingMode"u8);
                writer.WriteStringValue(ScalingMode.Value.ToString());
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static GridLayout DeserializeGridLayout(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rows = default;
            int columns = default;
            IList<IList<string>> inputIds = default;
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            Optional<ScalingMode> scalingMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"u8))
                {
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"u8))
                {
                    columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inputIds"u8))
                {
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<string> array0 = new List<string>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetString());
                            }
                            array.Add(array0);
                        }
                    }
                    inputIds = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scalingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingMode = new ScalingMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GridLayout(kind, resolution.Value, placeholderImageUri.Value, Optional.ToNullable(scalingMode), rows, columns, inputIds, rawData);
        }

        GridLayout IModelJsonSerializable<GridLayout>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GridLayout>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGridLayout(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GridLayout>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GridLayout>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GridLayout IModelSerializable<GridLayout>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GridLayout>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGridLayout(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GridLayout model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GridLayout(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGridLayout(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
