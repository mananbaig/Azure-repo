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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BareMetalMachineRunDataExtractsContent : IUtf8JsonSerializable, IModelJsonSerializable<BareMetalMachineRunDataExtractsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BareMetalMachineRunDataExtractsContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BareMetalMachineRunDataExtractsContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("commands"u8);
            writer.WriteStartArray();
            foreach (var item in Commands)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BareMetalMachineCommandSpecification>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("limitTimeSeconds"u8);
            writer.WriteNumberValue(LimitTimeSeconds);
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

        internal static BareMetalMachineRunDataExtractsContent DeserializeBareMetalMachineRunDataExtractsContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BareMetalMachineCommandSpecification> commands = default;
            long limitTimeSeconds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commands"u8))
                {
                    List<BareMetalMachineCommandSpecification> array = new List<BareMetalMachineCommandSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BareMetalMachineCommandSpecification.DeserializeBareMetalMachineCommandSpecification(item));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("limitTimeSeconds"u8))
                {
                    limitTimeSeconds = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BareMetalMachineRunDataExtractsContent(commands, limitTimeSeconds, rawData);
        }

        BareMetalMachineRunDataExtractsContent IModelJsonSerializable<BareMetalMachineRunDataExtractsContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBareMetalMachineRunDataExtractsContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BareMetalMachineRunDataExtractsContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BareMetalMachineRunDataExtractsContent IModelSerializable<BareMetalMachineRunDataExtractsContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBareMetalMachineRunDataExtractsContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BareMetalMachineRunDataExtractsContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BareMetalMachineRunDataExtractsContent"/> to convert. </param>
        public static implicit operator RequestContent(BareMetalMachineRunDataExtractsContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BareMetalMachineRunDataExtractsContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BareMetalMachineRunDataExtractsContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBareMetalMachineRunDataExtractsContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
