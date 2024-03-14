// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Monitor.Query;
using NUnit.Framework;

namespace Azure.Monitor.Query.Samples
{
    public partial class Samples_QueryClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetQuery_ShortVersion()
        {
            QueryClient client = new QueryClient();

            Response response = client.GetQuery("<workspaceId>", "<query>", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetQuery_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            Response response = await client.GetQueryAsync("<workspaceId>", "<query>", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetQuery_AllParameters()
        {
            QueryClient client = new QueryClient();

            Response response = client.GetQuery("<workspaceId>", "<query>", XmlConvert.ToTimeSpan("PT1H23M45S"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetQuery_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            Response response = await client.GetQueryAsync("<workspaceId>", "<query>", XmlConvert.ToTimeSpan("PT1H23M45S"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Execute_ShortVersion()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
            });
            Response response = client.Execute("<workspaceId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Execute_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
            });
            Response response = await client.ExecuteAsync("<workspaceId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Execute_AllParameters()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
                timespan = "<timespan>",
                workspaces = new object[]
            {
"<workspaces>"
            },
            });
            Response response = client.Execute("<workspaceId>", content, prefer: "<prefer>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Execute_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
                timespan = "<timespan>",
                workspaces = new object[]
            {
"<workspaces>"
            },
            });
            Response response = await client.ExecuteAsync("<workspaceId>", content, prefer: "<prefer>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceGet_ShortVersion()
        {
            QueryClient client = new QueryClient();

            Response response = client.ResourceGet(null, "<query>", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceGet_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            Response response = await client.ResourceGetAsync(null, "<query>", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceGet_AllParameters()
        {
            QueryClient client = new QueryClient();

            Response response = client.ResourceGet(null, "<query>", XmlConvert.ToTimeSpan("PT1H23M45S"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceGet_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            Response response = await client.ResourceGetAsync(null, "<query>", XmlConvert.ToTimeSpan("PT1H23M45S"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceExecute_ShortVersion()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
            });
            Response response = client.ResourceExecute(null, content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceExecute_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
            });
            Response response = await client.ResourceExecuteAsync(null, content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceExecute_AllParameters()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
                timespan = "<timespan>",
                workspaces = new object[]
            {
"<workspaces>"
            },
            });
            Response response = client.ResourceExecute(null, content, prefer: "<prefer>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceExecute_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
                timespan = "<timespan>",
                workspaces = new object[]
            {
"<workspaces>"
            },
            });
            Response response = await client.ResourceExecuteAsync(null, content, prefer: "<prefer>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Batch_ShortVersion()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                requests = new object[]
            {
new
{
id = "<id>",
body = new
{
query = "<query>",
},
path = "/query",
method = "POST",
workspace = "<workspace>",
}
            },
            });
            Response response = client.Batch(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Batch_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                requests = new object[]
            {
new
{
id = "<id>",
body = new
{
query = "<query>",
},
path = "/query",
method = "POST",
workspace = "<workspace>",
}
            },
            });
            Response response = await client.BatchAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Batch_AllParameters()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                requests = new object[]
            {
new
{
id = "<id>",
headers = new
{
key = "<headers>",
},
body = new
{
query = "<query>",
timespan = "<timespan>",
workspaces = new object[]
{
"<workspaces>"
},
},
path = "/query",
method = "POST",
workspace = "<workspace>",
}
            },
            });
            Response response = client.Batch(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("resources")[0].ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("additionalProperties").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("additionalProperties").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("headers").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Batch_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                requests = new object[]
            {
new
{
id = "<id>",
headers = new
{
key = "<headers>",
},
body = new
{
query = "<query>",
timespan = "<timespan>",
workspaces = new object[]
{
"<workspaces>"
},
},
path = "/query",
method = "POST",
workspace = "<workspace>",
}
            },
            });
            Response response = await client.BatchAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("resources")[0].ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("details")[0].GetProperty("additionalProperties").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("body").GetProperty("error").GetProperty("additionalProperties").ToString());
            Console.WriteLine(result.GetProperty("responses")[0].GetProperty("headers").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceGetXms_ShortVersion()
        {
            QueryClient client = new QueryClient();

            Response response = client.ResourceGetXms(null, "<query>", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceGetXms_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            Response response = await client.ResourceGetXmsAsync(null, "<query>", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceGetXms_AllParameters()
        {
            QueryClient client = new QueryClient();

            Response response = client.ResourceGetXms(null, "<query>", XmlConvert.ToTimeSpan("PT1H23M45S"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceGetXms_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            Response response = await client.ResourceGetXmsAsync(null, "<query>", XmlConvert.ToTimeSpan("PT1H23M45S"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceExecuteXms_ShortVersion()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
            });
            Response response = client.ResourceExecuteXms(null, content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceExecuteXms_ShortVersion_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
            });
            Response response = await client.ResourceExecuteXmsAsync(null, content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceExecuteXms_AllParameters()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
                timespan = "<timespan>",
                workspaces = new object[]
            {
"<workspaces>"
            },
            });
            Response response = client.ResourceExecuteXms(null, content, prefer: "<prefer>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceExecuteXms_AllParameters_Async()
        {
            QueryClient client = new QueryClient();

            using RequestContent content = RequestContent.Create(new
            {
                query = "<query>",
                timespan = "<timespan>",
                workspaces = new object[]
            {
"<workspaces>"
            },
            });
            Response response = await client.ResourceExecuteXmsAsync(null, content, prefer: "<prefer>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("columns")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("tables")[0].GetProperty("rows")[0][0].ToString());
            Console.WriteLine(result.GetProperty("statistics").ToString());
            Console.WriteLine(result.GetProperty("render").ToString());
            Console.WriteLine(result.GetProperty("error").ToString());
        }
    }
}
