// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryManagedVirtualNetworkResource
    {
        // ManagedVirtualNetworks_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ManagedVirtualNetworksCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_Create.json
            // this example is just showing the usage of "ManagedVirtualNetworks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // invoke the operation
            DataFactoryManagedVirtualNetworkData data = new DataFactoryManagedVirtualNetworkData(new DataFactoryManagedVirtualNetworkProperties());
            ArmOperation<DataFactoryManagedVirtualNetworkResource> lro = await dataFactoryManagedVirtualNetwork.UpdateAsync(WaitUntil.Completed, data);
            DataFactoryManagedVirtualNetworkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryManagedVirtualNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedVirtualNetworks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedVirtualNetworksGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedVirtualNetworks_Get.json
            // this example is just showing the usage of "ManagedVirtualNetworks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // invoke the operation
            DataFactoryManagedVirtualNetworkResource result = await dataFactoryManagedVirtualNetwork.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryManagedVirtualNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
