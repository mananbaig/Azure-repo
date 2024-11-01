// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Synapse.AccessControl.Samples
{
    public partial class Samples_RoleAssignmentsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CheckPrincipalAccess_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                actions = new object[]
            {
new
{
id = "<id>",
isDataAction = true,
}
            },
                scope = "<scope>",
            });
            Response response = client.CheckPrincipalAccess(content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CheckPrincipalAccess_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                },
                actions = new object[]
            {
new
{
id = "<id>",
isDataAction = true,
}
            },
                scope = "<scope>",
            });
            Response response = await client.CheckPrincipalAccessAsync(content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CheckPrincipalAccess_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    groupIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
                },
                actions = new object[]
            {
new
{
id = "<id>",
isDataAction = true,
}
            },
                scope = "<scope>",
            });
            Response response = client.CheckPrincipalAccess(content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("accessDecision").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("actionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CheckPrincipalAccess_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                subject = new
                {
                    principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                    groupIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
                },
                actions = new object[]
            {
new
{
id = "<id>",
isDataAction = true,
}
            },
                scope = "<scope>",
            });
            Response response = await client.CheckPrincipalAccessAsync(content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("accessDecision").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("actionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("accessDecisions")[0].GetProperty("roleAssignment").GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignments_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignments(null, null, null, null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignments_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentsAsync(null, null, null, null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignments_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignments("<roleId>", "<principalId>", "<scope>", "<continuationToken>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignments_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentsAsync("<roleId>", "<principalId>", "<scope>", "<continuationToken>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("count").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("value")[0].GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateRoleAssignment_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
            });
            Response response = client.CreateRoleAssignment("<roleAssignmentId>", content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateRoleAssignment_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
            });
            Response response = await client.CreateRoleAssignmentAsync("<roleAssignmentId>", content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateRoleAssignment_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
                principalType = "<principalType>",
            });
            Response response = client.CreateRoleAssignment("<roleAssignmentId>", content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateRoleAssignment_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                roleId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                principalId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                scope = "<scope>",
                principalType = "<principalType>",
            });
            Response response = await client.CreateRoleAssignmentAsync("<roleAssignmentId>", content, new ContentType("application/json"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignmentById_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignmentById("<roleAssignmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignmentById_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentByIdAsync("<roleAssignmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetRoleAssignmentById_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.GetRoleAssignmentById("<roleAssignmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetRoleAssignmentById_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.GetRoleAssignmentByIdAsync("<roleAssignmentId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("roleDefinitionId").ToString());
            Console.WriteLine(result.GetProperty("principalId").ToString());
            Console.WriteLine(result.GetProperty("scope").ToString());
            Console.WriteLine(result.GetProperty("principalType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteRoleAssignmentById_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.DeleteRoleAssignmentById("<roleAssignmentId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteRoleAssignmentById_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.DeleteRoleAssignmentByIdAsync("<roleAssignmentId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteRoleAssignmentById_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = client.DeleteRoleAssignmentById("<roleAssignmentId>", scope: "<scope>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteRoleAssignmentById_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            RoleAssignmentsClient client = new RoleAssignmentsClient(endpoint, credential);

            Response response = await client.DeleteRoleAssignmentByIdAsync("<roleAssignmentId>", scope: "<scope>");

            Console.WriteLine(response.Status);
        }
    }
}
