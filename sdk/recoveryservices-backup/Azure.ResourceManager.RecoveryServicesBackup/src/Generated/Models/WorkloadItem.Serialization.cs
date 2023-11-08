// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [ModelReaderProxy(typeof(UnknownWorkloadItem))]
    public partial class WorkloadItem : IUtf8JsonSerializable, IJsonModel<WorkloadItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadItem>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WorkloadItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("workloadItemType"u8);
            writer.WriteStringValue(WorkloadItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        WorkloadItem IJsonModel<WorkloadItem>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadItem(document.RootElement, options);
        }

        internal static WorkloadItem DeserializeWorkloadItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("workloadItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureVmWorkloadItem": return VmWorkloadItem.DeserializeVmWorkloadItem(element);
                    case "SAPAseDatabase": return VmWorkloadSapAseDatabaseWorkloadItem.DeserializeVmWorkloadSapAseDatabaseWorkloadItem(element);
                    case "SAPAseSystem": return VmWorkloadSapAseSystemWorkloadItem.DeserializeVmWorkloadSapAseSystemWorkloadItem(element);
                    case "SAPHanaDatabase": return VmWorkloadSapHanaDatabaseWorkloadItem.DeserializeVmWorkloadSapHanaDatabaseWorkloadItem(element);
                    case "SAPHanaSystem": return VmWorkloadSapHanaSystemWorkloadItem.DeserializeVmWorkloadSapHanaSystemWorkloadItem(element);
                    case "SQLDataBase": return VmWorkloadSqlDatabaseWorkloadItem.DeserializeVmWorkloadSqlDatabaseWorkloadItem(element);
                    case "SQLInstance": return VmWorkloadSqlInstanceWorkloadItem.DeserializeVmWorkloadSqlInstanceWorkloadItem(element);
                }
            }
            return UnknownWorkloadItem.DeserializeUnknownWorkloadItem(element);
        }

        BinaryData IModel<WorkloadItem>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WorkloadItem IModel<WorkloadItem>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWorkloadItem(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WorkloadItem>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
