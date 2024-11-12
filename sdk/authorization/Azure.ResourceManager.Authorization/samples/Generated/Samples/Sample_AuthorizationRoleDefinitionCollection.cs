// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_AuthorizationRoleDefinitionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRoleDefinitionByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetRoleDefinitionByName.json
            // this example is just showing the usage of "RoleDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AuthorizationRoleDefinitionResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            AuthorizationRoleDefinitionCollection collection = client.GetAuthorizationRoleDefinitions(scopeId);

            // invoke the operation
            ResourceIdentifier roleDefinitionId = new ResourceIdentifier("roleDefinitionId");
            AuthorizationRoleDefinitionResource result = await collection.GetAsync(roleDefinitionId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetRoleDefinitionByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetRoleDefinitionByName.json
            // this example is just showing the usage of "RoleDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AuthorizationRoleDefinitionResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            AuthorizationRoleDefinitionCollection collection = client.GetAuthorizationRoleDefinitions(scopeId);

            // invoke the operation
            ResourceIdentifier roleDefinitionId = new ResourceIdentifier("roleDefinitionId");
            bool result = await collection.ExistsAsync(roleDefinitionId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetRoleDefinitionByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetRoleDefinitionByName.json
            // this example is just showing the usage of "RoleDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AuthorizationRoleDefinitionResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            AuthorizationRoleDefinitionCollection collection = client.GetAuthorizationRoleDefinitions(scopeId);

            // invoke the operation
            ResourceIdentifier roleDefinitionId = new ResourceIdentifier("roleDefinitionId");
            NullableResponse<AuthorizationRoleDefinitionResource> response = await collection.GetIfExistsAsync(roleDefinitionId);
            AuthorizationRoleDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationRoleDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateRoleDefinition()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/PutRoleDefinition.json
            // this example is just showing the usage of "RoleDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AuthorizationRoleDefinitionResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            AuthorizationRoleDefinitionCollection collection = client.GetAuthorizationRoleDefinitions(scopeId);

            // invoke the operation
            ResourceIdentifier roleDefinitionId = new ResourceIdentifier("roleDefinitionId");
            AuthorizationRoleDefinitionData data = new AuthorizationRoleDefinitionData();
            ArmOperation<AuthorizationRoleDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, roleDefinitionId, data);
            AuthorizationRoleDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationRoleDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListRoleDefinitionsForScope()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2022-04-01/examples/GetRoleDefinitionAtScope.json
            // this example is just showing the usage of "RoleDefinitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AuthorizationRoleDefinitionResource
            string scope = "scope";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            AuthorizationRoleDefinitionCollection collection = client.GetAuthorizationRoleDefinitions(scopeId);

            // invoke the operation and iterate over the result
            await foreach (AuthorizationRoleDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationRoleDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
