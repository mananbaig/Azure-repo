// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.PostgreSql.FlexibleServers;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Samples
{
    public partial class Sample_PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection
    {
        // Adds an Active DIrectory Administrator for the server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AddsAnActiveDIrectoryAdministratorForTheServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/AdministratorAdd.json
            // this example is just showing the usage of "Administrators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerActiveDirectoryAdministrators();

            // invoke the operation
            string objectId = "oooooooo-oooo-oooo-oooo-oooooooooooo";
            PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent content = new PostgreSqlFlexibleServerActiveDirectoryAdministratorCreateOrUpdateContent()
            {
                PrincipalType = PostgreSqlFlexibleServerPrincipalType.User,
                PrincipalName = "testuser1@microsoft.com",
                TenantId = Guid.Parse("tttttttt-tttt-tttt-tttt-tttttttttttt"),
            };
            ArmOperation<PostgreSqlFlexibleServerActiveDirectoryAdministratorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, objectId, content);
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerActiveDirectoryAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ServerGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/AdministratorGet.json
            // this example is just showing the usage of "Administrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc1";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerActiveDirectoryAdministrators();

            // invoke the operation
            string objectId = "oooooooo-oooo-oooo-oooo-oooooooooooo";
            PostgreSqlFlexibleServerActiveDirectoryAdministratorResource result = await collection.GetAsync(objectId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerActiveDirectoryAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ServerGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/AdministratorGet.json
            // this example is just showing the usage of "Administrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc1";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerActiveDirectoryAdministrators();

            // invoke the operation
            string objectId = "oooooooo-oooo-oooo-oooo-oooooooooooo";
            bool result = await collection.ExistsAsync(objectId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // AdministratorsListByServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AdministratorsListByServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/preview/2023-03-01-preview/examples/AdministratorsListByServer.json
            // this example is just showing the usage of "Administrators_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "pgtestsvc1";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerActiveDirectoryAdministratorResource
            PostgreSqlFlexibleServerActiveDirectoryAdministratorCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerActiveDirectoryAdministrators();

            // invoke the operation and iterate over the result
            await foreach (PostgreSqlFlexibleServerActiveDirectoryAdministratorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlFlexibleServerActiveDirectoryAdministratorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
