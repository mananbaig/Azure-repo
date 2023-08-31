// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExecutionActivity : IUtf8JsonSerializable, IModelJsonSerializable<ExecutionActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExecutionActivity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExecutionActivity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExecutionActivity>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                JsonSerializer.Serialize(writer, LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActivityType);
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
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ExecutionActivity DeserializeExecutionActivity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureDataExplorerCommand": return AzureDataExplorerCommandActivity.DeserializeAzureDataExplorerCommandActivity(element);
                    case "AzureFunctionActivity": return AzureFunctionActivity.DeserializeAzureFunctionActivity(element);
                    case "AzureMLBatchExecution": return AzureMLBatchExecutionActivity.DeserializeAzureMLBatchExecutionActivity(element);
                    case "AzureMLExecutePipeline": return AzureMLExecutePipelineActivity.DeserializeAzureMLExecutePipelineActivity(element);
                    case "AzureMLUpdateResource": return AzureMLUpdateResourceActivity.DeserializeAzureMLUpdateResourceActivity(element);
                    case "Copy": return CopyActivity.DeserializeCopyActivity(element);
                    case "Custom": return CustomActivity.DeserializeCustomActivity(element);
                    case "DataLakeAnalyticsU-SQL": return DataLakeAnalyticsUsqlActivity.DeserializeDataLakeAnalyticsUsqlActivity(element);
                    case "DatabricksNotebook": return DatabricksNotebookActivity.DeserializeDatabricksNotebookActivity(element);
                    case "DatabricksSparkJar": return DatabricksSparkJarActivity.DeserializeDatabricksSparkJarActivity(element);
                    case "DatabricksSparkPython": return DatabricksSparkPythonActivity.DeserializeDatabricksSparkPythonActivity(element);
                    case "Delete": return DeleteActivity.DeserializeDeleteActivity(element);
                    case "ExecuteDataFlow": return ExecuteDataFlowActivity.DeserializeExecuteDataFlowActivity(element);
                    case "ExecuteSSISPackage": return ExecuteSsisPackageActivity.DeserializeExecuteSsisPackageActivity(element);
                    case "GetMetadata": return GetDatasetMetadataActivity.DeserializeGetDatasetMetadataActivity(element);
                    case "HDInsightHive": return HDInsightHiveActivity.DeserializeHDInsightHiveActivity(element);
                    case "HDInsightMapReduce": return HDInsightMapReduceActivity.DeserializeHDInsightMapReduceActivity(element);
                    case "HDInsightPig": return HDInsightPigActivity.DeserializeHDInsightPigActivity(element);
                    case "HDInsightSpark": return HDInsightSparkActivity.DeserializeHDInsightSparkActivity(element);
                    case "HDInsightStreaming": return HDInsightStreamingActivity.DeserializeHDInsightStreamingActivity(element);
                    case "Lookup": return LookupActivity.DeserializeLookupActivity(element);
                    case "Script": return DataFactoryScriptActivity.DeserializeDataFactoryScriptActivity(element);
                    case "SparkJob": return SynapseSparkJobDefinitionActivity.DeserializeSynapseSparkJobDefinitionActivity(element);
                    case "SqlServerStoredProcedure": return SqlServerStoredProcedureActivity.DeserializeSqlServerStoredProcedureActivity(element);
                    case "SynapseNotebook": return SynapseNotebookActivity.DeserializeSynapseNotebookActivity(element);
                    case "WebActivity": return WebActivity.DeserializeWebActivity(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<DataFactoryLinkedServiceReference> linkedServiceName = default;
            Optional<PipelineActivityPolicy> policy = default;
            string name = default;
            string type = "Execution";
            Optional<string> description = default;
            Optional<PipelineActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            Optional<IList<PipelineActivityDependency>> dependsOn = default;
            Optional<IList<PipelineActivityUserProperty>> userProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value);
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
                    state = new PipelineActivityState(property.Value.GetString());
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
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item));
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
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecutionActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName, policy.Value);
        }

        ExecutionActivity IModelJsonSerializable<ExecutionActivity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExecutionActivity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExecutionActivity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExecutionActivity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExecutionActivity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExecutionActivity IModelSerializable<ExecutionActivity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ExecutionActivity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExecutionActivity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExecutionActivity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExecutionActivity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExecutionActivity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
