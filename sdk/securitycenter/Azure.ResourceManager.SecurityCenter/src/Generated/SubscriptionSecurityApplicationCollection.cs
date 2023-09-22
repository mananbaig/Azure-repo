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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionSecurityApplicationResource" /> and their operations.
    /// Each <see cref="SubscriptionSecurityApplicationResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionSecurityApplicationCollection" /> instance call the GetSubscriptionSecurityApplications method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionSecurityApplicationCollection : ArmCollection, IEnumerable<SubscriptionSecurityApplicationResource>, IAsyncEnumerable<SubscriptionSecurityApplicationResource>
    {
        private readonly ClientDiagnostics _subscriptionSecurityApplicationApplicationClientDiagnostics;
        private readonly ApplicationRestOperations _subscriptionSecurityApplicationApplicationRestClient;
        private readonly ClientDiagnostics _subscriptionSecurityApplicationApplicationsClientDiagnostics;
        private readonly ApplicationsRestOperations _subscriptionSecurityApplicationApplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSecurityApplicationCollection"/> class for mocking. </summary>
        protected SubscriptionSecurityApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSecurityApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionSecurityApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionSecurityApplicationApplicationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SubscriptionSecurityApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionSecurityApplicationResource.ResourceType, out string subscriptionSecurityApplicationApplicationApiVersion);
            _subscriptionSecurityApplicationApplicationRestClient = new ApplicationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionSecurityApplicationApplicationApiVersion);
            _subscriptionSecurityApplicationApplicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SubscriptionSecurityApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionSecurityApplicationResource.ResourceType, out string subscriptionSecurityApplicationApplicationsApiVersion);
            _subscriptionSecurityApplicationApplicationsRestClient = new ApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionSecurityApplicationApplicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or update a security application on the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="data"> Application over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionSecurityApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationId, SecurityApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityApplicationApplicationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, applicationId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SubscriptionSecurityApplicationResource>(Response.FromValue(new SubscriptionSecurityApplicationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or update a security application on the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="data"> Application over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionSecurityApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string applicationId, SecurityApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityApplicationApplicationRestClient.CreateOrUpdate(Id.SubscriptionId, applicationId, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SubscriptionSecurityApplicationResource>(Response.FromValue(new SubscriptionSecurityApplicationResource(Client, response), response.GetRawResponse()));
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
        /// Get a specific application for the requested scope by applicationId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual async Task<Response<SubscriptionSecurityApplicationResource>> GetAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, applicationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific application for the requested scope by applicationId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual Response<SubscriptionSecurityApplicationResource> Get(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityApplicationApplicationRestClient.Get(Id.SubscriptionId, applicationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all relevant applications over a subscription level scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionSecurityApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionSecurityApplicationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionSecurityApplicationApplicationsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionSecurityApplicationApplicationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionSecurityApplicationResource(Client, SecurityApplicationData.DeserializeSecurityApplicationData(e)), _subscriptionSecurityApplicationApplicationsClientDiagnostics, Pipeline, "SubscriptionSecurityApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all relevant applications over a subscription level scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionSecurityApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionSecurityApplicationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionSecurityApplicationApplicationsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionSecurityApplicationApplicationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionSecurityApplicationResource(Client, SecurityApplicationData.DeserializeSecurityApplicationData(e)), _subscriptionSecurityApplicationApplicationsClientDiagnostics, Pipeline, "SubscriptionSecurityApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, applicationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityApplicationApplicationRestClient.Get(Id.SubscriptionId, applicationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual async Task<NullableResponse<SubscriptionSecurityApplicationResource>> GetIfExistsAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionSecurityApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, applicationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionSecurityApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual NullableResponse<SubscriptionSecurityApplicationResource> GetIfExists(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _subscriptionSecurityApplicationApplicationClientDiagnostics.CreateScope("SubscriptionSecurityApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionSecurityApplicationApplicationRestClient.Get(Id.SubscriptionId, applicationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionSecurityApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSecurityApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionSecurityApplicationResource> IEnumerable<SubscriptionSecurityApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionSecurityApplicationResource> IAsyncEnumerable<SubscriptionSecurityApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
