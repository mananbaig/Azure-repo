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
    // Data plane generated sub-client.
    /// <summary> The Attachments sub-client. </summary>
    public partial class Attachments
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Attachments for mocking. </summary>
        protected Attachments()
        {
        }

        /// <summary> Initializes a new instance of Attachments. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal Attachments(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Gets a specified attachment resource under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party. </param>
        /// <param name="attachmentId"> Id of the attachment. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='GetAttachmentAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> GetAttachmentAsync(string partyId, string attachmentId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.GetAttachment");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAttachmentRequest(partyId, attachmentId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a specified attachment resource under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party. </param>
        /// <param name="attachmentId"> Id of the attachment. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='GetAttachment(string,string,RequestContext)']/*" />
        public virtual Response GetAttachment(string partyId, string attachmentId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.GetAttachment");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAttachmentRequest(partyId, attachmentId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates an attachment resource under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party resource. </param>
        /// <param name="attachmentId"> Id of the attachment resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='CreateOrUpdateAsync(string,string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateAsync(string partyId, string attachmentId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(partyId, attachmentId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates an attachment resource under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party resource. </param>
        /// <param name="attachmentId"> Id of the attachment resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='CreateOrUpdate(string,string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdate(string partyId, string attachmentId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(partyId, attachmentId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a specified attachment resource under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the party. </param>
        /// <param name="attachmentId"> Id of the attachment. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='DeleteAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> DeleteAsync(string partyId, string attachmentId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(partyId, attachmentId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a specified attachment resource under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the party. </param>
        /// <param name="attachmentId"> Id of the attachment. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='Delete(string,string,RequestContext)']/*" />
        public virtual Response Delete(string partyId, string attachmentId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(partyId, attachmentId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Downloads and returns attachment as response for the given input filePath.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party. </param>
        /// <param name="attachmentId"> Id of attachment to be downloaded. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='DownloadAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> DownloadAsync(string partyId, string attachmentId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.Download");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDownloadRequest(partyId, attachmentId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Downloads and returns attachment as response for the given input filePath.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party. </param>
        /// <param name="attachmentId"> Id of attachment to be downloaded. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> or <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='Download(string,string,RequestContext)']/*" />
        public virtual Response Download(string partyId, string attachmentId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = ClientDiagnostics.CreateScope("Attachments.Download");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDownloadRequest(partyId, attachmentId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of attachment resources under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party. </param>
        /// <param name="resourceIds"> Resource Ids of the resource. </param>
        /// <param name="resourceTypes">
        /// Resource Types of the resource.
        /// i.e. Party, Farm, Field, SeasonalField, Boundary, ApplicationData, HarvestData, TillageData, PlantingData, PlantTissueAnalysis.
        /// </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
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
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='GetAttachmentsByPartyIdAsync(string,IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetAttachmentsByPartyIdAsync(string partyId, IEnumerable<string> resourceIds, IEnumerable<string> resourceTypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetAttachmentsByPartyIdRequest(partyId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetAttachmentsByPartyIdNextPageRequest(nextLink, partyId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "Attachments.GetAttachmentsByPartyId", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of attachment resources under a particular party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the associated party. </param>
        /// <param name="resourceIds"> Resource Ids of the resource. </param>
        /// <param name="resourceTypes">
        /// Resource Types of the resource.
        /// i.e. Party, Farm, Field, SeasonalField, Boundary, ApplicationData, HarvestData, TillageData, PlantingData, PlantTissueAnalysis.
        /// </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
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
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/Attachments.xml" path="doc/members/member[@name='GetAttachmentsByPartyId(string,IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetAttachmentsByPartyId(string partyId, IEnumerable<string> resourceIds, IEnumerable<string> resourceTypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetAttachmentsByPartyIdRequest(partyId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetAttachmentsByPartyIdNextPageRequest(nextLink, partyId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "Attachments.GetAttachmentsByPartyId", "value", "nextLink", context);
        }

        internal HttpMessage CreateGetAttachmentsByPartyIdRequest(string partyId, IEnumerable<string> resourceIds, IEnumerable<string> resourceTypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendPath("/attachments", false);
            if (resourceIds != null && Optional.IsCollectionDefined(resourceIds))
            {
                foreach (var param in resourceIds)
                {
                    uri.AppendQuery("resourceIds", param, true);
                }
            }
            if (resourceTypes != null && Optional.IsCollectionDefined(resourceTypes))
            {
                foreach (var param in resourceTypes)
                {
                    uri.AppendQuery("resourceTypes", param, true);
                }
            }
            if (ids != null && Optional.IsCollectionDefined(ids))
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null && Optional.IsCollectionDefined(names))
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null && Optional.IsCollectionDefined(propertyFilters))
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null && Optional.IsCollectionDefined(statuses))
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
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
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAttachmentRequest(string partyId, string attachmentId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string partyId, string attachmentId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "multipart/form-data");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string partyId, string attachmentId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateDownloadRequest(string partyId, string attachmentId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendPath("/file", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, application/octet-stream");
            return message;
        }

        internal HttpMessage CreateGetAttachmentsByPartyIdNextPageRequest(string nextLink, string partyId, IEnumerable<string> resourceIds, IEnumerable<string> resourceTypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
