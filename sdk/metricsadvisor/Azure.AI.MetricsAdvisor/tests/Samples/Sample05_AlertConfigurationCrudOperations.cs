﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.AI.MetricsAdvisor.Administration;
using Azure.AI.MetricsAdvisor.Models;
using Azure.AI.MetricsAdvisor.Tests;
using NUnit.Framework;

namespace Azure.AI.MetricsAdvisor.Samples
{
    public partial class MetricsAdvisorSamples : MetricsAdvisorTestEnvironment
    {
        [Test]
        public async Task CreateAndDeleteAlertConfigurationAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            #region Snippet:CreateAlertConfigurationAsync
#if SNIPPET
            string hookId = "<hookId>";
            string anomalyDetectionConfigurationId = "<anomalyDetectionConfigurationId>";
            string configurationName = "<configurationName>";
#else
            string hookId = HookId;
            string anomalyDetectionConfigurationId = DetectionConfigurationId;
            string configurationName = GetUniqueName();
#endif

            AnomalyAlertConfiguration alertConfiguration = new AnomalyAlertConfiguration()
            {
                Name = configurationName
            };

            alertConfiguration.IdsOfHooksToAlert.Add(hookId);

            var scope = MetricAnomalyAlertScope.GetScopeForWholeSeries();
            var metricAlertConfiguration = new MetricAnomalyAlertConfiguration(anomalyDetectionConfigurationId, scope);

            alertConfiguration.MetricAlertConfigurations.Add(metricAlertConfiguration);

            Response<AnomalyAlertConfiguration> response = await adminClient.CreateAlertConfigurationAsync(alertConfiguration);

            AnomalyAlertConfiguration createdAlertConfiguration = response.Value;

            Console.WriteLine($"Alert configuration ID: {createdAlertConfiguration.Id}");
            #endregion

            // Delete the anomaly alert configuration to clean up the Metrics Advisor resource. Do not
            // perform this step if you intend to keep using the configuration.

            await adminClient.DeleteAlertConfigurationAsync(createdAlertConfiguration.Id);
        }

        [Test]
        public async Task GetAlertConfigurationAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            string alertConfigurationId = AlertConfigurationId;

            Response<AnomalyAlertConfiguration> response = await adminClient.GetAlertConfigurationAsync(alertConfigurationId);

            AnomalyAlertConfiguration alertConfiguration = response.Value;

            Console.WriteLine($"Alert configuration name: {alertConfiguration.Name}");
            Console.WriteLine($"Alert configuration description: {alertConfiguration.Description}");
            Console.WriteLine();

            Console.WriteLine($"IDs of hooks to alert:");
            foreach (string hookId in alertConfiguration.IdsOfHooksToAlert)
            {
                Console.WriteLine($" - {hookId}");
            }

            Console.WriteLine();

            Console.WriteLine("Metric anomaly alert configurations:");
            foreach (MetricAnomalyAlertConfiguration metricAlertConfiguration in alertConfiguration.MetricAlertConfigurations)
            {
                Console.Write($"  Scope type: {metricAlertConfiguration.AlertScope.ScopeType}, ");
                Console.WriteLine($"Anomaly detection configuration ID: {metricAlertConfiguration.DetectionConfigurationId}");
            }
        }

        [Test]
        public async Task UpdateAlertConfigurationAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            string alertConfigurationId = AlertConfigurationId;

            Response<AnomalyAlertConfiguration> response = await adminClient.GetAlertConfigurationAsync(alertConfigurationId);
            AnomalyAlertConfiguration alertConfiguration = response.Value;

            string originalDescription = alertConfiguration.Description;
            alertConfiguration.Description = "This description was generated by a sample.";

            response = await adminClient.UpdateAlertConfigurationAsync(alertConfiguration);
            AnomalyAlertConfiguration updatedAlertConfiguration = response.Value;

            Console.WriteLine($"Updated description: {updatedAlertConfiguration.Description}");

            // Undo the changes to leave the alert configuration unaltered. Skip this step if you intend to keep
            // the changes.

            alertConfiguration.Description = originalDescription;
            await adminClient.UpdateAlertConfigurationAsync(alertConfiguration);
        }

        [Test]
        public async Task GetAlertConfigurationsAsync()
        {
            string endpoint = MetricsAdvisorUri;
            string subscriptionKey = MetricsAdvisorSubscriptionKey;
            string apiKey = MetricsAdvisorApiKey;
            var credential = new MetricsAdvisorKeyCredential(subscriptionKey, apiKey);

            var adminClient = new MetricsAdvisorAdministrationClient(new Uri(endpoint), credential);

            string detectionConfigurationId = DetectionConfigurationId;

            int configCount = 0;

            await foreach (AnomalyAlertConfiguration alertConfiguration in adminClient.GetAlertConfigurationsAsync(detectionConfigurationId))
            {
                Console.WriteLine($"Alert configuration ID: {alertConfiguration.Id}");
                Console.WriteLine($"Name: {alertConfiguration.Name}");
                Console.WriteLine($"Description: {alertConfiguration.Description}");
                Console.WriteLine();

                // Print at most 5 alert configurations.
                if (++configCount >= 5)
                {
                    break;
                }
            }
        }
    }
}
