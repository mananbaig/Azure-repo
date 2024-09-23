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
    public partial class Sample_DataFactoryServiceCredentialCollection
    {
        // Credentials_ListByFactory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CredentialsListByFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Credentials_ListByFactory.json
            // this example is just showing the usage of "CredentialOperations_ListByFactory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryServiceCredentialResource
            DataFactoryServiceCredentialCollection collection = dataFactory.GetDataFactoryServiceCredentials();

            // invoke the operation and iterate over the result
            await foreach (DataFactoryServiceCredentialResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryServiceCredentialData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Credentials_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CredentialsCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Credentials_Create.json
            // this example is just showing the usage of "CredentialOperations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryServiceCredentialResource
            DataFactoryServiceCredentialCollection collection = dataFactory.GetDataFactoryServiceCredentials();

            // invoke the operation
            string credentialName = "exampleCredential";
            DataFactoryServiceCredentialData data = new DataFactoryServiceCredentialData(new DataFactoryManagedIdentityCredentialProperties()
            {
                ResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-12345678abc/resourcegroups/exampleResourceGroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/exampleUami"),
            });
            ArmOperation<DataFactoryServiceCredentialResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, credentialName, data);
            DataFactoryServiceCredentialResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryServiceCredentialData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Credentials_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CredentialsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Credentials_Get.json
            // this example is just showing the usage of "CredentialOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryServiceCredentialResource
            DataFactoryServiceCredentialCollection collection = dataFactory.GetDataFactoryServiceCredentials();

            // invoke the operation
            string credentialName = "exampleCredential";
            DataFactoryServiceCredentialResource result = await collection.GetAsync(credentialName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryServiceCredentialData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Credentials_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CredentialsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Credentials_Get.json
            // this example is just showing the usage of "CredentialOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryServiceCredentialResource
            DataFactoryServiceCredentialCollection collection = dataFactory.GetDataFactoryServiceCredentials();

            // invoke the operation
            string credentialName = "exampleCredential";
            bool result = await collection.ExistsAsync(credentialName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Credentials_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_CredentialsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/Credentials_Get.json
            // this example is just showing the usage of "CredentialOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryServiceCredentialResource
            DataFactoryServiceCredentialCollection collection = dataFactory.GetDataFactoryServiceCredentials();

            // invoke the operation
            string credentialName = "exampleCredential";
            NullableResponse<DataFactoryServiceCredentialResource> response = await collection.GetIfExistsAsync(credentialName);
            DataFactoryServiceCredentialResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryServiceCredentialData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
