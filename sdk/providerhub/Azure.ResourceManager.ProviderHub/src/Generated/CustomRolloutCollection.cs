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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing a collection of <see cref="CustomRolloutResource" /> and their operations.
    /// Each <see cref="CustomRolloutResource" /> in the collection will belong to the same instance of <see cref="ProviderRegistrationResource" />.
    /// To get a <see cref="CustomRolloutCollection" /> instance call the GetCustomRollouts method from an instance of <see cref="ProviderRegistrationResource" />.
    /// </summary>
    public partial class CustomRolloutCollection : ArmCollection, IEnumerable<CustomRolloutResource>, IAsyncEnumerable<CustomRolloutResource>
    {
        private readonly ClientDiagnostics _customRolloutClientDiagnostics;
        private readonly CustomRolloutsRestOperations _customRolloutRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomRolloutCollection"/> class for mocking. </summary>
        protected CustomRolloutCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomRolloutCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CustomRolloutCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customRolloutClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", CustomRolloutResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CustomRolloutResource.ResourceType, out string customRolloutApiVersion);
            _customRolloutRestClient = new CustomRolloutsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customRolloutApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProviderRegistrationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProviderRegistrationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="data"> The custom rollout properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CustomRolloutResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string rolloutName, CustomRolloutData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customRolloutRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, rolloutName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<CustomRolloutResource>(Response.FromValue(new CustomRolloutResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="data"> The custom rollout properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CustomRolloutResource> CreateOrUpdate(WaitUntil waitUntil, string rolloutName, CustomRolloutData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customRolloutRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, rolloutName, data, cancellationToken);
                var operation = new ProviderHubArmOperation<CustomRolloutResource>(Response.FromValue(new CustomRolloutResource(Client, response), response.GetRawResponse()));
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
        /// Gets the custom rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<Response<CustomRolloutResource>> GetAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.Get");
            scope.Start();
            try
            {
                var response = await _customRolloutRestClient.GetAsync(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomRolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the custom rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual Response<CustomRolloutResource> Get(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.Get");
            scope.Start();
            try
            {
                var response = _customRolloutRestClient.Get(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomRolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of the custom rollouts for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_ListByProviderRegistration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomRolloutResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomRolloutResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customRolloutRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _customRolloutRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CustomRolloutResource(Client, CustomRolloutData.DeserializeCustomRolloutData(e)), _customRolloutClientDiagnostics, Pipeline, "CustomRolloutCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of the custom rollouts for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_ListByProviderRegistration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomRolloutResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomRolloutResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customRolloutRestClient.CreateListByProviderRegistrationRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _customRolloutRestClient.CreateListByProviderRegistrationNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CustomRolloutResource(Client, CustomRolloutData.DeserializeCustomRolloutData(e)), _customRolloutClientDiagnostics, Pipeline, "CustomRolloutCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.Exists");
            scope.Start();
            try
            {
                var response = await _customRolloutRestClient.GetAsync(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual Response<bool> Exists(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.Exists");
            scope.Start();
            try
            {
                var response = _customRolloutRestClient.Get(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual async Task<NullableResponse<CustomRolloutResource>> GetIfExistsAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customRolloutRestClient.GetAsync(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CustomRolloutResource>(response.GetRawResponse());
                return Response.FromValue(new CustomRolloutResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        public virtual NullableResponse<CustomRolloutResource> GetIfExists(string rolloutName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rolloutName, nameof(rolloutName));

            using var scope = _customRolloutClientDiagnostics.CreateScope("CustomRolloutCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customRolloutRestClient.Get(Id.SubscriptionId, Id.Name, rolloutName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CustomRolloutResource>(response.GetRawResponse());
                return Response.FromValue(new CustomRolloutResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomRolloutResource> IEnumerable<CustomRolloutResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomRolloutResource> IAsyncEnumerable<CustomRolloutResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
