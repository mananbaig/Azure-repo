// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Scanning
{
    /// <summary> The PurviewClassificationRule service client. </summary>
    public partial class PurviewClassificationRuleClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _classificationRuleName;
        private readonly string _apiVersion;
        internal ClientDiagnostics ClientDiagnostics { get; }
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient for mocking. </summary>
        protected PurviewClassificationRuleClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.scan.purview.azure.com. </param>
        /// <param name="classificationRuleName"> The String to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="classificationRuleName"/>, or <paramref name="credential"/> is null. </exception>
        public PurviewClassificationRuleClient(Uri endpoint, string classificationRuleName, TokenCredential credential, PurviewScanningServiceClientOptions options = null)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(classificationRuleName, nameof(classificationRuleName));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PurviewScanningServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _classificationRuleName = classificationRuleName;
            _apiVersion = options.Version;
        }

        /// <summary> Get a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetPropertiesAsync(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetProperties");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPropertiesRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetProperties(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetProperties");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPropertiesRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or Updates a classification rule. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot; (required)
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or Updates a classification rule. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot; (required)
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: string,
        ///   name: string,
        ///   kind: &quot;System&quot; | &quot;Custom&quot;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Delete(RequestContext context = null)
#pragma warning restore AZC0002
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets Classification Action on a specific classification rule version. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. Allowed values: &quot;Keep&quot; | &quot;Delete&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   scanResultId: OperationResponseScanResultId,
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   status: &quot;Accepted&quot; | &quot;InProgress&quot; | &quot;TransientFailure&quot; | &quot;Succeeded&quot; | &quot;Failed&quot; | &quot;Canceled&quot;,
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorInfo]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> TagVersionAsync(int classificationRuleVersion, string action, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.TagVersion");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTagVersionRequest(classificationRuleVersion, action, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets Classification Action on a specific classification rule version. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. Allowed values: &quot;Keep&quot; | &quot;Delete&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   scanResultId: OperationResponseScanResultId,
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   status: &quot;Accepted&quot; | &quot;InProgress&quot; | &quot;TransientFailure&quot; | &quot;Succeeded&quot; | &quot;Failed&quot; | &quot;Canceled&quot;,
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorInfo]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response TagVersion(int classificationRuleVersion, string action, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.TagVersion");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTagVersionRequest(classificationRuleVersion, action, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the rule versions of a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       name: string,
        ///       kind: &quot;System&quot; | &quot;Custom&quot;
        ///     }
        ///   ],
        ///   nextLink: string,
        ///   count: number
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetVersionsAsync(RequestContext context = null)
#pragma warning restore AZC0002
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "PurviewClassificationRuleClient.GetVersions");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetVersionsRequest(context)
                        : CreateGetVersionsNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Lists the rule versions of a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string,
        ///       name: string,
        ///       kind: &quot;System&quot; | &quot;Custom&quot;
        ///     }
        ///   ],
        ///   nextLink: string,
        ///   count: number
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         message: string,
        ///         target: string,
        ///         details: [ErrorModel]
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetVersions(RequestContext context = null)
#pragma warning restore AZC0002
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "PurviewClassificationRuleClient.GetVersions");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetVersionsRequest(context)
                        : CreateGetVersionsNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetPropertiesRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200201.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200204.Instance;
            return message;
        }

        internal HttpMessage CreateGetVersionsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateTagVersionRequest(int classificationRuleVersion, string action, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(classificationRuleVersion, true);
            uri.AppendPath("/:tag", false);
            uri.AppendQuery("action", action, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier202.Instance;
            return message;
        }

        internal HttpMessage CreateGetVersionsNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200201 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200201();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    201 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    204 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier202 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier202();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    202 => false,
                    _ => true
                };
            }
        }
    }
}
