// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseSqlPoolSecurityAlertPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetASecurityAlertOfASQLAnalyticsPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolSecurityAlert.json
            // this example is just showing the usage of "SqlPoolSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSecurityAlertPolicyResource created on azure
            // for more information of creating SynapseSqlPoolSecurityAlertPolicyResource, please refer to the document of SynapseSqlPoolSecurityAlertPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-6852";
            string workspaceName = "securityalert-2080";
            string sqlPoolName = "testdb";
            SqlPoolSecurityAlertPolicyName securityAlertPolicyName = SqlPoolSecurityAlertPolicyName.Default;
            ResourceIdentifier synapseSqlPoolSecurityAlertPolicyResourceId = SynapseSqlPoolSecurityAlertPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, securityAlertPolicyName);
            SynapseSqlPoolSecurityAlertPolicyResource synapseSqlPoolSecurityAlertPolicy = client.GetSynapseSqlPoolSecurityAlertPolicyResource(synapseSqlPoolSecurityAlertPolicyResourceId);

            // invoke the operation
            SynapseSqlPoolSecurityAlertPolicyResource result = await synapseSqlPoolSecurityAlertPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseSqlPoolSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateASqlPoolSThreatDetectionPolicyWithAllParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolSecurityAlertWithAllParameters.json
            // this example is just showing the usage of "SqlPoolSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSecurityAlertPolicyResource created on azure
            // for more information of creating SynapseSqlPoolSecurityAlertPolicyResource, please refer to the document of SynapseSqlPoolSecurityAlertPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string workspaceName = "securityalert-6440";
            string sqlPoolName = "testdb";
            SqlPoolSecurityAlertPolicyName securityAlertPolicyName = SqlPoolSecurityAlertPolicyName.Default;
            ResourceIdentifier synapseSqlPoolSecurityAlertPolicyResourceId = SynapseSqlPoolSecurityAlertPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, securityAlertPolicyName);
            SynapseSqlPoolSecurityAlertPolicyResource synapseSqlPoolSecurityAlertPolicy = client.GetSynapseSqlPoolSecurityAlertPolicyResource(synapseSqlPoolSecurityAlertPolicyResourceId);

            // invoke the operation
            SynapseSqlPoolSecurityAlertPolicyData data = new SynapseSqlPoolSecurityAlertPolicyData()
            {
                State = SynapseSecurityAlertPolicyState.Enabled,
                DisabledAlerts =
{
"Sql_Injection","Usage_Anomaly"
},
                EmailAddresses =
{
"test@microsoft.com","user@microsoft.com"
},
                EnableEmailToAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 6,
            };
            ArmOperation<SynapseSqlPoolSecurityAlertPolicyResource> lro = await synapseSqlPoolSecurityAlertPolicy.UpdateAsync(WaitUntil.Completed, data);
            SynapseSqlPoolSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseSqlPoolSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateASqlPoolSThreatDetectionPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolSecurityAlertWithMinParameters.json
            // this example is just showing the usage of "SqlPoolSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolSecurityAlertPolicyResource created on azure
            // for more information of creating SynapseSqlPoolSecurityAlertPolicyResource, please refer to the document of SynapseSqlPoolSecurityAlertPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string workspaceName = "securityalert-6440";
            string sqlPoolName = "testdb";
            SqlPoolSecurityAlertPolicyName securityAlertPolicyName = SqlPoolSecurityAlertPolicyName.Default;
            ResourceIdentifier synapseSqlPoolSecurityAlertPolicyResourceId = SynapseSqlPoolSecurityAlertPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, securityAlertPolicyName);
            SynapseSqlPoolSecurityAlertPolicyResource synapseSqlPoolSecurityAlertPolicy = client.GetSynapseSqlPoolSecurityAlertPolicyResource(synapseSqlPoolSecurityAlertPolicyResourceId);

            // invoke the operation
            SynapseSqlPoolSecurityAlertPolicyData data = new SynapseSqlPoolSecurityAlertPolicyData()
            {
                State = SynapseSecurityAlertPolicyState.Enabled,
            };
            ArmOperation<SynapseSqlPoolSecurityAlertPolicyResource> lro = await synapseSqlPoolSecurityAlertPolicy.UpdateAsync(WaitUntil.Completed, data);
            SynapseSqlPoolSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseSqlPoolSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
