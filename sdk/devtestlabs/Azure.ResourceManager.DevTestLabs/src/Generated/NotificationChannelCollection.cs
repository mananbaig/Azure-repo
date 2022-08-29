// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="NotificationChannelResource" /> and their operations.
    /// Each <see cref="NotificationChannelResource" /> in the collection will belong to the same instance of <see cref="LabResource" />.
    /// To get a <see cref="NotificationChannelCollection" /> instance call the GetNotificationChannels method from an instance of <see cref="LabResource" />.
    /// </summary>
    public partial class NotificationChannelCollection : ArmCollection, IEnumerable<NotificationChannelResource>, IAsyncEnumerable<NotificationChannelResource>
    {
        private readonly ClientDiagnostics _notificationChannelClientDiagnostics;
        private readonly NotificationChannelsRestOperations _notificationChannelRestClient;

        /// <summary> Initializes a new instance of the <see cref="NotificationChannelCollection"/> class for mocking. </summary>
        protected NotificationChannelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NotificationChannelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NotificationChannelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _notificationChannelClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", NotificationChannelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NotificationChannelResource.ResourceType, out string notificationChannelApiVersion);
            _notificationChannelRestClient = new NotificationChannelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationChannelApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing notification channel.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels/{name}
        /// Operation Id: NotificationChannels_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the notification channel. </param>
        /// <param name="data"> A notification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NotificationChannelResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, NotificationChannelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _notificationChannelRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<NotificationChannelResource>(Response.FromValue(new NotificationChannelResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace an existing notification channel.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels/{name}
        /// Operation Id: NotificationChannels_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the notification channel. </param>
        /// <param name="data"> A notification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NotificationChannelResource> CreateOrUpdate(WaitUntil waitUntil, string name, NotificationChannelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _notificationChannelRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<NotificationChannelResource>(Response.FromValue(new NotificationChannelResource(Client, response), response.GetRawResponse()));
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
        /// Get notification channel.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels/{name}
        /// Operation Id: NotificationChannels_Get
        /// </summary>
        /// <param name="name"> The name of the notification channel. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=webHookUrl)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<NotificationChannelResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.Get");
            scope.Start();
            try
            {
                var response = await _notificationChannelRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get notification channel.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels/{name}
        /// Operation Id: NotificationChannels_Get
        /// </summary>
        /// <param name="name"> The name of the notification channel. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=webHookUrl)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<NotificationChannelResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.Get");
            scope.Start();
            try
            {
                var response = _notificationChannelRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationChannelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List notification channels in a given lab.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels
        /// Operation Id: NotificationChannels_List
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=webHookUrl)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NotificationChannelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NotificationChannelResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<NotificationChannelResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _notificationChannelRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationChannelResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NotificationChannelResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _notificationChannelRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationChannelResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List notification channels in a given lab.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels
        /// Operation Id: NotificationChannels_List
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=webHookUrl)&apos;. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: &apos;$filter=contains(name,&apos;myName&apos;). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: &apos;$orderby=name desc&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NotificationChannelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NotificationChannelResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Page<NotificationChannelResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _notificationChannelRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationChannelResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NotificationChannelResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _notificationChannelRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, filter, top, orderby, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NotificationChannelResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels/{name}
        /// Operation Id: NotificationChannels_Get
        /// </summary>
        /// <param name="name"> The name of the notification channel. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=webHookUrl)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _notificationChannelRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/notificationchannels/{name}
        /// Operation Id: NotificationChannels_Get
        /// </summary>
        /// <param name="name"> The name of the notification channel. </param>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=webHookUrl)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _notificationChannelClientDiagnostics.CreateScope("NotificationChannelCollection.Exists");
            scope.Start();
            try
            {
                var response = _notificationChannelRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NotificationChannelResource> IEnumerable<NotificationChannelResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NotificationChannelResource> IAsyncEnumerable<NotificationChannelResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
