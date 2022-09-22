// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dataLakeStoreAccountAccountsClientDiagnostics;
        private AccountsRestOperations _dataLakeStoreAccountAccountsRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataLakeStoreAccountAccountsClientDiagnostics => _dataLakeStoreAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", DataLakeStoreAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations DataLakeStoreAccountAccountsRestClient => _dataLakeStoreAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataLakeStoreAccountResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataLakeStore", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The response includes a link to the next page of results, if any.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/accounts
        /// Operation Id: Accounts_List
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="top"> The number of items to return. Optional. </param>
        /// <param name="skip"> The number of items to skip over before returning elements. Optional. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional. </param>
        /// <param name="orderby"> OrderBy clause. One or more comma-separated expressions with an optional &quot;asc&quot; (the default) or &quot;desc&quot; depending on the order you&apos;d like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional. </param>
        /// <param name="count"> The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeStoreAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeStoreAccountBasic> GetAccountsAsync(string filter = null, int? top = null, int? skip = null, string select = null, string orderby = null, bool? count = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DataLakeStoreAccountBasic>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataLakeStoreAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAccounts");
                scope.Start();
                try
                {
                    var response = await DataLakeStoreAccountAccountsRestClient.ListAsync(Id.SubscriptionId, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataLakeStoreAccountBasic>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DataLakeStoreAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAccounts");
                scope.Start();
                try
                {
                    var response = await DataLakeStoreAccountAccountsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the Data Lake Store accounts within the subscription. The response includes a link to the next page of results, if any.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/accounts
        /// Operation Id: Accounts_List
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="top"> The number of items to return. Optional. </param>
        /// <param name="skip"> The number of items to skip over before returning elements. Optional. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. Categories?$select=CategoryName,Description. Optional. </param>
        /// <param name="orderby"> OrderBy clause. One or more comma-separated expressions with an optional &quot;asc&quot; (the default) or &quot;desc&quot; depending on the order you&apos;d like the values sorted, e.g. Categories?$orderby=CategoryName desc. Optional. </param>
        /// <param name="count"> The Boolean value of true or false to request a count of the matching resources included with the resources in the response, e.g. Categories?$count=true. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeStoreAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeStoreAccountBasic> GetAccounts(string filter = null, int? top = null, int? skip = null, string select = null, string orderby = null, bool? count = null, CancellationToken cancellationToken = default)
        {
            Page<DataLakeStoreAccountBasic> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataLakeStoreAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAccounts");
                scope.Start();
                try
                {
                    var response = DataLakeStoreAccountAccountsRestClient.List(Id.SubscriptionId, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataLakeStoreAccountBasic> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DataLakeStoreAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAccounts");
                scope.Start();
                try
                {
                    var response = DataLakeStoreAccountAccountsRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, top, skip, select, orderby, count, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Checks whether the specified account name is available or taken.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/checkNameAvailability
        /// Operation Id: Accounts_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Store account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NameAvailabilityInformation>> CheckNameAvailabilityAccountAsync(AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DataLakeStoreAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityAccount");
            scope.Start();
            try
            {
                var response = await DataLakeStoreAccountAccountsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/checkNameAvailability
        /// Operation Id: Accounts_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Store account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NameAvailabilityInformation> CheckNameAvailabilityAccount(AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DataLakeStoreAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityAccount");
            scope.Start();
            try
            {
                var response = DataLakeStoreAccountAccountsRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Store specified by resource location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/capability
        /// Operation Id: Locations_GetCapability
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CapabilityInformation>> GetCapabilityLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCapabilityLocation");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.GetCapabilityAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Store specified by resource location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/capability
        /// Operation Id: Locations_GetCapability
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CapabilityInformation> GetCapabilityLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCapabilityLocation");
            scope.Start();
            try
            {
                var response = LocationsRestClient.GetCapability(Id.SubscriptionId, location, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/usages
        /// Operation Id: Locations_GetUsage
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeStoreUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeStoreUsage> GetUsageLocationsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            async Task<Page<DataLakeStoreUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetUsageLocations");
                scope.Start();
                try
                {
                    var response = await LocationsRestClient.GetUsageAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets the current usage count and the limit for the resources of the location under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataLakeStore/locations/{location}/usages
        /// Operation Id: Locations_GetUsage
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeStoreUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeStoreUsage> GetUsageLocations(AzureLocation location, CancellationToken cancellationToken = default)
        {
            Page<DataLakeStoreUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetUsageLocations");
                scope.Start();
                try
                {
                    var response = LocationsRestClient.GetUsage(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
