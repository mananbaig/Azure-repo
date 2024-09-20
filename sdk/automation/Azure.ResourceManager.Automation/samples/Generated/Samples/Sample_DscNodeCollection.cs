// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_DscNodeCollection
    {
        // Get a node
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetANode()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getDscNode.json
            // this example is just showing the usage of "DscNode_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation
            string nodeId = "nodeId";
            DscNodeResource result = await collection.GetAsync(nodeId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscNodeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a node
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetANode()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getDscNode.json
            // this example is just showing the usage of "DscNode_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation
            string nodeId = "nodeId";
            bool result = await collection.ExistsAsync(nodeId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a node
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetANode()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getDscNode.json
            // this example is just showing the usage of "DscNode_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation
            string nodeId = "nodeId";
            NullableResponse<DscNodeResource> response = await collection.GetIfExistsAsync(nodeId);
            DscNodeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List DSC nodes by Automation Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDSCNodesByAutomationAccount()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listAllDscNodesByAutomationAccount.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            await foreach (DscNodeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes by Automation Account where Node Configurations are not assigned filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesByAutomationAccountWhereNodeConfigurationsAreNotAssignedFilter()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithNodeConfigurationNotAssignedFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            string filter = "properties/nodeConfiguration/name eq ''";
            int? skip = 0;
            int? top = 20;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(filter: filter, skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes by Automation Account with Node Configuration Custom filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesByAutomationAccountWithNodeConfigurationCustomFilter()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithNodeConfigurationCustomFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            string filter = "contains(properties/nodeConfiguration/name,'SetupServer.localhost,SetupClient.localhost,$$Not$$Configured$$')";
            int? skip = 0;
            int? top = 4;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(filter: filter, skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes by Automation Account with name filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesByAutomationAccountWithNameFilter()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithNameFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            string filter = "contains('DSCCOMP',name)";
            int? skip = 0;
            int? top = 6;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(filter: filter, skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes by Automation Account with no filters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesByAutomationAccountWithNoFilters()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithNoFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            int? skip = 0;
            int? top = 2;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes by Automation Account with node status filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesByAutomationAccountWithNodeStatusFilter()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithStatusFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            string filter = "contains(properties/status,'Compliant,NotCompliant')";
            int? skip = 0;
            int? top = 4;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(filter: filter, skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes by Automation Account with version filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesByAutomationAccountWithVersionFilter()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithVersionFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            string filter = "properties/extensionHandler/any(eh: eh/version le '2.70')";
            int? skip = 0;
            int? top = 4;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(filter: filter, skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Paged DSC nodes with filters separated by 'and'
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPagedDSCNodesWithFiltersSeparatedByAnd()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listPagedDscNodesByAutomationAccountWithCompositeFilter.json
            // this example is just showing the usage of "DscNode_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this DscNodeResource
            DscNodeCollection collection = automationAccount.GetDscNodes();

            // invoke the operation and iterate over the result
            string filter = "properties/extensionHandler/any(eh: eh/version gt '2.70') and contains(name,'sql') and contains(properties/nodeConfiguration/name,'$$Not$$Configured$$')";
            int? skip = 0;
            int? top = 10;
            string inlinecount = "allpages";
            await foreach (DscNodeResource item in collection.GetAllAsync(filter: filter, skip: skip, top: top, inlinecount: inlinecount))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscNodeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
