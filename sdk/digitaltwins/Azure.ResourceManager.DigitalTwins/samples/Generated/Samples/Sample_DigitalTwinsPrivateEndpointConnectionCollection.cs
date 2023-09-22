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
using Azure.ResourceManager.DigitalTwins;
using Azure.ResourceManager.DigitalTwins.Models;

namespace Azure.ResourceManager.DigitalTwins.Samples
{
    public partial class Sample_DigitalTwinsPrivateEndpointConnectionCollection
    {
        // List private endpoint connection properties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPrivateEndpointConnectionProperties()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateEndpointConnectionsList_example.json
            // this example is just showing the usage of "PrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateEndpointConnectionResource
            DigitalTwinsPrivateEndpointConnectionCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (DigitalTwinsPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DigitalTwinsPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get private endpoint connection properties for the given private endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpointConnectionPropertiesForTheGivenPrivateEndpoint()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateEndpointConnectionByConnectionName_example.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateEndpointConnectionResource
            DigitalTwinsPrivateEndpointConnectionCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myPrivateConnection";
            DigitalTwinsPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DigitalTwinsPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get private endpoint connection properties for the given private endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetPrivateEndpointConnectionPropertiesForTheGivenPrivateEndpoint()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateEndpointConnectionByConnectionName_example.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateEndpointConnectionResource
            DigitalTwinsPrivateEndpointConnectionCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myPrivateConnection";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get private endpoint connection properties for the given private endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetPrivateEndpointConnectionPropertiesForTheGivenPrivateEndpoint()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateEndpointConnectionByConnectionName_example.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateEndpointConnectionResource
            DigitalTwinsPrivateEndpointConnectionCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myPrivateConnection";
            NullableResponse<DigitalTwinsPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            DigitalTwinsPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DigitalTwinsPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Update the status of a private endpoint connection with the given name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateTheStatusOfAPrivateEndpointConnectionWithTheGivenName()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateEndpointConnectionPut_example.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateEndpointConnectionResource
            DigitalTwinsPrivateEndpointConnectionCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myPrivateConnection";
            DigitalTwinsPrivateEndpointConnectionData data = new DigitalTwinsPrivateEndpointConnectionData(new DigitalTwinsPrivateEndpointConnectionProperties()
            {
                PrivateLinkServiceConnectionState = new DigitalTwinsPrivateLinkServiceConnectionState(DigitalTwinsPrivateLinkServiceConnectionStatus.Approved, "Approved by johndoe@company.com."),
            });
            ArmOperation<DigitalTwinsPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            DigitalTwinsPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DigitalTwinsPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
