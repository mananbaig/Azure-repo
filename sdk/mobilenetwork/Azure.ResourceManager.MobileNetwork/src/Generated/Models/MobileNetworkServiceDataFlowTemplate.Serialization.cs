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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkServiceDataFlowTemplate : IUtf8JsonSerializable, IModelJsonSerializable<MobileNetworkServiceDataFlowTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MobileNetworkServiceDataFlowTemplate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MobileNetworkServiceDataFlowTemplate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("templateName"u8);
            writer.WriteStringValue(TemplateName);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol"u8);
            writer.WriteStartArray();
            foreach (var item in Protocol)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("remoteIpList"u8);
            writer.WriteStartArray();
            foreach (var item in RemoteIPList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static MobileNetworkServiceDataFlowTemplate DeserializeMobileNetworkServiceDataFlowTemplate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string templateName = default;
            MobileNetworkSdfDirectionS direction = default;
            IList<string> protocol = default;
            IList<string> remoteIPList = default;
            Optional<IList<string>> ports = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateName"u8))
                {
                    templateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new MobileNetworkSdfDirectionS(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protocol = array;
                    continue;
                }
                if (property.NameEquals("remoteIpList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    remoteIPList = array;
                    continue;
                }
                if (property.NameEquals("ports"u8))
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
                    ports = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MobileNetworkServiceDataFlowTemplate(templateName, direction, protocol, remoteIPList, Optional.ToList(ports), rawData);
        }

        MobileNetworkServiceDataFlowTemplate IModelJsonSerializable<MobileNetworkServiceDataFlowTemplate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkServiceDataFlowTemplate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MobileNetworkServiceDataFlowTemplate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MobileNetworkServiceDataFlowTemplate IModelSerializable<MobileNetworkServiceDataFlowTemplate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMobileNetworkServiceDataFlowTemplate(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MobileNetworkServiceDataFlowTemplate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MobileNetworkServiceDataFlowTemplate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMobileNetworkServiceDataFlowTemplate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
