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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceWorkerPoolData : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceWorkerPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceWorkerPoolData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceWorkerPoolData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceWorkerPoolData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceSkuDescription>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerSizeId))
            {
                writer.WritePropertyName("workerSizeId"u8);
                writer.WriteNumberValue(WorkerSizeId.Value);
            }
            if (Optional.IsDefined(ComputeMode))
            {
                writer.WritePropertyName("computeMode"u8);
                writer.WriteStringValue(ComputeMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(WorkerSize))
            {
                writer.WritePropertyName("workerSize"u8);
                writer.WriteStringValue(WorkerSize);
            }
            if (Optional.IsDefined(WorkerCount))
            {
                writer.WritePropertyName("workerCount"u8);
                writer.WriteNumberValue(WorkerCount.Value);
            }
            writer.WriteEndObject();
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

        internal static AppServiceWorkerPoolData DeserializeAppServiceWorkerPoolData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceSkuDescription> sku = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> workerSizeId = default;
            Optional<ComputeModeOption> computeMode = default;
            Optional<string> workerSize = default;
            Optional<int> workerCount = default;
            Optional<IReadOnlyList<string>> instanceNames = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = AppServiceSkuDescription.DeserializeAppServiceSkuDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("workerSizeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workerSizeId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("computeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeMode = property0.Value.GetString().ToComputeModeOption();
                            continue;
                        }
                        if (property0.NameEquals("workerSize"u8))
                        {
                            workerSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("workerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("instanceNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            instanceNames = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceWorkerPoolData(id, name, type, systemData.Value, sku.Value, Optional.ToNullable(workerSizeId), Optional.ToNullable(computeMode), workerSize.Value, Optional.ToNullable(workerCount), Optional.ToList(instanceNames), kind.Value, serializedAdditionalRawData);
        }

        AppServiceWorkerPoolData IModelJsonSerializable<AppServiceWorkerPoolData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceWorkerPoolData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceWorkerPoolData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceWorkerPoolData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceWorkerPoolData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceWorkerPoolData IModelSerializable<AppServiceWorkerPoolData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceWorkerPoolData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceWorkerPoolData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceWorkerPoolData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceWorkerPoolData"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceWorkerPoolData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceWorkerPoolData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceWorkerPoolData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceWorkerPoolData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
