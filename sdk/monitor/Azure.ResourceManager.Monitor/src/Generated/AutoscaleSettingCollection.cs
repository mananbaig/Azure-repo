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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="AutoscaleSettingResource" /> and their operations.
    /// Each <see cref="AutoscaleSettingResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AutoscaleSettingCollection" /> instance call the GetAutoscaleSettings method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AutoscaleSettingCollection : ArmCollection, IEnumerable<AutoscaleSettingResource>, IAsyncEnumerable<AutoscaleSettingResource>
    {
        private readonly ClientDiagnostics _autoscaleSettingClientDiagnostics;
        private readonly AutoscaleSettingsRestOperations _autoscaleSettingRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutoscaleSettingCollection"/> class for mocking. </summary>
        protected AutoscaleSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutoscaleSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutoscaleSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autoscaleSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", AutoscaleSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutoscaleSettingResource.ResourceType, out string autoscaleSettingApiVersion);
            _autoscaleSettingRestClient = new AutoscaleSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autoscaleSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an autoscale setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutoscaleSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string autoscaleSettingName, AutoscaleSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<AutoscaleSettingResource>(Response.FromValue(new AutoscaleSettingResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an autoscale setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutoscaleSettingResource> CreateOrUpdate(WaitUntil waitUntil, string autoscaleSettingName, AutoscaleSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _autoscaleSettingRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, data, cancellationToken);
                var operation = new MonitorArmOperation<AutoscaleSettingResource>(Response.FromValue(new AutoscaleSettingResource(Client, response), response.GetRawResponse()));
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
        /// Gets an autoscale setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual async Task<Response<AutoscaleSettingResource>> GetAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoscaleSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an autoscale setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual Response<AutoscaleSettingResource> Get(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _autoscaleSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoscaleSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the autoscale settings for a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutoscaleSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutoscaleSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autoscaleSettingRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _autoscaleSettingRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutoscaleSettingResource(Client, AutoscaleSettingData.DeserializeAutoscaleSettingData(e)), _autoscaleSettingClientDiagnostics, Pipeline, "AutoscaleSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the autoscale settings for a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutoscaleSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutoscaleSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autoscaleSettingRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _autoscaleSettingRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutoscaleSettingResource(Client, AutoscaleSettingData.DeserializeAutoscaleSettingData(e)), _autoscaleSettingClientDiagnostics, Pipeline, "AutoscaleSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _autoscaleSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutoscaleSettingResource>> GetIfExistsAsync(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _autoscaleSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutoscaleSettingResource>(response.GetRawResponse());
                return Response.FromValue(new AutoscaleSettingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoscaleSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="autoscaleSettingName"> The autoscale setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="autoscaleSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="autoscaleSettingName"/> is null. </exception>
        public virtual NullableResponse<AutoscaleSettingResource> GetIfExists(string autoscaleSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(autoscaleSettingName, nameof(autoscaleSettingName));

            using var scope = _autoscaleSettingClientDiagnostics.CreateScope("AutoscaleSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _autoscaleSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, autoscaleSettingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutoscaleSettingResource>(response.GetRawResponse());
                return Response.FromValue(new AutoscaleSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutoscaleSettingResource> IEnumerable<AutoscaleSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutoscaleSettingResource> IAsyncEnumerable<AutoscaleSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
