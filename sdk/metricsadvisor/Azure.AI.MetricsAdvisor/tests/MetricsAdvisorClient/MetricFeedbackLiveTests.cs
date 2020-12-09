﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.MetricsAdvisor.Tests
{
    public class MetricFeedbackLiveTests : MetricsAdvisorLiveTestBase
    {
        public MetricFeedbackLiveTests(bool isAsync) : base(isAsync)
        {
        }

        private DateTimeOffset CreatedFeedbackStartTime => DateTimeOffset.Parse("2020-09-26T00:00:00Z");

        private DateTimeOffset CreatedFeedbackEndTime => DateTimeOffset.Parse("2020-09-29T00:00:00Z");

        private DateTimeOffset FeedbackSamplingStartTime => DateTimeOffset.Parse("2020-12-01T00:00:00Z");

        private DateTimeOffset FeedbackSamplingEndTime => DateTimeOffset.Parse("2020-12-31T00:00:00Z");

        [RecordedTest]
        [TestCase(true)]
        [TestCase(false)]
        public async Task AddAndGetAnomalyFeedback(bool populateOptionalMembers)
        {
            MetricsAdvisorClient client = GetMetricsAdvisorClient();

            var dimensionKey = new DimensionKey();
            dimensionKey.AddDimensionColumn("city", "Delhi");
            dimensionKey.AddDimensionColumn("category", "Handmade");

            var filter = new FeedbackDimensionFilter(dimensionKey);

            var feedbackToAdd = new MetricAnomalyFeedback(MetricId, filter, CreatedFeedbackStartTime, CreatedFeedbackEndTime, AnomalyValue.AutoDetect);

            if (populateOptionalMembers)
            {
                feedbackToAdd.AnomalyDetectionConfigurationId = DetectionConfigurationId;
            }

            string feedbackId = await client.AddFeedbackAsync(feedbackToAdd);

            Assert.That(feedbackId, Is.Not.Null);

            MetricFeedback addedFeedback = await client.GetFeedbackAsync(feedbackId);

            ValidateMetricFeedback(addedFeedback, feedbackId, dimensionKey);

            Assert.That(addedFeedback.Type, Is.EqualTo(FeedbackType.Anomaly));

            var anomalyFeedback = addedFeedback as MetricAnomalyFeedback;

            Assert.That(anomalyFeedback, Is.Not.Null);
            Assert.That(anomalyFeedback.AnomalyValue, Is.EqualTo(AnomalyValue.AutoDetect));
            Assert.That(anomalyFeedback.StartTime, Is.EqualTo(CreatedFeedbackStartTime));
            Assert.That(anomalyFeedback.EndTime, Is.EqualTo(CreatedFeedbackEndTime));

            if (populateOptionalMembers)
            {
                Assert.That(anomalyFeedback.AnomalyDetectionConfigurationId, Is.EqualTo(DetectionConfigurationId));
                // TODO: Add snapshot validation (https://github.com/azure/azure-sdk-for-net/issues/15915).
            }
            else
            {
                Assert.That(anomalyFeedback.AnomalyDetectionConfigurationId, Is.Null);
                Assert.That(anomalyFeedback.AnomalyDetectionConfigurationSnapshot, Is.Null);
            }
        }

        [RecordedTest]
        public async Task AddAndGetChangePointFeedback()
        {
            MetricsAdvisorClient client = GetMetricsAdvisorClient();

            var dimensionKey = new DimensionKey();
            dimensionKey.AddDimensionColumn("city", "Delhi");
            dimensionKey.AddDimensionColumn("category", "Handmade");

            var filter = new FeedbackDimensionFilter(dimensionKey);

            var feedbackToAdd = new MetricChangePointFeedback(MetricId, filter, CreatedFeedbackStartTime, CreatedFeedbackEndTime, ChangePointValue.AutoDetect);

            string feedbackId = await client.AddFeedbackAsync(feedbackToAdd);

            Assert.That(feedbackId, Is.Not.Null);

            MetricFeedback addedFeedback = await client.GetFeedbackAsync(feedbackId);

            ValidateMetricFeedback(addedFeedback, feedbackId, dimensionKey);

            Assert.That(addedFeedback.Type, Is.EqualTo(FeedbackType.ChangePoint));

            var changePointFeedback = addedFeedback as MetricChangePointFeedback;

            Assert.That(changePointFeedback, Is.Not.Null);
            Assert.That(changePointFeedback.ChangePointValue, Is.EqualTo(ChangePointValue.AutoDetect));
            Assert.That(changePointFeedback.StartTime, Is.EqualTo(CreatedFeedbackStartTime));
            Assert.That(changePointFeedback.EndTime, Is.EqualTo(CreatedFeedbackEndTime));
        }

        [RecordedTest]
        [TestCase(true)]
        [TestCase(false)]
        public async Task AddAndGetCommentFeedback(bool populateOptionalMembers)
        {
            MetricsAdvisorClient client = GetMetricsAdvisorClient();

            var dimensionKey = new DimensionKey();
            dimensionKey.AddDimensionColumn("city", "Delhi");
            dimensionKey.AddDimensionColumn("category", "Handmade");

            var filter = new FeedbackDimensionFilter(dimensionKey);
            var comment = "Feedback created in a .NET test.";

            var feedbackToAdd = new MetricCommentFeedback(MetricId, filter, comment);

            if (populateOptionalMembers)
            {
                feedbackToAdd.StartTime = CreatedFeedbackStartTime;
                feedbackToAdd.EndTime = CreatedFeedbackEndTime;
            }

            string feedbackId = await client.AddFeedbackAsync(feedbackToAdd);

            Assert.That(feedbackId, Is.Not.Null);

            MetricFeedback addedFeedback = await client.GetFeedbackAsync(feedbackId);

            ValidateMetricFeedback(addedFeedback, feedbackId, dimensionKey);

            Assert.That(addedFeedback.Type, Is.EqualTo(FeedbackType.Comment));

            var commentFeedback = addedFeedback as MetricCommentFeedback;

            Assert.That(commentFeedback, Is.Not.Null);
            Assert.That(commentFeedback.Comment, Is.EqualTo(comment));

            if (populateOptionalMembers)
            {
                Assert.That(commentFeedback.StartTime, Is.EqualTo(CreatedFeedbackStartTime));
                Assert.That(commentFeedback.EndTime, Is.EqualTo(CreatedFeedbackEndTime));
            }
            else
            {
                Assert.That(commentFeedback.StartTime, Is.Null);
                Assert.That(commentFeedback.EndTime, Is.Null);
            }
        }

        [RecordedTest]
        public async Task AddAndGetPeriodFeedback()
        {
            MetricsAdvisorClient client = GetMetricsAdvisorClient();

            var dimensionKey = new DimensionKey();
            dimensionKey.AddDimensionColumn("city", "Delhi");
            dimensionKey.AddDimensionColumn("category", "Handmade");

            var filter = new FeedbackDimensionFilter(dimensionKey);
            var periodValue = 10;

            var feedbackToAdd = new MetricPeriodFeedback(MetricId, filter, PeriodType.AutoDetect, periodValue);

            string feedbackId = await client.AddFeedbackAsync(feedbackToAdd);

            Assert.That(feedbackId, Is.Not.Null);

            MetricFeedback addedFeedback = await client.GetFeedbackAsync(feedbackId);

            ValidateMetricFeedback(addedFeedback, feedbackId, dimensionKey);

            Assert.That(addedFeedback.Type, Is.EqualTo(FeedbackType.Period));

            var periodFeedback = addedFeedback as MetricPeriodFeedback;

            Assert.That(periodFeedback, Is.Not.Null);
            Assert.That(periodFeedback.PeriodType, Is.EqualTo(PeriodType.AutoDetect));
            Assert.That(periodFeedback.PeriodValue, Is.EqualTo(periodValue));
        }

        [RecordedTest]
        [TestCase(true)]
        [TestCase(false)]
        public async Task GetAllFeedback(bool populateOptionalMembers)
        {
            MetricsAdvisorClient client = GetMetricsAdvisorClient();

            var options = new GetAllFeedbackOptions();

            if (populateOptionalMembers)
            {
                options.TimeMode = FeedbackQueryTimeMode.FeedbackCreatedTime;
                options.StartTime = FeedbackSamplingStartTime;
                options.EndTime = FeedbackSamplingEndTime;
                options.FeedbackType = FeedbackType.Comment;

                options.Filter.AddDimensionColumn("city", "Delhi");
            }

            var feedbackCount = 0;

            await foreach (MetricFeedback feedback in client.GetAllFeedbackAsync(MetricId, options))
            {
                Assert.That(feedback, Is.Not.Null);
                Assert.That(feedback.Id, Is.Not.Null.And.Not.Empty);
                Assert.That(feedback.MetricId, Is.EqualTo(MetricId));
                Assert.That(feedback.UserPrincipal, Is.Not.Null.And.Not.Empty);
                Assert.That(feedback.CreatedTime, Is.Not.Null);

                Assert.That(feedback.DimensionFilter, Is.Not.Null);
                Assert.That(feedback.DimensionFilter.DimensionFilter, Is.Not.Null);

                ValidateGroupKey(feedback.DimensionFilter.DimensionFilter);

                if (populateOptionalMembers)
                {
                    Assert.That(feedback.CreatedTime, Is.GreaterThanOrEqualTo(FeedbackSamplingStartTime));
                    Assert.That(feedback.CreatedTime, Is.LessThanOrEqualTo(FeedbackSamplingEndTime));
                    Assert.That(feedback.Type, Is.EqualTo(FeedbackType.Comment));

                    Dictionary<string, string> dimensionColumns = feedback.DimensionFilter.DimensionFilter.AsDictionary();

                    Assert.That(dimensionColumns.ContainsKey("city"));
                    Assert.That(dimensionColumns["city"], Is.EqualTo("Delhi"));
                }

                if (feedback.Type == FeedbackType.Anomaly)
                {
                    var anomalyFeedback = feedback as MetricAnomalyFeedback;

                    Assert.That(anomalyFeedback, Is.Not.Null);
                    Assert.That(anomalyFeedback.AnomalyValue, Is.Not.EqualTo(default(AnomalyFeedbackValue)));

                    if (anomalyFeedback.AnomalyDetectionConfigurationId != null)
                    {
                        // TODO: Add snapshot validation (https://github.com/azure/azure-sdk-for-net/issues/15915).
                    }
                }
                else if (feedback.Type == FeedbackType.ChangePoint)
                {
                    var changePointFeedback = feedback as MetricChangePointFeedback;

                    Assert.That(changePointFeedback, Is.Not.Null);
                    Assert.That(changePointFeedback.ChangePointValue, Is.Not.EqualTo(default(ChangePointValue)));
                }
                else if (feedback.Type == FeedbackType.Comment)
                {
                    var commentFeedback = feedback as MetricCommentFeedback;

                    Assert.That(commentFeedback, Is.Not.Null);
                    Assert.That(commentFeedback.Comment, Is.Not.Null.And.Not.Empty);
                }
                else
                {
                    Assert.That(feedback.Type, Is.EqualTo(FeedbackType.Period));

                    var periodFeedback = feedback as MetricPeriodFeedback;

                    Assert.That(periodFeedback, Is.Not.Null);
                    Assert.That(periodFeedback.PeriodType, Is.Not.EqualTo(default(PeriodType)));
                }

                if (++feedbackCount >= MaximumSamplesCount)
                {
                    break;
                }
            }

            Assert.That(feedbackCount, Is.GreaterThan(0));
        }

        private void ValidateMetricFeedback(MetricFeedback feedback, string expectedFeedbackId, DimensionKey expectedDimensionKey)
        {
            Assert.That(feedback, Is.Not.Null);
            Assert.That(feedback.Id, Is.EqualTo(expectedFeedbackId));
            Assert.That(feedback.MetricId, Is.EqualTo(MetricId));
            Assert.That(feedback.UserPrincipal, Is.Not.Null.And.Not.Empty);

            DateTimeOffset justNow = Recording.UtcNow.Subtract(TimeSpan.FromMinutes(5));
            Assert.That(feedback.CreatedTime, Is.GreaterThan(justNow));

            Assert.That(feedback.DimensionFilter, Is.Not.Null);
            Assert.That(feedback.DimensionFilter.DimensionFilter, Is.EqualTo(expectedDimensionKey));
        }
    }
}
