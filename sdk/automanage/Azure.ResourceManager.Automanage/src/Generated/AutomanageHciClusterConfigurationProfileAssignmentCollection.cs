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

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource" /> and their operations.
    /// Each <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get an <see cref="AutomanageHciClusterConfigurationProfileAssignmentCollection" /> instance call the GetAutomanageHciClusterConfigurationProfileAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class AutomanageHciClusterConfigurationProfileAssignmentCollection : ArmCollection, IEnumerable<AutomanageHciClusterConfigurationProfileAssignmentResource>, IAsyncEnumerable<AutomanageHciClusterConfigurationProfileAssignmentResource>
    {
        private readonly ClientDiagnostics _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics;
        private readonly ConfigurationProfileHCIAssignmentsRestOperations _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient;
        private readonly ClientDiagnostics _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics;
        private readonly ConfigurationProfileAssignmentsRestOperations _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentCollection"/> class for mocking. </summary>
        protected AutomanageHciClusterConfigurationProfileAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageHciClusterConfigurationProfileAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageHciClusterConfigurationProfileAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageHciClusterConfigurationProfileAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageHciClusterConfigurationProfileAssignmentResource.ResourceType, out string automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsApiVersion);
            _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient = new ConfigurationProfileHCIAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsApiVersion);
            _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageHciClusterConfigurationProfileAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageHciClusterConfigurationProfileAssignmentResource.ResourceType, out string automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsApiVersion);
            _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient = new ConfigurationProfileAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.AzureStackHci/clusters")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.AzureStackHci/clusters"), nameof(id));
        }

        /// <summary>
        /// Creates an association between a AzureStackHCI cluster and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationProfileAssignmentName, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates an association between a AzureStackHCI cluster and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string configurationProfileAssignmentName, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, data, cancellationToken);
                var operation = new AutomanageArmOperation<AutomanageHciClusterConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<AutomanageHciClusterConfigurationProfileAssignmentResource>> GetAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<AutomanageHciClusterConfigurationProfileAssignmentResource> Get(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_ListByClusterName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageHciClusterConfigurationProfileAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateListByClusterNameRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, AutomanageConfigurationProfileAssignmentData.DeserializeAutomanageConfigurationProfileAssignmentData(e)), _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics, Pipeline, "AutomanageHciClusterConfigurationProfileAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_ListByClusterName</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageHciClusterConfigurationProfileAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageHciClusterConfigurationProfileAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateListByClusterNameRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new AutomanageHciClusterConfigurationProfileAssignmentResource(Client, AutomanageConfigurationProfileAssignmentData.DeserializeAutomanageConfigurationProfileAssignmentData(e)), _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics, Pipeline, "AutomanageHciClusterConfigurationProfileAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHci/clusters/{clusterName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileHCIAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsClientDiagnostics.CreateScope("AutomanageHciClusterConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageHciClusterConfigurationProfileAssignmentConfigurationProfileHCIAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageHciClusterConfigurationProfileAssignmentResource> IEnumerable<AutomanageHciClusterConfigurationProfileAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageHciClusterConfigurationProfileAssignmentResource> IAsyncEnumerable<AutomanageHciClusterConfigurationProfileAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
