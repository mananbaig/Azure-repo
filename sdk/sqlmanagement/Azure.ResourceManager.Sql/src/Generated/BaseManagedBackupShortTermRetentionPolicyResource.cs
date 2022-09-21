// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary> TODO. </summary>
    public abstract partial class BaseManagedBackupShortTermRetentionPolicyResource : ArmResource
    {
        internal static BaseManagedBackupShortTermRetentionPolicyResource GetResource(ArmClient client, ManagedBackupShortTermRetentionPolicyData data)
        {
            if (IsManagedBackupShortTermRetentionPolicyResource(data.Id))
            {
                return new ManagedBackupShortTermRetentionPolicyResource(client, data);
            }
            if (IsManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(data.Id))
            {
                return new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsManagedBackupShortTermRetentionPolicyResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ManagedBackupShortTermRetentionPolicyResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly ManagedBackupShortTermRetentionPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="BaseManagedBackupShortTermRetentionPolicyResource"/> class for mocking. </summary>
        protected BaseManagedBackupShortTermRetentionPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BaseManagedBackupShortTermRetentionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BaseManagedBackupShortTermRetentionPolicyResource(ArmClient client, ManagedBackupShortTermRetentionPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BaseManagedBackupShortTermRetentionPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BaseManagedBackupShortTermRetentionPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedBackupShortTermRetentionPolicyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<Response<BaseManagedBackupShortTermRetentionPolicyResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<BaseManagedBackupShortTermRetentionPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<BaseManagedBackupShortTermRetentionPolicyResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<BaseManagedBackupShortTermRetentionPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Task<ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>> UpdateCoreAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource>> UpdateAsync(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            return await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource> UpdateCore(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<BaseManagedBackupShortTermRetentionPolicyResource> Update(WaitUntil waitUntil, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            return UpdateCore(waitUntil, data, cancellationToken);
        }
    }
}
