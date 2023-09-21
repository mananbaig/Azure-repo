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
    internal class Samples_FarmOperationsDataIngestion
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetJobDetails()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            Response response = client.GetJobDetails("<jobId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetJobDetails_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            Response response = client.GetJobDetails("<jobId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetJobDetails_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            Response response = await client.GetJobDetailsAsync("<jobId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetJobDetails_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            Response response = await client.GetJobDetailsAsync("<jobId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            var data = new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                startYear = 1234,
            };

            var operation = client.CreateJob(WaitUntil.Completed, "<jobId>", RequestContent.Create(data));

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            var data = new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                operations = new[] {
        "<String>"
    },
                startYear = 1234,
                isIncremental = true,
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            var operation = client.CreateJob(WaitUntil.Completed, "<jobId>", RequestContent.Create(data));

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            var data = new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                startYear = 1234,
            };

            var operation = await client.CreateJobAsync(WaitUntil.Completed, "<jobId>", RequestContent.Create(data));

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetFarmOperationsDataIngestionClient("2022-11-01-preview");

            var data = new
            {
                partyId = "<partyId>",
                authProviderId = "<authProviderId>",
                operations = new[] {
        "<String>"
    },
                startYear = 1234,
                isIncremental = true,
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            var operation = await client.CreateJobAsync(WaitUntil.Completed, "<jobId>", RequestContent.Create(data));

            BinaryData responseData = operation.Value;
            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("authProviderId").ToString());
            Console.WriteLine(result.GetProperty("operations")[0].ToString());
            Console.WriteLine(result.GetProperty("startYear").ToString());
            Console.WriteLine(result.GetProperty("isIncremental").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }
    }
}
