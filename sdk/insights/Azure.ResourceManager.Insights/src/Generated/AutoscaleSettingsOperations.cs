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
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The AutoscaleSettings service client. </summary>
    public partial class AutoscaleSettingsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AutoscaleSettingsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of AutoscaleSettingsOperations for mocking. </summary>
        protected AutoscaleSettingsOperations()
        {
        }
        /// <summary> Initializes a new instance of AutoscaleSettingsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal AutoscaleSettingsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new AutoscaleSettingsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates or updates an autoscale setting. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutoscaleSettingResource>> CreateOrUpdateAsync(string resourceGroupName, string autoscaleSettingName, AutoscaleSettingResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, autoscaleSettingName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an autoscale setting. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutoscaleSettingResource> CreateOrUpdate(string resourceGroupName, string autoscaleSettingName, AutoscaleSettingResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, autoscaleSettingName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes and autoscale setting. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, autoscaleSettingName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes and autoscale setting. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, autoscaleSettingName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an autoscale setting. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutoscaleSettingResource>> GetAsync(string resourceGroupName, string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, autoscaleSettingName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an autoscale setting. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutoscaleSettingResource> Get(string resourceGroupName, string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, autoscaleSettingName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing AutoscaleSettingsResource. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="autoscaleSettingResource"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutoscaleSettingResource>> UpdateAsync(string resourceGroupName, string autoscaleSettingName, AutoscaleSettingResourcePatch autoscaleSettingResource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, autoscaleSettingName, autoscaleSettingResource, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing AutoscaleSettingsResource. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="autoscaleSettingResource"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutoscaleSettingResource> Update(string resourceGroupName, string autoscaleSettingName, AutoscaleSettingResourcePatch autoscaleSettingResource, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, autoscaleSettingName, autoscaleSettingResource, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the autoscale settings for a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<AutoscaleSettingResource> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<AutoscaleSettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AutoscaleSettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the autoscale settings for a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<AutoscaleSettingResource> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<AutoscaleSettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AutoscaleSettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Lists the autoscale settings for a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<AutoscaleSettingResource> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AutoscaleSettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AutoscaleSettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the autoscale settings for a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<AutoscaleSettingResource> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<AutoscaleSettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AutoscaleSettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AutoscaleSettingsOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscriptionNextPage(nextLink, cancellationToken);
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
    }
}
