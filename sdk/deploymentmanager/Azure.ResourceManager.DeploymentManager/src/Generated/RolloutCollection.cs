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
using Azure.ResourceManager.DeploymentManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeploymentManager
{
    /// <summary>
    /// A class representing a collection of <see cref="RolloutResource" /> and their operations.
    /// Each <see cref="RolloutResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RolloutCollection" /> instance call the GetRollouts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RolloutCollection : ArmCollection, IEnumerable<RolloutResource>, IAsyncEnumerable<RolloutResource>
    {
        private readonly ClientDiagnostics _rolloutClientDiagnostics;
        private readonly RolloutsRestOperations _rolloutRestClient;

        /// <summary> Initializes a new instance of the <see cref="RolloutCollection"/> class for mocking. </summary>
        protected RolloutCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RolloutCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RolloutCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _rolloutClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeploymentManager", RolloutResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RolloutResource.ResourceType, out string rolloutApiVersion);
            _rolloutRestClient = new RolloutsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, rolloutApiVersion);
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
        /// This is an asynchronous operation and can be polled to completion using the location header returned by this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="content"> Source rollout request object that defines the rollout. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RolloutResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string rolloutName, RolloutCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _rolloutClientDiagnostics.CreateScope("RolloutCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _rolloutRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, content, cancellationToken).ConfigureAwait(false);
                var operation = new DeploymentManagerArmOperation<RolloutResource>(new RolloutOperationSource(Client), _rolloutClientDiagnostics, Pipeline, _rolloutRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, content).Request, response, OperationFinalStateVia.Location);
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
        /// This is an asynchronous operation and can be polled to completion using the location header returned by this operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="content"> Source rollout request object that defines the rollout. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RolloutResource> CreateOrUpdate(WaitUntil waitUntil, string rolloutName, RolloutCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _rolloutClientDiagnostics.CreateScope("RolloutCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _rolloutRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, content, cancellationToken);
                var operation = new DeploymentManagerArmOperation<RolloutResource>(new RolloutOperationSource(Client), _rolloutClientDiagnostics, Pipeline, _rolloutRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets detailed information of a rollout.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="retryAttempt"> Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<Response<RolloutResource>> GetAsync(string rolloutName, int? retryAttempt = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _rolloutClientDiagnostics.CreateScope("RolloutCollection.Get");
            scope.Start();
            try
            {
                var response = await _rolloutRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, retryAttempt, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets detailed information of a rollout.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="retryAttempt"> Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual Response<RolloutResource> Get(string rolloutName, int? retryAttempt = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _rolloutClientDiagnostics.CreateScope("RolloutCollection.Get");
            scope.Start();
            try
            {
                var response = _rolloutRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, retryAttempt, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the rollouts in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RolloutResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RolloutResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _rolloutRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new RolloutResource(Client, RolloutData.DeserializeRolloutData(e)), _rolloutClientDiagnostics, Pipeline, "RolloutCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Lists the rollouts in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RolloutResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RolloutResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _rolloutRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new RolloutResource(Client, RolloutData.DeserializeRolloutData(e)), _rolloutClientDiagnostics, Pipeline, "RolloutCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="retryAttempt"> Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rolloutName, int? retryAttempt = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _rolloutClientDiagnostics.CreateScope("RolloutCollection.Exists");
            scope.Start();
            try
            {
                var response = await _rolloutRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, retryAttempt, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/rollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Rollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="retryAttempt"> Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual Response<bool> Exists(string rolloutName, int? retryAttempt = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _rolloutClientDiagnostics.CreateScope("RolloutCollection.Exists");
            scope.Start();
            try
            {
                var response = _rolloutRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rolloutName, retryAttempt, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RolloutResource> IEnumerable<RolloutResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RolloutResource> IAsyncEnumerable<RolloutResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
