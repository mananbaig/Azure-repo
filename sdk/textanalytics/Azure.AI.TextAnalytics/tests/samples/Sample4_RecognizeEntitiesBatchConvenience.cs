﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void RecognizeEntitiesBatchConvenience()
        {
            string endpoint = TextAnalyticsTestEnvironment.Instance.Endpoint;
            string apiKey = TextAnalyticsTestEnvironment.Instance.ApiKey;

            // Instantiate a client that will be used to call the service.
            var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            var documents = new List<string>
            {
                "Microsoft was founded by Bill Gates and Paul Allen.",
                "Text Analytics is one of the Azure Cognitive Services.",
                "A key technology in Text Analytics is Named Entity Recognition (NER).",
            };

            #region Snippet:TextAnalyticsSample4RecognizeEntitiesConvenience
            RecognizeEntitiesResultCollection results = client.RecognizeEntitiesBatch(documents);
            #endregion

            Debug.WriteLine($"Recognized entities for each document are:");
            int i = 0;
            foreach (RecognizeEntitiesResult result in results)
            {
                Debug.WriteLine($"For document: \"{documents[i++]}\",");
                Debug.WriteLine($"the following {result.Entities.Count()} entities were found: ");

                foreach (CategorizedEntity entity in result.Entities)
                {
                    Debug.WriteLine($"    Text: {entity.Text}, Category: {entity.Category}, SubCategory: {entity.SubCategory}, Confidence score: {entity.ConfidenceScore}");
                }
            }
        }
    }
}
