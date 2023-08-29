// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiIssueAttachmentResource" /> and their operations.
    /// Each <see cref="ApiIssueAttachmentResource" /> in the collection will belong to the same instance of <see cref="ApiIssueResource" />.
    /// To get an <see cref="ApiIssueAttachmentCollection" /> instance call the GetApiIssueAttachments method from an instance of <see cref="ApiIssueResource" />.
    /// </summary>
    public partial class ApiIssueAttachmentCollection : ArmCollection, IEnumerable<ApiIssueAttachmentResource>, IAsyncEnumerable<ApiIssueAttachmentResource>
    {
        private readonly ClientDiagnostics _apiIssueAttachmentClientDiagnostics;
        private readonly ApiIssueAttachmentRestOperations _apiIssueAttachmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiIssueAttachmentCollection"/> class for mocking. </summary>
        protected ApiIssueAttachmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiIssueAttachmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiIssueAttachmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiIssueAttachmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiIssueAttachmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiIssueAttachmentResource.ResourceType, out string apiIssueAttachmentApiVersion);
            _apiIssueAttachmentRestClient = new ApiIssueAttachmentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiIssueAttachmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiIssueResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiIssueResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Attachment for the Issue in an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiIssueAttachmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string attachmentId, ApiIssueAttachmentData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiIssueAttachmentClientDiagnostics.CreateScope("ApiIssueAttachmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiIssueAttachmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, attachmentId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiIssueAttachmentResource>(Response.FromValue(new ApiIssueAttachmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new Attachment for the Issue in an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiIssueAttachmentResource> CreateOrUpdate(WaitUntil waitUntil, string attachmentId, ApiIssueAttachmentData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiIssueAttachmentClientDiagnostics.CreateScope("ApiIssueAttachmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiIssueAttachmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, attachmentId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiIssueAttachmentResource>(Response.FromValue(new ApiIssueAttachmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the issue Attachment for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> is null. </exception>
        public virtual async Task<Response<ApiIssueAttachmentResource>> GetAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = _apiIssueAttachmentClientDiagnostics.CreateScope("ApiIssueAttachmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiIssueAttachmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, attachmentId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiIssueAttachmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the issue Attachment for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> is null. </exception>
        public virtual Response<ApiIssueAttachmentResource> Get(string attachmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = _apiIssueAttachmentClientDiagnostics.CreateScope("ApiIssueAttachmentCollection.Get");
            scope.Start();
            try
            {
                var response = _apiIssueAttachmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, attachmentId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiIssueAttachmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all attachments for the Issue associated with the specified API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiIssueAttachmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiIssueAttachmentResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiIssueAttachmentRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiIssueAttachmentRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiIssueAttachmentResource(Client, ApiIssueAttachmentData.DeserializeApiIssueAttachmentData(e)), _apiIssueAttachmentClientDiagnostics, Pipeline, "ApiIssueAttachmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all attachments for the Issue associated with the specified API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiIssueAttachmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiIssueAttachmentResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiIssueAttachmentRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiIssueAttachmentRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiIssueAttachmentResource(Client, ApiIssueAttachmentData.DeserializeApiIssueAttachmentData(e)), _apiIssueAttachmentClientDiagnostics, Pipeline, "ApiIssueAttachmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string attachmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = _apiIssueAttachmentClientDiagnostics.CreateScope("ApiIssueAttachmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiIssueAttachmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, attachmentId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}/attachments/{attachmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssueAttachment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="attachmentId"> Attachment identifier within an Issue. Must be unique in the current Issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="attachmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="attachmentId"/> is null. </exception>
        public virtual Response<bool> Exists(string attachmentId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(attachmentId, nameof(attachmentId));

            using var scope = _apiIssueAttachmentClientDiagnostics.CreateScope("ApiIssueAttachmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiIssueAttachmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, attachmentId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiIssueAttachmentResource> IEnumerable<ApiIssueAttachmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiIssueAttachmentResource> IAsyncEnumerable<ApiIssueAttachmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
