// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm.Samples
{
    public partial class Sample_ScVmmInventoryItemResource
    {
        // CreateInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/CreateInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmInventoryItemResource created on azure
            // for more information of creating ScVmmInventoryItemResource, please refer to the document of ScVmmInventoryItemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            string inventoryItemResourceName = "12345678-1234-1234-1234-123456789abc";
            ResourceIdentifier scVmmInventoryItemResourceId = ScVmmInventoryItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName, inventoryItemResourceName);
            ScVmmInventoryItemResource scVmmInventoryItem = client.GetScVmmInventoryItemResource(scVmmInventoryItemResourceId);

            // invoke the operation
            ScVmmInventoryItemData data = new ScVmmInventoryItemData(new CloudInventoryItem());
            ArmOperation<ScVmmInventoryItemResource> lro = await scVmmInventoryItem.UpdateAsync(WaitUntil.Completed, data);
            ScVmmInventoryItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmInventoryItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmInventoryItemResource created on azure
            // for more information of creating ScVmmInventoryItemResource, please refer to the document of ScVmmInventoryItemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            string inventoryItemResourceName = "12345678-1234-1234-1234-123456789abc";
            ResourceIdentifier scVmmInventoryItemResourceId = ScVmmInventoryItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName, inventoryItemResourceName);
            ScVmmInventoryItemResource scVmmInventoryItem = client.GetScVmmInventoryItemResource(scVmmInventoryItemResourceId);

            // invoke the operation
            ScVmmInventoryItemResource result = await scVmmInventoryItem.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmInventoryItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/DeleteInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmInventoryItemResource created on azure
            // for more information of creating ScVmmInventoryItemResource, please refer to the document of ScVmmInventoryItemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            string inventoryItemResourceName = "12345678-1234-1234-1234-123456789abc";
            ResourceIdentifier scVmmInventoryItemResourceId = ScVmmInventoryItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName, inventoryItemResourceName);
            ScVmmInventoryItemResource scVmmInventoryItem = client.GetScVmmInventoryItemResource(scVmmInventoryItemResourceId);

            // invoke the operation
            await scVmmInventoryItem.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
