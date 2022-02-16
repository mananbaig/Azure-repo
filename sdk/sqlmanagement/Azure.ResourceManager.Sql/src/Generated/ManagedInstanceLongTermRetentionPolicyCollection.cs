// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstanceLongTermRetentionPolicy and their operations over its parent. </summary>
    public partial class ManagedInstanceLongTermRetentionPolicyCollection : ArmCollection, IEnumerable<ManagedInstanceLongTermRetentionPolicy>, IAsyncEnumerable<ManagedInstanceLongTermRetentionPolicy>
    {
        private readonly ClientDiagnostics _managedInstanceLongTermRetentionPolicyClientDiagnostics;
        private readonly ManagedInstanceLongTermRetentionPoliciesRestOperations _managedInstanceLongTermRetentionPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceLongTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected ManagedInstanceLongTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceLongTermRetentionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceLongTermRetentionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceLongTermRetentionPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceLongTermRetentionPolicy.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ManagedInstanceLongTermRetentionPolicy.ResourceType, out string managedInstanceLongTermRetentionPolicyApiVersion);
            _managedInstanceLongTermRetentionPolicyRestClient = new ManagedInstanceLongTermRetentionPoliciesRestOperations(_managedInstanceLongTermRetentionPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceLongTermRetentionPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabase.ResourceType), nameof(id));
        }

        /// <summary>
        /// Sets a managed database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="parameters"> The long term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ManagedInstanceLongTermRetentionPolicy>> CreateOrUpdateAsync(bool waitForCompletion, ManagedInstanceLongTermRetentionPolicyName policyName, ManagedInstanceLongTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceLongTermRetentionPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceLongTermRetentionPolicy>(new ManagedInstanceLongTermRetentionPolicyOperationSource(Client), _managedInstanceLongTermRetentionPolicyClientDiagnostics, Pipeline, _managedInstanceLongTermRetentionPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Sets a managed database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="parameters"> The long term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceLongTermRetentionPolicy> CreateOrUpdate(bool waitForCompletion, ManagedInstanceLongTermRetentionPolicyName policyName, ManagedInstanceLongTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceLongTermRetentionPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceLongTermRetentionPolicy>(new ManagedInstanceLongTermRetentionPolicyOperationSource(Client), _managedInstanceLongTermRetentionPolicyClientDiagnostics, Pipeline, _managedInstanceLongTermRetentionPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Gets a managed database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceLongTermRetentionPolicy>> GetAsync(ManagedInstanceLongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceLongTermRetentionPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceLongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceLongTermRetentionPolicy> Get(ManagedInstanceLongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceLongTermRetentionPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceLongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceLongTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceLongTermRetentionPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceLongTermRetentionPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceLongTermRetentionPolicyRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceLongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceLongTermRetentionPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceLongTermRetentionPolicyRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceLongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a database&apos;s long term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_ListByDatabase
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceLongTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceLongTermRetentionPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceLongTermRetentionPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceLongTermRetentionPolicyRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceLongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceLongTermRetentionPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceLongTermRetentionPolicyRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceLongTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(ManagedInstanceLongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedInstanceLongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceLongTermRetentionPolicy>> GetIfExistsAsync(ManagedInstanceLongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceLongTermRetentionPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceLongTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceLongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupLongTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedInstanceLongTermRetentionPolicies_Get
        /// </summary>
        /// <param name="policyName"> The policy name. Should always be Default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceLongTermRetentionPolicy> GetIfExists(ManagedInstanceLongTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceLongTermRetentionPolicyClientDiagnostics.CreateScope("ManagedInstanceLongTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceLongTermRetentionPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceLongTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceLongTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceLongTermRetentionPolicy> IEnumerable<ManagedInstanceLongTermRetentionPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceLongTermRetentionPolicy> IAsyncEnumerable<ManagedInstanceLongTermRetentionPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
