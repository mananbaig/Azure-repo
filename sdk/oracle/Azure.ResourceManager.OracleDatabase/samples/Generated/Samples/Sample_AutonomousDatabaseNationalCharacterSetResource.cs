// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_AutonomousDatabaseNationalCharacterSetResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAutonomousDbNationalCharacterSet()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/autonomousDatabaseNationalCharacterSet_get.json
            // this example is just showing the usage of "AutonomousDatabaseNationalCharacterSets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseNationalCharacterSetResource created on azure
            // for more information of creating AutonomousDatabaseNationalCharacterSetResource, please refer to the document of AutonomousDatabaseNationalCharacterSetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("eastus");
            string adbsncharsetname = "NATIONAL";
            ResourceIdentifier autonomousDatabaseNationalCharacterSetResourceId = AutonomousDatabaseNationalCharacterSetResource.CreateResourceIdentifier(subscriptionId, location, adbsncharsetname);
            AutonomousDatabaseNationalCharacterSetResource autonomousDatabaseNationalCharacterSet = client.GetAutonomousDatabaseNationalCharacterSetResource(autonomousDatabaseNationalCharacterSetResourceId);

            // invoke the operation
            AutonomousDatabaseNationalCharacterSetResource result = await autonomousDatabaseNationalCharacterSet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutonomousDatabaseNationalCharacterSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
