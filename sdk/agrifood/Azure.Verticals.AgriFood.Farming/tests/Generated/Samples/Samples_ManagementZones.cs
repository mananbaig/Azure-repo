// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_ManagementZones
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetManagementZone()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetManagementZone("<partyId>", "<managementZoneId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetManagementZone_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetManagementZoneAsync("<partyId>", "<managementZoneId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetManagementZone_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetManagementZone("<partyId>", "<managementZoneId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("seasonId").ToString());
            Console.WriteLine(result.GetProperty("cropId").ToString());
            Console.WriteLine(result.GetProperty("fieldId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetManagementZone_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetManagementZoneAsync("<partyId>", "<managementZoneId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("seasonId").ToString());
            Console.WriteLine(result.GetProperty("cropId").ToString());
            Console.WriteLine(result.GetProperty("fieldId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<partyId>", "<managementZoneId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<managementZoneId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                seasonId = "<seasonId>",
                cropId = "<cropId>",
                fieldId = "<fieldId>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<partyId>", "<managementZoneId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("seasonId").ToString());
            Console.WriteLine(result.GetProperty("cropId").ToString());
            Console.WriteLine(result.GetProperty("fieldId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                seasonId = "<seasonId>",
                cropId = "<cropId>",
                fieldId = "<fieldId>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<managementZoneId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("seasonId").ToString());
            Console.WriteLine(result.GetProperty("cropId").ToString());
            Console.WriteLine(result.GetProperty("fieldId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<managementZoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<managementZoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<managementZoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<managementZoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetManagementZones()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetManagementZones(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetManagementZones_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetManagementZonesAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetManagementZones_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetManagementZones(new List<string>()
{
"<types>"
}, new List<string>()
{
"<cropIds>"
}, new List<string>()
{
"<seasonIds>"
}, new List<string>()
{
"<fieldIds>"
}, new List<string>()
{
"<sources>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("seasonId").ToString());
                Console.WriteLine(result[0].GetProperty("cropId").ToString());
                Console.WriteLine(result[0].GetProperty("fieldId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("source").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetManagementZones_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetManagementZonesAsync(new List<string>()
{
"<types>"
}, new List<string>()
{
"<cropIds>"
}, new List<string>()
{
"<seasonIds>"
}, new List<string>()
{
"<fieldIds>"
}, new List<string>()
{
"<sources>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("seasonId").ToString());
                Console.WriteLine(result[0].GetProperty("cropId").ToString());
                Console.WriteLine(result[0].GetProperty("fieldId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("source").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetManagementZonesByPartyId()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetManagementZonesByPartyId("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetManagementZonesByPartyId_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetManagementZonesByPartyIdAsync("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetManagementZonesByPartyId_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetManagementZonesByPartyId("<partyId>", new List<string>()
{
"<types>"
}, new List<string>()
{
"<cropIds>"
}, new List<string>()
{
"<seasonIds>"
}, new List<string>()
{
"<fieldIds>"
}, new List<string>()
{
"<sources>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("seasonId").ToString());
                Console.WriteLine(result[0].GetProperty("cropId").ToString());
                Console.WriteLine(result[0].GetProperty("fieldId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("source").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetManagementZonesByPartyId_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetManagementZonesByPartyIdAsync("<partyId>", new List<string>()
{
"<types>"
}, new List<string>()
{
"<cropIds>"
}, new List<string>()
{
"<seasonIds>"
}, new List<string>()
{
"<fieldIds>"
}, new List<string>()
{
"<sources>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("partyId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("seasonId").ToString());
                Console.WriteLine(result[0].GetProperty("cropId").ToString());
                Console.WriteLine(result[0].GetProperty("fieldId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("source").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<managementZoneId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<managementZoneId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<managementZoneId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            ManagementZones client = new FarmBeatsClient(credential).GetManagementZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<managementZoneId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }
    }
}
