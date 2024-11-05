// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_StaticSiteBuildDatabaseConnectionResource
    {
        // Get overview of database connections for the static site build.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetOverviewOfDatabaseConnectionsForTheStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSiteBuildDatabaseConnection.json
            // this example is just showing the usage of "StaticSites_GetBuildDatabaseConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildDatabaseConnectionResource created on azure
            // for more information of creating StaticSiteBuildDatabaseConnectionResource, please refer to the document of StaticSiteBuildDatabaseConnectionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            string databaseConnectionName = "default";
            ResourceIdentifier staticSiteBuildDatabaseConnectionResourceId = StaticSiteBuildDatabaseConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, databaseConnectionName);
            StaticSiteBuildDatabaseConnectionResource staticSiteBuildDatabaseConnection = client.GetStaticSiteBuildDatabaseConnectionResource(staticSiteBuildDatabaseConnectionResourceId);

            // invoke the operation
            StaticSiteBuildDatabaseConnectionResource result = await staticSiteBuildDatabaseConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteDatabaseConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a database connection from a static site build.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteADatabaseConnectionFromAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/DeleteStaticSiteBuildDatabaseConnection.json
            // this example is just showing the usage of "StaticSites_DeleteBuildDatabaseConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildDatabaseConnectionResource created on azure
            // for more information of creating StaticSiteBuildDatabaseConnectionResource, please refer to the document of StaticSiteBuildDatabaseConnectionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            string databaseConnectionName = "default";
            ResourceIdentifier staticSiteBuildDatabaseConnectionResourceId = StaticSiteBuildDatabaseConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, databaseConnectionName);
            StaticSiteBuildDatabaseConnectionResource staticSiteBuildDatabaseConnection = client.GetStaticSiteBuildDatabaseConnectionResource(staticSiteBuildDatabaseConnectionResourceId);

            // invoke the operation
            await staticSiteBuildDatabaseConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch a database connection for a static site build
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchADatabaseConnectionForAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/PatchStaticSiteBuildDatabaseConnection.json
            // this example is just showing the usage of "StaticSites_UpdateBuildDatabaseConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildDatabaseConnectionResource created on azure
            // for more information of creating StaticSiteBuildDatabaseConnectionResource, please refer to the document of StaticSiteBuildDatabaseConnectionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            string databaseConnectionName = "default";
            ResourceIdentifier staticSiteBuildDatabaseConnectionResourceId = StaticSiteBuildDatabaseConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, databaseConnectionName);
            StaticSiteBuildDatabaseConnectionResource staticSiteBuildDatabaseConnection = client.GetStaticSiteBuildDatabaseConnectionResource(staticSiteBuildDatabaseConnectionResourceId);

            // invoke the operation
            StaticSiteDatabaseConnectionPatchContent content = new StaticSiteDatabaseConnectionPatchContent();
            StaticSiteBuildDatabaseConnectionResource result = await staticSiteBuildDatabaseConnection.UpdateAsync(content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteDatabaseConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get details of database connections for the static site build.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBuildDatabaseConnectionWithDetails_GetDetailsOfDatabaseConnectionsForTheStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSiteBuildDatabaseConnectionWithDetails.json
            // this example is just showing the usage of "StaticSites_GetBuildDatabaseConnectionWithDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildDatabaseConnectionResource created on azure
            // for more information of creating StaticSiteBuildDatabaseConnectionResource, please refer to the document of StaticSiteBuildDatabaseConnectionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            string databaseConnectionName = "default";
            ResourceIdentifier staticSiteBuildDatabaseConnectionResourceId = StaticSiteBuildDatabaseConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, databaseConnectionName);
            StaticSiteBuildDatabaseConnectionResource staticSiteBuildDatabaseConnection = client.GetStaticSiteBuildDatabaseConnectionResource(staticSiteBuildDatabaseConnectionResourceId);

            // invoke the operation
            StaticSiteBuildDatabaseConnectionResource result = await staticSiteBuildDatabaseConnection.GetBuildDatabaseConnectionWithDetailsAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteDatabaseConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
