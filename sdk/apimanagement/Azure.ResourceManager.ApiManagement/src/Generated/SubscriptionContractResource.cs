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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> TODO. </summary>
    public abstract partial class SubscriptionContractResource : ArmResource
    {
        internal static SubscriptionContractResource GetResource(ArmClient client, SubscriptionContractData data)
        {
            if (IsApiManagementSubscriptionResource(data.Id))
            {
                return new ApiManagementSubscriptionResource(client, data);
            }
            if (IsApiManagementUserSubscriptionResource(data.Id))
            {
                return new ApiManagementUserSubscriptionResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsApiManagementSubscriptionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ApiManagementSubscriptionResource.ResourceType)
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

        internal static bool IsApiManagementUserSubscriptionResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ApiManagementUserSubscriptionResource.ResourceType)
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

        private readonly SubscriptionContractData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionContractResource"/> class for mocking. </summary>
        protected SubscriptionContractResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionContractResource(ArmClient client, SubscriptionContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionContractResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionContractResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionContractData Data
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
        protected abstract Task<Response<SubscriptionContractResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<SubscriptionContractResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<SubscriptionContractResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<SubscriptionContractResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
