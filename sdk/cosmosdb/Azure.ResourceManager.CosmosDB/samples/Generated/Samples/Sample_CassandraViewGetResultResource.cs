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
    public partial class Sample_CassandraViewGetResultResource
    {
        // CosmosDBCassandraViewGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBCassandraViewGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBCassandraViewGet.json
            // this example is just showing the usage of "CassandraResources_GetCassandraView" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewGetResultResource created on azure
            // for more information of creating CassandraViewGetResultResource, please refer to the document of CassandraViewGetResultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewGetResultResourceId = CassandraViewGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewGetResultResource cassandraViewGetResult = client.GetCassandraViewGetResultResource(cassandraViewGetResultResourceId);

            // invoke the operation
            CassandraViewGetResultResource result = await cassandraViewGetResult.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraViewGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraViewCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBCassandraViewCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBCassandraViewCreateUpdate.json
            // this example is just showing the usage of "CassandraResources_CreateUpdateCassandraView" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewGetResultResource created on azure
            // for more information of creating CassandraViewGetResultResource, please refer to the document of CassandraViewGetResultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewGetResultResourceId = CassandraViewGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewGetResultResource cassandraViewGetResult = client.GetCassandraViewGetResultResource(cassandraViewGetResultResourceId);

            // invoke the operation
            CassandraViewGetResultCreateOrUpdateContent content = new CassandraViewGetResultCreateOrUpdateContent(new AzureLocation("placeholder"), new CassandraViewResource("viewname", "SELECT columna, columnb, columnc FROM keyspacename.srctablename WHERE columna IS NOT NULL AND columnc IS NOT NULL PRIMARY (columnc, columna)"))
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CassandraViewGetResultResource> lro = await cassandraViewGetResult.UpdateAsync(WaitUntil.Completed, content);
            CassandraViewGetResultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CassandraViewGetResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraViewDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBCassandraViewDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBCassandraViewDelete.json
            // this example is just showing the usage of "CassandraResources_DeleteCassandraView" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraViewGetResultResource created on azure
            // for more information of creating CassandraViewGetResultResource, please refer to the document of CassandraViewGetResultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspacename";
            string viewName = "viewname";
            ResourceIdentifier cassandraViewGetResultResourceId = CassandraViewGetResultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName, viewName);
            CassandraViewGetResultResource cassandraViewGetResult = client.GetCassandraViewGetResultResource(cassandraViewGetResultResourceId);

            // invoke the operation
            await cassandraViewGetResult.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
