// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlClientEncryptionKeyResource
    {
        // CosmosDBClientEncryptionKeyGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBClientEncryptionKeyGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlClientEncryptionKeyGet.json
            // this example is just showing the usage of "SqlResources_GetClientEncryptionKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlClientEncryptionKeyResource created on azure
            // for more information of creating CosmosDBSqlClientEncryptionKeyResource, please refer to the document of CosmosDBSqlClientEncryptionKeyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgName";
            string accountName = "accountName";
            string databaseName = "databaseName";
            string clientEncryptionKeyName = "cekName";
            ResourceIdentifier cosmosDBSqlClientEncryptionKeyResourceId = CosmosDBSqlClientEncryptionKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, clientEncryptionKeyName);
            CosmosDBSqlClientEncryptionKeyResource cosmosDBSqlClientEncryptionKey = client.GetCosmosDBSqlClientEncryptionKeyResource(cosmosDBSqlClientEncryptionKeyResourceId);

            // invoke the operation
            CosmosDBSqlClientEncryptionKeyResource result = await cosmosDBSqlClientEncryptionKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlClientEncryptionKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBClientEncryptionKeyCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBClientEncryptionKeyCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBSqlClientEncryptionKeyCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateClientEncryptionKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlClientEncryptionKeyResource created on azure
            // for more information of creating CosmosDBSqlClientEncryptionKeyResource, please refer to the document of CosmosDBSqlClientEncryptionKeyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgName";
            string accountName = "accountName";
            string databaseName = "databaseName";
            string clientEncryptionKeyName = "cekName";
            ResourceIdentifier cosmosDBSqlClientEncryptionKeyResourceId = CosmosDBSqlClientEncryptionKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, clientEncryptionKeyName);
            CosmosDBSqlClientEncryptionKeyResource cosmosDBSqlClientEncryptionKey = client.GetCosmosDBSqlClientEncryptionKeyResource(cosmosDBSqlClientEncryptionKeyResourceId);

            // invoke the operation
            CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent content = new CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent(new CosmosDBSqlClientEncryptionKeyResourceInfo()
            {
                Id = "cekName",
                EncryptionAlgorithm = "AEAD_AES_256_CBC_HMAC_SHA256",
                WrappedDataEncryptionKey = Convert.FromBase64String("VGhpcyBpcyBhY3R1YWxseSBhbiBhcnJheSBvZiBieXRlcy4gVGhpcyByZXF1ZXN0L3Jlc3BvbnNlIGlzIGJlaW5nIHByZXNlbnRlZCBhcyBhIHN0cmluZyBmb3IgcmVhZGFiaWxpdHkgaW4gdGhlIGV4YW1wbGU="),
                KeyWrapMetadata = new CosmosDBKeyWrapMetadata()
                {
                    Name = "customerManagedKey",
                    CosmosDBKeyWrapMetadataType = "AzureKeyVault",
                    Value = "AzureKeyVault Key URL",
                    Algorithm = "RSA-OAEP",
                },
            });
            ArmOperation<CosmosDBSqlClientEncryptionKeyResource> lro = await cosmosDBSqlClientEncryptionKey.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBSqlClientEncryptionKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlClientEncryptionKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
