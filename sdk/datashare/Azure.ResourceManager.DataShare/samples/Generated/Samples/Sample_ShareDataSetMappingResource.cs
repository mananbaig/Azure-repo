// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_ShareDataSetMappingResource
    {
        // DataSetMappings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataSetMappingsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_Get.json
            // this example is just showing the usage of "DataSetMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "DatasetMapping1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            ShareDataSetMappingResource result = await shareDataSetMapping.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSetMappings_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataSetMappingsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_Create.json
            // this example is just showing the usage of "DataSetMappings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "DatasetMapping1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            ShareDataSetMappingData data = new BlobDataSetMapping("C1", Guid.Parse("a08f184b-0567-4b11-ba22-a1199336d226"), "file21", "SampleResourceGroup", "storage2", "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a");
            ArmOperation<ShareDataSetMappingResource> lro = await shareDataSetMapping.UpdateAsync(WaitUntil.Completed, data);
            ShareDataSetMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSetMappings_SqlDB_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataSetMappingsSqlDBCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_SqlDB_Create.json
            // this example is just showing the usage of "DataSetMappings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "DatasetMapping1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            ShareDataSetMappingData data = new SqlDBTableDataSetMapping("Database1", Guid.Parse("a08f184b-0567-4b11-ba22-a1199336d226"), "dbo", new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Sql/servers/Server1"), "Table1");
            ArmOperation<ShareDataSetMappingResource> lro = await shareDataSetMapping.UpdateAsync(WaitUntil.Completed, data);
            ShareDataSetMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSetMappings_SqlDWDataSetToAdlsGen2File_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataSetMappingsSqlDWDataSetToAdlsGen2FileCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_SqlDWDataSetToAdlsGen2File_Create.json
            // this example is just showing the usage of "DataSetMappings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "DatasetMapping1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            ShareDataSetMappingData data = new AdlsGen2FileDataSetMapping(Guid.Parse("a08f184b-0567-4b11-ba22-a1199336d226"), "file21", "fileSystem", "SampleResourceGroup", "storage2", "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a")
            {
                OutputType = DataShareOutputType.Csv,
            };
            ArmOperation<ShareDataSetMappingResource> lro = await shareDataSetMapping.UpdateAsync(WaitUntil.Completed, data);
            ShareDataSetMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSetMappings_SqlDW_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataSetMappingsSqlDWCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_SqlDW_Create.json
            // this example is just showing the usage of "DataSetMappings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "DatasetMapping1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            ShareDataSetMappingData data = new SqlDWTableDataSetMapping(Guid.Parse("a08f184b-0567-4b11-ba22-a1199336d226"), "DataWarehouse1", "dbo", new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Sql/servers/Server1"), "Table1");
            ArmOperation<ShareDataSetMappingResource> lro = await shareDataSetMapping.UpdateAsync(WaitUntil.Completed, data);
            ShareDataSetMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSetMappings_SynapseWorkspaceSqlPoolTable_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DataSetMappingsSynapseWorkspaceSqlPoolTableCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_SynapseWorkspaceSqlPoolTable_Create.json
            // this example is just showing the usage of "DataSetMappings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "consumerAccount";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "datasetMappingName1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            ShareDataSetMappingData data = new SynapseWorkspaceSqlPoolTableDataSetMapping(Guid.Parse("3dc64e49-1fc3-4186-b3dc-d388c4d3076a"), new ResourceIdentifier("/subscriptions/0f3dcfc3-18f8-4099-b381-8353e19d43a7/resourceGroups/SampleResourceGroup/providers/Microsoft.Synapse/workspaces/ExampleWorkspace/sqlPools/ExampleSqlPool/schemas/dbo/tables/table1"));
            ArmOperation<ShareDataSetMappingResource> lro = await shareDataSetMapping.UpdateAsync(WaitUntil.Completed, data);
            ShareDataSetMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSetMappings_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DataSetMappingsDelete()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSetMappings_Delete.json
            // this example is just showing the usage of "DataSetMappings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareDataSetMappingResource created on azure
            // for more information of creating ShareDataSetMappingResource, please refer to the document of ShareDataSetMappingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string dataSetMappingName = "DatasetMapping1";
            ResourceIdentifier shareDataSetMappingResourceId = ShareDataSetMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            ShareDataSetMappingResource shareDataSetMapping = client.GetShareDataSetMappingResource(shareDataSetMappingResourceId);

            // invoke the operation
            await shareDataSetMapping.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
