// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_Zones
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZone_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetZone("<partyId>", "<zoneId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZone_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetZoneAsync("<partyId>", "<zoneId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZone_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetZone("<partyId>", "<zoneId>", null);

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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZone_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetZoneAsync("<partyId>", "<zoneId>", null);

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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<partyId>", "<zoneId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<zoneId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                managementZoneId = "<managementZoneId>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<partyId>", "<zoneId>", content);

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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                type = "<type>",
                managementZoneId = "<managementZoneId>",
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<zoneId>", content);

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
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<zoneId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<zoneId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<zoneId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<zoneId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

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
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

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
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

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
        public void Example_GetZonesByPartyId_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetZonesByPartyId("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZonesByPartyId_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetZonesByPartyIdAsync("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZonesByPartyId_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetZonesByPartyId("<partyId>", new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZonesByPartyId_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetZonesByPartyIdAsync("<partyId>", new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZones_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetZones(null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZones_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetZonesAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetZones_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetZones(new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetZones_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetZonesAsync(new string[] { "<types>" }, new string[] { "<managementZoneIds>" }, new string[] { "<sources>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
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
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_ShortVersion()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_ShortVersion_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", null);
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
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", null);
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
            Zones client = new FarmBeatsClient(credential).GetZonesClient(apiVersion: "2022-11-01-preview");

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", "<zoneId>", null);
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
