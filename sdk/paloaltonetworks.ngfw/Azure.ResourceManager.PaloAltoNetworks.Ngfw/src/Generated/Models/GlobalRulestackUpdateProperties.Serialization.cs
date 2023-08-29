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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class GlobalRulestackUpdateProperties : IUtf8JsonSerializable, IModelJsonSerializable<GlobalRulestackUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GlobalRulestackUpdateProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GlobalRulestackUpdateProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PanETag))
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag.Value.ToString());
            }
            if (Optional.IsDefined(PanLocation))
            {
                writer.WritePropertyName("panLocation"u8);
                writer.WriteStringValue(PanLocation.Value);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AssociatedSubscriptions))
            {
                writer.WritePropertyName("associatedSubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in AssociatedSubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DefaultMode))
            {
                writer.WritePropertyName("defaultMode"u8);
                writer.WriteStringValue(DefaultMode.Value.ToString());
            }
            if (Optional.IsDefined(MinAppIdVersion))
            {
                writer.WritePropertyName("minAppIdVersion"u8);
                writer.WriteStringValue(MinAppIdVersion);
            }
            if (Optional.IsDefined(SecurityServices))
            {
                writer.WritePropertyName("securityServices"u8);
                writer.WriteObjectValue(SecurityServices);
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

        internal static GlobalRulestackUpdateProperties DeserializeGlobalRulestackUpdateProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> panETag = default;
            Optional<AzureLocation> panLocation = default;
            Optional<RulestackScopeType> scope = default;
            Optional<IList<string>> associatedSubscriptions = default;
            Optional<string> description = default;
            Optional<RuleCreationDefaultMode> defaultMode = default;
            Optional<string> minAppIdVersion = default;
            Optional<RulestackSecurityServices> securityServices = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("panEtag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    panETag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("panLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    panLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = new RulestackScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("associatedSubscriptions"u8))
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
                    associatedSubscriptions = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMode = new RuleCreationDefaultMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minAppIdVersion"u8))
                {
                    minAppIdVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityServices = RulestackSecurityServices.DeserializeRulestackSecurityServices(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GlobalRulestackUpdateProperties(Optional.ToNullable(panETag), Optional.ToNullable(panLocation), Optional.ToNullable(scope), Optional.ToList(associatedSubscriptions), description.Value, Optional.ToNullable(defaultMode), minAppIdVersion.Value, securityServices.Value, rawData);
        }

        GlobalRulestackUpdateProperties IModelJsonSerializable<GlobalRulestackUpdateProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGlobalRulestackUpdateProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GlobalRulestackUpdateProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GlobalRulestackUpdateProperties IModelSerializable<GlobalRulestackUpdateProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGlobalRulestackUpdateProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GlobalRulestackUpdateProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GlobalRulestackUpdateProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGlobalRulestackUpdateProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
