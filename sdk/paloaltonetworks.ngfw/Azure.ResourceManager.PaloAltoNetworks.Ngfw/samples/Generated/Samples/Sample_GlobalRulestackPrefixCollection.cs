// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_GlobalRulestackPrefixCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_PrefixListGlobalRulestackListMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_List_MaximumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation and iterate over the result
            await foreach (GlobalRulestackPrefixResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackPrefixData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_PrefixListGlobalRulestackListMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_List_MinimumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation and iterate over the result
            await foreach (GlobalRulestackPrefixResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackPrefixData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrefixListGlobalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackPrefixResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PrefixListGlobalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PrefixListGlobalRulestackGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            NullableResponse<GlobalRulestackPrefixResource> response = await collection.GetIfExistsAsync(name);
            GlobalRulestackPrefixResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackPrefixData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrefixListGlobalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackPrefixResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PrefixListGlobalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PrefixListGlobalRulestackGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            NullableResponse<GlobalRulestackPrefixResource> response = await collection.GetIfExistsAsync(name);
            GlobalRulestackPrefixResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GlobalRulestackPrefixData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PrefixListGlobalRulestackCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackPrefixData data = new GlobalRulestackPrefixData(new string[]
            {
"1.0.0.0/24"
            })
            {
                Description = "string",
                ETag = new ETag("2bf4a339-294d-4c25-b0b2-ef649e9f5c27"),
                AuditComment = "comment",
            };
            ArmOperation<GlobalRulestackPrefixResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            GlobalRulestackPrefixResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PrefixListGlobalRulestackCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/stable/2023-09-01/examples/PrefixListGlobalRulestack_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "PrefixListGlobalRulestack_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GlobalRulestackResource created on azure
            // for more information of creating GlobalRulestackResource, please refer to the document of GlobalRulestackResource
            string globalRulestackName = "praval";
            ResourceIdentifier globalRulestackResourceId = GlobalRulestackResource.CreateResourceIdentifier(globalRulestackName);
            GlobalRulestackResource globalRulestack = client.GetGlobalRulestackResource(globalRulestackResourceId);

            // get the collection of this GlobalRulestackPrefixResource
            GlobalRulestackPrefixCollection collection = globalRulestack.GetGlobalRulestackPrefixes();

            // invoke the operation
            string name = "armid1";
            GlobalRulestackPrefixData data = new GlobalRulestackPrefixData(new string[]
            {
"1.0.0.0/24"
            });
            ArmOperation<GlobalRulestackPrefixResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            GlobalRulestackPrefixResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GlobalRulestackPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
