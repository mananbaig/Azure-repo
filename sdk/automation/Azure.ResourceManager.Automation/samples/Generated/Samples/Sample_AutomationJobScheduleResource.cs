// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationJobScheduleResource
    {
        // Delete a job schedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAJobSchedule()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/deleteJobSchedule.json
            // this example is just showing the usage of "JobSchedule_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationJobScheduleResource created on azure
            // for more information of creating AutomationJobScheduleResource, please refer to the document of AutomationJobScheduleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            Guid jobScheduleId = Guid.Parse("0fa462ba-3aa2-4138-83ca-9ebc3bc55cdc");
            ResourceIdentifier automationJobScheduleResourceId = AutomationJobScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, jobScheduleId);
            AutomationJobScheduleResource automationJobSchedule = client.GetAutomationJobScheduleResource(automationJobScheduleResourceId);

            // invoke the operation
            await automationJobSchedule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a job schedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAJobSchedule()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getJobSchedule.json
            // this example is just showing the usage of "JobSchedule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationJobScheduleResource created on azure
            // for more information of creating AutomationJobScheduleResource, please refer to the document of AutomationJobScheduleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            Guid jobScheduleId = Guid.Parse("0fa462ba-3aa2-4138-83ca-9ebc3bc55cdc");
            ResourceIdentifier automationJobScheduleResourceId = AutomationJobScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, jobScheduleId);
            AutomationJobScheduleResource automationJobSchedule = client.GetAutomationJobScheduleResource(automationJobScheduleResourceId);

            // invoke the operation
            AutomationJobScheduleResource result = await automationJobSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationJobScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a job schedule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateAJobSchedule()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/createJobSchedule.json
            // this example is just showing the usage of "JobSchedule_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationJobScheduleResource created on azure
            // for more information of creating AutomationJobScheduleResource, please refer to the document of AutomationJobScheduleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "ContoseAutomationAccount";
            Guid jobScheduleId = Guid.Parse("0fa462ba-3aa2-4138-83ca-9ebc3bc55cdc");
            ResourceIdentifier automationJobScheduleResourceId = AutomationJobScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, jobScheduleId);
            AutomationJobScheduleResource automationJobSchedule = client.GetAutomationJobScheduleResource(automationJobScheduleResourceId);

            // invoke the operation
            AutomationJobScheduleCreateOrUpdateContent content = new AutomationJobScheduleCreateOrUpdateContent(new ScheduleAssociationProperty()
            {
                Name = "ScheduleNameGoesHere332204b5-debe-4348-a5c7-6357457189f2",
            }, new RunbookAssociationProperty()
            {
                Name = "TestRunbook",
            })
            {
                Parameters =
{
["jobscheduletag01"] = "jobschedulevalue01",
["jobscheduletag02"] = "jobschedulevalue02",
},
            };
            ArmOperation<AutomationJobScheduleResource> lro = await automationJobSchedule.UpdateAsync(WaitUntil.Completed, content);
            AutomationJobScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationJobScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
