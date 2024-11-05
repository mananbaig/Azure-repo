// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Health.Insights.RadiologyInsights
{
    // Data plane generated client.
    /// <summary> The RadiologyInsights service client. </summary>
    public partial class RadiologyInsightsClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://cognitiveservices.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of RadiologyInsightsClient for mocking. </summary>
        protected RadiologyInsightsClient()
        {
        }

        /// <summary> Initializes a new instance of RadiologyInsightsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RadiologyInsightsClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new RadiologyInsightsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of RadiologyInsightsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RadiologyInsightsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new RadiologyInsightsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of RadiologyInsightsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RadiologyInsightsClient(Uri endpoint, AzureKeyCredential credential, RadiologyInsightsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new RadiologyInsightsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Initializes a new instance of RadiologyInsightsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus2.api.cognitive.microsoft.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RadiologyInsightsClient(Uri endpoint, TokenCredential credential, RadiologyInsightsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new RadiologyInsightsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Create Radiology Insights job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The unique ID of the job. </param>
        /// <param name="resource"> The resource instance. </param>
        /// <param name="expand"> Expand the indicated resources into the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="resource"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Creates a Radiology Insights job with the given request body. </remarks>
        /// <include file="Docs/RadiologyInsightsClient.xml" path="doc/members/member[@name='InferRadiologyInsightsAsync(WaitUntil,string,RadiologyInsightsJob,IEnumerable{string},CancellationToken)']/*" />
        public virtual async Task<Operation<RadiologyInsightsInferenceResult>> InferRadiologyInsightsAsync(WaitUntil waitUntil, string id, RadiologyInsightsJob resource, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(resource, nameof(resource));

            using RequestContent content = resource.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Operation<BinaryData> response = await InferRadiologyInsightsAsync(waitUntil, id, content, expand, context).ConfigureAwait(false);
            return ProtocolOperationHelpers.Convert(response, FetchRadiologyInsightsInferenceResultFromRadiologyInsightsJob, ClientDiagnostics, "RadiologyInsightsClient.InferRadiologyInsights");
        }

        /// <summary> Create Radiology Insights job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The unique ID of the job. </param>
        /// <param name="resource"> The resource instance. </param>
        /// <param name="expand"> Expand the indicated resources into the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="resource"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Creates a Radiology Insights job with the given request body. </remarks>
        /// <include file="Docs/RadiologyInsightsClient.xml" path="doc/members/member[@name='InferRadiologyInsights(WaitUntil,string,RadiologyInsightsJob,IEnumerable{string},CancellationToken)']/*" />
        public virtual Operation<RadiologyInsightsInferenceResult> InferRadiologyInsights(WaitUntil waitUntil, string id, RadiologyInsightsJob resource, IEnumerable<string> expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(resource, nameof(resource));

            using RequestContent content = resource.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Operation<BinaryData> response = InferRadiologyInsights(waitUntil, id, content, expand, context);
            return ProtocolOperationHelpers.Convert(response, FetchRadiologyInsightsInferenceResultFromRadiologyInsightsJob, ClientDiagnostics, "RadiologyInsightsClient.InferRadiologyInsights");
        }

        /// <summary>
        /// [Protocol Method] Create Radiology Insights job
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="InferRadiologyInsightsAsync(WaitUntil,string,RadiologyInsightsJob,IEnumerable{string},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The unique ID of the job. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="expand"> Expand the indicated resources into the response. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/RadiologyInsightsClient.xml" path="doc/members/member[@name='InferRadiologyInsightsAsync(WaitUntil,string,RequestContent,IEnumerable{string},RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> InferRadiologyInsightsAsync(WaitUntil waitUntil, string id, RequestContent content, IEnumerable<string> expand = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("RadiologyInsightsClient.InferRadiologyInsights");
            scope.Start();
            try
            {
                using HttpMessage message = CreateInferRadiologyInsightsRequest(id, content, expand, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "RadiologyInsightsClient.InferRadiologyInsights", OperationFinalStateVia.OriginalUri, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create Radiology Insights job
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="InferRadiologyInsights(WaitUntil,string,RadiologyInsightsJob,IEnumerable{string},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The unique ID of the job. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="expand"> Expand the indicated resources into the response. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/RadiologyInsightsClient.xml" path="doc/members/member[@name='InferRadiologyInsights(WaitUntil,string,RequestContent,IEnumerable{string},RequestContext)']/*" />
        public virtual Operation<BinaryData> InferRadiologyInsights(WaitUntil waitUntil, string id, RequestContent content, IEnumerable<string> expand = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("RadiologyInsightsClient.InferRadiologyInsights");
            scope.Start();
            try
            {
                using HttpMessage message = CreateInferRadiologyInsightsRequest(id, content, expand, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "RadiologyInsightsClient.InferRadiologyInsights", OperationFinalStateVia.OriginalUri, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateInferRadiologyInsightsRequest(string id, RequestContent content, IEnumerable<string> expand, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/health-insights", false);
            uri.AppendPath("/radiology-insights/jobs/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null && !(expand is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                foreach (var param in expand)
                {
                    uri.AppendQuery("expand", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
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

        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });

        private RadiologyInsightsInferenceResult FetchRadiologyInsightsInferenceResultFromRadiologyInsightsJob(Response response)
        {
            var resultJsonElement = JsonDocument.Parse(response.Content).RootElement.GetProperty("result");
            return RadiologyInsightsInferenceResult.DeserializeRadiologyInsightsInferenceResult(resultJsonElement);
        }
    }
}
