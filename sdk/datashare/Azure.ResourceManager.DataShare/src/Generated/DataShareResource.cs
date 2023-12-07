// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A Class representing a DataShare along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataShareResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataShareResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataShareAccountResource"/> using the GetDataShare method.
    /// </summary>
    public partial class DataShareResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataShareResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="shareName"> The shareName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string shareName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataShareSharesClientDiagnostics;
        private readonly SharesRestOperations _dataShareSharesRestClient;
        private readonly DataShareData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataShare/accounts/shares";

        /// <summary> Initializes a new instance of the <see cref="DataShareResource"/> class for mocking. </summary>
        protected DataShareResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataShareResource(ArmClient client, DataShareData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataShareResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareSharesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataShareSharesApiVersion);
            _dataShareSharesRestClient = new SharesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareSharesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataShareData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ShareDataSetResources in the DataShare. </summary>
        /// <returns> An object representing collection of ShareDataSetResources and their operations over a ShareDataSetResource. </returns>
        public virtual ShareDataSetCollection GetShareDataSets()
        {
            return GetCachedClient(client => new ShareDataSetCollection(client, Id));
        }

        /// <summary>
        /// Get a DataSet in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ShareDataSetResource>> GetShareDataSetAsync(string dataSetName, CancellationToken cancellationToken = default)
        {
            return await GetShareDataSets().GetAsync(dataSetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a DataSet in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/dataSets/{dataSetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataSets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataSetName"> The name of the dataSet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataSetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ShareDataSetResource> GetShareDataSet(string dataSetName, CancellationToken cancellationToken = default)
        {
            return GetShareDataSets().Get(dataSetName, cancellationToken);
        }

        /// <summary> Gets a collection of DataShareInvitationResources in the DataShare. </summary>
        /// <returns> An object representing collection of DataShareInvitationResources and their operations over a DataShareInvitationResource. </returns>
        public virtual DataShareInvitationCollection GetDataShareInvitations()
        {
            return GetCachedClient(client => new DataShareInvitationCollection(client, Id));
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
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataShareInvitationResource>> GetDataShareInvitationAsync(string invitationName, CancellationToken cancellationToken = default)
        {
            return await GetDataShareInvitations().GetAsync(invitationName, cancellationToken).ConfigureAwait(false);
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
        /// <exception cref="ArgumentNullException"> <paramref name="invitationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="invitationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataShareInvitationResource> GetDataShareInvitation(string invitationName, CancellationToken cancellationToken = default)
        {
            return GetDataShareInvitations().Get(invitationName, cancellationToken);
        }

        /// <summary> Gets a collection of ProviderShareSubscriptionResources in the DataShare. </summary>
        /// <returns> An object representing collection of ProviderShareSubscriptionResources and their operations over a ProviderShareSubscriptionResource. </returns>
        public virtual ProviderShareSubscriptionCollection GetProviderShareSubscriptions()
        {
            return GetCachedClient(client => new ProviderShareSubscriptionCollection(client, Id));
        }

        /// <summary>
        /// Get share subscription in a provider share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ProviderShareSubscriptionResource>> GetProviderShareSubscriptionAsync(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            return await GetProviderShareSubscriptions().GetAsync(providerShareSubscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get share subscription in a provider share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/providerShareSubscriptions/{providerShareSubscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderShareSubscriptions_GetByShare</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerShareSubscriptionId"> To locate shareSubscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerShareSubscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerShareSubscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ProviderShareSubscriptionResource> GetProviderShareSubscription(string providerShareSubscriptionId, CancellationToken cancellationToken = default)
        {
            return GetProviderShareSubscriptions().Get(providerShareSubscriptionId, cancellationToken);
        }

        /// <summary> Gets a collection of DataShareSynchronizationSettingResources in the DataShare. </summary>
        /// <returns> An object representing collection of DataShareSynchronizationSettingResources and their operations over a DataShareSynchronizationSettingResource. </returns>
        public virtual DataShareSynchronizationSettingCollection GetDataShareSynchronizationSettings()
        {
            return GetCachedClient(client => new DataShareSynchronizationSettingCollection(client, Id));
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataShareSynchronizationSettingResource>> GetDataShareSynchronizationSettingAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            return await GetDataShareSynchronizationSettings().GetAsync(synchronizationSettingName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SynchronizationSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataShareSynchronizationSettingResource> GetDataShareSynchronizationSetting(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            return GetDataShareSynchronizationSettings().Get(synchronizationSettingName, cancellationToken);
        }

        /// <summary>
        /// Get a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataShareResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareResource.Get");
            scope.Start();
            try
            {
                var response = await _dataShareSharesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataShareResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareResource.Get");
            scope.Start();
            try
            {
                var response = _dataShareSharesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<DataShareOperationResult>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataShareSharesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<DataShareOperationResult>(new DataShareOperationResultOperationSource(), _dataShareSharesClientDiagnostics, Pipeline, _dataShareSharesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DataShareOperationResult> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareResource.Delete");
            scope.Start();
            try
            {
                var response = _dataShareSharesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DataShareArmOperation<DataShareOperationResult>(new DataShareOperationResultOperationSource(), _dataShareSharesClientDiagnostics, Pipeline, _dataShareSharesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The share payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataShareResource>> UpdateAsync(WaitUntil waitUntil, DataShareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareResource.Update");
            scope.Start();
            try
            {
                var response = await _dataShareSharesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<DataShareResource>(Response.FromValue(new DataShareResource(Client, response), response.GetRawResponse()));
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
        /// Create a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The share payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataShareResource> Update(WaitUntil waitUntil, DataShareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataShareSharesClientDiagnostics.CreateScope("DataShareResource.Update");
            scope.Start();
            try
            {
                var response = _dataShareSharesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DataShareArmOperation<DataShareResource>(Response.FromValue(new DataShareResource(Client, response), response.GetRawResponse()));
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
        /// List synchronization details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizationDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_ListSynchronizationDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="shareSynchronization"> Share Synchronization payload. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSynchronization"/> is null. </exception>
        /// <returns> An async collection of <see cref="SynchronizationDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynchronizationDetails> GetSynchronizationDetailsAsync(ShareSynchronization shareSynchronization, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(shareSynchronization, nameof(shareSynchronization));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSharesRestClient.CreateListSynchronizationDetailsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSharesRestClient.CreateListSynchronizationDetailsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => SynchronizationDetails.DeserializeSynchronizationDetails(e), _dataShareSharesClientDiagnostics, Pipeline, "DataShareResource.GetSynchronizationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List synchronization details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizationDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_ListSynchronizationDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="shareSynchronization"> Share Synchronization payload. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareSynchronization"/> is null. </exception>
        /// <returns> A collection of <see cref="SynchronizationDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynchronizationDetails> GetSynchronizationDetails(ShareSynchronization shareSynchronization, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(shareSynchronization, nameof(shareSynchronization));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSharesRestClient.CreateListSynchronizationDetailsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSharesRestClient.CreateListSynchronizationDetailsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, shareSynchronization, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => SynchronizationDetails.DeserializeSynchronizationDetails(e), _dataShareSharesClientDiagnostics, Pipeline, "DataShareResource.GetSynchronizationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List synchronizations of a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_ListSynchronizations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ShareSynchronization"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ShareSynchronization> GetSynchronizationsAsync(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSharesRestClient.CreateListSynchronizationsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSharesRestClient.CreateListSynchronizationsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ShareSynchronization.DeserializeShareSynchronization(e), _dataShareSharesClientDiagnostics, Pipeline, "DataShareResource.GetSynchronizations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List synchronizations of a share
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/listSynchronizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Shares_ListSynchronizations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ShareSynchronization"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ShareSynchronization> GetSynchronizations(string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareSharesRestClient.CreateListSynchronizationsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareSharesRestClient.CreateListSynchronizationsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, filter, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ShareSynchronization.DeserializeShareSynchronization(e), _dataShareSharesClientDiagnostics, Pipeline, "DataShareResource.GetSynchronizations", "value", "nextLink", cancellationToken);
        }
    }
}
