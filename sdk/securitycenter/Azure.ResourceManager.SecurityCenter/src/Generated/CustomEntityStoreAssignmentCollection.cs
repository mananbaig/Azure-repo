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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="CustomEntityStoreAssignmentResource" /> and their operations.
    /// Each <see cref="CustomEntityStoreAssignmentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="CustomEntityStoreAssignmentCollection" /> instance call the GetCustomEntityStoreAssignments method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class CustomEntityStoreAssignmentCollection : ArmCollection, IEnumerable<CustomEntityStoreAssignmentResource>, IAsyncEnumerable<CustomEntityStoreAssignmentResource>
    {
        private readonly ClientDiagnostics _customEntityStoreAssignmentClientDiagnostics;
        private readonly CustomEntityStoreAssignmentsRestOperations _customEntityStoreAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomEntityStoreAssignmentCollection"/> class for mocking. </summary>
        protected CustomEntityStoreAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomEntityStoreAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CustomEntityStoreAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customEntityStoreAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", CustomEntityStoreAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CustomEntityStoreAssignmentResource.ResourceType, out string customEntityStoreAssignmentApiVersion);
            _customEntityStoreAssignmentRestClient = new CustomEntityStoreAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customEntityStoreAssignmentApiVersion);
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
        /// Creates a custom entity store assignment for the provided subscription, if not already exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments/{customEntityStoreAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customEntityStoreAssignmentName"> Name of the custom entity store assignment. Generated name is GUID. </param>
        /// <param name="content"> Custom entity store assignment body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customEntityStoreAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customEntityStoreAssignmentName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CustomEntityStoreAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string customEntityStoreAssignmentName, CustomEntityStoreAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customEntityStoreAssignmentName, nameof(customEntityStoreAssignmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _customEntityStoreAssignmentClientDiagnostics.CreateScope("CustomEntityStoreAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customEntityStoreAssignmentRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, customEntityStoreAssignmentName, content, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<CustomEntityStoreAssignmentResource>(Response.FromValue(new CustomEntityStoreAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates a custom entity store assignment for the provided subscription, if not already exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments/{customEntityStoreAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customEntityStoreAssignmentName"> Name of the custom entity store assignment. Generated name is GUID. </param>
        /// <param name="content"> Custom entity store assignment body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customEntityStoreAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customEntityStoreAssignmentName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CustomEntityStoreAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string customEntityStoreAssignmentName, CustomEntityStoreAssignmentCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customEntityStoreAssignmentName, nameof(customEntityStoreAssignmentName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _customEntityStoreAssignmentClientDiagnostics.CreateScope("CustomEntityStoreAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customEntityStoreAssignmentRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, customEntityStoreAssignmentName, content, cancellationToken);
                var operation = new SecurityCenterArmOperation<CustomEntityStoreAssignmentResource>(Response.FromValue(new CustomEntityStoreAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Gets a single custom entity store assignment by name for the provided subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments/{customEntityStoreAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customEntityStoreAssignmentName"> Name of the custom entity store assignment. Generated name is GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customEntityStoreAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customEntityStoreAssignmentName"/> is null. </exception>
        public virtual async Task<Response<CustomEntityStoreAssignmentResource>> GetAsync(string customEntityStoreAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customEntityStoreAssignmentName, nameof(customEntityStoreAssignmentName));

            using var scope = _customEntityStoreAssignmentClientDiagnostics.CreateScope("CustomEntityStoreAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _customEntityStoreAssignmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customEntityStoreAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomEntityStoreAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a single custom entity store assignment by name for the provided subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments/{customEntityStoreAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customEntityStoreAssignmentName"> Name of the custom entity store assignment. Generated name is GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customEntityStoreAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customEntityStoreAssignmentName"/> is null. </exception>
        public virtual Response<CustomEntityStoreAssignmentResource> Get(string customEntityStoreAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customEntityStoreAssignmentName, nameof(customEntityStoreAssignmentName));

            using var scope = _customEntityStoreAssignmentClientDiagnostics.CreateScope("CustomEntityStoreAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _customEntityStoreAssignmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customEntityStoreAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomEntityStoreAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List custom entity store assignments by a provided subscription and resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomEntityStoreAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomEntityStoreAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customEntityStoreAssignmentRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _customEntityStoreAssignmentRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new CustomEntityStoreAssignmentResource(Client, CustomEntityStoreAssignmentData.DeserializeCustomEntityStoreAssignmentData(e)), _customEntityStoreAssignmentClientDiagnostics, Pipeline, "CustomEntityStoreAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List custom entity store assignments by a provided subscription and resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomEntityStoreAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomEntityStoreAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _customEntityStoreAssignmentRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _customEntityStoreAssignmentRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new CustomEntityStoreAssignmentResource(Client, CustomEntityStoreAssignmentData.DeserializeCustomEntityStoreAssignmentData(e)), _customEntityStoreAssignmentClientDiagnostics, Pipeline, "CustomEntityStoreAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments/{customEntityStoreAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customEntityStoreAssignmentName"> Name of the custom entity store assignment. Generated name is GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customEntityStoreAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customEntityStoreAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string customEntityStoreAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customEntityStoreAssignmentName, nameof(customEntityStoreAssignmentName));

            using var scope = _customEntityStoreAssignmentClientDiagnostics.CreateScope("CustomEntityStoreAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _customEntityStoreAssignmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, customEntityStoreAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Security/customEntityStoreAssignments/{customEntityStoreAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomEntityStoreAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customEntityStoreAssignmentName"> Name of the custom entity store assignment. Generated name is GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customEntityStoreAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customEntityStoreAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string customEntityStoreAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customEntityStoreAssignmentName, nameof(customEntityStoreAssignmentName));

            using var scope = _customEntityStoreAssignmentClientDiagnostics.CreateScope("CustomEntityStoreAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _customEntityStoreAssignmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, customEntityStoreAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomEntityStoreAssignmentResource> IEnumerable<CustomEntityStoreAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomEntityStoreAssignmentResource> IAsyncEnumerable<CustomEntityStoreAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
