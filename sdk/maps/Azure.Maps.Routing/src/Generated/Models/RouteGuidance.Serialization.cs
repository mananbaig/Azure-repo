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

namespace Azure.Maps.Routing.Models
{
    public partial class RouteGuidance : IUtf8JsonSerializable, IModelJsonSerializable<RouteGuidance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouteGuidance>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouteGuidance>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static RouteGuidance DeserializeRouteGuidance(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RouteInstruction>> instructions = default;
            Optional<IReadOnlyList<RouteInstructionGroup>> instructionGroups = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteInstruction> array = new List<RouteInstruction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteInstruction.DeserializeRouteInstruction(item));
                    }
                    instructions = array;
                    continue;
                }
                if (property.NameEquals("instructionGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteInstructionGroup> array = new List<RouteInstructionGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteInstructionGroup.DeserializeRouteInstructionGroup(item));
                    }
                    instructionGroups = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouteGuidance(Optional.ToList(instructions), Optional.ToList(instructionGroups), rawData);
        }

        RouteGuidance IModelJsonSerializable<RouteGuidance>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteGuidance(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouteGuidance>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouteGuidance IModelSerializable<RouteGuidance>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouteGuidance(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RouteGuidance model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RouteGuidance(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouteGuidance(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
