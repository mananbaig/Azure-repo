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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class ExecuteGovernanceRuleParams : IUtf8JsonSerializable, IModelJsonSerializable<ExecuteGovernanceRuleParams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExecuteGovernanceRuleParams>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExecuteGovernanceRuleParams>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExecuteGovernanceRuleParams>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Override))
            {
                writer.WritePropertyName("override"u8);
                writer.WriteBooleanValue(Override.Value);
            }
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

        internal static ExecuteGovernanceRuleParams DeserializeExecuteGovernanceRuleParams(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> @override = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("override"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @override = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExecuteGovernanceRuleParams(Optional.ToNullable(@override), serializedAdditionalRawData);
        }

        ExecuteGovernanceRuleParams IModelJsonSerializable<ExecuteGovernanceRuleParams>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExecuteGovernanceRuleParams>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExecuteGovernanceRuleParams(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExecuteGovernanceRuleParams>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExecuteGovernanceRuleParams>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExecuteGovernanceRuleParams IModelSerializable<ExecuteGovernanceRuleParams>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExecuteGovernanceRuleParams>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExecuteGovernanceRuleParams(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExecuteGovernanceRuleParams"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExecuteGovernanceRuleParams"/> to convert. </param>
        public static implicit operator RequestContent(ExecuteGovernanceRuleParams model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExecuteGovernanceRuleParams"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExecuteGovernanceRuleParams(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExecuteGovernanceRuleParams(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
