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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="DataShareInvitationResource" /> and their operations.
    /// Each <see cref="DataShareInvitationResource" /> in the collection will belong to the same instance of <see cref="DataShareResource" />.
    /// To get a <see cref="DataShareInvitationCollection" /> instance call the GetDataShareInvitations method from an instance of <see cref="DataShareResource" />.
    /// </summary>
    public partial class DataShareInvitationCollection : ArmCollection, IEnumerable<DataShareInvitationResource>, IAsyncEnumerable<DataShareInvitationResource>
    {
        private readonly ClientDiagnostics _dataShareInvitationInvitationsClientDiagnostics;
        private readonly InvitationsRestOperations _dataShareInvitationInvitationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataShareInvitationCollection"/> class for mocking. </summary>
        protected DataShareInvitationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareInvitationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataShareInvitationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareInvitationInvitationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", DataShareInvitationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataShareInvitationResource.ResourceType, out string dataShareInvitationInvitationsApiVersion);
            _dataShareInvitationInvitationsRestClient = new InvitationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareInvitationInvitationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataShareResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataShareResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create an invitation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="data"> Invitation details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataShareInvitationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string invitationName, DataShareInvitationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationName, nameof(invitationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareInvitationInvitationsClientDiagnostics.CreateScope("DataShareInvitationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataShareInvitationInvitationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, invitationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<DataShareInvitationResource>(Response.FromValue(new DataShareInvitationResource(Client, response), response.GetRawResponse()));
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
        /// Create an invitation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="data"> Invitation details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataShareInvitationResource> CreateOrUpdate(WaitUntil waitUntil, string invitationName, DataShareInvitationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationName, nameof(invitationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareInvitationInvitationsClientDiagnostics.CreateScope("DataShareInvitationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataShareInvitationInvitationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, invitationName, data, cancellationToken);
                var operation = new DataShareArmOperation<DataShareInvitationResource>(Response.FromValue(new DataShareInvitationResource(Client, response), response.GetRawResponse()));
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
        /// Get an invitation in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        public virtual async Task<Response<DataShareInvitationResource>> GetAsync(string invitationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationName, nameof(invitationName));

            using var scope = _dataShareInvitationInvitationsClientDiagnostics.CreateScope("DataShareInvitationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataShareInvitationInvitationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, invitationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an invitation in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        public virtual Response<DataShareInvitationResource> Get(string invitationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationName, nameof(invitationName));

            using var scope = _dataShareInvitationInvitationsClientDiagnostics.CreateScope("DataShareInvitationCollection.Get");
            scope.Start();
            try
            {
                var response = _dataShareInvitationInvitationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, invitationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List invitations in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_ListByShare</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataShareInvitationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataShareInvitationResource> GetAllAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareInvitationInvitationsRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareInvitationInvitationsRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DataShareInvitationResource(Client, DataShareInvitationData.DeserializeDataShareInvitationData(e)), _dataShareInvitationInvitationsClientDiagnostics, Pipeline, "DataShareInvitationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List invitations in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_ListByShare</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataShareInvitationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataShareInvitationResource> GetAll(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareInvitationInvitationsRestClient.CreateListByShareRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareInvitationInvitationsRestClient.CreateListByShareNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DataShareInvitationResource(Client, DataShareInvitationData.DeserializeDataShareInvitationData(e)), _dataShareInvitationInvitationsClientDiagnostics, Pipeline, "DataShareInvitationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string invitationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationName, nameof(invitationName));

            using var scope = _dataShareInvitationInvitationsClientDiagnostics.CreateScope("DataShareInvitationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataShareInvitationInvitationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, invitationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/invitations/{invitationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Invitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="invitationName"> The name of the invitation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        public virtual Response<bool> Exists(string invitationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationName, nameof(invitationName));

            using var scope = _dataShareInvitationInvitationsClientDiagnostics.CreateScope("DataShareInvitationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataShareInvitationInvitationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, invitationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataShareInvitationResource> IEnumerable<DataShareInvitationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataShareInvitationResource> IAsyncEnumerable<DataShareInvitationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
