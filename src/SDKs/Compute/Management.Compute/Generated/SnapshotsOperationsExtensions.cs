// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SnapshotsOperations.
    /// </summary>
    public static partial class SnapshotsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Put disk operation.
            /// </param>
            public static Snapshot CreateOrUpdate(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, Snapshot snapshot)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, snapshotName, snapshot).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Put disk operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> CreateOrUpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, Snapshot snapshot, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates (patches) a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Patch snapshot operation.
            /// </param>
            public static Snapshot Update(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotUpdate snapshot)
            {
                return operations.UpdateAsync(resourceGroupName, snapshotName, snapshot).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates (patches) a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Patch snapshot operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> UpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotUpdate snapshot, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            public static Snapshot Get(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName)
            {
                return operations.GetAsync(resourceGroupName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> GetAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            public static OperationStatusResponse Delete(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName)
            {
                return operations.DeleteAsync(resourceGroupName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> DeleteAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists snapshots under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<Snapshot> ListByResourceGroup(this ISnapshotsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists snapshots under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Snapshot>> ListByResourceGroupAsync(this ISnapshotsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists snapshots under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Snapshot> List(this ISnapshotsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists snapshots under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Snapshot>> ListAsync(this ISnapshotsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='grantAccessData'>
            /// Access data object supplied in the body of the get snapshot access
            /// operation.
            /// </param>
            public static AccessUri GrantAccess(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, GrantAccessData grantAccessData)
            {
                return operations.GrantAccessAsync(resourceGroupName, snapshotName, grantAccessData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Grants access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='grantAccessData'>
            /// Access data object supplied in the body of the get snapshot access
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessUri> GrantAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, GrantAccessData grantAccessData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GrantAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, grantAccessData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Revokes access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            public static OperationStatusResponse RevokeAccess(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName)
            {
                return operations.RevokeAccessAsync(resourceGroupName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Revokes access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> RevokeAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RevokeAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Put disk operation.
            /// </param>
            public static Snapshot BeginCreateOrUpdate(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, Snapshot snapshot)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, snapshotName, snapshot).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Put disk operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> BeginCreateOrUpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, Snapshot snapshot, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates (patches) a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Patch snapshot operation.
            /// </param>
            public static Snapshot BeginUpdate(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotUpdate snapshot)
            {
                return operations.BeginUpdateAsync(resourceGroupName, snapshotName, snapshot).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates (patches) a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='snapshot'>
            /// Snapshot object supplied in the body of the Patch snapshot operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> BeginUpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotUpdate snapshot, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            public static OperationStatusResponse BeginDelete(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> BeginDeleteAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='grantAccessData'>
            /// Access data object supplied in the body of the get snapshot access
            /// operation.
            /// </param>
            public static AccessUri BeginGrantAccess(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, GrantAccessData grantAccessData)
            {
                return operations.BeginGrantAccessAsync(resourceGroupName, snapshotName, grantAccessData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Grants access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='grantAccessData'>
            /// Access data object supplied in the body of the get snapshot access
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessUri> BeginGrantAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, GrantAccessData grantAccessData, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGrantAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, grantAccessData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Revokes access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            public static OperationStatusResponse BeginRevokeAccess(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName)
            {
                return operations.BeginRevokeAccessAsync(resourceGroupName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Revokes access to a snapshot.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the snapshot that is being created. The name can't be changed
            /// after the snapshot is created. Supported characters for the name are a-z,
            /// A-Z, 0-9 and _. The max name length is 80 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponse> BeginRevokeAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRevokeAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists snapshots under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Snapshot> ListByResourceGroupNext(this ISnapshotsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists snapshots under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Snapshot>> ListByResourceGroupNextAsync(this ISnapshotsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists snapshots under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Snapshot> ListNext(this ISnapshotsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists snapshots under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Snapshot>> ListNextAsync(this ISnapshotsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
