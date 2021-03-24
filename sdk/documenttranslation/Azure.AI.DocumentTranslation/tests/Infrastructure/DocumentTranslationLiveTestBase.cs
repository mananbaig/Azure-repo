﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Sas;

namespace Azure.AI.DocumentTranslation.Tests
{
    public class DocumentTranslationLiveTestBase : RecordedTestBase<DocumentTranslationTestEnvironment>
    {
        protected TimeSpan PollingInterval => TimeSpan.FromSeconds(Mode == RecordedTestMode.Playback ? 0 : 30);

        public DocumentTranslationLiveTestBase(bool isAsync, RecordedTestMode? mode = null)
            : base(isAsync, mode ?? RecordedTestUtilities.GetModeFromEnvironment())
        {
            Sanitizer = new DocumentTranslationRecordedTestSanitizer();
        }

        public DocumentTranslationClient GetClient(
            AzureKeyCredential credential = default,
            DocumentTranslationClientOptions options = default)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            options ??= new DocumentTranslationClientOptions();

            credential ??= new AzureKeyCredential(TestEnvironment.ApiKey);
            return InstrumentClient(new DocumentTranslationClient(endpoint, credential, InstrumentClientOptions(options)));
        }

        public async Task<Uri> CreateSourceContainerAsync(List<string> documents)
        {
            string containerName = "source" + Guid.NewGuid().ToString();
            var containerClient = new BlobContainerClient(TestEnvironment.StorageConnectionString, containerName.ToLower());
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.BlobContainer).ConfigureAwait(false);

            for (int i = 0; i < documents.Count; i++)
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(documents[i]);
                MemoryStream stream = new MemoryStream(byteArray);
                await containerClient.UploadBlobAsync($"document{i}.txt", stream);
            }

            var expiresOn = DateTimeOffset.Now.AddHours(1);
            return containerClient.GenerateSasUri(BlobContainerSasPermissions.List | BlobContainerSasPermissions.Read, expiresOn);
        }

        public async Task<Uri> CreateTargetContainerAsync()
        {
            string containerName = "target" + Guid.NewGuid().ToString();
            var containerClient = new BlobContainerClient(TestEnvironment.StorageConnectionString, containerName.ToLower());
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.BlobContainer).ConfigureAwait(false);

            var expiresOn = DateTimeOffset.Now.AddHours(1);
            return containerClient.GenerateSasUri(BlobContainerSasPermissions.List | BlobContainerSasPermissions.Write, expiresOn);
        }
    }
}
