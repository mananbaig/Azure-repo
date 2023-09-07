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
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A Class representing a BackupRecoveryPoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BackupRecoveryPointResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBackupRecoveryPointResource method.
    /// Otherwise you can get one from its parent resource <see cref="BackupProtectedItemResource" /> using the GetBackupRecoveryPoint method.
    /// </summary>
    public partial class BackupRecoveryPointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BackupRecoveryPointResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string containerName, string protectedItemName, string recoveryPointId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _backupRecoveryPointRecoveryPointsClientDiagnostics;
        private readonly RecoveryPointsRestOperations _backupRecoveryPointRecoveryPointsRestClient;
        private readonly ClientDiagnostics _defaultClientDiagnostics;
        private readonly RecoveryServicesBackupRestOperations _defaultRestClient;
        private readonly ClientDiagnostics _restoresClientDiagnostics;
        private readonly RestoresRestOperations _restoresRestClient;
        private readonly ClientDiagnostics _itemLevelRecoveryConnectionsClientDiagnostics;
        private readonly ItemLevelRecoveryConnectionsRestOperations _itemLevelRecoveryConnectionsRestClient;
        private readonly BackupRecoveryPointData _data;

        /// <summary> Initializes a new instance of the <see cref="BackupRecoveryPointResource"/> class for mocking. </summary>
        protected BackupRecoveryPointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BackupRecoveryPointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BackupRecoveryPointResource(ArmClient client, BackupRecoveryPointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BackupRecoveryPointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BackupRecoveryPointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupRecoveryPointRecoveryPointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string backupRecoveryPointRecoveryPointsApiVersion);
            _backupRecoveryPointRecoveryPointsRestClient = new RecoveryPointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupRecoveryPointRecoveryPointsApiVersion);
            _defaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _defaultRestClient = new RecoveryServicesBackupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _restoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restoresRestClient = new RestoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _itemLevelRecoveryConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _itemLevelRecoveryConnectionsRestClient = new ItemLevelRecoveryConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/backupFabrics/protectionContainers/protectedItems/recoveryPoints";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BackupRecoveryPointData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Provides the information of the backed up data identified using RecoveryPointID. This is an asynchronous operation.
        /// To know the status of the operation, call the GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BackupRecoveryPointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointResource.Get");
            scope.Start();
            try
            {
                var response = await _backupRecoveryPointRecoveryPointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides the information of the backed up data identified using RecoveryPointID. This is an asynchronous operation.
        /// To know the status of the operation, call the GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryPoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BackupRecoveryPointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _backupRecoveryPointRecoveryPointsClientDiagnostics.CreateScope("BackupRecoveryPointResource.Get");
            scope.Start();
            try
            {
                var response = _backupRecoveryPointRecoveryPointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Move recovery point from one datastore to another store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/move</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveRecoveryPoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Move Resource Across Tiers Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> MoveRecoveryPointAsync(WaitUntil waitUntil, MoveRPAcrossTiersContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _defaultClientDiagnostics.CreateScope("BackupRecoveryPointResource.MoveRecoveryPoint");
            scope.Start();
            try
            {
                var response = await _defaultRestClient.MoveRecoveryPointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation(_defaultClientDiagnostics, Pipeline, _defaultRestClient.CreateMoveRecoveryPointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Move recovery point from one datastore to another store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/move</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveRecoveryPoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Move Resource Across Tiers Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation MoveRecoveryPoint(WaitUntil waitUntil, MoveRPAcrossTiersContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _defaultClientDiagnostics.CreateScope("BackupRecoveryPointResource.MoveRecoveryPoint");
            scope.Start();
            try
            {
                var response = _defaultRestClient.MoveRecoveryPoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation(_defaultClientDiagnostics, Pipeline, _defaultRestClient.CreateMoveRecoveryPointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restores the specified backed up data. This is an asynchronous operation. To know the status of this API call, use
        /// GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/restore</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Restores_Trigger</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> resource restore request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> TriggerRestoreAsync(WaitUntil waitUntil, TriggerRestoreContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _restoresClientDiagnostics.CreateScope("BackupRecoveryPointResource.TriggerRestore");
            scope.Start();
            try
            {
                var response = await _restoresRestClient.TriggerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation(_restoresClientDiagnostics, Pipeline, _restoresRestClient.CreateTriggerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restores the specified backed up data. This is an asynchronous operation. To know the status of this API call, use
        /// GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/restore</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Restores_Trigger</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> resource restore request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation TriggerRestore(WaitUntil waitUntil, TriggerRestoreContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _restoresClientDiagnostics.CreateScope("BackupRecoveryPointResource.TriggerRestore");
            scope.Start();
            try
            {
                var response = _restoresRestClient.Trigger(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation(_restoresClientDiagnostics, Pipeline, _restoresRestClient.CreateTriggerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provisions a script which invokes an iSCSI connection to the backup data. Executing this script opens a file
        /// explorer displaying all the recoverable files and folders. This is an asynchronous operation. To know the status of
        /// provisioning, call GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/provisionInstantItemRecovery</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ItemLevelRecoveryConnections_Provision</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> resource ILR request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response> ProvisionItemLevelRecoveryConnectionAsync(ProvisionIlrConnectionContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _itemLevelRecoveryConnectionsClientDiagnostics.CreateScope("BackupRecoveryPointResource.ProvisionItemLevelRecoveryConnection");
            scope.Start();
            try
            {
                var response = await _itemLevelRecoveryConnectionsRestClient.ProvisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provisions a script which invokes an iSCSI connection to the backup data. Executing this script opens a file
        /// explorer displaying all the recoverable files and folders. This is an asynchronous operation. To know the status of
        /// provisioning, call GetProtectedItemOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/provisionInstantItemRecovery</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ItemLevelRecoveryConnections_Provision</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> resource ILR request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response ProvisionItemLevelRecoveryConnection(ProvisionIlrConnectionContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _itemLevelRecoveryConnectionsClientDiagnostics.CreateScope("BackupRecoveryPointResource.ProvisionItemLevelRecoveryConnection");
            scope.Start();
            try
            {
                var response = _itemLevelRecoveryConnectionsRestClient.Provision(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script. Executing this script opens a file explorer
        /// displaying all recoverable files and folders. This is an asynchronous operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/revokeInstantItemRecovery</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ItemLevelRecoveryConnections_Revoke</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RevokeItemLevelRecoveryConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _itemLevelRecoveryConnectionsClientDiagnostics.CreateScope("BackupRecoveryPointResource.RevokeItemLevelRecoveryConnection");
            scope.Start();
            try
            {
                var response = await _itemLevelRecoveryConnectionsRestClient.RevokeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Revokes an iSCSI connection which can be used to download a script. Executing this script opens a file explorer
        /// displaying all recoverable files and folders. This is an asynchronous operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupFabrics/{fabricName}/protectionContainers/{containerName}/protectedItems/{protectedItemName}/recoveryPoints/{recoveryPointId}/revokeInstantItemRecovery</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ItemLevelRecoveryConnections_Revoke</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RevokeItemLevelRecoveryConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _itemLevelRecoveryConnectionsClientDiagnostics.CreateScope("BackupRecoveryPointResource.RevokeItemLevelRecoveryConnection");
            scope.Start();
            try
            {
                var response = _itemLevelRecoveryConnectionsRestClient.Revoke(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
