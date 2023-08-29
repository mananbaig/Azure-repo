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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildResultProperties : IUtf8JsonSerializable, IModelJsonSerializable<AppPlatformBuildResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppPlatformBuildResultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppPlatformBuildResultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(BuildPodName))
            {
                writer.WritePropertyName("buildPodName"u8);
                writer.WriteStringValue(BuildPodName);
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

        internal static AppPlatformBuildResultProperties DeserializeAppPlatformBuildResultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AppPlatformBuildResultProvisioningState> provisioningState = default;
            Optional<string> buildPodName = default;
            Optional<IReadOnlyList<AppPlatformBuildStageProperties>> buildStages = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformBuildResultProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("buildPodName"u8))
                {
                    buildPodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("buildStages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformBuildStageProperties> array = new List<AppPlatformBuildStageProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformBuildStageProperties.DeserializeAppPlatformBuildStageProperties(item));
                    }
                    buildStages = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppPlatformBuildResultProperties(name.Value, Optional.ToNullable(provisioningState), buildPodName.Value, Optional.ToList(buildStages), rawData);
        }

        AppPlatformBuildResultProperties IModelJsonSerializable<AppPlatformBuildResultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformBuildResultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppPlatformBuildResultProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppPlatformBuildResultProperties IModelSerializable<AppPlatformBuildResultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppPlatformBuildResultProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AppPlatformBuildResultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AppPlatformBuildResultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppPlatformBuildResultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
