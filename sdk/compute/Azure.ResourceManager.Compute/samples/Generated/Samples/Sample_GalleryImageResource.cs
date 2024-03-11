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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_GalleryImageResource
    {
        // Update a simple gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASimpleGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/GalleryImage_Update.json
            // this example is just showing the usage of "GalleryImages_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryImageResource created on azure
            // for more information of creating GalleryImageResource, please refer to the document of GalleryImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier galleryImageResourceId = GalleryImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName);
            GalleryImageResource galleryImage = client.GetGalleryImageResource(galleryImageResourceId);

            // invoke the operation
            GalleryImagePatch patch = new GalleryImagePatch()
            {
                OSType = SupportedOperatingSystemType.Windows,
                OSState = OperatingSystemStateType.Generalized,
                HyperVGeneration = HyperVGeneration.V1,
                Identifier = new GalleryImageIdentifier("myPublisherName", "myOfferName", "mySkuName"),
            };
            ArmOperation<GalleryImageResource> lro = await galleryImage.UpdateAsync(WaitUntil.Completed, patch);
            GalleryImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/GalleryImage_Get.json
            // this example is just showing the usage of "GalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryImageResource created on azure
            // for more information of creating GalleryImageResource, please refer to the document of GalleryImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier galleryImageResourceId = GalleryImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName);
            GalleryImageResource galleryImage = client.GetGalleryImageResource(galleryImageResourceId);

            // invoke the operation
            GalleryImageResource result = await galleryImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/GalleryImage_Delete.json
            // this example is just showing the usage of "GalleryImages_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryImageResource created on azure
            // for more information of creating GalleryImageResource, please refer to the document of GalleryImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier galleryImageResourceId = GalleryImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName);
            GalleryImageResource galleryImage = client.GetGalleryImageResource(galleryImageResourceId);

            // invoke the operation
            await galleryImage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
