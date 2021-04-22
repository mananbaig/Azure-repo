﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public class RegistryArtifactLiveTests : ContainerRegistryRecordedTestBase
    {
        private readonly string _repositoryName = "library/hello-world";

        public RegistryArtifactLiveTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
        }

        #region Setup methods

        private ContainerRegistryClient CreateClient()
        {
            return InstrumentClient(new ContainerRegistryClient(
                new Uri(TestEnvironment.Endpoint),
                TestEnvironment.Credential,
                InstrumentClientOptions(new ContainerRegistryClientOptions())
            ));
        }

        #endregion

        #region Manifest Tests
        [RecordedTest]
        public async Task CanGetManifestListProperties()
        {
            // Arrange
            var client = CreateClient();
            string tag = "v1";
            var artifact = client.GetArtifact(_repositoryName, tag);
            int helloWorldManifestReferences = 9;

            // Act
            ManifestProperties properties = await artifact.GetManifestPropertiesAsync();

            // Assert
            Assert.Contains(tag, properties.Tags.ToList());
            Assert.AreEqual(_repositoryName, properties.Repository);
            Assert.GreaterOrEqual(helloWorldManifestReferences, properties.Manifests.Count);

            Assert.IsTrue(properties.Manifests.Any(
                artifact =>
                    artifact.Architecture == "arm64" &&
                    artifact.OperatingSystem == "linux"));

            Assert.IsTrue(properties.Manifests.Any(
                artifact =>
                    artifact.Architecture == "amd64" &&
                    artifact.OperatingSystem == "windows"));
        }

        [RecordedTest]
        public async Task CanGetManifestProperties()
        {
            // Arrange
            var client = CreateClient();
            string tag = "v1";
            var artifact = client.GetArtifact(_repositoryName, tag);

            // Act
            ManifestProperties listProperties = await artifact.GetManifestPropertiesAsync();
            var arm64LinuxImage = listProperties.Manifests.First(
                artifact =>
                    artifact.Architecture == "arm64" &&
                    artifact.OperatingSystem == "linux");
            ManifestProperties properties = await artifact.GetManifestPropertiesAsync();

            // Assert
            Assert.AreEqual(_repositoryName, properties.Repository);
            Assert.IsNotNull(properties.Digest);
            Assert.AreEqual("arm64", properties.Architecture);
            Assert.AreEqual("linux", properties.OperatingSystem);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanSetManifestProperties()
        {
            // Arrange
            var client = CreateClient();
            string tag = "latest";
            var artifact = client.GetArtifact(_repositoryName, tag);

            ManifestProperties artifactProperties = await artifact.GetManifestPropertiesAsync();
            ContentProperties originalContentProperties = artifactProperties.WriteableProperties;

            // Act
            ManifestProperties properties = await artifact.SetManifestPropertiesAsync(
                new ContentProperties()
                {
                    CanList = false,
                    CanRead = false,
                    CanWrite = false,
                    CanDelete = false
                });

            // Assert
            Assert.IsFalse(properties.WriteableProperties.CanList);
            Assert.IsFalse(properties.WriteableProperties.CanRead);
            Assert.IsFalse(properties.WriteableProperties.CanWrite);
            Assert.IsFalse(properties.WriteableProperties.CanDelete);

            ManifestProperties updatedProperties = await artifact.GetManifestPropertiesAsync();

            Assert.IsFalse(updatedProperties.WriteableProperties.CanList);
            Assert.IsFalse(updatedProperties.WriteableProperties.CanRead);
            Assert.IsFalse(updatedProperties.WriteableProperties.CanWrite);
            Assert.IsFalse(updatedProperties.WriteableProperties.CanDelete);

            // Cleanup
            await artifact.SetManifestPropertiesAsync(originalContentProperties);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanDeleteRegistryArtifact()
        {
            // Arrange
            string repository = $"library/node";
            string tag = "test-delete-image";
            var client = CreateClient();
            var artifact = client.GetArtifact(repository, tag);

            if (Mode != RecordedTestMode.Playback)
            {
                await ImportImage(repository, tag);
            }

            // Act
            await artifact.DeleteAsync();

            // Assert

            // This will be removed, pending investigation into potential race condition.
            // https://github.com/azure/azure-sdk-for-net/issues/19699
            if (Mode != RecordedTestMode.Playback)
            {
                await Task.Delay(5000);
            }

            Assert.ThrowsAsync<RequestFailedException>(async () => { await artifact.GetManifestPropertiesAsync(); });
        }

        #endregion

        #region Tag Tests
        [RecordedTest]
        public async Task CanGetTags()
        {
            // Arrange
            var client = CreateClient();
            string tagName = "latest";
            var artifact = client.GetArtifact(_repositoryName, tagName);

            // Act
            AsyncPageable<TagProperties> tags = artifact.GetTagsAsync();

            bool gotV1Tag = false;
            await foreach (TagProperties tag in tags)
            {
                if (tag.Name.Contains("v1"))
                {
                    gotV1Tag = true;
                }
            }

            // Assert
            Assert.IsTrue(gotV1Tag);
        }

        [RecordedTest]
        public async Task CanGetTagsWithCustomPageSize()
        {
            // Arrange
            var client = CreateClient();
            string tagName = "latest";
            var artifact = client.GetArtifact(_repositoryName, tagName);
            int pageSize = 2;
            int minExpectedPages = 2;

            // Act
            AsyncPageable<TagProperties> tags = artifact.GetTagsAsync();
            var pages = tags.AsPages(pageSizeHint: pageSize);

            int pageCount = 0;
            await foreach (var page in pages)
            {
                Assert.IsTrue(page.Values.Count <= pageSize);
                pageCount++;
            }

            // Assert
            Assert.IsTrue(pageCount >= minExpectedPages);
        }

        [RecordedTest]
        public async Task CanGetTagsStartingMidCollection()
        {
            // Arrange
            var client = CreateClient();
            string tagName = "latest";
            var artifact = client.GetArtifact(_repositoryName, tagName);
            int pageSize = 1;
            int minExpectedPages = 2;

            // Act
            AsyncPageable<TagProperties> tags = artifact.GetTagsAsync();
            var pages = tags.AsPages($"</acr/v1/{_repositoryName}/_tags?last=v1&n={pageSize}>");

            int pageCount = 0;
            Page<TagProperties> firstPage = null;
            await foreach (var page in pages)
            {
                if (pageCount == 0)
                {
                    firstPage = page;
                }

                Assert.IsTrue(page.Values.Count <= pageSize);
                pageCount++;
            }

            // Assert
            Assert.AreNotEqual(null, firstPage);
            Assert.AreEqual("v2", firstPage.Values[0].Name);
            Assert.GreaterOrEqual(pageCount, minExpectedPages);
        }

        [RecordedTest]
        public async Task CanGetTagProperties()
        {
            // Arrange
            var client = CreateClient();
            string tag = "latest";
            var artifact = client.GetArtifact(_repositoryName, tag);

            // Act
            TagProperties properties = await artifact.GetTagPropertiesAsync(tag);

            // Assert
            Assert.AreEqual(tag, properties.Name);
            Assert.AreEqual(_repositoryName, properties.Repository);
        }

        [RecordedTest]
        public async Task CanGetTagsOrdered()
        {
            // Arrange
            var client = CreateClient();
            string tagName = "latest";
            var artifact = client.GetArtifact(_repositoryName, tagName);

            if (Mode != RecordedTestMode.Playback)
            {
                await ImportImage(_repositoryName, "newest");
            }

            // Act
            AsyncPageable<TagProperties> tags = artifact.GetTagsAsync(new GetTagsOptions(TagOrderBy.LastUpdatedOnDescending));

            // Assert
            await foreach (TagProperties tag in tags)
            {
                Assert.That(tag.Name.Contains("newest"));
                break;
            }
        }

        [RecordedTest, NonParallelizable]
        public async Task CanSetTagProperties()
        {
            // Arrange
            var client = CreateClient();
            string tag = "latest";
            var artifact = client.GetArtifact(_repositoryName, tag);

            TagProperties tagProperties = await artifact.GetTagPropertiesAsync(tag);
            ContentProperties originalContentProperties = tagProperties.WriteableProperties;

            // Act
            TagProperties properties = await artifact.SetTagPropertiesAsync(
                tag,
                new ContentProperties()
                {
                    CanList = false,
                    CanRead = false,
                    CanWrite = false,
                    CanDelete = false
                });

            // Assert
            Assert.IsFalse(properties.WriteableProperties.CanList);
            Assert.IsFalse(properties.WriteableProperties.CanRead);
            Assert.IsFalse(properties.WriteableProperties.CanWrite);
            Assert.IsFalse(properties.WriteableProperties.CanDelete);

            TagProperties updatedProperties = await artifact.GetTagPropertiesAsync(tag);

            Assert.IsFalse(updatedProperties.WriteableProperties.CanList);
            Assert.IsFalse(updatedProperties.WriteableProperties.CanRead);
            Assert.IsFalse(updatedProperties.WriteableProperties.CanWrite);
            Assert.IsFalse(updatedProperties.WriteableProperties.CanDelete);

            // Cleanup
            await artifact.SetTagPropertiesAsync(tag, originalContentProperties);
        }

        [RecordedTest, NonParallelizable]
        public async Task CanDeleteTag()
        {
            // Arrange
            var client = CreateClient();
            string tag = "test-delete-tag";
            var artifact = client.GetArtifact(_repositoryName, tag);

            if (Mode != RecordedTestMode.Playback)
            {
                await ImportImage(_repositoryName, tag);
            }

            // Act
            await artifact.UntagAsync(tag);

            // Assert

            // This will be removed, pending investigation into potential race condition.
            // https://github.com/azure/azure-sdk-for-net/issues/19699
            if (Mode != RecordedTestMode.Playback)
            {
                await Task.Delay(5000);
            }

            Assert.ThrowsAsync<RequestFailedException>(async () => { await artifact.GetTagPropertiesAsync(tag); });
        }
        #endregion
    }
}
