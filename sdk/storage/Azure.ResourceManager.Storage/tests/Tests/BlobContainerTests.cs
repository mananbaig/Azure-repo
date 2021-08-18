﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.ResourceManager.Resources;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Storage.Models;
using Azure.ResourceManager.Storage.Tests.Tests.Helpers;

namespace Azure.ResourceManager.Storage.Tests.Tests
{
    public class BlobContainerTests: StorageTestBase
    {
        private ResourceGroup resourceGroup;
        private StorageAccount storageAccount;
        private BlobServiceContainer blobServiceContainer;
        private BlobService blobService;
        private BlobContainerContainer blobContainerContainer;
        public BlobContainerTests(bool async) : base(async)
        {
        }
        [SetUp]
        public async Task createStorageAccountAndGetBlobContainerContainer()
        {
            resourceGroup = await CreateResourceGroupAsync();
            string accountName = Recording.GenerateAssetName("storage");
            StorageAccountContainer storageAccountContainer = resourceGroup.GetStorageAccounts();
            StorageAccountCreateOperation accountCreateOperation = await storageAccountContainer.CreateOrUpdateAsync(accountName, GetDefaultStorageAccountParameters());
            storageAccount = await accountCreateOperation.WaitForCompletionAsync();
            blobServiceContainer = storageAccount.GetBlobServices();
            blobService = await blobServiceContainer.GetAsync("default");
            blobContainerContainer = blobService.GetBlobContainers();
        }
        [TearDown]
        public async Task ClearStorageAccount()
        {
            if (resourceGroup != null)
            {
                StorageAccountContainer storageAccountContainer = resourceGroup.GetStorageAccounts();
                await foreach (StorageAccount account in storageAccountContainer.GetAllAsync())
                {
                    await account.DeleteAsync();
                }
                resourceGroup = null;
                storageAccount = null;
            }
        }
        [Test]
        [RecordedTest]
        public async Task CreateDeleteBlobContainer()
        {
            //create blob container
            string containerName = Recording.GenerateAssetName("testblob");
            BlobContainerCreateOperation blobContainerCreateOperation=await blobContainerContainer.CreateOrUpdateAsync(containerName, new BlobContainerData());
            BlobContainer container1 = await blobContainerCreateOperation.WaitForCompletionAsync();
            Assert.IsNotNull(container1);
            Assert.AreEqual(container1.Id.Name, containerName);

            //validate if created successfully
            BlobContainer container2 = await blobContainerContainer.GetAsync(containerName);
            AssertBlobContainerEqual(container1, container2);
            Assert.IsTrue(await blobContainerContainer.CheckIfExistsAsync(containerName));
            Assert.IsFalse(await blobContainerContainer.CheckIfExistsAsync(containerName + "1"));
            BlobContainerData containerData = container1.Data;
            Assert.IsEmpty(containerData.Metadata);
            Assert.IsFalse(containerData.HasLegalHold);
            Assert.IsNull(containerData.PublicAccess);
            Assert.False(containerData.HasImmutabilityPolicy);

            //delete blob container
            BlobContainerDeleteOperation blobContainerDeleteOperation = await container1.DeleteAsync();
            await blobContainerDeleteOperation.WaitForCompletionResponseAsync();

            //validate if deleted successfully
            BlobContainer blobContainer3 = await blobContainerContainer.GetIfExistsAsync(containerName);
            Assert.IsNull(blobContainer3);
            Assert.IsFalse(await blobContainerContainer.CheckIfExistsAsync(containerName));
        }

        [Test]
        [RecordedTest]
        public async Task GetAllBlobContainers()
        {
            //create two blob containers
            string containerName1 = Recording.GenerateAssetName("testblob1");
            string containerName2 = Recording.GenerateAssetName("testblob2");
            BlobContainerCreateOperation blobContainerCreateOperation1 = await blobContainerContainer.CreateOrUpdateAsync(containerName1, new BlobContainerData());
            BlobContainer container1 = await blobContainerCreateOperation1.WaitForCompletionAsync();
            BlobContainerCreateOperation blobContainerCreateOperation2 = await blobContainerContainer.CreateOrUpdateAsync(containerName2, new BlobContainerData());
            BlobContainer container2 = await blobContainerCreateOperation2.WaitForCompletionAsync();

            //validate if there are two containers
            BlobContainer container3 = null;
            BlobContainer container4 = null;
            int count = 0;
            await foreach (BlobContainer container in blobContainerContainer.GetAllAsync())
            {
                count++;
                if (container.Id.Name == containerName1)
                    container3 = container;
                if (container.Id.Name == containerName2)
                    container4 = container;
            }
            Assert.AreEqual(count, 2);
            Assert.IsNotNull(container3);
            Assert.IsNotNull(container4);
        }
        [Test]
        [RecordedTest]
        public async Task UpdataBlobContainer()
        {
            //create a blob container
            string containerName = Recording.GenerateAssetName("testblob");
            BlobContainerData data = new BlobContainerData();
            BlobContainerCreateOperation blobContainerCreateOperation = await blobContainerContainer.CreateOrUpdateAsync(containerName, new BlobContainerData());
            BlobContainer container = await blobContainerCreateOperation.WaitForCompletionAsync();

            //update metadata, public access
            BlobContainerData containerData = container.Data;
            containerData.Metadata.Add("key1", "value1");
            containerData.PublicAccess = PublicAccess.Container;
            BlobContainer container1=await container.UpdateAsync(containerData);

            //validate
            Assert.NotNull(container1);
            Assert.NotNull(container1.Data.Metadata);
            Assert.AreEqual(container1.Data.Metadata["key1"],"value1");
            Assert.AreEqual(PublicAccess.Container, container.Data.PublicAccess);
            Assert.False(container1.Data.HasLegalHold);
            Assert.False(container1.Data.HasImmutabilityPolicy);
        }

