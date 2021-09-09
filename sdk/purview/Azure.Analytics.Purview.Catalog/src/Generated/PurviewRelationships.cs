// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    /// <summary> The PurviewRelationships service client. </summary>
    public partial class PurviewRelationships
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of PurviewRelationships for mocking. </summary>
        protected PurviewRelationships()
        {
        }

        /// <summary> Create a new relationship between entities. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Create");
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

        /// <summary> Create a new relationship between entities. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Create(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Create");
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

        /// <summary> Create Request for <see cref="Create"/> and <see cref="CreateAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCreateRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/atlas/v2/relationship", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Update an existing relationship between entities. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> UpdateAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateUpdateRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Update");
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

        /// <summary> Update an existing relationship between entities. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;,
        ///   typeName: string,
        ///   lastModifiedTS: string,
        ///   createTime: number,
        ///   createdBy: string,
        ///   end1: {
        ///     guid: string,
        ///     typeName: string,
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///   },
        ///   end2: AtlasObjectId,
        ///   guid: string,
        ///   homeId: string,
        ///   label: string,
        ///   provenanceType: number,
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///   updateTime: number,
        ///   updatedBy: string,
        ///   version: number
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Update(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateUpdateRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Update");
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

        /// <summary> Create Request for <see cref="Update"/> and <see cref="UpdateAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateUpdateRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/atlas/v2/relationship", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get relationship information between entities by its GUID. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntityHeader&gt;,
        ///   relationship: {
        ///     attributes: Dictionary&lt;string, AnyObject&gt;,
        ///     typeName: string,
        ///     lastModifiedTS: string,
        ///     createTime: number,
        ///     createdBy: string,
        ///     end1: {
        ///       guid: string,
        ///       typeName: string,
        ///       uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///     },
        ///     end2: AtlasObjectId,
        ///     guid: string,
        ///     homeId: string,
        ///     label: string,
        ///     provenanceType: number,
        ///     status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///     updateTime: number,
        ///     updatedBy: string,
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="extendedInfo"> Limits whether includes extended information. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAsync(string guid, bool? extendedInfo = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetRequest(guid, extendedInfo, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Get");
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

        /// <summary> Get relationship information between entities by its GUID. </summary>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntityHeader&gt;,
        ///   relationship: {
        ///     attributes: Dictionary&lt;string, AnyObject&gt;,
        ///     typeName: string,
        ///     lastModifiedTS: string,
        ///     createTime: number,
        ///     createdBy: string,
        ///     end1: {
        ///       guid: string,
        ///       typeName: string,
        ///       uniqueAttributes: Dictionary&lt;string, AnyObject&gt;
        ///     },
        ///     end2: AtlasObjectId,
        ///     guid: string,
        ///     homeId: string,
        ///     label: string,
        ///     provenanceType: number,
        ///     status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///     updateTime: number,
        ///     updatedBy: string,
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="extendedInfo"> Limits whether includes extended information. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Get(string guid, bool? extendedInfo = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetRequest(guid, extendedInfo, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Get");
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

        /// <summary> Create Request for <see cref="Get"/> and <see cref="GetAsync"/> operations. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="extendedInfo"> Limits whether includes extended information. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetRequest(string guid, bool? extendedInfo = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/atlas/v2/relationship/guid/", false);
            uri.AppendPath(guid, true);
            if (extendedInfo != null)
            {
                uri.AppendQuery("extendedInfo", extendedInfo.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete a relationship between entities by its GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(string guid, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDeleteRequest(guid, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Delete");
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

        /// <summary> Delete a relationship between entities by its GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Delete(string guid, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDeleteRequest(guid, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewRelationships.Delete");
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

        /// <summary> Create Request for <see cref="Delete"/> and <see cref="DeleteAsync"/> operations. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateDeleteRequest(string guid, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/atlas/v2/relationship/guid/", false);
            uri.AppendPath(guid, true);
            request.Uri = uri;
            return message;
        }
    }
}
