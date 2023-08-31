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
    public partial class TriggerDependencyReference : IUtf8JsonSerializable, IModelJsonSerializable<TriggerDependencyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggerDependencyReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggerDependencyReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("referenceTrigger"u8);
            writer.WriteObjectValue(ReferenceTrigger);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DependencyReferenceType);
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

        internal static TriggerDependencyReference DeserializeTriggerDependencyReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "TumblingWindowTriggerDependencyReference": return TumblingWindowTriggerDependencyReference.DeserializeTumblingWindowTriggerDependencyReference(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataFactoryTriggerReference referenceTrigger = default;
            string type = "TriggerDependencyReference";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referenceTrigger"u8))
                {
                    referenceTrigger = DataFactoryTriggerReference.DeserializeDataFactoryTriggerReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TriggerDependencyReference(type, referenceTrigger, rawData);
        }

        TriggerDependencyReference IModelJsonSerializable<TriggerDependencyReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerDependencyReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggerDependencyReference>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggerDependencyReference IModelSerializable<TriggerDependencyReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TriggerDependencyReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggerDependencyReference(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TriggerDependencyReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TriggerDependencyReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggerDependencyReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
