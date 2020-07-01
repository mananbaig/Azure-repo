// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.Data.Tables;
using Azure.Data.Tables.Sas;
using Moq;
using NUnit.Framework;

namespace Azure.Tables.Tests
{
    public class TableClientTests : ClientTestBase
    {
        public TableClientTests(bool isAsync) : base(isAsync)
        { }

        private const string tableName = "someTableName";
        private TableClient client_Instrumented { get; set; }
        private Dictionary<string, object> entityWithoutPK = new Dictionary<string, object> { { TableConstants.PropertyNames.RowKey, "row" } };
        private Dictionary<string, object> entityWithoutRK = new Dictionary<string, object> { { TableConstants.PropertyNames.PartitionKey, "partition" } };
        private Dictionary<string, object> validEntity = new Dictionary<string, object> { { TableConstants.PropertyNames.PartitionKey, "partition" }, { TableConstants.PropertyNames.RowKey, "row" } };

        [SetUp]
        public void TestSetup()
        {
            var service_Instrumented = InstrumentClient(new TableServiceClient(new Uri("https://example.com")));
            client_Instrumented = service_Instrumented.GetTableClient(tableName);
        }

        /// <summary>
        /// Validates the functionality of the TableClient.
        /// </summary>
        [Test]
        public void ServiceMethodsValidateArguments()
        {
            Assert.That(async () => await client_Instrumented.CreateEntityAsync(null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.CreateEntityAsync<TableEntity>(null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpsertEntityAsync<TableEntity>(TableClient.UpdateMode.Replace, null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpsertEntityAsync(TableClient.UpdateMode.Replace, new TableEntity { PartitionKey = null, RowKey = "row" }), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.PartitionKey}.");

            Assert.That(async () => await client_Instrumented.UpsertEntityAsync(TableClient.UpdateMode.Replace, new TableEntity { PartitionKey = "partition", RowKey = null }), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.RowKey}.");

            Assert.That(async () => await client_Instrumented.UpdateEntityAsync(TableClient.UpdateMode.Replace, null, "etag"), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the entity is not null.");

            Assert.That(async () => await client_Instrumented.UpdateEntityAsync(TableClient.UpdateMode.Replace, validEntity, null), Throws.InstanceOf<ArgumentNullException>(), "The method should validate the eTag is not null.");

            Assert.That(async () => await client_Instrumented.UpdateEntityAsync(TableClient.UpdateMode.Replace, entityWithoutPK, "etag"), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.PartitionKey}.");

            Assert.That(async () => await client_Instrumented.UpdateEntityAsync(TableClient.UpdateMode.Replace, entityWithoutRK, "etag"), Throws.InstanceOf<ArgumentException>(), $"The method should validate the entity has a {TableConstants.PropertyNames.RowKey}.");
        }

        [Test]
        public void GetSasBuilderPopulatesPermissionsAndExpiry()
        {
            var expiry = DateTimeOffset.Now.AddDays(1);
            var permissions = TableSasPermissions.All;

            var sas = client_Instrumented.GetSasBuilder(permissions, expiry);

            Assert.That(sas.Permissions, Is.EqualTo(permissions.ToPermissionsString()));
            Assert.That(sas.ExpiresOn, Is.EqualTo(expiry));
        }

        [Test]
        public void GetSasBuilderPopulatesRawPermissionsAndExpiry()
        {
            var expiry = DateTimeOffset.Now.AddDays(1);
            var permissions = TableSasPermissions.All;

            var sas = client_Instrumented.GetSasBuilder(permissions.ToPermissionsString(), expiry);

            Assert.That(sas.Permissions, Is.EqualTo(permissions.ToPermissionsString()));
            Assert.That(sas.ExpiresOn, Is.EqualTo(expiry));
        }
    }
}
