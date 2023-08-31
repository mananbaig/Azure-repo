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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CustomEventsTrigger : IUtf8JsonSerializable, IModelJsonSerializable<CustomEventsTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomEventsTrigger>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomEventsTrigger>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomEventsTrigger>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Pipelines))
            {
                writer.WritePropertyName("pipelines"u8);
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SubjectBeginsWith))
            {
                writer.WritePropertyName("subjectBeginsWith"u8);
                writer.WriteStringValue(SubjectBeginsWith);
            }
            if (Optional.IsDefined(SubjectEndsWith))
            {
                writer.WritePropertyName("subjectEndsWith"u8);
                writer.WriteStringValue(SubjectEndsWith);
            }
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
            }
            writer.WriteEndArray();
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CustomEventsTrigger DeserializeCustomEventsTrigger(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TriggerPipelineReference>> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryTriggerRuntimeState> runtimeState = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<string> subjectBeginsWith = default;
            Optional<string> subjectEndsWith = default;
            IList<BinaryData> events = default;
            string scope = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item));
                    }
                    pipelines = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new DataFactoryTriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subjectBeginsWith"u8))
                        {
                            subjectBeginsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subjectEndsWith"u8))
                        {
                            subjectEndsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("events"u8))
                        {
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            events = array;
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CustomEventsTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, Optional.ToList(pipelines), subjectBeginsWith.Value, subjectEndsWith.Value, events, scope);
        }

        CustomEventsTrigger IModelJsonSerializable<CustomEventsTrigger>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomEventsTrigger>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomEventsTrigger(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomEventsTrigger>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomEventsTrigger>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomEventsTrigger IModelSerializable<CustomEventsTrigger>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomEventsTrigger>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomEventsTrigger(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CustomEventsTrigger model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CustomEventsTrigger(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomEventsTrigger(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
