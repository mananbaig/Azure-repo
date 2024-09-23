// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlClusterCollection
    {
        // List the clusters by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTheClustersByResourceGroup()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterListByResourceGroup.json
            // this example is just showing the usage of "Clusters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBForPostgreSqlClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Create a new cluster as a point in time restore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewClusterAsAPointInTimeRestore()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterCreatePITR.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster";
            CosmosDBForPostgreSqlClusterData data = new CosmosDBForPostgreSqlClusterData(new AzureLocation("westus"))
            {
                SourceResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/TestResourceGroup/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/source-cluster"),
                SourceLocation = new AzureLocation("westus"),
                PointInTimeUTC = DateTimeOffset.Parse("2017-12-14T00:00:37.467Z"),
            };
            ArmOperation<CosmosDBForPostgreSqlClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            CosmosDBForPostgreSqlClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a new cluster as a read replica
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewClusterAsAReadReplica()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterCreateReadReplica.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster";
            CosmosDBForPostgreSqlClusterData data = new CosmosDBForPostgreSqlClusterData(new AzureLocation("westus"))
            {
                SourceResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/TestResourceGroup/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/sourcecluster"),
                SourceLocation = new AzureLocation("westus"),
            };
            ArmOperation<CosmosDBForPostgreSqlClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            CosmosDBForPostgreSqlClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a new multi-node cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewMultiNodeCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterCreateMultiNode.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster-multinode";
            CosmosDBForPostgreSqlClusterData data = new CosmosDBForPostgreSqlClusterData(new AzureLocation("westus"))
            {
                AdministratorLoginPassword = "password",
                PostgresqlVersion = "15",
                CitusVersion = "11.1",
                PreferredPrimaryZone = "1",
                IsShardsOnCoordinatorEnabled = false,
                IsHAEnabled = true,
                CoordinatorServerEdition = "GeneralPurpose",
                CoordinatorStorageQuotaInMb = 524288,
                CoordinatorVCores = 4,
                IsCoordinatorPublicIPAccessEnabled = true,
                NodeServerEdition = "MemoryOptimized",
                NodeCount = 3,
                NodeStorageQuotaInMb = 524288,
                NodeVCores = 8,
                IsNodePublicIPAccessEnabled = false,
                Tags =
{
},
            };
            ArmOperation<CosmosDBForPostgreSqlClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            CosmosDBForPostgreSqlClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a new single node Burstable 1 vCore cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewSingleNodeBurstable1VCoreCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterCreateBurstablev1.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster-burstablev1";
            CosmosDBForPostgreSqlClusterData data = new CosmosDBForPostgreSqlClusterData(new AzureLocation("westus"))
            {
                AdministratorLoginPassword = "password",
                PostgresqlVersion = "15",
                CitusVersion = "11.3",
                PreferredPrimaryZone = "1",
                IsShardsOnCoordinatorEnabled = true,
                IsHAEnabled = false,
                CoordinatorServerEdition = "BurstableMemoryOptimized",
                CoordinatorStorageQuotaInMb = 131072,
                CoordinatorVCores = 1,
                IsCoordinatorPublicIPAccessEnabled = true,
                NodeCount = 0,
                Tags =
{
["owner"] = "JohnDoe",
},
            };
            ArmOperation<CosmosDBForPostgreSqlClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            CosmosDBForPostgreSqlClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a new single node Burstable 2 vCores cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewSingleNodeBurstable2VCoresCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterCreateBurstablev2.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster-burstablev2";
            CosmosDBForPostgreSqlClusterData data = new CosmosDBForPostgreSqlClusterData(new AzureLocation("westus"))
            {
                AdministratorLoginPassword = "password",
                PostgresqlVersion = "15",
                CitusVersion = "11.3",
                PreferredPrimaryZone = "1",
                IsShardsOnCoordinatorEnabled = true,
                IsHAEnabled = false,
                CoordinatorServerEdition = "BurstableGeneralPurpose",
                CoordinatorStorageQuotaInMb = 131072,
                CoordinatorVCores = 2,
                IsCoordinatorPublicIPAccessEnabled = true,
                NodeCount = 0,
                Tags =
{
["owner"] = "JohnDoe",
},
            };
            ArmOperation<CosmosDBForPostgreSqlClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            CosmosDBForPostgreSqlClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a new single node cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewSingleNodeCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterCreateSingleNode.json
            // this example is just showing the usage of "Clusters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster-singlenode";
            CosmosDBForPostgreSqlClusterData data = new CosmosDBForPostgreSqlClusterData(new AzureLocation("westus"))
            {
                AdministratorLoginPassword = "password",
                PostgresqlVersion = "15",
                CitusVersion = "11.3",
                PreferredPrimaryZone = "1",
                IsShardsOnCoordinatorEnabled = true,
                IsHAEnabled = true,
                CoordinatorServerEdition = "GeneralPurpose",
                CoordinatorStorageQuotaInMb = 131072,
                CoordinatorVCores = 8,
                IsCoordinatorPublicIPAccessEnabled = true,
                NodeCount = 0,
                Tags =
{
["owner"] = "JohnDoe",
},
            };
            ArmOperation<CosmosDBForPostgreSqlClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            CosmosDBForPostgreSqlClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterGet.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster1";
            CosmosDBForPostgreSqlClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterGet.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster1";
            bool result = await collection.ExistsAsync(clusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/ClusterGet.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CosmosDBForPostgreSqlClusterResource
            CosmosDBForPostgreSqlClusterCollection collection = resourceGroupResource.GetCosmosDBForPostgreSqlClusters();

            // invoke the operation
            string clusterName = "testcluster1";
            NullableResponse<CosmosDBForPostgreSqlClusterResource> response = await collection.GetIfExistsAsync(clusterName);
            CosmosDBForPostgreSqlClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBForPostgreSqlClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
