// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Crops service client. </summary>
    public partial class CropsClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }
        private HttpPipeline _pipeline;
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of CropsClient for mocking. </summary>
        protected CropsClient()
        {
        }

        /// <summary> Initializes a new instance of CropsClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public CropsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new FarmBeatsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Returns a paginated list of crop resources. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       phenotype: string,
        ///       id: string,
        ///       eTag: string,
        ///       status: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format),
        ///       name: string,
        ///       description: string,
        ///       properties: Dictionary&lt;string, AnyObject&gt;
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListAsync(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateListRequest(phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.List");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of crop resources. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       phenotype: string,
        ///       id: string,
        ///       eTag: string,
        ///       status: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format),
        ///       name: string,
        ///       description: string,
        ///       properties: Dictionary&lt;string, AnyObject&gt;
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response List(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateListRequest(phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.List");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private HttpMessage CreateListRequest(IEnumerable<string> phenotypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops", false);
            if (phenotypes != null)
            {
                uri.AppendQueryDelimited("phenotypes", phenotypes, ",", true);
            }
            if (ids != null)
            {
                uri.AppendQueryDelimited("ids", ids, ",", true);
            }
            if (names != null)
            {
                uri.AppendQueryDelimited("names", names, ",", true);
            }
            if (propertyFilters != null)
            {
                uri.AppendQueryDelimited("propertyFilters", propertyFilters, ",", true);
            }
            if (statuses != null)
            {
                uri.AppendQueryDelimited("statuses", statuses, ",", true);
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a specified crop resource. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   phenotype: string,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAsync(string cropId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetRequest(cropId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Get");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specified crop resource. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   phenotype: string,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Get(string cropId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetRequest(cropId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Get");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private HttpMessage CreateGetRequest(string cropId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Creates or updates a crop resource. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   phenotype: string,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   phenotype: string,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(string cropId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateOrUpdateRequest(cropId, content);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a crop resource. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   phenotype: string,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   phenotype: string,
        ///   id: string,
        ///   eTag: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(string cropId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateOrUpdateRequest(cropId, content);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private HttpMessage CreateCreateOrUpdateRequest(string cropId, RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            return message;
        }

        /// <summary> Deletes Crop for given crop id. </summary>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(string cropId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDeleteRequest(cropId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Delete");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 204:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes Crop for given crop id. </summary>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Delete(string cropId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDeleteRequest(cropId);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Delete");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 204:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private HttpMessage CreateDeleteRequest(string cropId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
