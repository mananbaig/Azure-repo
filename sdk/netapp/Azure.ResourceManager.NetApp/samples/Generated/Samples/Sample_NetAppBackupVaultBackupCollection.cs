// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppBackupVaultBackupCollection
    {
        // Backups_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BackupsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/BackupsUnderBackupVault_List.json
            // this example is just showing the usage of "Backups_ListByVault" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultResource created on azure
            // for more information of creating NetAppBackupVaultResource, please refer to the document of NetAppBackupVaultResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            ResourceIdentifier netAppBackupVaultResourceId = NetAppBackupVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName);
            NetAppBackupVaultResource netAppBackupVault = client.GetNetAppBackupVaultResource(netAppBackupVaultResourceId);

            // get the collection of this NetAppBackupVaultBackupResource
            NetAppBackupVaultBackupCollection collection = netAppBackupVault.GetNetAppBackupVaultBackups();

            // invoke the operation and iterate over the result
            await foreach (NetAppBackupVaultBackupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppBackupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // BackupsUnderBackupVault_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BackupsUnderBackupVaultGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/BackupsUnderBackupVault_Get.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultResource created on azure
            // for more information of creating NetAppBackupVaultResource, please refer to the document of NetAppBackupVaultResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            ResourceIdentifier netAppBackupVaultResourceId = NetAppBackupVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName);
            NetAppBackupVaultResource netAppBackupVault = client.GetNetAppBackupVaultResource(netAppBackupVaultResourceId);

            // get the collection of this NetAppBackupVaultBackupResource
            NetAppBackupVaultBackupCollection collection = netAppBackupVault.GetNetAppBackupVaultBackups();

            // invoke the operation
            string backupName = "backup1";
            NetAppBackupVaultBackupResource result = await collection.GetAsync(backupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BackupsUnderBackupVault_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BackupsUnderBackupVaultGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/BackupsUnderBackupVault_Get.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultResource created on azure
            // for more information of creating NetAppBackupVaultResource, please refer to the document of NetAppBackupVaultResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            ResourceIdentifier netAppBackupVaultResourceId = NetAppBackupVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName);
            NetAppBackupVaultResource netAppBackupVault = client.GetNetAppBackupVaultResource(netAppBackupVaultResourceId);

            // get the collection of this NetAppBackupVaultBackupResource
            NetAppBackupVaultBackupCollection collection = netAppBackupVault.GetNetAppBackupVaultBackups();

            // invoke the operation
            string backupName = "backup1";
            bool result = await collection.ExistsAsync(backupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // BackupsUnderBackupVault_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_BackupsUnderBackupVaultGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/BackupsUnderBackupVault_Get.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultResource created on azure
            // for more information of creating NetAppBackupVaultResource, please refer to the document of NetAppBackupVaultResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            ResourceIdentifier netAppBackupVaultResourceId = NetAppBackupVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName);
            NetAppBackupVaultResource netAppBackupVault = client.GetNetAppBackupVaultResource(netAppBackupVaultResourceId);

            // get the collection of this NetAppBackupVaultBackupResource
            NetAppBackupVaultBackupCollection collection = netAppBackupVault.GetNetAppBackupVaultBackups();

            // invoke the operation
            string backupName = "backup1";
            NullableResponse<NetAppBackupVaultBackupResource> response = await collection.GetIfExistsAsync(backupName);
            NetAppBackupVaultBackupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppBackupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // BackupsUnderBackupVault_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BackupsUnderBackupVaultCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/BackupsUnderBackupVault_Create.json
            // this example is just showing the usage of "Backups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppBackupVaultResource created on azure
            // for more information of creating NetAppBackupVaultResource, please refer to the document of NetAppBackupVaultResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string backupVaultName = "backupVault1";
            ResourceIdentifier netAppBackupVaultResourceId = NetAppBackupVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, backupVaultName);
            NetAppBackupVaultResource netAppBackupVault = client.GetNetAppBackupVaultResource(netAppBackupVaultResourceId);

            // get the collection of this NetAppBackupVaultBackupResource
            NetAppBackupVaultBackupCollection collection = netAppBackupVault.GetNetAppBackupVaultBackups();

            // invoke the operation
            string backupName = "backup1";
            NetAppBackupData data = new NetAppBackupData(new ResourceIdentifier("/subscriptions/D633CC2E-722B-4AE1-B636-BBD9E4C60ED9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPool/pool1/volumes/volume1"))
            {
                Label = "myLabel",
            };
            ArmOperation<NetAppBackupVaultBackupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, backupName, data);
            NetAppBackupVaultBackupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
