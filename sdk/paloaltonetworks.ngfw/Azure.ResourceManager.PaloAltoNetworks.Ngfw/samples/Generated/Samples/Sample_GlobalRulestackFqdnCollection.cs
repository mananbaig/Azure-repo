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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_GlobalRulestackFqdnCollection
    {
        // FqdnListGlobalRulestack_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FqdnListGlobalRulestackListMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_List_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation and iterate over the result
            await foreach (GlobalRulestackFqdnResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackFqdnData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FqdnListGlobalRulestack_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FqdnListGlobalRulestackListMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_List_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation and iterate over the result
            await foreach (GlobalRulestackFqdnResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackFqdnData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FqdnListGlobalRulestack_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FqdnListGlobalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackFqdnResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FqdnListGlobalRulestack_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FqdnListGlobalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // FqdnListGlobalRulestack_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FqdnListGlobalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            NullableResponse<GlobalRulestackFqdnResource> response = await collection.GetIfExistsAsync(name);
            GlobalRulestackFqdnResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackFqdnData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // FqdnListGlobalRulestack_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FqdnListGlobalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackFqdnResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FqdnListGlobalRulestack_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FqdnListGlobalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // FqdnListGlobalRulestack_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FqdnListGlobalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            NullableResponse<GlobalRulestackFqdnResource> response = await collection.GetIfExistsAsync(name);
            GlobalRulestackFqdnResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackFqdnData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // FqdnListGlobalRulestack_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FqdnListGlobalRulestackCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackFqdnData data = new GlobalRulestackFqdnData(new string[]
            {
"string1","string2"
            })
            {
                Description = "string",
                ETag = new ETag("aaaaaaaaaaaaaaaaaa"),
                AuditComment = "string",
            };
            ArmOperation<GlobalRulestackFqdnResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            GlobalRulestackFqdnResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FqdnListGlobalRulestack_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FqdnListGlobalRulestackCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2022-08-29/examples/FqdnListGlobalRulestack_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "FqdnListGlobalRulestack_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackFqdnResource
            GlobalRulestackFqdnCollection collection = globalRulestack.GetGlobalRulestackFqdns();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackFqdnData data = new GlobalRulestackFqdnData(new string[]
            {
"string1","string2"
            });
            ArmOperation<GlobalRulestackFqdnResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            GlobalRulestackFqdnResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackFqdnData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
