// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DefenderEasm.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DefenderEasm.Samples
{
    public partial class Sample_EasmLabelResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_Labels()
        {
            // Generated from example definition: specification/riskiq/resource-manager/Microsoft.Easm/preview/2023-04-01-preview/examples/Labels_GetByWorkspace.json
            // this example is just showing the usage of "Labels_GetByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EasmLabelResource created on azure
            // for more information of creating EasmLabelResource, please refer to the document of EasmLabelResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "dummyrg";
            string workspaceName = "ThisisaWorkspace";
            string labelName = "ThisisaLabel";
            ResourceIdentifier easmLabelResourceId = EasmLabelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, labelName);
            EasmLabelResource easmLabel = client.GetEasmLabelResource(easmLabelResourceId);

            // invoke the operation
            EasmLabelResource result = await easmLabel.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EasmLabelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_Labels()
        {
            // Generated from example definition: specification/riskiq/resource-manager/Microsoft.Easm/preview/2023-04-01-preview/examples/Labels_Update.json
            // this example is just showing the usage of "Labels_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EasmLabelResource created on azure
            // for more information of creating EasmLabelResource, please refer to the document of EasmLabelResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "dummyrg";
            string workspaceName = "ThisisaWorkspace";
            string labelName = "ThisisaLabel";
            ResourceIdentifier easmLabelResourceId = EasmLabelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, labelName);
            EasmLabelResource easmLabel = client.GetEasmLabelResource(easmLabelResourceId);

            // invoke the operation
            EasmLabelPatch patch = new EasmLabelPatch();
            EasmLabelResource result = await easmLabel.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EasmLabelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_Labels()
        {
            // Generated from example definition: specification/riskiq/resource-manager/Microsoft.Easm/preview/2023-04-01-preview/examples/Labels_Delete.json
            // this example is just showing the usage of "Labels_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EasmLabelResource created on azure
            // for more information of creating EasmLabelResource, please refer to the document of EasmLabelResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "dummyrg";
            string workspaceName = "ThisisaWorkspace";
            string labelName = "ThisisaLabel";
            ResourceIdentifier easmLabelResourceId = EasmLabelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, labelName);
            EasmLabelResource easmLabel = client.GetEasmLabelResource(easmLabelResourceId);

            // invoke the operation
            await easmLabel.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
