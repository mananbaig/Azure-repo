// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_DevOpsOrgCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAzureDevOpsOrgs()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListAzureDevOpsOrgs_example.json
            // this example is just showing the usage of "AzureDevOpsOrgs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this DevOpsOrgResource
            DevOpsOrgCollection collection = devOpsConfiguration.GetDevOpsOrgs();

            // invoke the operation and iterate over the result
            await foreach (DevOpsOrgResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevOpsOrgData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAzureDevOpsOrgs()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsOrgs_example.json
            // this example is just showing the usage of "AzureDevOpsOrgs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this DevOpsOrgResource
            DevOpsOrgCollection collection = devOpsConfiguration.GetDevOpsOrgs();

            // invoke the operation
            string orgName = "myAzDevOpsOrg";
            DevOpsOrgResource result = await collection.GetAsync(orgName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsOrgData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAzureDevOpsOrgs()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsOrgs_example.json
            // this example is just showing the usage of "AzureDevOpsOrgs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this DevOpsOrgResource
            DevOpsOrgCollection collection = devOpsConfiguration.GetDevOpsOrgs();

            // invoke the operation
            string orgName = "myAzDevOpsOrg";
            bool result = await collection.ExistsAsync(orgName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAzureDevOpsOrgs()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsOrgs_example.json
            // this example is just showing the usage of "AzureDevOpsOrgs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this DevOpsOrgResource
            DevOpsOrgCollection collection = devOpsConfiguration.GetDevOpsOrgs();

            // invoke the operation
            string orgName = "myAzDevOpsOrg";
            NullableResponse<DevOpsOrgResource> response = await collection.GetIfExistsAsync(orgName);
            DevOpsOrgResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevOpsOrgData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAzureDevOpsOrgs()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/CreateOrUpdateAzureDevOpsOrgs_example.json
            // this example is just showing the usage of "AzureDevOpsOrgs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this DevOpsOrgResource
            DevOpsOrgCollection collection = devOpsConfiguration.GetDevOpsOrgs();

            // invoke the operation
            string orgName = "myAzDevOpsOrg";
            DevOpsOrgData data = new DevOpsOrgData()
            {
                Properties = new DevOpsOrgProperties()
                {
                    OnboardingState = ResourceOnboardingState.NotApplicable,
                    ActionableRemediation = new ActionableRemediation()
                    {
                        State = ActionableRemediationState.Enabled,
                    },
                },
            };
            ArmOperation<DevOpsOrgResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, orgName, data);
            DevOpsOrgResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsOrgData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
