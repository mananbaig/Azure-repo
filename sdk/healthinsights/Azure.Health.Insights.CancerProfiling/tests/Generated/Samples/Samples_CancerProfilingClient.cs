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
using Azure.Health.Insights.CancerProfiling;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Health.Insights.CancerProfiling.Samples
{
    public class Samples_CancerProfilingClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InferCancerProfile()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["patients"] = new List<object>()
{
new Dictionary<string, object>()
{
["id"] = "<id>",
}
},
            });
            Operation<BinaryData> operation = client.InferCancerProfile(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InferCancerProfile_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["patients"] = new List<object>()
{
new Dictionary<string, object>()
{
["id"] = "<id>",
["info"] = new Dictionary<string, object>()
{
["sex"] = "female",
["birthDate"] = "2022-05-10",
["clinicalInfo"] = new List<object>()
{
new Dictionary<string, object>()
{
["system"] = "<system>",
["code"] = "<code>",
["name"] = "<name>",
["value"] = "<value>",
}
},
},
["data"] = new List<object>()
{
new Dictionary<string, object>()
{
["type"] = "note",
["clinicalType"] = "consultation",
["id"] = "<id>",
["language"] = "<language>",
["createdDateTime"] = "2022-05-10T14:57:31.2311892-04:00",
["content"] = new Dictionary<string, object>()
{
["sourceType"] = "inline",
["value"] = "<value>",
},
}
},
}
},
                ["configuration"] = new Dictionary<string, object>()
                {
                    ["verbose"] = true,
                    ["includeEvidence"] = true,
                    ["inferenceTypes"] = new List<object>()
{
"tumorSite"
},
                    ["checkForCancerCase"] = true,
                },
            });
            Operation<BinaryData> operation = client.InferCancerProfile(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("confidenceScore").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("importance").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("caseId").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("modelVersion").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InferCancerProfile_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            OncoPhenotypeData oncoPhenotypeData = new OncoPhenotypeData(new List<PatientRecord>()
{
new PatientRecord("<id>")
});
            Operation<OncoPhenotypeResult> operation = client.InferCancerProfile(WaitUntil.Completed, oncoPhenotypeData);
            OncoPhenotypeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_InferCancerProfile_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            OncoPhenotypeData oncoPhenotypeData = new OncoPhenotypeData(new List<PatientRecord>()
{
new PatientRecord("<id>")
{
Info = new PatientInfo()
{
Sex = PatientInfoSex.Female,
BirthDate = DateTimeOffset.Parse("2022-05-10"),
ClinicalInfo =
{
new ClinicalCodedElement("<system>","<code>")
{
Name = "<name>",
Value = "<value>",
}
},
},
Data =
{
new PatientDocument(DocumentType.Note,"<id>",new DocumentContent(DocumentContentSourceType.Inline,"<value>"))
{
ClinicalType = ClinicalDocumentType.Consultation,
Language = "<language>",
CreatedDateTime = DateTimeOffset.Parse("2022-05-10T14:57:31.2311892-04:00"),
}
},
}
})
            {
                Configuration = new OncoPhenotypeModelConfiguration()
                {
                    Verbose = true,
                    IncludeEvidence = true,
                    InferenceTypes =
{
OncoPhenotypeInferenceType.TumorSite
},
                    CheckForCancerCase = true,
                },
            };
            Operation<OncoPhenotypeResult> operation = client.InferCancerProfile(WaitUntil.Completed, oncoPhenotypeData);
            OncoPhenotypeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InferCancerProfile_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["patients"] = new List<object>()
{
new Dictionary<string, object>()
{
["id"] = "<id>",
}
},
            });
            Operation<BinaryData> operation = await client.InferCancerProfileAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InferCancerProfile_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new Dictionary<string, object>()
            {
                ["patients"] = new List<object>()
{
new Dictionary<string, object>()
{
["id"] = "<id>",
["info"] = new Dictionary<string, object>()
{
["sex"] = "female",
["birthDate"] = "2022-05-10",
["clinicalInfo"] = new List<object>()
{
new Dictionary<string, object>()
{
["system"] = "<system>",
["code"] = "<code>",
["name"] = "<name>",
["value"] = "<value>",
}
},
},
["data"] = new List<object>()
{
new Dictionary<string, object>()
{
["type"] = "note",
["clinicalType"] = "consultation",
["id"] = "<id>",
["language"] = "<language>",
["createdDateTime"] = "2022-05-10T14:57:31.2311892-04:00",
["content"] = new Dictionary<string, object>()
{
["sourceType"] = "inline",
["value"] = "<value>",
},
}
},
}
},
                ["configuration"] = new Dictionary<string, object>()
                {
                    ["verbose"] = true,
                    ["includeEvidence"] = true,
                    ["inferenceTypes"] = new List<object>()
{
"tumorSite"
},
                    ["checkForCancerCase"] = true,
                },
            });
            Operation<BinaryData> operation = await client.InferCancerProfileAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdateDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("confidenceScore").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("text").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientDataEvidence").GetProperty("length").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("system").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("patientInfoEvidence").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("evidence")[0].GetProperty("importance").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("patients")[0].GetProperty("inferences")[0].GetProperty("caseId").ToString());
            Console.WriteLine(result.GetProperty("results").GetProperty("modelVersion").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InferCancerProfile_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            OncoPhenotypeData oncoPhenotypeData = new OncoPhenotypeData(new List<PatientRecord>()
{
new PatientRecord("<id>")
});
            Operation<OncoPhenotypeResult> operation = await client.InferCancerProfileAsync(WaitUntil.Completed, oncoPhenotypeData);
            OncoPhenotypeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_InferCancerProfile_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            CancerProfilingClient client = new CancerProfilingClient(endpoint, credential);

            OncoPhenotypeData oncoPhenotypeData = new OncoPhenotypeData(new List<PatientRecord>()
{
new PatientRecord("<id>")
{
Info = new PatientInfo()
{
Sex = PatientInfoSex.Female,
BirthDate = DateTimeOffset.Parse("2022-05-10"),
ClinicalInfo =
{
new ClinicalCodedElement("<system>","<code>")
{
Name = "<name>",
Value = "<value>",
}
},
},
Data =
{
new PatientDocument(DocumentType.Note,"<id>",new DocumentContent(DocumentContentSourceType.Inline,"<value>"))
{
ClinicalType = ClinicalDocumentType.Consultation,
Language = "<language>",
CreatedDateTime = DateTimeOffset.Parse("2022-05-10T14:57:31.2311892-04:00"),
}
},
}
})
            {
                Configuration = new OncoPhenotypeModelConfiguration()
                {
                    Verbose = true,
                    IncludeEvidence = true,
                    InferenceTypes =
{
OncoPhenotypeInferenceType.TumorSite
},
                    CheckForCancerCase = true,
                },
            };
            Operation<OncoPhenotypeResult> operation = await client.InferCancerProfileAsync(WaitUntil.Completed, oncoPhenotypeData);
            OncoPhenotypeResult responseData = operation.Value;
        }
    }
}
