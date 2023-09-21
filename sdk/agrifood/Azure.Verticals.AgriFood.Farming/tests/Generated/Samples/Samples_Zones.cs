// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_Zones
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZone()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = client.GetZone("<partyId>", "<zoneId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZone_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = client.GetZone("<partyId>", "<zoneId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZone_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = await client.GetZoneAsync("<partyId>", "<zoneId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZone_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = await client.GetZoneAsync("<partyId>", "<zoneId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var data = new { };

            Response response = client.CreateOrUpdate("<partyId>", "<zoneId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var data = new
            {
                type = "<type>",
                managementZoneId = "<managementZoneId>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            Response response = client.CreateOrUpdate("<partyId>", "<zoneId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var data = new { };

            Response response = await client.CreateOrUpdateAsync("<partyId>", "<zoneId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var data = new
            {
                type = "<type>",
                managementZoneId = "<managementZoneId>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            Response response = await client.CreateOrUpdateAsync("<partyId>", "<zoneId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<zoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<zoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<zoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<zoneId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", new RequestContext());

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
        public async Task Example_GetCascadeDeleteJobDetails_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", new RequestContext());

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
        public void Example_GetZonesByPartyId()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            foreach (var item in client.GetZonesByPartyId("<partyId>", new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZonesByPartyId_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            foreach (var item in client.GetZonesByPartyId("<partyId>", new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZonesByPartyId_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            await foreach (var item in client.GetZonesByPartyIdAsync("<partyId>", new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZonesByPartyId_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            await foreach (var item in client.GetZonesByPartyIdAsync("<partyId>", new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZones()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            foreach (var item in client.GetZones(new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZones_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            foreach (var item in client.GetZones(new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZones_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            await foreach (var item in client.GetZonesAsync(new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZones_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            await foreach (var item in client.GetZonesAsync(new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
                Console.WriteLine(result.GetProperty("managementZoneId").ToString());
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", new RequestContext());

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
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", new RequestContext());

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
        public async Task Example_CreateCascadeDeleteJob_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", new RequestContext());

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetZonesClient("2022-11-01-preview");

            var operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", new RequestContext());

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
