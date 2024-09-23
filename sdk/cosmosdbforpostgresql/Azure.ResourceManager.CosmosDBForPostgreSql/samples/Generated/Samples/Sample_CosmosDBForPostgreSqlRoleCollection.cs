// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlRoleCollection
    {
        // Get the role of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheRoleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleGet.json
            // this example is just showing the usage of "Roles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlRoleResource
            CosmosDBForPostgreSqlRoleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlRoles();

            // invoke the operation
            string roleName = "role1";
            CosmosDBForPostgreSqlRoleResource result = await collection.GetAsync(roleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlRoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the role of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheRoleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleGet.json
            // this example is just showing the usage of "Roles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlRoleResource
            CosmosDBForPostgreSqlRoleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlRoles();

            // invoke the operation
            string roleName = "role1";
            bool result = await collection.ExistsAsync(roleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the role of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheRoleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleGet.json
            // this example is just showing the usage of "Roles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlRoleResource
            CosmosDBForPostgreSqlRoleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlRoles();

            // invoke the operation
            string roleName = "role1";
            NullableResponse<CosmosDBForPostgreSqlRoleResource> response = await collection.GetIfExistsAsync(roleName);
            CosmosDBForPostgreSqlRoleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlRoleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // RoleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_RoleCreate()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleCreate.json
            // this example is just showing the usage of "Roles_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlRoleResource
            CosmosDBForPostgreSqlRoleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlRoles();

            // invoke the operation
            string roleName = "role1";
            CosmosDBForPostgreSqlRoleData data = new CosmosDBForPostgreSqlRoleData("password");
            ArmOperation<CosmosDBForPostgreSqlRoleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, roleName, data);
            CosmosDBForPostgreSqlRoleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlRoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RoleList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RoleList()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleListByCluster.json
            // this example is just showing the usage of "Roles_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlClusterResource created on azure
            // for more information of creating CosmosDBForPostgreSqlClusterResource, please refer to the document of CosmosDBForPostgreSqlClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            ResourceIdentifier cosmosDBForPostgreSqlClusterResourceId = CosmosDBForPostgreSqlClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            CosmosDBForPostgreSqlClusterResource cosmosDBForPostgreSqlCluster = client.GetCosmosDBForPostgreSqlClusterResource(cosmosDBForPostgreSqlClusterResourceId);

            // get the collection of this CosmosDBForPostgreSqlRoleResource
            CosmosDBForPostgreSqlRoleCollection collection = cosmosDBForPostgreSqlCluster.GetCosmosDBForPostgreSqlRoles();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBForPostgreSqlRoleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlRoleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
