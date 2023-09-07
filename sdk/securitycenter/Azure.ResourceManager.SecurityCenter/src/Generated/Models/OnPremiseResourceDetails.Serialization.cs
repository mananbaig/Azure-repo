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
    public partial class OnPremiseResourceDetails : IUtf8JsonSerializable, IModelJsonSerializable<OnPremiseResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OnPremiseResourceDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OnPremiseResourceDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnPremiseResourceDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("vmuuid"u8);
            writer.WriteStringValue(VmUuid);
            writer.WritePropertyName("sourceComputerId"u8);
            writer.WriteStringValue(SourceComputerId);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
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

        internal static OnPremiseResourceDetails DeserializeOnPremiseResourceDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("source", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "OnPremiseSql": return OnPremiseSqlResourceDetails.DeserializeOnPremiseSqlResourceDetails(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            ResourceIdentifier workspaceId = default;
            Guid vmuuid = default;
            string sourceComputerId = default;
            string machineName = default;
            Source source = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmuuid"u8))
                {
                    vmuuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sourceComputerId"u8))
                {
                    sourceComputerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = new Source(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OnPremiseResourceDetails(source, workspaceId, vmuuid, sourceComputerId, machineName, serializedAdditionalRawData);
        }

        OnPremiseResourceDetails IModelJsonSerializable<OnPremiseResourceDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnPremiseResourceDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOnPremiseResourceDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OnPremiseResourceDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnPremiseResourceDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OnPremiseResourceDetails IModelSerializable<OnPremiseResourceDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnPremiseResourceDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOnPremiseResourceDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OnPremiseResourceDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OnPremiseResourceDetails"/> to convert. </param>
        public static implicit operator RequestContent(OnPremiseResourceDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OnPremiseResourceDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OnPremiseResourceDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOnPremiseResourceDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
