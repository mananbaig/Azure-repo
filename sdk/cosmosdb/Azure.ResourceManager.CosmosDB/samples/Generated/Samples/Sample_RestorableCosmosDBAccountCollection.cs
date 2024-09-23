// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_RestorableCosmosDBAccountCollection
    {
        // CosmosDBRestorableDatabaseAccountList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CosmosDBRestorableDatabaseAccountList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableDatabaseAccountList.json
            // this example is just showing the usage of "RestorableDatabaseAccounts_ListByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBLocationResource created on azure
            // for more information of creating CosmosDBLocationResource, please refer to the document of CosmosDBLocationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("West US");
            ResourceIdentifier cosmosDBLocationResourceId = CosmosDBLocationResource.CreateResourceIdentifier(subscriptionId, location);
            CosmosDBLocationResource cosmosDBLocation = client.GetCosmosDBLocationResource(cosmosDBLocationResourceId);

            // get the collection of this RestorableCosmosDBAccountResource
            RestorableCosmosDBAccountCollection collection = cosmosDBLocation.GetRestorableCosmosDBAccounts();

            // invoke the operation and iterate over the result
            await foreach (RestorableCosmosDBAccountResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RestorableCosmosDBAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableDatabaseAccountGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBRestorableDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableDatabaseAccountGet.json
            // this example is just showing the usage of "RestorableDatabaseAccounts_GetByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBLocationResource created on azure
            // for more information of creating CosmosDBLocationResource, please refer to the document of CosmosDBLocationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("West US");
            ResourceIdentifier cosmosDBLocationResourceId = CosmosDBLocationResource.CreateResourceIdentifier(subscriptionId, location);
            CosmosDBLocationResource cosmosDBLocation = client.GetCosmosDBLocationResource(cosmosDBLocationResourceId);

            // get the collection of this RestorableCosmosDBAccountResource
            RestorableCosmosDBAccountCollection collection = cosmosDBLocation.GetRestorableCosmosDBAccounts();

            // invoke the operation
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            RestorableCosmosDBAccountResource result = await collection.GetAsync(instanceId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RestorableCosmosDBAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBRestorableDatabaseAccountGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CosmosDBRestorableDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableDatabaseAccountGet.json
            // this example is just showing the usage of "RestorableDatabaseAccounts_GetByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBLocationResource created on azure
            // for more information of creating CosmosDBLocationResource, please refer to the document of CosmosDBLocationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("West US");
            ResourceIdentifier cosmosDBLocationResourceId = CosmosDBLocationResource.CreateResourceIdentifier(subscriptionId, location);
            CosmosDBLocationResource cosmosDBLocation = client.GetCosmosDBLocationResource(cosmosDBLocationResourceId);

            // get the collection of this RestorableCosmosDBAccountResource
            RestorableCosmosDBAccountCollection collection = cosmosDBLocation.GetRestorableCosmosDBAccounts();

            // invoke the operation
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            bool result = await collection.ExistsAsync(instanceId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBRestorableDatabaseAccountGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_CosmosDBRestorableDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableDatabaseAccountGet.json
            // this example is just showing the usage of "RestorableDatabaseAccounts_GetByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBLocationResource created on azure
            // for more information of creating CosmosDBLocationResource, please refer to the document of CosmosDBLocationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("West US");
            ResourceIdentifier cosmosDBLocationResourceId = CosmosDBLocationResource.CreateResourceIdentifier(subscriptionId, location);
            CosmosDBLocationResource cosmosDBLocation = client.GetCosmosDBLocationResource(cosmosDBLocationResourceId);

            // get the collection of this RestorableCosmosDBAccountResource
            RestorableCosmosDBAccountCollection collection = cosmosDBLocation.GetRestorableCosmosDBAccounts();

            // invoke the operation
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            NullableResponse<RestorableCosmosDBAccountResource> response = await collection.GetIfExistsAsync(instanceId);
            RestorableCosmosDBAccountResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RestorableCosmosDBAccountData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
