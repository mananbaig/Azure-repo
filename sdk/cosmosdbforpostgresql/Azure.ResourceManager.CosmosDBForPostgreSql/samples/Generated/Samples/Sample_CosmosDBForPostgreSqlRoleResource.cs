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
    public partial class Sample_CosmosDBForPostgreSqlRoleResource
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

            // this example assumes you already have this CosmosDBForPostgreSqlRoleResource created on azure
            // for more information of creating CosmosDBForPostgreSqlRoleResource, please refer to the document of CosmosDBForPostgreSqlRoleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            string roleName = "role1";
            ResourceIdentifier cosmosDBForPostgreSqlRoleResourceId = CosmosDBForPostgreSqlRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, roleName);
            CosmosDBForPostgreSqlRoleResource cosmosDBForPostgreSqlRole = client.GetCosmosDBForPostgreSqlRoleResource(cosmosDBForPostgreSqlRoleResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlRoleResource result = await cosmosDBForPostgreSqlRole.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlRoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RoleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RoleCreate()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleCreate.json
            // this example is just showing the usage of "Roles_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlRoleResource created on azure
            // for more information of creating CosmosDBForPostgreSqlRoleResource, please refer to the document of CosmosDBForPostgreSqlRoleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            string roleName = "role1";
            ResourceIdentifier cosmosDBForPostgreSqlRoleResourceId = CosmosDBForPostgreSqlRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, roleName);
            CosmosDBForPostgreSqlRoleResource cosmosDBForPostgreSqlRole = client.GetCosmosDBForPostgreSqlRoleResource(cosmosDBForPostgreSqlRoleResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlRoleData data = new CosmosDBForPostgreSqlRoleData("password");
            ArmOperation<CosmosDBForPostgreSqlRoleResource> lro = await cosmosDBForPostgreSqlRole.UpdateAsync(WaitUntil.Completed, data);
            CosmosDBForPostgreSqlRoleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlRoleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RoleDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RoleDelete()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/RoleDelete.json
            // this example is just showing the usage of "Roles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlRoleResource created on azure
            // for more information of creating CosmosDBForPostgreSqlRoleResource, please refer to the document of CosmosDBForPostgreSqlRoleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            string roleName = "role1";
            ResourceIdentifier cosmosDBForPostgreSqlRoleResourceId = CosmosDBForPostgreSqlRoleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, roleName);
            CosmosDBForPostgreSqlRoleResource cosmosDBForPostgreSqlRole = client.GetCosmosDBForPostgreSqlRoleResource(cosmosDBForPostgreSqlRoleResourceId);

            // invoke the operation
            await cosmosDBForPostgreSqlRole.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
