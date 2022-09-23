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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> TODO. </summary>
    public abstract partial class PrivateAccessResource : ArmResource
    {
        internal static PrivateAccessResource GetResource(ArmClient client, PrivateAccessData data)
        {
            if (IsWebSitePrivateAccessResource(data.Id))
            {
                return new WebSitePrivateAccessResource(client, data);
            }
            if (IsWebSiteSlotPrivateAccessResource(data.Id))
            {
                return new WebSiteSlotPrivateAccessResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: WebSitePrivateAccessResource or WebSiteSlotPrivateAccessResource");
        }

        private static bool IsWebSitePrivateAccessResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSitePrivateAccessResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "virtualNetworks")
            {
                return false;
            }
            return true;
        }

        private static bool IsWebSiteSlotPrivateAccessResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSlotPrivateAccessResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "virtualNetworks")
            {
                return false;
            }
            return true;
        }

        private readonly PrivateAccessData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateAccessResource"/> class for mocking. </summary>
        protected PrivateAccessResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateAccessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateAccessResource(ArmClient client, PrivateAccessData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateAccessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateAccessResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateAccessData Data
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
        protected abstract Task<Response<PrivateAccessResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<PrivateAccessResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<PrivateAccessResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<PrivateAccessResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Task<ArmOperation<PrivateAccessResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<PrivateAccessResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default)
        {
            return await CreateOrUpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract ArmOperation<PrivateAccessResource> CreateOrUpdateCore(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The information for the private access. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<PrivateAccessResource> CreateOrUpdate(WaitUntil waitUntil, PrivateAccessData data, CancellationToken cancellationToken = default)
        {
            return CreateOrUpdateCore(waitUntil, data, cancellationToken);
        }
    }
}
