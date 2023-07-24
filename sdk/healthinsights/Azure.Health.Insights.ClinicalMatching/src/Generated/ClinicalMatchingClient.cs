// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Health.Insights.ClinicalMatching
{
    // Data plane generated client.
    /// <summary> The ClinicalMatching service client. </summary>
    public partial class ClinicalMatchingClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ClinicalMatchingClient for mocking. </summary>
        protected ClinicalMatchingClient()
        {
        }

        /// <summary> Initializes a new instance of ClinicalMatchingClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ClinicalMatchingClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new ClinicalMatchingClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ClinicalMatchingClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ClinicalMatchingClient(Uri endpoint, AzureKeyCredential credential, ClinicalMatchingClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ClinicalMatchingClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Create Trial Matcher job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trialMatcherData"> The body of the Trial Matcher request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trialMatcherData"/> is null. </exception>
        /// <remarks> Creates a Trial Matcher job with the given request body. </remarks>
        /// <include file="Docs/ClinicalMatchingClient.xml" path="doc/members/member[@name='MatchTrialsAsync(WaitUntil,TrialMatcherData,CancellationToken)']/*" />
        public virtual async Task<Operation<OperationStatusneverError>> MatchTrialsAsync(WaitUntil waitUntil, TrialMatcherData trialMatcherData, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(trialMatcherData, nameof(trialMatcherData));

            RequestContext context = FromCancellationToken(cancellationToken);
            Operation<BinaryData> response = await MatchTrialsAsync(waitUntil, trialMatcherData.ToRequestContent(), context).ConfigureAwait(false);
            return ProtocolOperationHelpers.Convert(response, OperationStatusneverError.FromResponse, ClientDiagnostics, "ClinicalMatchingClient.MatchTrials");
        }

        /// <summary> Create Trial Matcher job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trialMatcherData"> The body of the Trial Matcher request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trialMatcherData"/> is null. </exception>
        /// <remarks> Creates a Trial Matcher job with the given request body. </remarks>
        /// <include file="Docs/ClinicalMatchingClient.xml" path="doc/members/member[@name='MatchTrials(WaitUntil,TrialMatcherData,CancellationToken)']/*" />
        public virtual Operation<OperationStatusneverError> MatchTrials(WaitUntil waitUntil, TrialMatcherData trialMatcherData, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(trialMatcherData, nameof(trialMatcherData));

            RequestContext context = FromCancellationToken(cancellationToken);
            Operation<BinaryData> response = MatchTrials(waitUntil, trialMatcherData.ToRequestContent(), context);
            return ProtocolOperationHelpers.Convert(response, OperationStatusneverError.FromResponse, ClientDiagnostics, "ClinicalMatchingClient.MatchTrials");
        }

        /// <summary>
        /// [Protocol Method] Create Trial Matcher job
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="MatchTrialsAsync(WaitUntil,TrialMatcherData,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/ClinicalMatchingClient.xml" path="doc/members/member[@name='MatchTrialsAsync(WaitUntil,RequestContent,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> MatchTrialsAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ClinicalMatchingClient.MatchTrials");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMatchTrialsRequest(content, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "ClinicalMatchingClient.MatchTrials", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create Trial Matcher job
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="MatchTrials(WaitUntil,TrialMatcherData,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/ClinicalMatchingClient.xml" path="doc/members/member[@name='MatchTrials(WaitUntil,RequestContent,RequestContext)']/*" />
        public virtual Operation<BinaryData> MatchTrials(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ClinicalMatchingClient.MatchTrials");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMatchTrialsRequest(content, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "ClinicalMatchingClient.MatchTrials", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateMatchTrialsRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/healthinsights", false);
            uri.AppendPath("/trialmatcher/jobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200202;
        private static ResponseClassifier ResponseClassifier200202 => _responseClassifier200202 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 202 });
    }
}
