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

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobInputHttp : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobInputHttp>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobInputHttp>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobInputHttp>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobInputHttp>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BaseUri))
            {
                writer.WritePropertyName("baseUri"u8);
                writer.WriteStringValue(BaseUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteObjectValue(Start);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteObjectValue(End);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(InputDefinitions))
            {
                writer.WritePropertyName("inputDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in InputDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static MediaJobInputHttp DeserializeMediaJobInputHttp(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> baseUri = default;
            Optional<IList<string>> files = default;
            Optional<ClipTime> start = default;
            Optional<ClipTime> end = default;
            Optional<string> label = default;
            Optional<IList<MediaJobInputDefinition>> inputDefinitions = default;
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = ClipTime.DeserializeClipTime(property.Value);
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = ClipTime.DeserializeClipTime(property.Value);
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDefinitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobInputDefinition> array = new List<MediaJobInputDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobInputDefinition.DeserializeMediaJobInputDefinition(item));
                    }
                    inputDefinitions = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobInputHttp(odataType, Optional.ToList(files), start.Value, end.Value, label.Value, Optional.ToList(inputDefinitions), baseUri.Value, rawData);
        }

        MediaJobInputHttp IModelJsonSerializable<MediaJobInputHttp>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobInputHttp>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobInputHttp(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobInputHttp>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobInputHttp>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobInputHttp IModelSerializable<MediaJobInputHttp>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobInputHttp>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobInputHttp(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaJobInputHttp model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaJobInputHttp(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobInputHttp(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
