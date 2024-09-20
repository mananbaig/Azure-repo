// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_BatchPrivateLinkResource
    {
        // GetPrivateLinkResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateLinkResource()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PrivateLinkResourceGet.json
            // this example is just showing the usage of "PrivateLinkResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchPrivateLinkResource created on azure
            // for more information of creating BatchPrivateLinkResource, please refer to the document of BatchPrivateLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string privateLinkResourceName = "batchAccount";
            ResourceIdentifier batchPrivateLinkResourceId = BatchPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateLinkResourceName);
            BatchPrivateLinkResource batchPrivateLinkResource = client.GetBatchPrivateLinkResource(batchPrivateLinkResourceId);

            // invoke the operation
            BatchPrivateLinkResource result = await batchPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
