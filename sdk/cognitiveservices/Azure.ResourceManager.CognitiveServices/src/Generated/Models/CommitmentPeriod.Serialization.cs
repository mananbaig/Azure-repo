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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentPeriod : IUtf8JsonSerializable, IModelJsonSerializable<CommitmentPeriod>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommitmentPeriod>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommitmentPeriod>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
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

        internal static CommitmentPeriod DeserializeCommitmentPeriod(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tier = default;
            Optional<int> count = default;
            Optional<CommitmentQuota> quota = default;
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> endDate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quota = CommitmentQuota.DeserializeCommitmentQuota(property.Value);
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommitmentPeriod(tier.Value, Optional.ToNullable(count), quota.Value, Optional.ToNullable(startDate), Optional.ToNullable(endDate), rawData);
        }

        CommitmentPeriod IModelJsonSerializable<CommitmentPeriod>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommitmentPeriod(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommitmentPeriod>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommitmentPeriod IModelSerializable<CommitmentPeriod>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommitmentPeriod(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CommitmentPeriod model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CommitmentPeriod(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommitmentPeriod(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
