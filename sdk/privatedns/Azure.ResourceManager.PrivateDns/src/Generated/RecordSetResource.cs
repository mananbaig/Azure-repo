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

namespace Azure.ResourceManager.PrivateDns
{
    /// <summary> TODO. </summary>
    public abstract partial class RecordSetResource : ArmResource
    {
        internal static RecordSetResource GetResource(ArmClient client, RecordSetData data)
        {
            if (IsPrivateDnsZoneAResource(data.Id))
            {
                return new PrivateDnsZoneAResource(client, data);
            }
            if (IsPrivateDnsZoneAAAAResource(data.Id))
            {
                return new PrivateDnsZoneAAAAResource(client, data);
            }
            if (IsPrivateDnsZoneCNAMEResource(data.Id))
            {
                return new PrivateDnsZoneCNAMEResource(client, data);
            }
            if (IsPrivateDnsZoneMXResource(data.Id))
            {
                return new PrivateDnsZoneMXResource(client, data);
            }
            if (IsPrivateDnsZonePTRResource(data.Id))
            {
                return new PrivateDnsZonePTRResource(client, data);
            }
            if (IsPrivateDnsZoneSOAResource(data.Id))
            {
                return new PrivateDnsZoneSOAResource(client, data);
            }
            if (IsPrivateDnsZoneSRVResource(data.Id))
            {
                return new PrivateDnsZoneSRVResource(client, data);
            }
            if (IsPrivateDnsZoneTXTResource(data.Id))
            {
                return new PrivateDnsZoneTXTResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsPrivateDnsZoneAResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneAResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZoneAAAAResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneAAAAResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZoneCNAMEResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneCNAMEResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZoneMXResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneMXResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZonePTRResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZonePTRResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZoneSOAResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneSOAResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZoneSRVResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneSRVResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsPrivateDnsZoneTXTResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != PrivateDnsZoneTXTResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly RecordSetData _data;

        /// <summary> Initializes a new instance of the <see cref="RecordSetResource"/> class for mocking. </summary>
        protected RecordSetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RecordSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RecordSetResource(ArmClient client, RecordSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RecordSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RecordSetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RecordSetData Data
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
        protected abstract Task<Response<RecordSetResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<RecordSetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<RecordSetResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<RecordSetResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always delete the current record set. Specify the last-seen ETag value to prevent accidentally deleting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always delete the current record set. Specify the last-seen ETag value to prevent accidentally deleting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            return await DeleteCoreAsync(waitUntil, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always delete the current record set. Specify the last-seen ETag value to prevent accidentally deleting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract ArmOperation DeleteCore(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Delete. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always delete the current record set. Specify the last-seen ETag value to prevent accidentally deleting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public ArmOperation Delete(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            return DeleteCore(waitUntil, ifMatch, cancellationToken);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="data"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Task<Response<RecordSetResource>> UpdateCoreAsync(RecordSetData data, string ifMatch = null, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="data"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<RecordSetResource>> UpdateAsync(RecordSetData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            return await UpdateCoreAsync(data, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Update. </summary>
        /// <param name="data"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Response<RecordSetResource> UpdateCore(RecordSetData data, string ifMatch = null, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Update. </summary>
        /// <param name="data"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> The ETag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<RecordSetResource> Update(RecordSetData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            return UpdateCore(data, ifMatch, cancellationToken);
        }
    }
}
