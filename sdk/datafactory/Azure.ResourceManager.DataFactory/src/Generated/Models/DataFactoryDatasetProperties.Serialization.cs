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
    public partial class DataFactoryDatasetProperties : IUtf8JsonSerializable, IModelJsonSerializable<DataFactoryDatasetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFactoryDatasetProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFactoryDatasetProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure"u8);
                JsonSerializer.Serialize(writer, Structure);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                JsonSerializer.Serialize(writer, Schema);
            }
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName); if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EntityParameterSpecification>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                if (Folder is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DatasetFolder>)Folder).Serialize(writer, options);
                }
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

        internal static DataFactoryDatasetProperties DeserializeDataFactoryDatasetProperties(JsonElement element, ModelSerializerOptions options = default)
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
                    case "AmazonMWSObject": return AmazonMwsObjectDataset.DeserializeAmazonMwsObjectDataset(element);
                    case "AmazonRdsForOracleTable": return AmazonRdsForOracleTableDataset.DeserializeAmazonRdsForOracleTableDataset(element);
                    case "AmazonRdsForSqlServerTable": return AmazonRdsForSqlServerTableDataset.DeserializeAmazonRdsForSqlServerTableDataset(element);
                    case "AmazonRedshiftTable": return AmazonRedshiftTableDataset.DeserializeAmazonRedshiftTableDataset(element);
                    case "AmazonS3Object": return AmazonS3Dataset.DeserializeAmazonS3Dataset(element);
                    case "Avro": return AvroDataset.DeserializeAvroDataset(element);
                    case "AzureBlob": return AzureBlobDataset.DeserializeAzureBlobDataset(element);
                    case "AzureBlobFSFile": return AzureBlobFSDataset.DeserializeAzureBlobFSDataset(element);
                    case "AzureDataExplorerTable": return AzureDataExplorerTableDataset.DeserializeAzureDataExplorerTableDataset(element);
                    case "AzureDataLakeStoreFile": return AzureDataLakeStoreDataset.DeserializeAzureDataLakeStoreDataset(element);
                    case "AzureDatabricksDeltaLakeDataset": return AzureDatabricksDeltaLakeDataset.DeserializeAzureDatabricksDeltaLakeDataset(element);
                    case "AzureMariaDBTable": return AzureMariaDBTableDataset.DeserializeAzureMariaDBTableDataset(element);
                    case "AzureMySqlTable": return AzureMySqlTableDataset.DeserializeAzureMySqlTableDataset(element);
                    case "AzurePostgreSqlTable": return AzurePostgreSqlTableDataset.DeserializeAzurePostgreSqlTableDataset(element);
                    case "AzureSearchIndex": return AzureSearchIndexDataset.DeserializeAzureSearchIndexDataset(element);
                    case "AzureSqlDWTable": return AzureSqlDWTableDataset.DeserializeAzureSqlDWTableDataset(element);
                    case "AzureSqlMITable": return AzureSqlMITableDataset.DeserializeAzureSqlMITableDataset(element);
                    case "AzureSqlTable": return AzureSqlTableDataset.DeserializeAzureSqlTableDataset(element);
                    case "AzureTable": return AzureTableDataset.DeserializeAzureTableDataset(element);
                    case "Binary": return BinaryDataset.DeserializeBinaryDataset(element);
                    case "CassandraTable": return CassandraTableDataset.DeserializeCassandraTableDataset(element);
                    case "CommonDataServiceForAppsEntity": return CommonDataServiceForAppsEntityDataset.DeserializeCommonDataServiceForAppsEntityDataset(element);
                    case "ConcurObject": return ConcurObjectDataset.DeserializeConcurObjectDataset(element);
                    case "CosmosDbMongoDbApiCollection": return CosmosDBMongoDBApiCollectionDataset.DeserializeCosmosDBMongoDBApiCollectionDataset(element);
                    case "CosmosDbSqlApiCollection": return CosmosDBSqlApiCollectionDataset.DeserializeCosmosDBSqlApiCollectionDataset(element);
                    case "CouchbaseTable": return CouchbaseTableDataset.DeserializeCouchbaseTableDataset(element);
                    case "CustomDataset": return CustomDataset.DeserializeCustomDataset(element);
                    case "Db2Table": return Db2TableDataset.DeserializeDb2TableDataset(element);
                    case "DelimitedText": return DelimitedTextDataset.DeserializeDelimitedTextDataset(element);
                    case "DocumentDbCollection": return DocumentDBCollectionDataset.DeserializeDocumentDBCollectionDataset(element);
                    case "DrillTable": return DrillTableDataset.DeserializeDrillTableDataset(element);
                    case "DynamicsAXResource": return DynamicsAXResourceDataset.DeserializeDynamicsAXResourceDataset(element);
                    case "DynamicsCrmEntity": return DynamicsCrmEntityDataset.DeserializeDynamicsCrmEntityDataset(element);
                    case "DynamicsEntity": return DynamicsEntityDataset.DeserializeDynamicsEntityDataset(element);
                    case "EloquaObject": return EloquaObjectDataset.DeserializeEloquaObjectDataset(element);
                    case "Excel": return ExcelDataset.DeserializeExcelDataset(element);
                    case "FileShare": return FileShareDataset.DeserializeFileShareDataset(element);
                    case "GoogleAdWordsObject": return GoogleAdWordsObjectDataset.DeserializeGoogleAdWordsObjectDataset(element);
                    case "GoogleBigQueryObject": return GoogleBigQueryObjectDataset.DeserializeGoogleBigQueryObjectDataset(element);
                    case "GreenplumTable": return GreenplumTableDataset.DeserializeGreenplumTableDataset(element);
                    case "HBaseObject": return HBaseObjectDataset.DeserializeHBaseObjectDataset(element);
                    case "HiveObject": return HiveObjectDataset.DeserializeHiveObjectDataset(element);
                    case "HttpFile": return DataFactoryHttpDataset.DeserializeDataFactoryHttpDataset(element);
                    case "HubspotObject": return HubspotObjectDataset.DeserializeHubspotObjectDataset(element);
                    case "ImpalaObject": return ImpalaObjectDataset.DeserializeImpalaObjectDataset(element);
                    case "InformixTable": return InformixTableDataset.DeserializeInformixTableDataset(element);
                    case "JiraObject": return JiraObjectDataset.DeserializeJiraObjectDataset(element);
                    case "Json": return JsonDataset.DeserializeJsonDataset(element);
                    case "MagentoObject": return MagentoObjectDataset.DeserializeMagentoObjectDataset(element);
                    case "MariaDBTable": return MariaDBTableDataset.DeserializeMariaDBTableDataset(element);
                    case "MarketoObject": return MarketoObjectDataset.DeserializeMarketoObjectDataset(element);
                    case "MicrosoftAccessTable": return MicrosoftAccessTableDataset.DeserializeMicrosoftAccessTableDataset(element);
                    case "MongoDbAtlasCollection": return MongoDBAtlasCollectionDataset.DeserializeMongoDBAtlasCollectionDataset(element);
                    case "MongoDbCollection": return MongoDBCollectionDataset.DeserializeMongoDBCollectionDataset(element);
                    case "MongoDbV2Collection": return MongoDBV2CollectionDataset.DeserializeMongoDBV2CollectionDataset(element);
                    case "MySqlTable": return MySqlTableDataset.DeserializeMySqlTableDataset(element);
                    case "NetezzaTable": return NetezzaTableDataset.DeserializeNetezzaTableDataset(element);
                    case "ODataResource": return ODataResourceDataset.DeserializeODataResourceDataset(element);
                    case "OdbcTable": return OdbcTableDataset.DeserializeOdbcTableDataset(element);
                    case "Office365Table": return Office365Dataset.DeserializeOffice365Dataset(element);
                    case "OracleServiceCloudObject": return OracleServiceCloudObjectDataset.DeserializeOracleServiceCloudObjectDataset(element);
                    case "OracleTable": return OracleTableDataset.DeserializeOracleTableDataset(element);
                    case "Orc": return OrcDataset.DeserializeOrcDataset(element);
                    case "Parquet": return ParquetDataset.DeserializeParquetDataset(element);
                    case "PaypalObject": return PaypalObjectDataset.DeserializePaypalObjectDataset(element);
                    case "PhoenixObject": return PhoenixObjectDataset.DeserializePhoenixObjectDataset(element);
                    case "PostgreSqlTable": return PostgreSqlTableDataset.DeserializePostgreSqlTableDataset(element);
                    case "PrestoObject": return PrestoObjectDataset.DeserializePrestoObjectDataset(element);
                    case "QuickBooksObject": return QuickBooksObjectDataset.DeserializeQuickBooksObjectDataset(element);
                    case "RelationalTable": return RelationalTableDataset.DeserializeRelationalTableDataset(element);
                    case "ResponsysObject": return ResponsysObjectDataset.DeserializeResponsysObjectDataset(element);
                    case "RestResource": return RestResourceDataset.DeserializeRestResourceDataset(element);
                    case "SalesforceMarketingCloudObject": return SalesforceMarketingCloudObjectDataset.DeserializeSalesforceMarketingCloudObjectDataset(element);
                    case "SalesforceObject": return SalesforceObjectDataset.DeserializeSalesforceObjectDataset(element);
                    case "SalesforceServiceCloudObject": return SalesforceServiceCloudObjectDataset.DeserializeSalesforceServiceCloudObjectDataset(element);
                    case "SapBwCube": return SapBWCubeDataset.DeserializeSapBWCubeDataset(element);
                    case "SapCloudForCustomerResource": return SapCloudForCustomerResourceDataset.DeserializeSapCloudForCustomerResourceDataset(element);
                    case "SapEccResource": return SapEccResourceDataset.DeserializeSapEccResourceDataset(element);
                    case "SapHanaTable": return SapHanaTableDataset.DeserializeSapHanaTableDataset(element);
                    case "SapOdpResource": return SapOdpResourceDataset.DeserializeSapOdpResourceDataset(element);
                    case "SapOpenHubTable": return SapOpenHubTableDataset.DeserializeSapOpenHubTableDataset(element);
                    case "SapTableResource": return SapTableResourceDataset.DeserializeSapTableResourceDataset(element);
                    case "ServiceNowObject": return ServiceNowObjectDataset.DeserializeServiceNowObjectDataset(element);
                    case "SharePointOnlineListResource": return SharePointOnlineListResourceDataset.DeserializeSharePointOnlineListResourceDataset(element);
                    case "ShopifyObject": return ShopifyObjectDataset.DeserializeShopifyObjectDataset(element);
                    case "SnowflakeTable": return SnowflakeDataset.DeserializeSnowflakeDataset(element);
                    case "SparkObject": return SparkObjectDataset.DeserializeSparkObjectDataset(element);
                    case "SqlServerTable": return SqlServerTableDataset.DeserializeSqlServerTableDataset(element);
                    case "SquareObject": return SquareObjectDataset.DeserializeSquareObjectDataset(element);
                    case "SybaseTable": return SybaseTableDataset.DeserializeSybaseTableDataset(element);
                    case "TeradataTable": return TeradataTableDataset.DeserializeTeradataTableDataset(element);
                    case "VerticaTable": return VerticaTableDataset.DeserializeVerticaTableDataset(element);
                    case "WebTable": return WebTableDataset.DeserializeWebTableDataset(element);
                    case "XeroObject": return XeroObjectDataset.DeserializeXeroObjectDataset(element);
                    case "Xml": return XmlDataset.DeserializeXmlDataset(element);
                    case "ZohoObject": return ZohoObjectDataset.DeserializeZohoObjectDataset(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryElement<IList<DatasetDataElement>>> structure = default;
            Optional<DataFactoryElement<IList<DatasetSchemaDataElement>>> schema = default;
            DataFactoryLinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DatasetFolder> folder = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("structure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structure = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetSchemaDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownDataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties);
        }

        DataFactoryDatasetProperties IModelJsonSerializable<DataFactoryDatasetProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDatasetProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFactoryDatasetProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFactoryDatasetProperties IModelSerializable<DataFactoryDatasetProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFactoryDatasetProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFactoryDatasetProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFactoryDatasetProperties"/> to convert. </param>
        public static implicit operator RequestContent(DataFactoryDatasetProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFactoryDatasetProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFactoryDatasetProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFactoryDatasetProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
