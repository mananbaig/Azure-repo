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
    public partial class PresenterLayout : IUtf8JsonSerializable, IModelJsonSerializable<PresenterLayout>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PresenterLayout>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PresenterLayout>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PresenterLayout>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("presenterId"u8);
            writer.WriteStringValue(PresenterId);
            writer.WritePropertyName("supportId"u8);
            writer.WriteStringValue(SupportId);
            if (Optional.IsDefined(SupportPosition))
            {
                writer.WritePropertyName("supportPosition"u8);
                writer.WriteStringValue(SupportPosition.Value.ToString());
            }
            if (Optional.IsDefined(SupportAspectRatio))
            {
                writer.WritePropertyName("supportAspectRatio"u8);
                writer.WriteNumberValue(SupportAspectRatio.Value);
            }
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

        internal static PresenterLayout DeserializePresenterLayout(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string presenterId = default;
            string supportId = default;
            Optional<SupportPosition> supportPosition = default;
            Optional<double> supportAspectRatio = default;
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            Optional<ScalingMode> scalingMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("presenterId"u8))
                {
                    presenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportId"u8))
                {
                    supportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportPosition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportPosition = new SupportPosition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportAspectRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportAspectRatio = property.Value.GetDouble();
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
            return new PresenterLayout(kind, resolution.Value, placeholderImageUri.Value, Optional.ToNullable(scalingMode), presenterId, supportId, Optional.ToNullable(supportPosition), Optional.ToNullable(supportAspectRatio), rawData);
        }

        PresenterLayout IModelJsonSerializable<PresenterLayout>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PresenterLayout>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePresenterLayout(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PresenterLayout>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PresenterLayout>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PresenterLayout IModelSerializable<PresenterLayout>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PresenterLayout>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePresenterLayout(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PresenterLayout model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PresenterLayout(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePresenterLayout(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
