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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RegressionTrainingSettings : IUtf8JsonSerializable, IModelJsonSerializable<RegressionTrainingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RegressionTrainingSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RegressionTrainingSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RegressionTrainingSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedTrainingAlgorithms))
            {
                if (AllowedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("allowedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedTrainingAlgorithms");
                }
            }
            if (Optional.IsCollectionDefined(BlockedTrainingAlgorithms))
            {
                if (BlockedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("blockedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in BlockedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedTrainingAlgorithms");
                }
            }
            if (Optional.IsDefined(IsDnnTrainingEnabled))
            {
                writer.WritePropertyName("enableDnnTraining"u8);
                writer.WriteBooleanValue(IsDnnTrainingEnabled.Value);
            }
            if (Optional.IsDefined(IsModelExplainabilityEnabled))
            {
                writer.WritePropertyName("enableModelExplainability"u8);
                writer.WriteBooleanValue(IsModelExplainabilityEnabled.Value);
            }
            if (Optional.IsDefined(IsOnnxCompatibleModelsEnabled))
            {
                writer.WritePropertyName("enableOnnxCompatibleModels"u8);
                writer.WriteBooleanValue(IsOnnxCompatibleModelsEnabled.Value);
            }
            if (Optional.IsDefined(IsStackEnsembleEnabled))
            {
                writer.WritePropertyName("enableStackEnsemble"u8);
                writer.WriteBooleanValue(IsStackEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(IsVoteEnsembleEnabled))
            {
                writer.WritePropertyName("enableVoteEnsemble"u8);
                writer.WriteBooleanValue(IsVoteEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(EnsembleModelDownloadTimeout))
            {
                writer.WritePropertyName("ensembleModelDownloadTimeout"u8);
                writer.WriteStringValue(EnsembleModelDownloadTimeout.Value, "P");
            }
            if (Optional.IsDefined(StackEnsembleSettings))
            {
                if (StackEnsembleSettings != null)
                {
                    writer.WritePropertyName("stackEnsembleSettings"u8);
                    writer.WriteObjectValue(StackEnsembleSettings);
                }
                else
                {
                    writer.WriteNull("stackEnsembleSettings");
                }
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

        internal static RegressionTrainingSettings DeserializeRegressionTrainingSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AutoMLVerticalRegressionModel>> allowedTrainingAlgorithms = default;
            Optional<IList<AutoMLVerticalRegressionModel>> blockedTrainingAlgorithms = default;
            Optional<bool> enableDnnTraining = default;
            Optional<bool> enableModelExplainability = default;
            Optional<bool> enableOnnxCompatibleModels = default;
            Optional<bool> enableStackEnsemble = default;
            Optional<bool> enableVoteEnsemble = default;
            Optional<TimeSpan> ensembleModelDownloadTimeout = default;
            Optional<MachineLearningStackEnsembleSettings> stackEnsembleSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        allowedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    allowedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("blockedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    blockedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("enableDnnTraining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnTraining = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableModelExplainability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableModelExplainability = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableOnnxCompatibleModels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableOnnxCompatibleModels = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableStackEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableStackEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVoteEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVoteEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ensembleModelDownloadTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ensembleModelDownloadTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stackEnsembleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackEnsembleSettings = null;
                        continue;
                    }
                    stackEnsembleSettings = MachineLearningStackEnsembleSettings.DeserializeMachineLearningStackEnsembleSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RegressionTrainingSettings(Optional.ToNullable(enableDnnTraining), Optional.ToNullable(enableModelExplainability), Optional.ToNullable(enableOnnxCompatibleModels), Optional.ToNullable(enableStackEnsemble), Optional.ToNullable(enableVoteEnsemble), Optional.ToNullable(ensembleModelDownloadTimeout), stackEnsembleSettings.Value, Optional.ToList(allowedTrainingAlgorithms), Optional.ToList(blockedTrainingAlgorithms), rawData);
        }

        RegressionTrainingSettings IModelJsonSerializable<RegressionTrainingSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RegressionTrainingSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRegressionTrainingSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RegressionTrainingSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RegressionTrainingSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RegressionTrainingSettings IModelSerializable<RegressionTrainingSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RegressionTrainingSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRegressionTrainingSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RegressionTrainingSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RegressionTrainingSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRegressionTrainingSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
