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
    public partial class MachineLearningForecasting : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningForecasting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningForecasting>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningForecasting>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningForecasting>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ForecastingSettings))
            {
                if (ForecastingSettings != null)
                {
                    writer.WritePropertyName("forecastingSettings"u8);
                    writer.WriteObjectValue(ForecastingSettings);
                }
                else
                {
                    writer.WriteNull("forecastingSettings");
                }
            }
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(TrainingSettings))
            {
                if (TrainingSettings != null)
                {
                    writer.WritePropertyName("trainingSettings"u8);
                    writer.WriteObjectValue(TrainingSettings);
                }
                else
                {
                    writer.WriteNull("trainingSettings");
                }
            }
            if (Optional.IsCollectionDefined(CvSplitColumnNames))
            {
                if (CvSplitColumnNames != null)
                {
                    writer.WritePropertyName("cvSplitColumnNames"u8);
                    writer.WriteStartArray();
                    foreach (var item in CvSplitColumnNames)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("cvSplitColumnNames");
                }
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings"u8);
                    writer.WriteObjectValue(FeaturizationSettings);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings"u8);
                    writer.WriteObjectValue(LimitSettings);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (Optional.IsDefined(NCrossValidations))
            {
                if (NCrossValidations != null)
                {
                    writer.WritePropertyName("nCrossValidations"u8);
                    writer.WriteObjectValue(NCrossValidations);
                }
                else
                {
                    writer.WriteNull("nCrossValidations");
                }
            }
            if (Optional.IsDefined(TestData))
            {
                if (TestData != null)
                {
                    writer.WritePropertyName("testData"u8);
                    writer.WriteObjectValue(TestData);
                }
                else
                {
                    writer.WriteNull("testData");
                }
            }
            if (Optional.IsDefined(TestDataSize))
            {
                if (TestDataSize != null)
                {
                    writer.WritePropertyName("testDataSize"u8);
                    writer.WriteNumberValue(TestDataSize.Value);
                }
                else
                {
                    writer.WriteNull("testDataSize");
                }
            }
            if (Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Optional.IsDefined(ValidationDataSize))
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
            if (Optional.IsDefined(WeightColumnName))
            {
                if (WeightColumnName != null)
                {
                    writer.WritePropertyName("weightColumnName"u8);
                    writer.WriteStringValue(WeightColumnName);
                }
                else
                {
                    writer.WriteNull("weightColumnName");
                }
            }
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData);
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

        internal static MachineLearningForecasting DeserializeMachineLearningForecasting(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ForecastingSettings> forecastingSettings = default;
            Optional<ForecastingPrimaryMetric> primaryMetric = default;
            Optional<ForecastingTrainingSettings> trainingSettings = default;
            Optional<IList<string>> cvSplitColumnNames = default;
            Optional<TableVerticalFeaturizationSettings> featurizationSettings = default;
            Optional<TableVerticalLimitSettings> limitSettings = default;
            Optional<NCrossValidations> nCrossValidations = default;
            Optional<MachineLearningTableJobInput> testData = default;
            Optional<double?> testDataSize = default;
            Optional<MachineLearningTableJobInput> validationData = default;
            Optional<double?> validationDataSize = default;
            Optional<string> weightColumnName = default;
            Optional<MachineLearningLogVerbosity> logVerbosity = default;
            Optional<string> targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forecastingSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        forecastingSettings = null;
                        continue;
                    }
                    forecastingSettings = ForecastingSettings.DeserializeForecastingSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ForecastingPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingSettings = null;
                        continue;
                    }
                    trainingSettings = ForecastingTrainingSettings.DeserializeForecastingTrainingSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("cvSplitColumnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cvSplitColumnNames = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    cvSplitColumnNames = array;
                    continue;
                }
                if (property.NameEquals("featurizationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = TableVerticalFeaturizationSettings.DeserializeTableVerticalFeaturizationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = TableVerticalLimitSettings.DeserializeTableVerticalLimitSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("nCrossValidations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nCrossValidations = null;
                        continue;
                    }
                    nCrossValidations = NCrossValidations.DeserializeNCrossValidations(property.Value);
                    continue;
                }
                if (property.NameEquals("testData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testData = null;
                        continue;
                    }
                    testData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
                if (property.NameEquals("testDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        testDataSize = null;
                        continue;
                    }
                    testDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("weightColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightColumnName = null;
                        continue;
                    }
                    weightColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningForecasting(Optional.ToNullable(logVerbosity), targetColumnName.Value, taskType, trainingData, forecastingSettings.Value, Optional.ToNullable(primaryMetric), trainingSettings.Value, Optional.ToList(cvSplitColumnNames), featurizationSettings.Value, limitSettings.Value, nCrossValidations.Value, testData.Value, Optional.ToNullable(testDataSize), validationData.Value, Optional.ToNullable(validationDataSize), weightColumnName.Value, rawData);
        }

        MachineLearningForecasting IModelJsonSerializable<MachineLearningForecasting>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningForecasting>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningForecasting(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningForecasting>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningForecasting>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningForecasting IModelSerializable<MachineLearningForecasting>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningForecasting>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningForecasting(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningForecasting model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningForecasting(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningForecasting(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
