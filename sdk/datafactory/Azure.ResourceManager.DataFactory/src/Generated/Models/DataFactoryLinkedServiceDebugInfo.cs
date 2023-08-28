// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service debug resource. </summary>
    public partial class DataFactoryLinkedServiceDebugInfo : DataFactoryDebugInfo
    {
        /// <summary> Initializes a new instance of DataFactoryLinkedServiceDebugInfo. </summary>
        /// <param name="properties">
        /// Properties of linked service.
        /// Please note <see cref="DataFactoryLinkedServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsLinkedService"/>, <see cref="AmazonRdsForOracleLinkedService"/>, <see cref="AmazonRdsForSqlServerLinkedService"/>, <see cref="AmazonRedshiftLinkedService"/>, <see cref="AmazonS3LinkedService"/>, <see cref="AmazonS3CompatibleLinkedService"/>, <see cref="AppFiguresLinkedService"/>, <see cref="AsanaLinkedService"/>, <see cref="AzureBatchLinkedService"/>, <see cref="AzureBlobFSLinkedService"/>, <see cref="AzureBlobStorageLinkedService"/>, <see cref="AzureDataExplorerLinkedService"/>, <see cref="AzureDataLakeAnalyticsLinkedService"/>, <see cref="AzureDataLakeStoreLinkedService"/>, <see cref="AzureDatabricksLinkedService"/>, <see cref="AzureDatabricksDeltaLakeLinkedService"/>, <see cref="AzureFileStorageLinkedService"/>, <see cref="AzureFunctionLinkedService"/>, <see cref="AzureKeyVaultLinkedService"/>, <see cref="AzureMLLinkedService"/>, <see cref="AzureMLServiceLinkedService"/>, <see cref="AzureMariaDBLinkedService"/>, <see cref="AzureMySqlLinkedService"/>, <see cref="AzurePostgreSqlLinkedService"/>, <see cref="AzureSearchLinkedService"/>, <see cref="AzureSqlDWLinkedService"/>, <see cref="AzureSqlDatabaseLinkedService"/>, <see cref="AzureSqlMILinkedService"/>, <see cref="AzureStorageLinkedService"/>, <see cref="AzureSynapseArtifactsLinkedService"/>, <see cref="AzureTableStorageLinkedService"/>, <see cref="CassandraLinkedService"/>, <see cref="CommonDataServiceForAppsLinkedService"/>, <see cref="ConcurLinkedService"/>, <see cref="CosmosDBLinkedService"/>, <see cref="CosmosDBMongoDBApiLinkedService"/>, <see cref="CouchbaseLinkedService"/>, <see cref="CustomDataSourceLinkedService"/>, <see cref="DataworldLinkedService"/>, <see cref="Db2LinkedService"/>, <see cref="DrillLinkedService"/>, <see cref="DynamicsLinkedService"/>, <see cref="DynamicsAXLinkedService"/>, <see cref="DynamicsCrmLinkedService"/>, <see cref="EloquaLinkedService"/>, <see cref="FileServerLinkedService"/>, <see cref="FtpServerLinkedService"/>, <see cref="GoogleAdWordsLinkedService"/>, <see cref="GoogleBigQueryLinkedService"/>, <see cref="GoogleCloudStorageLinkedService"/>, <see cref="GoogleSheetsLinkedService"/>, <see cref="GreenplumLinkedService"/>, <see cref="HBaseLinkedService"/>, <see cref="HDInsightLinkedService"/>, <see cref="HDInsightOnDemandLinkedService"/>, <see cref="HdfsLinkedService"/>, <see cref="HiveLinkedService"/>, <see cref="HttpLinkedService"/>, <see cref="HubspotLinkedService"/>, <see cref="ImpalaLinkedService"/>, <see cref="InformixLinkedService"/>, <see cref="JiraLinkedService"/>, <see cref="MagentoLinkedService"/>, <see cref="MariaDBLinkedService"/>, <see cref="MarketoLinkedService"/>, <see cref="MicrosoftAccessLinkedService"/>, <see cref="MongoDBLinkedService"/>, <see cref="MongoDBAtlasLinkedService"/>, <see cref="MongoDBV2LinkedService"/>, <see cref="MySqlLinkedService"/>, <see cref="NetezzaLinkedService"/>, <see cref="ODataLinkedService"/>, <see cref="OdbcLinkedService"/>, <see cref="Office365LinkedService"/>, <see cref="OracleLinkedService"/>, <see cref="OracleCloudStorageLinkedService"/>, <see cref="OracleServiceCloudLinkedService"/>, <see cref="PaypalLinkedService"/>, <see cref="PhoenixLinkedService"/>, <see cref="PostgreSqlLinkedService"/>, <see cref="PrestoLinkedService"/>, <see cref="QuickBooksLinkedService"/>, <see cref="QuickbaseLinkedService"/>, <see cref="ResponsysLinkedService"/>, <see cref="RestServiceLinkedService"/>, <see cref="SalesforceLinkedService"/>, <see cref="SalesforceMarketingCloudLinkedService"/>, <see cref="SalesforceServiceCloudLinkedService"/>, <see cref="SapBWLinkedService"/>, <see cref="SapCloudForCustomerLinkedService"/>, <see cref="SapEccLinkedService"/>, <see cref="SapHanaLinkedService"/>, <see cref="SapOdpLinkedService"/>, <see cref="SapOpenHubLinkedService"/>, <see cref="SapTableLinkedService"/>, <see cref="ServiceNowLinkedService"/>, <see cref="SftpServerLinkedService"/>, <see cref="SharePointOnlineListLinkedService"/>, <see cref="ShopifyLinkedService"/>, <see cref="SmartsheetLinkedService"/>, <see cref="SnowflakeLinkedService"/>, <see cref="SparkLinkedService"/>, <see cref="SqlServerLinkedService"/>, <see cref="SquareLinkedService"/>, <see cref="SybaseLinkedService"/>, <see cref="TeamDeskLinkedService"/>, <see cref="TeradataLinkedService"/>, <see cref="TwilioLinkedService"/>, <see cref="VerticaLinkedService"/>, <see cref="WebLinkedService"/>, <see cref="XeroLinkedService"/>, <see cref="ZendeskLinkedService"/> and <see cref="ZohoLinkedService"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryLinkedServiceDebugInfo(DataFactoryLinkedServiceProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary>
        /// Properties of linked service.
        /// Please note <see cref="DataFactoryLinkedServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsLinkedService"/>, <see cref="AmazonRdsForOracleLinkedService"/>, <see cref="AmazonRdsForSqlServerLinkedService"/>, <see cref="AmazonRedshiftLinkedService"/>, <see cref="AmazonS3LinkedService"/>, <see cref="AmazonS3CompatibleLinkedService"/>, <see cref="AppFiguresLinkedService"/>, <see cref="AsanaLinkedService"/>, <see cref="AzureBatchLinkedService"/>, <see cref="AzureBlobFSLinkedService"/>, <see cref="AzureBlobStorageLinkedService"/>, <see cref="AzureDataExplorerLinkedService"/>, <see cref="AzureDataLakeAnalyticsLinkedService"/>, <see cref="AzureDataLakeStoreLinkedService"/>, <see cref="AzureDatabricksLinkedService"/>, <see cref="AzureDatabricksDeltaLakeLinkedService"/>, <see cref="AzureFileStorageLinkedService"/>, <see cref="AzureFunctionLinkedService"/>, <see cref="AzureKeyVaultLinkedService"/>, <see cref="AzureMLLinkedService"/>, <see cref="AzureMLServiceLinkedService"/>, <see cref="AzureMariaDBLinkedService"/>, <see cref="AzureMySqlLinkedService"/>, <see cref="AzurePostgreSqlLinkedService"/>, <see cref="AzureSearchLinkedService"/>, <see cref="AzureSqlDWLinkedService"/>, <see cref="AzureSqlDatabaseLinkedService"/>, <see cref="AzureSqlMILinkedService"/>, <see cref="AzureStorageLinkedService"/>, <see cref="AzureSynapseArtifactsLinkedService"/>, <see cref="AzureTableStorageLinkedService"/>, <see cref="CassandraLinkedService"/>, <see cref="CommonDataServiceForAppsLinkedService"/>, <see cref="ConcurLinkedService"/>, <see cref="CosmosDBLinkedService"/>, <see cref="CosmosDBMongoDBApiLinkedService"/>, <see cref="CouchbaseLinkedService"/>, <see cref="CustomDataSourceLinkedService"/>, <see cref="DataworldLinkedService"/>, <see cref="Db2LinkedService"/>, <see cref="DrillLinkedService"/>, <see cref="DynamicsLinkedService"/>, <see cref="DynamicsAXLinkedService"/>, <see cref="DynamicsCrmLinkedService"/>, <see cref="EloquaLinkedService"/>, <see cref="FileServerLinkedService"/>, <see cref="FtpServerLinkedService"/>, <see cref="GoogleAdWordsLinkedService"/>, <see cref="GoogleBigQueryLinkedService"/>, <see cref="GoogleCloudStorageLinkedService"/>, <see cref="GoogleSheetsLinkedService"/>, <see cref="GreenplumLinkedService"/>, <see cref="HBaseLinkedService"/>, <see cref="HDInsightLinkedService"/>, <see cref="HDInsightOnDemandLinkedService"/>, <see cref="HdfsLinkedService"/>, <see cref="HiveLinkedService"/>, <see cref="HttpLinkedService"/>, <see cref="HubspotLinkedService"/>, <see cref="ImpalaLinkedService"/>, <see cref="InformixLinkedService"/>, <see cref="JiraLinkedService"/>, <see cref="MagentoLinkedService"/>, <see cref="MariaDBLinkedService"/>, <see cref="MarketoLinkedService"/>, <see cref="MicrosoftAccessLinkedService"/>, <see cref="MongoDBLinkedService"/>, <see cref="MongoDBAtlasLinkedService"/>, <see cref="MongoDBV2LinkedService"/>, <see cref="MySqlLinkedService"/>, <see cref="NetezzaLinkedService"/>, <see cref="ODataLinkedService"/>, <see cref="OdbcLinkedService"/>, <see cref="Office365LinkedService"/>, <see cref="OracleLinkedService"/>, <see cref="OracleCloudStorageLinkedService"/>, <see cref="OracleServiceCloudLinkedService"/>, <see cref="PaypalLinkedService"/>, <see cref="PhoenixLinkedService"/>, <see cref="PostgreSqlLinkedService"/>, <see cref="PrestoLinkedService"/>, <see cref="QuickBooksLinkedService"/>, <see cref="QuickbaseLinkedService"/>, <see cref="ResponsysLinkedService"/>, <see cref="RestServiceLinkedService"/>, <see cref="SalesforceLinkedService"/>, <see cref="SalesforceMarketingCloudLinkedService"/>, <see cref="SalesforceServiceCloudLinkedService"/>, <see cref="SapBWLinkedService"/>, <see cref="SapCloudForCustomerLinkedService"/>, <see cref="SapEccLinkedService"/>, <see cref="SapHanaLinkedService"/>, <see cref="SapOdpLinkedService"/>, <see cref="SapOpenHubLinkedService"/>, <see cref="SapTableLinkedService"/>, <see cref="ServiceNowLinkedService"/>, <see cref="SftpServerLinkedService"/>, <see cref="SharePointOnlineListLinkedService"/>, <see cref="ShopifyLinkedService"/>, <see cref="SmartsheetLinkedService"/>, <see cref="SnowflakeLinkedService"/>, <see cref="SparkLinkedService"/>, <see cref="SqlServerLinkedService"/>, <see cref="SquareLinkedService"/>, <see cref="SybaseLinkedService"/>, <see cref="TeamDeskLinkedService"/>, <see cref="TeradataLinkedService"/>, <see cref="TwilioLinkedService"/>, <see cref="VerticaLinkedService"/>, <see cref="WebLinkedService"/>, <see cref="XeroLinkedService"/>, <see cref="ZendeskLinkedService"/> and <see cref="ZohoLinkedService"/>.
        /// </summary>
        public DataFactoryLinkedServiceProperties Properties { get; }
    }
}
