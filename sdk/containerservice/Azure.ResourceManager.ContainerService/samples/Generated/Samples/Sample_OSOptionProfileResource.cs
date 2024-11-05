// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ContainerService.Samples
{
    public partial class Sample_OSOptionProfileResource
    {
        // Get Container Service OS Options
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContainerServiceOSOptions()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/ContainerServiceGetOSOptions.json
            // this example is just showing the usage of "ManagedClusters_GetOSOptions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OSOptionProfileResource created on azure
            // for more information of creating OSOptionProfileResource, please refer to the document of OSOptionProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("location1");
            ResourceIdentifier osOptionProfileResourceId = OSOptionProfileResource.CreateResourceIdentifier(subscriptionId, location);
            OSOptionProfileResource osOptionProfile = client.GetOSOptionProfileResource(osOptionProfileResourceId);

            // invoke the operation
            OSOptionProfileResource result = await osOptionProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OSOptionProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
