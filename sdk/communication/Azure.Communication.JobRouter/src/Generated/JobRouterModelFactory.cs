// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Model factory for models. </summary>
    public static partial class JobRouterModelFactory
    {
        /// <summary> Initializes a new instance of DistributionMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for the job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of DistributionMode. </param>
        /// <returns> A new <see cref="JobRouter.DistributionMode"/> instance for mocking. </returns>
        public static DistributionMode DistributionMode(int minConcurrentOffers = default, int maxConcurrentOffers = default, bool? bypassSelectors = null, string kind = null)
        {
            return new UnknownDistributionMode(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, kind);
        }

        /// <summary> Initializes a new instance of RouterRule. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of RouterRule. </param>
        /// <returns> A new <see cref="JobRouter.RouterRule"/> instance for mocking. </returns>
        public static RouterRule RouterRule(string kind = null)
        {
            return new UnknownRouterRule(kind);
        }

        /// <summary> Initializes a new instance of QueueSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of QueueSelectorAttachment. </param>
        /// <returns> A new <see cref="JobRouter.QueueSelectorAttachment"/> instance for mocking. </returns>
        public static QueueSelectorAttachment QueueSelectorAttachment(string kind = null)
        {
            return new UnknownQueueSelectorAttachment(kind);
        }

        /// <summary> Initializes a new instance of QueueWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="queueSelectors"> A collection of queue selectors that will be applied if this allocation is selected. </param>
        /// <returns> A new <see cref="JobRouter.QueueWeightedAllocation"/> instance for mocking. </returns>
        public static QueueWeightedAllocation QueueWeightedAllocation(double weight = default, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new QueueWeightedAllocation(weight, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of WorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of WorkerSelectorAttachment. </param>
        /// <returns> A new <see cref="JobRouter.WorkerSelectorAttachment"/> instance for mocking. </returns>
        public static WorkerSelectorAttachment WorkerSelectorAttachment(string kind = null)
        {
            return new UnknownWorkerSelectorAttachment(kind);
        }

        /// <summary> Initializes a new instance of WorkerWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="workerSelectors"> A collection of worker selectors that will be applied if this allocation is selected. </param>
        /// <returns> A new <see cref="JobRouter.WorkerWeightedAllocation"/> instance for mocking. </returns>
        public static WorkerWeightedAllocation WorkerWeightedAllocation(double weight = default, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new WorkerWeightedAllocation(weight, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of ExceptionRule. </summary>
        /// <param name="id"> Id of the exception rule. </param>
        /// <param name="trigger">
        /// The trigger for this exception rule
        /// Please note <see cref="JobRouter.ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
        /// </param>
        /// <param name="actions">
        /// A collection of actions to perform once the exception is triggered.
        /// Please note <see cref="JobRouter.ExceptionAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.CancelExceptionAction"/>, <see cref="JobRouter.ManualReclassifyExceptionAction"/> and <see cref="ReclassifyExceptionAction"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.ExceptionRule"/> instance for mocking. </returns>
        public static ExceptionRule ExceptionRule(string id = null, ExceptionTrigger trigger = null, IEnumerable<ExceptionAction> actions = null)
        {
            actions ??= new List<ExceptionAction>();

            return new ExceptionRule(id, trigger, actions?.ToList());
        }

        /// <summary> Initializes a new instance of ExceptionTrigger. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionTrigger. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionTrigger"/> instance for mocking. </returns>
        public static ExceptionTrigger ExceptionTrigger(string kind = null)
        {
            return new UnknownExceptionTrigger(kind);
        }

        /// <summary> Initializes a new instance of ExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionAction"/> instance for mocking. </returns>
        public static ExceptionAction ExceptionAction(string id = null, string kind = null)
        {
            return new UnknownExceptionAction(id, kind);
        }

        /// <summary> Initializes a new instance of RouterJobAssignment. </summary>
        /// <param name="assignmentId"> The Id of the job assignment. </param>
        /// <param name="workerId"> The Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <param name="completedAt"> The time the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> The time the job was marked as closed after being completed in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(assignmentId, workerId, assignedAt, completedAt, closedAt);
        }

        /// <summary> Initializes a new instance of RouterJobNote. </summary>
        /// <param name="message"> The message contained in the note. </param>
        /// <param name="addedAt"> The time at which the note was added in UTC. If not provided, will default to the current time. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobNote"/> instance for mocking. </returns>
        public static RouterJobNote RouterJobNote(string message = null, DateTimeOffset? addedAt = null)
        {
            return new RouterJobNote(message, addedAt);
        }

        /// <summary> Initializes a new instance of JobMatchingMode. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of JobMatchingMode. </param>
        /// <returns> A new <see cref="JobRouter.JobMatchingMode"/> instance for mocking. </returns>
        public static JobMatchingMode JobMatchingMode(string kind = null)
        {
            return new UnknownJobMatchingMode(kind);
        }

        /// <summary> Initializes a new instance of UnassignJobResult. </summary>
        /// <param name="jobId"> The Id of the job unassigned. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new UnassignJobResult(jobId, unassignmentCount);
        }

        /// <summary> Initializes a new instance of AcceptJobOfferResult. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/>, <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return new AcceptJobOfferResult(assignmentId, jobId, workerId);
        }

        /// <summary> Initializes a new instance of RouterChannel. </summary>
        /// <param name="channelId"> Id of the channel. </param>
        /// <param name="capacityCostPerJob"> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </param>
        /// <param name="maxNumberOfJobs"> The maximum number of jobs that can be supported concurrently for this channel. </param>
        /// <returns> A new <see cref="JobRouter.RouterChannel"/> instance for mocking. </returns>
        public static RouterChannel RouterChannel(string channelId = null, int capacityCostPerJob = default, int? maxNumberOfJobs = null)
        {
            return new RouterChannel(channelId, capacityCostPerJob, maxNumberOfJobs);
        }

        /// <summary> Initializes a new instance of RouterJobOffer. </summary>
        /// <param name="offerId"> The Id of the offer. </param>
        /// <param name="jobId"> The Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> The time the offer was created in UTC. </param>
        /// <param name="expiresAt"> The time that the offer will expire in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(offerId, jobId, capacityCost, offeredAt, expiresAt);
        }

        /// <summary> Initializes a new instance of RouterWorkerAssignment. </summary>
        /// <param name="assignmentId"> The Id of the assignment. </param>
        /// <param name="jobId"> The Id of the Job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> or <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt);
        }

        /// <summary> Initializes a new instance of BestWorkerMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for the job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <param name="scoringRule">
        /// Define a scoring rule to use, when calculating a score to determine the best worker. If not set, will use a default scoring formula that uses the number of job labels that the worker labels match, as well as the number of label selectors the worker labels match and/or exceed using a logistic function (https://en.wikipedia.org/wiki/Logistic_function).
        /// Please note <see cref="JobRouter.RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="scoringRuleOptions"> Options to configure 'scoringRule'. If not set, default values are used. </param>
        /// <returns> A new <see cref="JobRouter.BestWorkerMode"/> instance for mocking. </returns>
        public static BestWorkerMode BestWorkerMode(int minConcurrentOffers = default, int maxConcurrentOffers = default, bool? bypassSelectors = null, RouterRule scoringRule = null, ScoringRuleOptions scoringRuleOptions = null)
        {
            return new BestWorkerMode(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, "best-worker", scoringRule, scoringRuleOptions);
        }

        /// <summary> Initializes a new instance of DirectMapRouterRule. </summary>
        /// <returns> A new <see cref="JobRouter.DirectMapRouterRule"/> instance for mocking. </returns>
        public static DirectMapRouterRule DirectMapRouterRule()
        {
            return new DirectMapRouterRule("direct-map-rule");
        }

        /// <summary> Initializes a new instance of ExpressionRouterRule. </summary>
        /// <param name="language"> The expression language to compile to and execute. </param>
        /// <param name="expression"> The string containing the expression to evaluate. Should contain return statement with calculated values. </param>
        /// <returns> A new <see cref="JobRouter.ExpressionRouterRule"/> instance for mocking. </returns>
        public static ExpressionRouterRule ExpressionRouterRule(string language = null, string expression = null)
        {
            return new ExpressionRouterRule("expression-rule", language, expression);
        }

        /// <summary> Initializes a new instance of FunctionRouterRule. </summary>
        /// <param name="functionUri"> URL for Azure Function. </param>
        /// <param name="credential"> Credentials used to access Azure function rule. </param>
        /// <returns> A new <see cref="JobRouter.FunctionRouterRule"/> instance for mocking. </returns>
        public static FunctionRouterRule FunctionRouterRule(Uri functionUri = null, FunctionRouterRuleCredential credential = null)
        {
            return new FunctionRouterRule("azure-function-rule", functionUri, credential);
        }

        /// <summary> Initializes a new instance of WebhookRouterRule. </summary>
        /// <param name="authorizationServerUri"> Uri for Authorization Server. </param>
        /// <param name="clientCredential"> OAuth2.0 Credentials used to Contoso's Authorization server. Reference: https://www.oauth.com/oauth2-servers/access-tokens/client-credentials/. </param>
        /// <param name="webhookUri"> Uri for Contoso's Web Server. </param>
        /// <returns> A new <see cref="JobRouter.WebhookRouterRule"/> instance for mocking. </returns>
        public static WebhookRouterRule WebhookRouterRule(Uri authorizationServerUri = null, OAuth2WebhookClientCredential clientCredential = null, Uri webhookUri = null)
        {
            return new WebhookRouterRule("webhook-rule", authorizationServerUri, clientCredential, webhookUri);
        }

        /// <summary> Initializes a new instance of LongestIdleMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for the job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <returns> A new <see cref="JobRouter.LongestIdleMode"/> instance for mocking. </returns>
        public static LongestIdleMode LongestIdleMode(int minConcurrentOffers = default, int maxConcurrentOffers = default, bool? bypassSelectors = null)
        {
            return new LongestIdleMode(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, "longest-idle");
        }

        /// <summary> Initializes a new instance of RoundRobinMode. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for the job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <returns> A new <see cref="JobRouter.RoundRobinMode"/> instance for mocking. </returns>
        public static RoundRobinMode RoundRobinMode(int minConcurrentOffers = default, int maxConcurrentOffers = default, bool? bypassSelectors = null)
        {
            return new RoundRobinMode(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, "round-robin");
        }

        /// <summary> Initializes a new instance of ConditionalQueueSelectorAttachment. </summary>
        /// <param name="condition">
        /// The condition that must be true for the queue selectors to be attached
        /// Please note <see cref="JobRouter.RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="queueSelectors"> The queue selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalQueueSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalQueueSelectorAttachment ConditionalQueueSelectorAttachment(RouterRule condition = null, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new ConditionalQueueSelectorAttachment("conditional", condition, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of PassThroughQueueSelectorAttachment. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <returns> A new <see cref="JobRouter.PassThroughQueueSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughQueueSelectorAttachment PassThroughQueueSelectorAttachment(string key = null, LabelOperator labelOperator = default)
        {
            return new PassThroughQueueSelectorAttachment("pass-through", key, labelOperator);
        }

        /// <summary> Initializes a new instance of RuleEngineQueueSelectorAttachment. </summary>
        /// <param name="rule">
        /// A RouterRule that resolves a collection of queue selectors to attach
        /// Please note <see cref="JobRouter.RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineQueueSelectorAttachment RuleEngineQueueSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineQueueSelectorAttachment("rule-engine", rule);
        }

        /// <summary> Initializes a new instance of StaticQueueSelectorAttachment. </summary>
        /// <param name="queueSelector"> The queue selector to attach. </param>
        /// <returns> A new <see cref="JobRouter.StaticQueueSelectorAttachment"/> instance for mocking. </returns>
        public static StaticQueueSelectorAttachment StaticQueueSelectorAttachment(RouterQueueSelector queueSelector = null)
        {
            return new StaticQueueSelectorAttachment("static", queueSelector);
        }

        /// <summary> Initializes a new instance of WeightedAllocationQueueSelectorAttachment. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationQueueSelectorAttachment WeightedAllocationQueueSelectorAttachment(IEnumerable<QueueWeightedAllocation> allocations = null)
        {
            allocations ??= new List<QueueWeightedAllocation>();

            return new WeightedAllocationQueueSelectorAttachment("weighted-allocation-queue-selector", allocations?.ToList());
        }

        /// <summary> Initializes a new instance of ConditionalWorkerSelectorAttachment. </summary>
        /// <param name="condition">
        /// The condition that must be true for the worker selectors to be attached
        /// Please note <see cref="JobRouter.RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalWorkerSelectorAttachment ConditionalWorkerSelectorAttachment(RouterRule condition = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ConditionalWorkerSelectorAttachment("conditional", condition, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of RuleEngineWorkerSelectorAttachment. </summary>
        /// <param name="rule">
        /// A RouterRule that resolves a collection of worker selectors to attach
        /// Please note <see cref="JobRouter.RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.DirectMapRouterRule"/>, <see cref="JobRouter.ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineWorkerSelectorAttachment RuleEngineWorkerSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineWorkerSelectorAttachment("rule-engine", rule);
        }

        /// <summary> Initializes a new instance of StaticWorkerSelectorAttachment. </summary>
        /// <param name="workerSelector"> The worker selector to attach. </param>
        /// <returns> A new <see cref="JobRouter.StaticWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static StaticWorkerSelectorAttachment StaticWorkerSelectorAttachment(RouterWorkerSelector workerSelector = null)
        {
            return new StaticWorkerSelectorAttachment("static", workerSelector);
        }

        /// <summary> Initializes a new instance of WeightedAllocationWorkerSelectorAttachment. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationWorkerSelectorAttachment WeightedAllocationWorkerSelectorAttachment(IEnumerable<WorkerWeightedAllocation> allocations = null)
        {
            allocations ??= new List<WorkerWeightedAllocation>();

            return new WeightedAllocationWorkerSelectorAttachment("weighted-allocation-worker-selector", allocations?.ToList());
        }

        /// <summary> Initializes a new instance of QueueLengthExceptionTrigger. </summary>
        /// <param name="threshold"> Threshold of number of jobs ahead in the queue to for this trigger to fire. </param>
        /// <returns> A new <see cref="JobRouter.QueueLengthExceptionTrigger"/> instance for mocking. </returns>
        public static QueueLengthExceptionTrigger QueueLengthExceptionTrigger(int threshold = default)
        {
            return new QueueLengthExceptionTrigger("queue-length", threshold);
        }

        /// <summary> Initializes a new instance of CancelExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="note"> A note that will be appended to the jobs' Notes collection with the current timestamp. </param>
        /// <param name="dispositionCode"> Indicates the outcome of the job, populate this field with your own custom values. </param>
        /// <returns> A new <see cref="JobRouter.CancelExceptionAction"/> instance for mocking. </returns>
        public static CancelExceptionAction CancelExceptionAction(string id = null, string note = null, string dispositionCode = null)
        {
            return new CancelExceptionAction(id, "cancel", note, dispositionCode);
        }

        /// <summary> Initializes a new instance of ManualReclassifyExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="queueId"> Updated QueueId. </param>
        /// <param name="priority"> Updated Priority. </param>
        /// <param name="workerSelectors"> Updated WorkerSelectors. </param>
        /// <returns> A new <see cref="JobRouter.ManualReclassifyExceptionAction"/> instance for mocking. </returns>
        public static ManualReclassifyExceptionAction ManualReclassifyExceptionAction(string id = null, string queueId = null, int? priority = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ManualReclassifyExceptionAction(id, "manual-reclassify", queueId, priority, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of ScheduleAndSuspendMode. </summary>
        /// <param name="scheduleAt"> Scheduled time. </param>
        /// <returns> A new <see cref="JobRouter.ScheduleAndSuspendMode"/> instance for mocking. </returns>
        public static ScheduleAndSuspendMode ScheduleAndSuspendMode(DateTimeOffset scheduleAt = default)
        {
            return new ScheduleAndSuspendMode("schedule-and-suspend", scheduleAt);
        }

        /// <summary> Initializes a new instance of QueueAndMatchMode. </summary>
        /// <returns> A new <see cref="JobRouter.QueueAndMatchMode"/> instance for mocking. </returns>
        public static QueueAndMatchMode QueueAndMatchMode()
        {
            return new QueueAndMatchMode("queue-and-match");
        }

        /// <summary> Initializes a new instance of SuspendMode. </summary>
        /// <returns> A new <see cref="JobRouter.SuspendMode"/> instance for mocking. </returns>
        public static SuspendMode SuspendMode()
        {
            return new SuspendMode("suspend");
        }
    }
}
