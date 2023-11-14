﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.DocumentIntelligence.Tests
{
    public class MiscellaneousOperationsLiveTests : DocumentIntelligenceLiveTestBase
    {
        public MiscellaneousOperationsLiveTests(bool isAsync)
            : base(isAsync)
        {
        }

        #region Resource Info

        [RecordedTest]
        public async Task GetResourceInfo()
        {
            var client = CreateDocumentModelAdministrationClient();
            var startTime = Recording.UtcNow;

            // Ensure we will have at least one custom model to populate the resource details.
            await using var disposableModel = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl);

            ResourceDetails resourceDetails = await client.GetResourceInfoAsync();

            Assert.That(resourceDetails.CustomDocumentModels, Is.Not.Null);
            Assert.That(resourceDetails.CustomDocumentModels.Count, Is.GreaterThan(0));
            Assert.That(resourceDetails.CustomDocumentModels.Limit, Is.GreaterThanOrEqualTo(resourceDetails.CustomDocumentModels.Count));

            Assert.That(resourceDetails.CustomNeuralDocumentModelBuilds, Is.Not.Null);
            Assert.That(resourceDetails.CustomNeuralDocumentModelBuilds.Used, Is.GreaterThanOrEqualTo(0));
            Assert.That(resourceDetails.CustomNeuralDocumentModelBuilds.Quota, Is.GreaterThanOrEqualTo(resourceDetails.CustomNeuralDocumentModelBuilds.Used));
            Assert.That(resourceDetails.CustomNeuralDocumentModelBuilds.QuotaResetDateTime, Is.GreaterThan(startTime));
        }

        #endregion Resource Info

        #region Get Operation

        [RecordedTest]
        [Ignore("Calling Operation.Id throws a NotSupportedException: https://github.com/Azure/autorest.csharp/issues/2158")]
        public async Task GetOperationWithDocumentModelBuild()
        {
            var client = CreateDocumentModelAdministrationClient();
            var description = "This model was generated by a .NET test.";
            var tags = new Dictionary<string, string>() { { "tag1", "value1" }, { "tag2", "value2" } };
            var startTime = Recording.UtcNow;

            await using var disposableModel = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl, description, tags);

            var operationId = new Guid(disposableModel.Operation.Id);

            OperationDetails operationDetails = await client.GetOperationAsync(operationId);

            var resourceLocation = $"{TestEnvironment.Endpoint}formrecognizer/documentModels/{disposableModel.ModelId}?api-version={ServiceVersionString}";

            ValidateOperationDetails(operationDetails, operationId, resourceLocation, startTime, tags);

            var buildOperationDetails = operationDetails as DocumentModelBuildOperationDetails;

            Assert.That(buildOperationDetails, Is.Not.Null);

            DocumentAssert.AreEqual(disposableModel.Value, buildOperationDetails.Result);
        }

        [RecordedTest]
        [Ignore("Calling Operation.Id throws a NotSupportedException: https://github.com/Azure/autorest.csharp/issues/2158")]
        public async Task GetOperationWithDocumentClassifierBuild()
        {
            var client = CreateDocumentModelAdministrationClient();
            var description = "This model was generated by a .NET test.";
            var tags = new Dictionary<string, string>();
            var startTime = Recording.UtcNow;

            await using var disposableClassifier = await BuildDisposableDocumentClassifierAsync(description);

            var operationId = new Guid(disposableClassifier.ClassifierId);

            OperationDetails operationDetails = await client.GetOperationAsync(operationId);

            var resourceLocation = $"{TestEnvironment.Endpoint}formrecognizer/documentClassifiers/{disposableClassifier.ClassifierId}?api-version={ServiceVersionString}";

            ValidateOperationDetails(operationDetails, operationId, resourceLocation, startTime, tags);

            var buildOperationDetails = operationDetails as DocumentClassifierBuildOperationDetails;

            Assert.That(buildOperationDetails, Is.Not.Null);

            DocumentAssert.AreEqual(disposableClassifier.Value, buildOperationDetails.Result);
        }

        [RecordedTest]
        public void GetOperationCanParseError()
        {
            var client = CreateDocumentModelAdministrationClient();
            var operationId = new Guid("00000000-0000-0000-0000-000000000000");

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(() => client.GetOperationAsync(operationId));

            Assert.That(ex.ErrorCode, Is.EqualTo("NotFound"));
        }

        #endregion Get Operation

        #region List Operations

        [RecordedTest]
        [Ignore("Calling Operation.Id throws a NotSupportedException: https://github.com/Azure/autorest.csharp/issues/2158")]
        public async Task GetOperations()
        {
            var client = CreateDocumentModelAdministrationClient();
            var description = "This model was generated by a .NET test.";
            var tags = new Dictionary<string, string>() { { "tag1", "value1" }, { "tag2", "value2" } };

            // Once model caching is implemented, we should make the models slightly different to make sure the cache won't return copies of the same model.
            await using var disposableModel0 = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl, description, tags);
            await using var disposableModel1 = await BuildDisposableDocumentModelAsync(TestEnvironment.BlobContainerSasUrl, description, tags);

            var operationId0 = new Guid(disposableModel0.Operation.Id);
            var operationId1 = new Guid(disposableModel1.Operation.Id);

            OperationDetails expectedOperation0 = await client.GetOperationAsync(operationId0);
            OperationDetails expectedOperation1 = await client.GetOperationAsync(operationId1);

            var expectedIdMapping = new Dictionary<Guid, OperationDetails>()
            {
                { operationId0, expectedOperation0 },
                { operationId1, expectedOperation1 }
            };
            var idMapping = new Dictionary<Guid, OperationDetails>();

            await foreach (OperationDetails operation in client.GetOperationsAsync())
            {
                if (expectedIdMapping.ContainsKey(operation.OperationId))
                {
                    idMapping.Add(operation.OperationId, operation);
                }

                if (idMapping.Count == expectedIdMapping.Count)
                {
                    break;
                }
            }

            Assert.That(idMapping.Count, Is.EqualTo(expectedIdMapping.Count));

            foreach (Guid id in expectedIdMapping.Keys)
            {
                Assert.That(idMapping, Contains.Key(id));

                OperationDetails expected = expectedIdMapping[id];
                OperationDetails operation = idMapping[id];

                Assert.That(operation.OperationId, Is.EqualTo(expected.OperationId));
                Assert.That(operation.ApiVersion, Is.EqualTo(expected.ApiVersion));
                Assert.That(operation.Status, Is.EqualTo(expected.Status));
                Assert.That(operation.PercentCompleted, Is.EqualTo(expected.PercentCompleted));
                Assert.That(operation.ResourceLocation.AbsoluteUri, Is.EqualTo(expected.ResourceLocation.AbsoluteUri));
                Assert.That(operation.CreatedDateTime, Is.EqualTo(expected.CreatedDateTime));
                Assert.That(operation.LastUpdatedDateTime, Is.EqualTo(expected.LastUpdatedDateTime));
                Assert.That(operation.Tags, Is.EquivalentTo(expected.Tags));

                Assert.That(operation.Error, Is.Null);
            }
        }

        #endregion List Operations

        private void ValidateOperationDetails(OperationDetails operationDetails, Guid operationId, string resourceLocation, DateTimeOffset startTime, IDictionary<string, string> tags)
        {
            Assert.That(operationDetails.OperationId, Is.EqualTo(operationId));
            Assert.That(operationDetails.Status, Is.EqualTo(OperationStatus.Succeeded));
            Assert.That(operationDetails.PercentCompleted, Is.EqualTo(100));
            Assert.That(operationDetails.ResourceLocation.AbsoluteUri, Is.EqualTo(resourceLocation));

            Assert.That(operationDetails.ApiVersion, Is.Null);
            Assert.That(operationDetails.Error, Is.Null);

            // Add a 4-hour tolerance because the model could have been cached before this test.
            Assert.That(operationDetails.CreatedDateTime, Is.GreaterThan(startTime - TimeSpan.FromHours(4)));
            Assert.That(operationDetails.LastUpdatedDateTime, Is.GreaterThan(operationDetails.CreatedDateTime));
            Assert.That(operationDetails.Tags, Is.EquivalentTo(tags));
        }
    }
}
