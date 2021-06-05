// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// Ingests data into a <see cref="DataFeed"/> for anomaly detection.
    /// </summary>
    public abstract class DataFeedSource
    {
        internal DataFeedSourceType Type { get; }

        internal DataFeedSource(DataFeedSourceType dataFeedSourceType)
        {
            Type = dataFeedSourceType;
        }

        internal static DataFeedSource GetDataFeedSource(DataFeedDetail dataFeedDetail) =>
            dataFeedDetail switch
            {
                AzureApplicationInsightsDataFeed d => new AzureApplicationInsightsDataFeedSource(d.DataSourceParameter),
                AzureBlobDataFeed d => new AzureBlobDataFeedSource(d.DataSourceParameter),
                AzureCosmosDBDataFeed d => new AzureCosmosDbDataFeedSource(d.DataSourceParameter),
                AzureDataLakeStorageGen2DataFeed d => new AzureDataLakeStorageGen2DataFeedSource(d.DataSourceParameter),
                AzureEventHubsDataFeed d => new AzureEventHubsDataFeedSource(d.DataSourceParameter),
                AzureTableDataFeed d => new AzureTableDataFeedSource(d.DataSourceParameter),
                InfluxDBDataFeed d => new InfluxDbDataFeedSource(d.DataSourceParameter),
                AzureDataExplorerDataFeed d => new AzureDataExplorerDataFeedSource(d.DataSourceParameter),
                AzureLogAnalyticsDataFeed d => new LogAnalyticsDataFeedSource(d.DataSourceParameter),
                MySqlDataFeed d => new MySqlDataFeedSource(d.DataSourceParameter),
                PostgreSqlDataFeed d => new PostgreSqlDataFeedSource(d.DataSourceParameter),
                SQLServerDataFeed d => new SqlServerDataFeedSource(d.DataSourceParameter),
                MongoDBDataFeed d => new MongoDbDataFeedSource(d.DataSourceParameter),
                _ => throw new InvalidOperationException("Invalid DataFeedDetail type")
            };

        /// <summary>
        /// Initializes a new instance of a data source specific DataFeedDetail.
        /// </summary>
        internal DataFeedDetail InstantiateDataFeedDetail(string name, DataFeedGranularityType granularityType, IList<DataFeedMetric> metricColumns, DateTimeOffset ingestionStartTime)
        {
            ingestionStartTime = ClientCommon.NormalizeDateTimeOffset(ingestionStartTime);

            // AzureEventHubsParameter p => new AzureEventHubsDataFeed(name, granularityType, metricColumns, ingestionStartTime, p),
            return this switch
            {
                AzureApplicationInsightsDataFeedSource d => new AzureApplicationInsightsDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new AzureApplicationInsightsParameter(d.Query) { ApiKey = d.ApiKey, ApplicationId = d.ApplicationId, AzureCloud = d.AzureCloud }),
                AzureBlobDataFeedSource d => new AzureBlobDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new AzureBlobParameter(d.Container, d.BlobTemplate) { ConnectionString = d.ConnectionString }),
                AzureCosmosDbDataFeedSource d => new AzureCosmosDBDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new AzureCosmosDBParameter(d.SqlQuery, d.Database, d.CollectionId) { ConnectionString = d.ConnectionString }),
                AzureDataExplorerDataFeedSource d => new AzureDataExplorerDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new SqlSourceParameter(d.Query) { ConnectionString = d.ConnectionString }),
                AzureDataLakeStorageGen2DataFeedSource d => new AzureDataLakeStorageGen2DataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new AzureDataLakeStorageGen2Parameter(d.FileSystemName, d.DirectoryTemplate, d.FileTemplate) { AccountKey = d.AccountKey, AccountName = d.AccountName }),
                AzureTableDataFeedSource d => new AzureTableDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new AzureTableParameter(d.Table, d.Query) { ConnectionString = d.ConnectionString }),
                InfluxDbDataFeedSource d => new InfluxDBDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new InfluxDBParameter(d.Query) { UserName = d.Username, Password = d.Password, Database = d.Database, ConnectionString = d.ConnectionString }),
                MongoDbDataFeedSource d => new MongoDBDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new MongoDBParameter(d.Command) { Database = d.Database, ConnectionString = d.ConnectionString }),
                MySqlDataFeedSource d => new MySqlDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new SqlSourceParameter(d.Query) { ConnectionString = d.ConnectionString }),
                PostgreSqlDataFeedSource d => new PostgreSqlDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new SqlSourceParameter(d.Query) { ConnectionString = d.ConnectionString }),
                SqlServerDataFeedSource d => new SQLServerDataFeed(name, granularityType, metricColumns, ingestionStartTime,
                    new SqlSourceParameter(d.Query) { ConnectionString = d.ConnectionString }),
                _ => throw new InvalidOperationException("Invalid DataFeedDetail type")
            };
        }

        /// <summary>
        /// Initializes a new instance of a data source specific DataFeedDetailPatch.
        /// </summary>
        internal DataFeedDetailPatch InstantiateDataFeedDetailPatch() => this switch
        {
            // AzureEventHubsParameter p => new AzureEventHubsDataFeedPatch() { DataSourceParameter = p },
            AzureApplicationInsightsDataFeedSource d => new AzureApplicationInsightsDataFeedPatch()
                { DataSourceParameter = new() { Query = d.Query, ApiKey = d.ApiKey, ApplicationId = d.ApplicationId, AzureCloud = d.AzureCloud } },
            AzureBlobDataFeedSource d => new AzureBlobDataFeedPatch()
                { DataSourceParameter = new() { Container = d.Container, BlobTemplate = d.BlobTemplate, ConnectionString = d.ConnectionString } },
            AzureCosmosDbDataFeedSource d => new AzureCosmosDBDataFeedPatch()
                { DataSourceParameter = new() { SqlQuery = d.SqlQuery, Database = d.Database, CollectionId = d.CollectionId, ConnectionString = d.ConnectionString } },
            AzureDataExplorerDataFeedSource d => new AzureDataExplorerDataFeedPatch()
                { DataSourceParameter = new() { Query = d.Query, ConnectionString = d.ConnectionString } },
            AzureDataLakeStorageGen2DataFeedSource d => new AzureDataLakeStorageGen2DataFeedPatch()
                { DataSourceParameter = new() { FileSystemName = d.FileSystemName, DirectoryTemplate = d.DirectoryTemplate, FileTemplate = d.FileTemplate, AccountKey = d.AccountKey, AccountName = d.AccountName } },
            AzureTableDataFeedSource d => new AzureTableDataFeedPatch()
                { DataSourceParameter = new() { Table = d.Table, Query = d.Query, ConnectionString = d.ConnectionString } },
            InfluxDbDataFeedSource d => new InfluxDBDataFeedPatch()
                { DataSourceParameter = new() { Query = d.Query, UserName = d.Username, Password = d.Password, Database = d.Database, ConnectionString = d.ConnectionString } },
            MongoDbDataFeedSource d => new MongoDBDataFeedPatch()
                { DataSourceParameter = new() { Command = d.Command, Database = d.Database, ConnectionString = d.ConnectionString } },
            MySqlDataFeedSource d => new MySqlDataFeedPatch()
                { DataSourceParameter = new() { Query = d.Query, ConnectionString = d.ConnectionString } },
            PostgreSqlDataFeedSource d => new PostgreSqlDataFeedPatch()
                { DataSourceParameter = new() { Query = d.Query, ConnectionString = d.ConnectionString } },
            SqlServerDataFeedSource d => new SQLServerDataFeedPatch()
                { DataSourceParameter = new() { Query = d.Query, ConnectionString = d.ConnectionString } },
            _ => throw new InvalidOperationException("Invalid DataFeedDetailPatch type")
        };
    }
}
