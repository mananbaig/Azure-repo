﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Monitor.Query.Models;
using NUnit.Framework;

namespace Azure.Monitor.Query.Tests
{
    public class MetricsQueryClientLiveTests : RecordedTestBase<MonitorQueryClientTestEnvironment>
    {
        private MetricsTestData _testData;

        public MetricsQueryClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        private MetricsClient CreateClient()
        {
            return InstrumentClient(new MetricsClient(
                TestEnvironment.Credential,
                InstrumentClientOptions(new MetricsClientOptions())
            ));
        }

        [SetUp]
        public async Task SetUp()
        {
            _testData = new MetricsTestData(this);
            await _testData.InitializeAsync();
        }

        [Test]
        public async Task CanListMetrics()
        {
            var client = CreateClient();

            var results = await client.GetMetricsAsync(TestEnvironment.MetricsResource, TestEnvironment.MetricsNamespace);

            CollectionAssert.IsNotEmpty(results.Value);
        }

        [Test]
        public async Task CanQueryMetrics()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions()
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    Duration = TimeSpan.FromMinutes(3)
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.AreEqual(3, timeSeriesData.Count);
            // Average is queried by default
            Assert.True(timeSeriesData.All(d=> d.Average != null));
        }

        [Test]
        public async Task CanQueryMetricsAllAggregations()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    EndTime = _testData.StartTime.Add(_testData.Duration),
                    Aggregations =
                    {
                        MetricAggregationType.Average,
                        MetricAggregationType.Count,
                        MetricAggregationType.Maximum,
                        MetricAggregationType.Minimum,
                        MetricAggregationType.Total
                    }
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.AreEqual(_testData.Duration.Minutes, timeSeriesData.Count);
            // Average is queried by default
            Assert.True(timeSeriesData.All(d=>
                d.Average != null &&
                d.Count != null &&
                d.Maximum != null &&
                d.Minimum != null &&
                d.Total != null));
        }

        [Test]
        public async Task CanQueryMetricsStartEnd()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    EndTime = _testData.EndTime
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.AreEqual(_testData.Duration.Minutes, timeSeriesData.Count);
            Assert.True(timeSeriesData.All(d=>
                d.TimeStamp >= _testData.StartTime && d.TimeStamp <= _testData.EndTime));
        }

        [Test]
        public async Task CanQueryMetricsStartDuration()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    Duration = _testData.Duration
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.AreEqual(_testData.Duration.Minutes, timeSeriesData.Count);
            Assert.True(timeSeriesData.All(d=>
                d.TimeStamp >= _testData.StartTime && d.TimeStamp <= _testData.EndTime));
        }

        [Test]
        public async Task CanQueryMetricsDurationEnd()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    EndTime = _testData.EndTime,
                    Duration = _testData.Duration
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.AreEqual(_testData.Duration.Minutes, timeSeriesData.Count);
            Assert.True(timeSeriesData.All(d=>
                d.TimeStamp >= _testData.StartTime && d.TimeStamp <= _testData.EndTime));
        }

        [Test]
        public async Task CanQueryMetricsNoTimespan()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.Greater(timeSeriesData.Count, 0);
        }

        [Test]
        public async Task CanQueryMetricsStartEndInterval()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[]{ _testData.MetricName },
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    EndTime = _testData.EndTime,
                    Interval = TimeSpan.FromMinutes(5)
                });

            var timeSeriesData = results.Value.Metrics[0].Timeseries[0].Data;
            Assert.AreEqual(_testData.Duration.Minutes / 5, timeSeriesData.Count);
            Assert.True(timeSeriesData.All(d=>
                d.TimeStamp >= _testData.StartTime && d.TimeStamp <= _testData.EndTime));
        }

        [Test]
        public async Task CanQueryMetricsFilter()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[] {_testData.MetricName},
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    EndTime = _testData.EndTime,
                    Filter = $"Name eq '{_testData.Name1}'",
                    Aggregations =
                    {
                        MetricAggregationType.Count
                    }
                });

            var timeSeries = results.Value.Metrics[0].Timeseries[0];

            Assert.AreEqual(_testData.Name1, timeSeries.Metadata["name"]);
        }
        [Test]
        public async Task CanQueryMetricsFilterTop()
        {
            var client = CreateClient();

            var results = await client.QueryAsync(
                TestEnvironment.MetricsResource,
                new[] {_testData.MetricName},
                new MetricQueryOptions
                {
                    MetricNamespace = _testData.MetricNamespace,
                    StartTime = _testData.StartTime,
                    EndTime = _testData.EndTime,
                    Filter = $"Name eq '*'",
                    Top = 1,
                    Aggregations =
                    {
                        MetricAggregationType.Count
                    }
                });

            Assert.AreEqual(1, results.Value.Metrics[0].Timeseries.Count);
        }

        [Test]
        public async Task CanListNamespacesMetrics()
        {
            var client = CreateClient();

            var results = await client.GetMetricNamespacesAsync(
                TestEnvironment.MetricsResource);

            CollectionAssert.IsNotEmpty(results.Value);
        }
    }
}