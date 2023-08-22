﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;
using Azure.Core.TestFramework;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Developer.LoadTesting.Tests.Samples
{
    public partial class LoadTestingSamples : SamplesBase<LoadTestingClientTestEnvironment>
    {
        [Test]
        [SyncOnly]
        public void GetMetrics()
        {
#if SNIPPET
            // The data-plane endpoint is obtained from Control Plane APIs with "https://"
            // To obtain endpoint please follow: https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/loadtestservice/Azure.Developer.LoadTesting#data-plane-endpoint
            Uri endpointUrl = new Uri("https://" + <your resource URI obtained from steps above>);
            TokenCredential credential = new DefaultAzureCredential();
#else
            string endpoint = TestEnvironment.Endpoint;
            Uri endpointUrl = new Uri("https://" + endpoint);
            TokenCredential credential = TestEnvironment.Credential;
#endif

            // creating LoadTesting TestRun Client
            LoadTestRunClient loadTestRunClient = new LoadTestRunClient(endpointUrl, credential);

            #region Snippet:Azure_Developer_LoadTesting_GetMetrics

            string testId = "my-loadtest";
            string resourceId = TestEnvironment.ResourceId;
            string testRunId = "my-loadtest-run";

            // all other data to be sent to testRun
            var data = new
            {
                testid = testId,
                displayName = "My display name"
            };

            try
            {
                Response getTestRunResponse = loadTestRunClient.GetTestRun(testRunId);
                JsonDocument testRunJson = JsonDocument.Parse(getTestRunResponse.Content.ToString());

                Response getMetricNamespaces = loadTestRunClient.GetMetricNamespaces(testRunId);
                JsonDocument metricNamespacesJson = JsonDocument.Parse(getMetricNamespaces.Content.ToString());

                Response getMetricDefinitions = loadTestRunClient.GetMetricDefinitions(
                    testRunId, metricNamespacesJson.RootElement.GetProperty("value")[0].GetProperty("name").ToString()
                    );
                JsonDocument metricDefinitionsJson = JsonDocument.Parse(getMetricDefinitions.Content.ToString());

                Pageable<BinaryData> metrics = loadTestRunClient.GetMetrics(
                        testRunId,
                        metricNamespacesJson.RootElement.GetProperty("value")[0].GetProperty("name").GetString(),
                        metricDefinitionsJson.RootElement.GetProperty("value")[0].GetProperty("name").GetString(),
                        testRunJson.RootElement.GetProperty("startDateTime").GetString() + "/" + testRunJson.RootElement.GetProperty("endDateTime")
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
