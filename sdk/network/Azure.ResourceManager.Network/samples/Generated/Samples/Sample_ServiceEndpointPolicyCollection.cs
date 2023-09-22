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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ServiceEndpointPolicyCollection
    {
        // Get service endPoint Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetServiceEndPointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ServiceEndpointPolicyGet.json
            // this example is just showing the usage of "ServiceEndpointPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceEndpointPolicyResource
            ServiceEndpointPolicyCollection collection = resourceGroupResource.GetServiceEndpointPolicies();

            // invoke the operation
            string serviceEndpointPolicyName = "testServiceEndpointPolicy";
            ServiceEndpointPolicyResource result = await collection.GetAsync(serviceEndpointPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get service endPoint Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetServiceEndPointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ServiceEndpointPolicyGet.json
            // this example is just showing the usage of "ServiceEndpointPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceEndpointPolicyResource
            ServiceEndpointPolicyCollection collection = resourceGroupResource.GetServiceEndpointPolicies();

            // invoke the operation
            string serviceEndpointPolicyName = "testServiceEndpointPolicy";
            bool result = await collection.ExistsAsync(serviceEndpointPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get service endPoint Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetServiceEndPointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ServiceEndpointPolicyGet.json
            // this example is just showing the usage of "ServiceEndpointPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceEndpointPolicyResource
            ServiceEndpointPolicyCollection collection = resourceGroupResource.GetServiceEndpointPolicies();

            // invoke the operation
            string serviceEndpointPolicyName = "testServiceEndpointPolicy";
            NullableResponse<ServiceEndpointPolicyResource> response = await collection.GetIfExistsAsync(serviceEndpointPolicyName);
            ServiceEndpointPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceEndpointPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ServiceEndpointPolicyCreate.json
            // this example is just showing the usage of "ServiceEndpointPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceEndpointPolicyResource
            ServiceEndpointPolicyCollection collection = resourceGroupResource.GetServiceEndpointPolicies();

            // invoke the operation
            string serviceEndpointPolicyName = "testPolicy";
            ServiceEndpointPolicyData data = new ServiceEndpointPolicyData()
            {
                Location = new AzureLocation("westus"),
            };
            ArmOperation<ServiceEndpointPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serviceEndpointPolicyName, data);
            ServiceEndpointPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create service endpoint policy with definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateServiceEndpointPolicyWithDefinition()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ServiceEndpointPolicyCreateWithDefinition.json
            // this example is just showing the usage of "ServiceEndpointPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceEndpointPolicyResource
            ServiceEndpointPolicyCollection collection = resourceGroupResource.GetServiceEndpointPolicies();

            // invoke the operation
            string serviceEndpointPolicyName = "testPolicy";
            ServiceEndpointPolicyData data = new ServiceEndpointPolicyData()
            {
                ServiceEndpointPolicyDefinitions =
{
new ServiceEndpointPolicyDefinitionData()
{
Description = "Storage Service EndpointPolicy Definition",
Service = "Microsoft.Storage",
ServiceResources =
{
new ResourceIdentifier("/subscriptions/subid1"),new ResourceIdentifier("/subscriptions/subid1/resourceGroups/storageRg"),new ResourceIdentifier("/subscriptions/subid1/resourceGroups/storageRg/providers/Microsoft.Storage/storageAccounts/stAccount")
},
Name = "StorageServiceEndpointPolicyDefinition",
}
},
                Location = new AzureLocation("westus"),
            };
            ArmOperation<ServiceEndpointPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serviceEndpointPolicyName, data);
            ServiceEndpointPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List resource group service endpoint policies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListResourceGroupServiceEndpointPolicies()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ServiceEndpointPolicyList.json
            // this example is just showing the usage of "ServiceEndpointPolicies_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceEndpointPolicyResource
            ServiceEndpointPolicyCollection collection = resourceGroupResource.GetServiceEndpointPolicies();

            // invoke the operation and iterate over the result
            await foreach (ServiceEndpointPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceEndpointPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
