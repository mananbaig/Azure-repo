// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedApplicationTypeCollection
    {
        // Get an application type
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnApplicationType()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeNameGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeResource
            ServiceFabricManagedApplicationTypeCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            ServiceFabricManagedApplicationTypeResource result = await collection.GetAsync(applicationTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an application type
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnApplicationType()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeNameGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeResource
            ServiceFabricManagedApplicationTypeCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            bool result = await collection.ExistsAsync(applicationTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an application type
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnApplicationType()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeNameGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeResource
            ServiceFabricManagedApplicationTypeCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            NullableResponse<ServiceFabricManagedApplicationTypeResource> response = await collection.GetIfExistsAsync(applicationTypeName);
            ServiceFabricManagedApplicationTypeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedApplicationTypeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Put an application type
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationType()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeNamePutOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeResource
            ServiceFabricManagedApplicationTypeCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            ServiceFabricManagedApplicationTypeData data = new ServiceFabricManagedApplicationTypeData(new AzureLocation("eastus"));
            ArmOperation<ServiceFabricManagedApplicationTypeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationTypeName, data);
            ServiceFabricManagedApplicationTypeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedApplicationTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a list of application type name resources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAListOfApplicationTypeNameResources()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/stable/2024-04-01/examples/ApplicationTypeNameListOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedClusterResource created on azure
            // for more information of creating ServiceFabricManagedClusterResource, please refer to the document of ServiceFabricManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);

            // get the collection of this ServiceFabricManagedApplicationTypeResource
            ServiceFabricManagedApplicationTypeCollection collection = serviceFabricManagedCluster.GetServiceFabricManagedApplicationTypes();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricManagedApplicationTypeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedApplicationTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
