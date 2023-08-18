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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="ScalingPlanResource" /> and their operations.
    /// Each <see cref="ScalingPlanResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ScalingPlanCollection" /> instance call the GetScalingPlans method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ScalingPlanCollection : ArmCollection, IEnumerable<ScalingPlanResource>, IAsyncEnumerable<ScalingPlanResource>
    {
        private readonly ClientDiagnostics _scalingPlanClientDiagnostics;
        private readonly ScalingPlansRestOperations _scalingPlanRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScalingPlanCollection"/> class for mocking. </summary>
        protected ScalingPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScalingPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScalingPlanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scalingPlanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ScalingPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScalingPlanResource.ResourceType, out string scalingPlanApiVersion);
            _scalingPlanRestClient = new ScalingPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scalingPlanApiVersion);
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
        /// Create or update a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="data"> Object containing scaling plan definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScalingPlanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scalingPlanName, ScalingPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanName, nameof(scalingPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scalingPlanClientDiagnostics.CreateScope("ScalingPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scalingPlanRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, scalingPlanName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<ScalingPlanResource>(Response.FromValue(new ScalingPlanResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="data"> Object containing scaling plan definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScalingPlanResource> CreateOrUpdate(WaitUntil waitUntil, string scalingPlanName, ScalingPlanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanName, nameof(scalingPlanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scalingPlanClientDiagnostics.CreateScope("ScalingPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scalingPlanRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, scalingPlanName, data, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<ScalingPlanResource>(Response.FromValue(new ScalingPlanResource(Client, response), response.GetRawResponse()));
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
        /// Get a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        public virtual async Task<Response<ScalingPlanResource>> GetAsync(string scalingPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanName, nameof(scalingPlanName));

            using var scope = _scalingPlanClientDiagnostics.CreateScope("ScalingPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _scalingPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scalingPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        public virtual Response<ScalingPlanResource> Get(string scalingPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanName, nameof(scalingPlanName));

            using var scope = _scalingPlanClientDiagnostics.CreateScope("ScalingPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _scalingPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scalingPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScalingPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List scaling plans.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScalingPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScalingPlanResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scalingPlanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scalingPlanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScalingPlanResource(Client, ScalingPlanData.DeserializeScalingPlanData(e)), _scalingPlanClientDiagnostics, Pipeline, "ScalingPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List scaling plans.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScalingPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScalingPlanResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scalingPlanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scalingPlanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScalingPlanResource(Client, ScalingPlanData.DeserializeScalingPlanData(e)), _scalingPlanClientDiagnostics, Pipeline, "ScalingPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scalingPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanName, nameof(scalingPlanName));

            using var scope = _scalingPlanClientDiagnostics.CreateScope("ScalingPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scalingPlanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scalingPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string scalingPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scalingPlanName, nameof(scalingPlanName));

            using var scope = _scalingPlanClientDiagnostics.CreateScope("ScalingPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _scalingPlanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scalingPlanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScalingPlanResource> IEnumerable<ScalingPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScalingPlanResource> IAsyncEnumerable<ScalingPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
