// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ScVmm.Samples
{
    public partial class Sample_ScVmmVirtualMachineTemplateCollection
    {
        // GetVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScVmmVirtualMachineTemplateResource
            ScVmmVirtualMachineTemplateCollection collection = resourceGroupResource.GetScVmmVirtualMachineTemplates();

            // invoke the operation
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            ScVmmVirtualMachineTemplateResource result = await collection.GetAsync(virtualMachineTemplateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScVmmVirtualMachineTemplateResource
            ScVmmVirtualMachineTemplateCollection collection = resourceGroupResource.GetScVmmVirtualMachineTemplates();

            // invoke the operation
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            bool result = await collection.ExistsAsync(virtualMachineTemplateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScVmmVirtualMachineTemplateResource
            ScVmmVirtualMachineTemplateCollection collection = resourceGroupResource.GetScVmmVirtualMachineTemplates();

            // invoke the operation
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            NullableResponse<ScVmmVirtualMachineTemplateResource> response = await collection.GetIfExistsAsync(virtualMachineTemplateName);
            ScVmmVirtualMachineTemplateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScVmmVirtualMachineTemplateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CreateVirtualMachineTemplate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateVirtualMachineTemplate()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/CreateVirtualMachineTemplate.json
            // this example is just showing the usage of "VirtualMachineTemplates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScVmmVirtualMachineTemplateResource
            ScVmmVirtualMachineTemplateCollection collection = resourceGroupResource.GetScVmmVirtualMachineTemplates();

            // invoke the operation
            string virtualMachineTemplateName = "HRVirtualMachineTemplate";
            ScVmmVirtualMachineTemplateData data = new ScVmmVirtualMachineTemplateData(new AzureLocation("East US"), new ExtendedLocation()
            {
                Name = "/subscriptions/a5015e1c-867f-4533-8541-85cd470d0cfb/resourceGroups/demoRG/providers/Microsoft.Arc/customLocations/contoso",
            })
            {
                Uuid = "aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee",
                VmmServerId = new ResourceIdentifier("/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.SCVMM/VMMServers/ContosoVMMServer"),
            };
            ArmOperation<ScVmmVirtualMachineTemplateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualMachineTemplateName, data);
            ScVmmVirtualMachineTemplateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineTemplateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListVirtualMachineTemplatesByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVirtualMachineTemplatesByResourceGroup()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/ListVirtualMachineTemplatesByResourceGroup.json
            // this example is just showing the usage of "VirtualMachineTemplates_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScVmmVirtualMachineTemplateResource
            ScVmmVirtualMachineTemplateCollection collection = resourceGroupResource.GetScVmmVirtualMachineTemplates();

            // invoke the operation and iterate over the result
            await foreach (ScVmmVirtualMachineTemplateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScVmmVirtualMachineTemplateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
