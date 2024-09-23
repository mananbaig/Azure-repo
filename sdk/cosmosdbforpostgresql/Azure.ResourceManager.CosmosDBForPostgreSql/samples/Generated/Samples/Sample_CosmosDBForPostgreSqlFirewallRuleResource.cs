// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Samples
{
    public partial class Sample_CosmosDBForPostgreSqlFirewallRuleResource
    {
        // Create a firewall rule of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlFirewallRuleResource created on azure
            // for more information of creating CosmosDBForPostgreSqlFirewallRuleResource, please refer to the document of CosmosDBForPostgreSqlFirewallRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            string firewallRuleName = "rule1";
            ResourceIdentifier cosmosDBForPostgreSqlFirewallRuleResourceId = CosmosDBForPostgreSqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, firewallRuleName);
            CosmosDBForPostgreSqlFirewallRuleResource cosmosDBForPostgreSqlFirewallRule = client.GetCosmosDBForPostgreSqlFirewallRuleResource(cosmosDBForPostgreSqlFirewallRuleResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlFirewallRuleData data = new CosmosDBForPostgreSqlFirewallRuleData(IPAddress.Parse("0.0.0.0"), IPAddress.Parse("255.255.255.255"));
            ArmOperation<CosmosDBForPostgreSqlFirewallRuleResource> lro = await cosmosDBForPostgreSqlFirewallRule.UpdateAsync(WaitUntil.Completed, data);
            CosmosDBForPostgreSqlFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete the firewall rule of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteTheFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleDelete.json
            // this example is just showing the usage of "FirewallRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlFirewallRuleResource created on azure
            // for more information of creating CosmosDBForPostgreSqlFirewallRuleResource, please refer to the document of CosmosDBForPostgreSqlFirewallRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            string firewallRuleName = "rule1";
            ResourceIdentifier cosmosDBForPostgreSqlFirewallRuleResourceId = CosmosDBForPostgreSqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, firewallRuleName);
            CosmosDBForPostgreSqlFirewallRuleResource cosmosDBForPostgreSqlFirewallRule = client.GetCosmosDBForPostgreSqlFirewallRuleResource(cosmosDBForPostgreSqlFirewallRuleResourceId);

            // invoke the operation
            await cosmosDBForPostgreSqlFirewallRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get the firewall rule of the cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheFirewallRuleOfTheCluster()
        {
            // Generated from example definition: specification/postgresqlhsc/resource-manager/Microsoft.DBforPostgreSQL/stable/2022-11-08/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBForPostgreSqlFirewallRuleResource created on azure
            // for more information of creating CosmosDBForPostgreSqlFirewallRuleResource, please refer to the document of CosmosDBForPostgreSqlFirewallRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestGroup";
            string clusterName = "pgtestsvc4";
            string firewallRuleName = "rule1";
            ResourceIdentifier cosmosDBForPostgreSqlFirewallRuleResourceId = CosmosDBForPostgreSqlFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, firewallRuleName);
            CosmosDBForPostgreSqlFirewallRuleResource cosmosDBForPostgreSqlFirewallRule = client.GetCosmosDBForPostgreSqlFirewallRuleResource(cosmosDBForPostgreSqlFirewallRuleResourceId);

            // invoke the operation
            CosmosDBForPostgreSqlFirewallRuleResource result = await cosmosDBForPostgreSqlFirewallRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBForPostgreSqlFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
