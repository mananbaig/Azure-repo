// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GetMetadataActivityConverter))]
    public partial class GetMetadataActivity : IUtf8JsonSerializable, IModelJsonSerializable<GetMetadataActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetMetadataActivity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetMetadataActivity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetMetadataActivity>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                if (LinkedServiceName is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LinkedServiceReference>)LinkedServiceName).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                if (Policy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ActivityPolicy>)Policy).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ActivityDependency>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<UserProperty>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("dataset"u8);
            if (Dataset is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DatasetReference>)Dataset).Serialize(writer, options);
            }
            if (Optional.IsCollectionDefined(FieldList))
            {
                writer.WritePropertyName("fieldList"u8);
                writer.WriteStartArray();
                foreach (var item in FieldList)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StoreSettings))
            {
                writer.WritePropertyName("storeSettings"u8);
                if (StoreSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StoreReadSettings>)StoreSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(FormatSettings))
            {
                writer.WritePropertyName("formatSettings"u8);
                if (FormatSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FormatReadSettings>)FormatSettings).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static GetMetadataActivity DeserializeGetMetadataActivity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<ActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            DatasetReference dataset = default;
            Optional<IList<object>> fieldList = default;
            Optional<StoreReadSettings> storeSettings = default;
            Optional<FormatReadSettings> formatSettings = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("dataset"u8))
                        {
                            dataset = DatasetReference.DeserializeDatasetReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("fieldList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            fieldList = array;
                            continue;
                        }
                        if (property0.NameEquals("storeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storeSettings = StoreReadSettings.DeserializeStoreReadSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("formatSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            formatSettings = FormatReadSettings.DeserializeFormatReadSettings(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GetMetadataActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName.Value, policy.Value, dataset, Optional.ToList(fieldList), storeSettings.Value, formatSettings.Value);
        }

        GetMetadataActivity IModelJsonSerializable<GetMetadataActivity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetMetadataActivity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetMetadataActivity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetMetadataActivity>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetMetadataActivity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetMetadataActivity IModelSerializable<GetMetadataActivity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetMetadataActivity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetMetadataActivity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetMetadataActivity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetMetadataActivity"/> to convert. </param>
        public static implicit operator RequestContent(GetMetadataActivity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetMetadataActivity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetMetadataActivity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetMetadataActivity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class GetMetadataActivityConverter : JsonConverter<GetMetadataActivity>
        {
            public override void Write(Utf8JsonWriter writer, GetMetadataActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GetMetadataActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGetMetadataActivity(document.RootElement);
            }
        }
    }
}
