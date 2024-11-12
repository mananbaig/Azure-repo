// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_TenantDataBoundaryResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_OptInToDataBoundary()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2024-08-01/examples/PutDataBoundary.json
            // this example is just showing the usage of "DataBoundaries_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantDataBoundaryResource created on azure
            // for more information of creating TenantDataBoundaryResource, please refer to the document of TenantDataBoundaryResource
            DataBoundaryName name = DataBoundaryName.Default;
            ResourceIdentifier tenantDataBoundaryResourceId = TenantDataBoundaryResource.CreateResourceIdentifier(name);
            TenantDataBoundaryResource tenantDataBoundary = client.GetTenantDataBoundaryResource(tenantDataBoundaryResourceId);

            // invoke the operation
            DataBoundaryData data = new DataBoundaryData()
            {
                Properties = new DataBoundaryProperties()
                {
                    DataBoundary = DataBoundaryRegion.EU,
                },
            };
            ArmOperation<TenantDataBoundaryResource> lro = await tenantDataBoundary.UpdateAsync(WaitUntil.Completed, data);
            TenantDataBoundaryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoundaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDataBoundaryForTenant()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2024-08-01/examples/GetTenantDataBoundary.json
            // this example is just showing the usage of "DataBoundaries_GetTenant" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantDataBoundaryResource created on azure
            // for more information of creating TenantDataBoundaryResource, please refer to the document of TenantDataBoundaryResource
            DataBoundaryName name = DataBoundaryName.Default;
            ResourceIdentifier tenantDataBoundaryResourceId = TenantDataBoundaryResource.CreateResourceIdentifier(name);
            TenantDataBoundaryResource tenantDataBoundary = client.GetTenantDataBoundaryResource(tenantDataBoundaryResourceId);

            // invoke the operation
            TenantDataBoundaryResource result = await tenantDataBoundary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoundaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
