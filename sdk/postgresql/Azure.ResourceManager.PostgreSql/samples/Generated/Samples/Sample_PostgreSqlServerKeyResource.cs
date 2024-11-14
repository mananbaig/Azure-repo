// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PostgreSql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlServerKeyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetThePostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyGet.json
            // this example is just showing the usage of "ServerKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerKeyResource created on azure
            // for more information of creating PostgreSqlServerKeyResource, please refer to the document of PostgreSqlServerKeyResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ResourceIdentifier postgreSqlServerKeyResourceId = PostgreSqlServerKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, keyName);
            PostgreSqlServerKeyResource postgreSqlServerKey = client.GetPostgreSqlServerKeyResource(postgreSqlServerKeyResourceId);

            // invoke the operation
            PostgreSqlServerKeyResource result = await postgreSqlServerKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesOrUpdatesAPostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyCreateOrUpdate.json
            // this example is just showing the usage of "ServerKeys_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerKeyResource created on azure
            // for more information of creating PostgreSqlServerKeyResource, please refer to the document of PostgreSqlServerKeyResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ResourceIdentifier postgreSqlServerKeyResourceId = PostgreSqlServerKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, keyName);
            PostgreSqlServerKeyResource postgreSqlServerKey = client.GetPostgreSqlServerKeyResource(postgreSqlServerKeyResourceId);

            // invoke the operation
            PostgreSqlServerKeyData data = new PostgreSqlServerKeyData()
            {
                ServerKeyType = PostgreSqlServerKeyType.AzureKeyVault,
                Uri = new Uri("https://someVault.vault.azure.net/keys/someKey/01234567890123456789012345678901"),
            };
            ArmOperation<PostgreSqlServerKeyResource> lro = await postgreSqlServerKey.UpdateAsync(WaitUntil.Completed, data);
            PostgreSqlServerKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteThePostgreSQLServerKey()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2020-01-01/examples/ServerKeyDelete.json
            // this example is just showing the usage of "ServerKeys_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerKeyResource created on azure
            // for more information of creating PostgreSqlServerKeyResource, please refer to the document of PostgreSqlServerKeyResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ResourceIdentifier postgreSqlServerKeyResourceId = PostgreSqlServerKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, keyName);
            PostgreSqlServerKeyResource postgreSqlServerKey = client.GetPostgreSqlServerKeyResource(postgreSqlServerKeyResourceId);

            // invoke the operation
            await postgreSqlServerKey.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
