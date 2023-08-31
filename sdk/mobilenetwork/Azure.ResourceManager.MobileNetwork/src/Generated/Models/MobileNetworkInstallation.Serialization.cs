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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkInstallation : IUtf8JsonSerializable, IModelJsonSerializable<MobileNetworkInstallation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MobileNetworkInstallation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MobileNetworkInstallation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToString());
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

        internal static MobileNetworkInstallation DeserializeMobileNetworkInstallation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DesiredInstallationState> desiredState = default;
            Optional<MobileNetworkInstallationState> state = default;
            Optional<MobileNetworkReinstallRequired> reinstallRequired = default;
            Optional<IReadOnlyList<MobileNetworkInstallationReason>> reasons = default;
            Optional<SubResource> operation = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    desiredState = new DesiredInstallationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MobileNetworkInstallationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reinstallRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reinstallRequired = new MobileNetworkReinstallRequired(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reasons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkInstallationReason> array = new List<MobileNetworkInstallationReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MobileNetworkInstallationReason(item.GetString()));
                    }
                    reasons = array;
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operation = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MobileNetworkInstallation(Optional.ToNullable(desiredState), Optional.ToNullable(state), Optional.ToNullable(reinstallRequired), Optional.ToList(reasons), operation, rawData);
        }

        MobileNetworkInstallation IModelJsonSerializable<MobileNetworkInstallation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkInstallation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MobileNetworkInstallation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MobileNetworkInstallation IModelSerializable<MobileNetworkInstallation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMobileNetworkInstallation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MobileNetworkInstallation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MobileNetworkInstallation"/> to convert. </param>
        public static implicit operator RequestContent(MobileNetworkInstallation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MobileNetworkInstallation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MobileNetworkInstallation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMobileNetworkInstallation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
