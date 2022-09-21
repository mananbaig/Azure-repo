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

namespace Azure.ResourceManager.AppService
{
    /// <summary> TODO. </summary>
    public abstract partial class CsmPublishingCredentialsPoliciesEntityResource : ArmResource
    {
        internal static CsmPublishingCredentialsPoliciesEntityResource GetResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data)
        {
            if (IsWebSiteFtpPublishingCredentialsPolicyResource(data.Id))
            {
                return new WebSiteFtpPublishingCredentialsPolicyResource(client, data);
            }
            if (IsScmSiteBasicPublishingCredentialsPolicyResource(data.Id))
            {
                return new ScmSiteBasicPublishingCredentialsPolicyResource(client, data);
            }
            if (IsWebSiteSlotFtpPublishingCredentialsPolicyResource(data.Id))
            {
                return new WebSiteSlotFtpPublishingCredentialsPolicyResource(client, data);
            }
            if (IsScmSiteSlotBasicPublishingCredentialsPolicyResource(data.Id))
            {
                return new ScmSiteSlotBasicPublishingCredentialsPolicyResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsWebSiteFtpPublishingCredentialsPolicyResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteFtpPublishingCredentialsPolicyResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "ftp")
            {
                return false;
            }
            return true;
        }

        internal static bool IsScmSiteBasicPublishingCredentialsPolicyResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ScmSiteBasicPublishingCredentialsPolicyResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "scm")
            {
                return false;
            }
            return true;
        }

        internal static bool IsWebSiteSlotFtpPublishingCredentialsPolicyResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSlotFtpPublishingCredentialsPolicyResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "ftp")
            {
                return false;
            }
            return true;
        }

        internal static bool IsScmSiteSlotBasicPublishingCredentialsPolicyResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ScmSiteSlotBasicPublishingCredentialsPolicyResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "scm")
            {
                return false;
            }
            return true;
        }

        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Initializes a new instance of the <see cref="CsmPublishingCredentialsPoliciesEntityResource"/> class for mocking. </summary>
        protected CsmPublishingCredentialsPoliciesEntityResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CsmPublishingCredentialsPoliciesEntityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CsmPublishingCredentialsPoliciesEntityResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CsmPublishingCredentialsPoliciesEntityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CsmPublishingCredentialsPoliciesEntityResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
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
        protected abstract Task<Response<CsmPublishingCredentialsPoliciesEntityResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<CsmPublishingCredentialsPoliciesEntityResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<CsmPublishingCredentialsPoliciesEntityResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<CsmPublishingCredentialsPoliciesEntityResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        /// <summary> The core implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract Task<ArmOperation<CsmPublishingCredentialsPoliciesEntityResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<CsmPublishingCredentialsPoliciesEntityResource>> CreateOrUpdateAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            return await CreateOrUpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected abstract ArmOperation<CsmPublishingCredentialsPoliciesEntityResource> CreateOrUpdateCore(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation CreateOrUpdate. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<CsmPublishingCredentialsPoliciesEntityResource> CreateOrUpdate(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            return CreateOrUpdateCore(waitUntil, data, cancellationToken);
        }
    }
}
