// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseKustoPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSkusKustoPools_KustoPoolsListSkus()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsListSkus.json
            // this example is just showing the usage of "KustoPools_ListSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (KustoPoolSkuDescription item in subscriptionResource.GetSkusKustoPoolsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckKustoPoolNameAvailability_KustoPoolsCheckNameAvailability()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsCheckNameAvailability.json
            // this example is just showing the usage of "KustoPools_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            KustoPoolNameAvailabilityContent content = new KustoPoolNameAvailabilityContent("kustoclusterrptest4");
            KustoPoolNameAvailabilityResult result = await subscriptionResource.CheckKustoPoolNameAvailabilityAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoPoolsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsGet.json
            // this example is just showing the usage of "KustoPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            SynapseKustoPoolResource result = await synapseKustoPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseKustoPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_KustoPoolsUpdate()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsUpdate.json
            // this example is just showing the usage of "KustoPools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            SynapseKustoPoolPatch patch = new SynapseKustoPoolPatch()
            {
                Sku = new SynapseDataSourceSku(SynapseSkuName.StorageOptimized, KustoPoolSkuSize.Medium)
                {
                    Capacity = 2,
                },
                EnableStreamingIngest = true,
                EnablePurge = true,
                WorkspaceUid = Guid.Parse("11111111-2222-3333-444444444444"),
            };
            ArmOperation<SynapseKustoPoolResource> lro = await synapseKustoPool.UpdateAsync(WaitUntil.Completed, patch);
            SynapseKustoPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseKustoPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_KustoPoolsDelete()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsDelete.json
            // this example is just showing the usage of "KustoPools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            await synapseKustoPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_KustoPoolsStop()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsStop.json
            // this example is just showing the usage of "KustoPools_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            await synapseKustoPool.StopAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_KustoPoolsStop()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsStart.json
            // this example is just showing the usage of "KustoPools_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            await synapseKustoPool.StartAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSkusByResource_KustoPoolsListResourceSkus()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolsListResourceSkus.json
            // this example is just showing the usage of "KustoPools_ListSkusByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (SynapseDataSourceResourceSku item in synapseKustoPool.GetSkusByResourceAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetLanguageExtensions_KustoPoolListLanguageExtensions()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolLanguageExtensionsList.json
            // this example is just showing the usage of "KustoPools_ListLanguageExtensions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (SynapseLanguageExtension item in synapseKustoPool.GetLanguageExtensionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task AddLanguageExtensions_KustoPoolAddLanguageExtensions()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolLanguageExtensionsAdd.json
            // this example is just showing the usage of "KustoPools_AddLanguageExtensions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            SynapseLanguageExtensionsList languageExtensionsToAdd = new SynapseLanguageExtensionsList()
            {
                Value =
{
new SynapseLanguageExtension()
{
LanguageExtensionName = SynapseLanguageExtensionName.Python,
},new SynapseLanguageExtension()
{
LanguageExtensionName = SynapseLanguageExtensionName.R,
}
},
            };
            await synapseKustoPool.AddLanguageExtensionsAsync(WaitUntil.Completed, languageExtensionsToAdd);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RemoveLanguageExtensions_KustoPoolRemoveLanguageExtensions()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolLanguageExtensionsRemove.json
            // this example is just showing the usage of "KustoPools_RemoveLanguageExtensions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            SynapseLanguageExtensionsList languageExtensionsToRemove = new SynapseLanguageExtensionsList()
            {
                Value =
{
new SynapseLanguageExtension()
{
LanguageExtensionName = SynapseLanguageExtensionName.Python,
},new SynapseLanguageExtension()
{
LanguageExtensionName = SynapseLanguageExtensionName.R,
}
},
            };
            await synapseKustoPool.RemoveLanguageExtensionsAsync(WaitUntil.Completed, languageExtensionsToRemove);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetFollowerDatabases_KustoPoolListFollowerDatabases()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolFollowerDatabasesList.json
            // this example is just showing the usage of "KustoPools_ListFollowerDatabases" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (SynapseFollowerDatabaseDefinition item in synapseKustoPool.GetFollowerDatabasesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DetachFollowerDatabases_KustoPoolDetachFollowerDatabases()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolFollowerDatabasesDetach.json
            // this example is just showing the usage of "KustoPools_DetachFollowerDatabases" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            SynapseFollowerDatabaseDefinition followerDatabaseToRemove = new SynapseFollowerDatabaseDefinition(new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.Synapse/workspaces/kustorptest/kustoPools/leader4"), "myAttachedDatabaseConfiguration");
            await synapseKustoPool.DetachFollowerDatabasesAsync(WaitUntil.Completed, followerDatabaseToRemove);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckKustoPoolChildResourceNameAvailability_KustoPoolAttachedDatabaseConfigurationCheckNameAvailability()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolAttachedDatabaseConfigurationCheckNameAvailability.json
            // this example is just showing the usage of "KustoPoolChildResource_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            KustoPoolChildResourceNameAvailabilityContent content = new KustoPoolChildResourceNameAvailabilityContent("adc1", KustoPoolDatabaseType.MicrosoftSynapseWorkspacesKustoPoolsAttachedDatabaseConfigurations);
            KustoPoolNameAvailabilityResult result = await synapseKustoPool.CheckKustoPoolChildResourceNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckKustoPoolChildResourceNameAvailability_KustoPoolDatabasesCheckNameAvailability()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDatabasesCheckNameAvailability.json
            // this example is just showing the usage of "KustoPoolChildResource_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            KustoPoolChildResourceNameAvailabilityContent content = new KustoPoolChildResourceNameAvailabilityContent("database1", KustoPoolDatabaseType.MicrosoftSynapseWorkspacesKustoPoolsDatabases);
            KustoPoolNameAvailabilityResult result = await synapseKustoPool.CheckKustoPoolChildResourceNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckKustoPoolPrincipalAssignmentNameAvailability_KustoPoolPrincipalAssignmentsCheckNameAvailability()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolPrincipalAssignmentsCheckNameAvailability.json
            // this example is just showing the usage of "KustoPoolPrincipalAssignments_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation
            KustoPoolPrincipalAssignmentNameAvailabilityContent content = new KustoPoolPrincipalAssignmentNameAvailabilityContent("kustoprincipal1");
            KustoPoolNameAvailabilityResult result = await synapseKustoPool.CheckKustoPoolPrincipalAssignmentNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAllKustoPoolPrivateLinkData_KustoPoolPrivateLinkResourcesList()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolPrivateLinkResourcesList.json
            // this example is just showing the usage of "KustoPoolPrivateLinkResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "7a587823-959d-4ad0-85bd-cf2a7cef436a";
            string resourceGroupName = "DP-900";
            string workspaceName = "synapse-ws-ebi-data";
            string kustoPoolName = "dataexplorerpool900";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (SynapseKustoPoolPrivateLinkData item in synapseKustoPool.GetAllKustoPoolPrivateLinkDataAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