        [Test]
        [RecordedTest]
        public async Task CreateDeleteImmutabilityPolicy()
        {
            // create a blob container
            string containerName = Recording.GenerateAssetName("testblob");
            BlobContainerData data = new BlobContainerData();
            BlobContainerCreateOperation blobContainerCreateOperation = await blobContainerContainer.CreateOrUpdateAsync(containerName, new BlobContainerData());
            BlobContainer container = await blobContainerCreateOperation.WaitForCompletionAsync();

            //create immutability policy
            ImmutabilityPolicy immutabilityPolicyModel = new ImmutabilityPolicy() { ImmutabilityPeriodSinceCreationInDays = 3 };
            ImmutabilityPolicy immutabilityPolicy = await container.CreateOrUpdateImmutabilityPolicyAsync(parameters: immutabilityPolicyModel);

            //validate
            Assert.NotNull(immutabilityPolicy.Id);
            Assert.NotNull(immutabilityPolicy.Type);
            Assert.NotNull(immutabilityPolicy.Name);
            Assert.AreEqual(3, immutabilityPolicy.ImmutabilityPeriodSinceCreationInDays);
            Assert.AreEqual(ImmutabilityPolicyState.Unlocked, immutabilityPolicy.State);

            //delete immutability policy
            immutabilityPolicy = await container.DeleteImmutabilityPolicyAsync(immutabilityPolicy.Etag);

            //validate
            Assert.NotNull(immutabilityPolicy.Id);
            Assert.NotNull(immutabilityPolicy.Type);
            Assert.NotNull(immutabilityPolicy.Name);
            Assert.AreEqual(0, immutabilityPolicy.ImmutabilityPeriodSinceCreationInDays);
        }

        [Test]
        [RecordedTest]
        public async Task SetClearLegalHold()
        {
            // create a blob container
            string containerName = Recording.GenerateAssetName("testblob");
            BlobContainerData data = new BlobContainerData();
            BlobContainerCreateOperation blobContainerCreateOperation = await blobContainerContainer.CreateOrUpdateAsync(containerName, new BlobContainerData());
            BlobContainer container = await blobContainerCreateOperation.WaitForCompletionAsync();

            //set legal hold
            LegalHold legalHoldModel = new LegalHold(new List<string> { "tag1", "tag2", "tag3" });
            LegalHold legalHold =await container.SetLegalHoldAsync(legalHoldModel);

            //validate
            Assert.True(legalHold.HasLegalHold);
            Assert.AreEqual(new List<string> { "tag1", "tag2", "tag3" }, legalHold.Tags);

            //clear legal hold
            legalHold = await container.ClearLegalHoldAsync(legalHoldModel);

            //validate
            Assert.False(legalHold.HasLegalHold);
            Assert.AreEqual(0, legalHold.Tags.Count);
        }
        [Test]
        [RecordedTest]
        public async Task UpdateBlobService()
        {
            //validate current file service properties
            Assert.False(blobService.Data.DeleteRetentionPolicy.Enabled);
            Assert.Null(blobService.Data.DeleteRetentionPolicy.Days);

            //update delete retention policy
            BlobServiceData serviceData = blobService.Data;
            serviceData.DeleteRetentionPolicy = new DeleteRetentionPolicy
            {
                Enabled = true,
                Days = 100
            };
            BlobService service = await blobService.SetServicePropertiesAsync(serviceData);

            //validate update
            Assert.True(service.Data.DeleteRetentionPolicy.Enabled);
            Assert.AreEqual(service.Data.DeleteRetentionPolicy.Days, 100);
        }
    }
}
