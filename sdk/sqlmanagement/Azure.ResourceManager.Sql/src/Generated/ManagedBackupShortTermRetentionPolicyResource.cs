// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedBackupShortTermRetentionPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedBackupShortTermRetentionPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedBackupShortTermRetentionPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseResource" /> using the GetManagedBackupShortTermRetentionPolicy method.
    /// </summary>
    public partial class ManagedBackupShortTermRetentionPolicyResource : BaseManagedBackupShortTermRetentionPolicyResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedBackupShortTermRetentionPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, ManagedShortTermRetentionPolicyName policyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedBackupShortTermRetentionPolicyClientDiagnostics;
        private readonly ManagedBackupShortTermRetentionPoliciesRestOperations _managedBackupShortTermRetentionPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedBackupShortTermRetentionPolicyResource"/> class for mocking. </summary>
        protected ManagedBackupShortTermRetentionPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedBackupShortTermRetentionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedBackupShortTermRetentionPolicyResource(ArmClient client, ManagedBackupShortTermRetentionPolicyData data) : base(client, data)
        {
            _managedBackupShortTermRetentionPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedBackupShortTermRetentionPolicyApiVersion);
            _managedBackupShortTermRetentionPolicyRestClient = new ManagedBackupShortTermRetentionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedBackupShortTermRetentionPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedBackupShortTermRetentionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedBackupShortTermRetentionPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedBackupShortTermRetentionPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedBackupShortTermRetentionPolicyApiVersion);
            _managedBackupShortTermRetentionPolicyRestClient = new ManagedBackupShortTermRetentionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedBackupShortTermRetentionPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/backupShortTermRetentionPolicies";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseManagedBackupShortTermRetentionPolicyResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedBackupShortTermRetentionPolicyClientDiagnostics.CreateScope("ManagedBackupShortTermRetentionPolicyResource.GetCore");
            scope.Start();
            try
            {
                var response = await _managedBackupShortTermRetentionPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<ManagedBackupShortTermRetentionPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((ManagedBackupShortTermRetentionPolicyResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Gets a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseManagedBackupShortTermRetentionPolicyResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _managedBackupShortTermRetentionPolicyClientDiagnostics.CreateScope("ManagedBackupShortTermRetentionPolicyResource.GetCore");
            scope.Start();
            try
            {
                var response = _managedBackupShortTermRetentionPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<ManagedBackupShortTermRetentionPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((ManagedBackupShortTermRetentionPolicyResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Updates a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>> UpdateCoreAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedBackupShortTermRetentionPolicyClientDiagnostics.CreateScope("ManagedBackupShortTermRetentionPolicyResource.UpdateCore");
            scope.Start();
            try
            {
                var response = await _managedBackupShortTermRetentionPolicyRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>(new BaseManagedBackupShortTermRetentionPolicyOperationSource(Client), _managedBackupShortTermRetentionPolicyClientDiagnostics, Pipeline, _managedBackupShortTermRetentionPolicyRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<ArmOperation<ManagedBackupShortTermRetentionPolicyResource>> UpdateAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new SqlArmOperation<ManagedBackupShortTermRetentionPolicyResource>(Response.FromValue((ManagedBackupShortTermRetentionPolicyResource)value.Value, value.GetRawResponse()));
            }
            var operation = new SqlArmOperation<ManagedBackupShortTermRetentionPolicyResource>(new ManagedBackupShortTermRetentionPolicyOperationSource(Client), _managedBackupShortTermRetentionPolicyClientDiagnostics, Pipeline, _managedBackupShortTermRetentionPolicyRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, value.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Updates a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource> UpdateCore(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedBackupShortTermRetentionPolicyClientDiagnostics.CreateScope("ManagedBackupShortTermRetentionPolicyResource.UpdateCore");
            scope.Start();
            try
            {
                var response = _managedBackupShortTermRetentionPolicyRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>(new BaseManagedBackupShortTermRetentionPolicyOperationSource(Client), _managedBackupShortTermRetentionPolicyClientDiagnostics, Pipeline, _managedBackupShortTermRetentionPolicyRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a managed database&apos;s short term retention policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// Operation Id: ManagedBackupShortTermRetentionPolicies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual ArmOperation<ManagedBackupShortTermRetentionPolicyResource> Update(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(waitUntil, data, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new SqlArmOperation<ManagedBackupShortTermRetentionPolicyResource>(Response.FromValue((ManagedBackupShortTermRetentionPolicyResource)value.Value, value.GetRawResponse()));
            }
            var operation = new SqlArmOperation<ManagedBackupShortTermRetentionPolicyResource>(new ManagedBackupShortTermRetentionPolicyOperationSource(Client), _managedBackupShortTermRetentionPolicyClientDiagnostics, Pipeline, _managedBackupShortTermRetentionPolicyRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, value.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
