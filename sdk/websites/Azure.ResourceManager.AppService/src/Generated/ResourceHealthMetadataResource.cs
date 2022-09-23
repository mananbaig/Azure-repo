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
    public abstract partial class ResourceHealthMetadataResource : ArmResource
    {
        internal static ResourceHealthMetadataResource GetResource(ArmClient client, ResourceHealthMetadataData data)
        {
            if (IsWebSiteResourceHealthMetadataResource(data.Id))
            {
                return new WebSiteResourceHealthMetadataResource(client, data);
            }
            if (IsWebSiteSlotResourceHealthMetadataResource(data.Id))
            {
                return new WebSiteSlotResourceHealthMetadataResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: WebSiteResourceHealthMetadataResource or WebSiteSlotResourceHealthMetadataResource");
        }

        private static bool IsWebSiteResourceHealthMetadataResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteResourceHealthMetadataResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "default")
            {
                return false;
            }
            return true;
        }

        private static bool IsWebSiteSlotResourceHealthMetadataResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSlotResourceHealthMetadataResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "default")
            {
                return false;
            }
            return true;
        }

        private readonly ResourceHealthMetadataData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataResource"/> class for mocking. </summary>
        protected ResourceHealthMetadataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceHealthMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceHealthMetadataResource(ArmClient client, ResourceHealthMetadataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceHealthMetadataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthMetadataData Data
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
        protected abstract Task<Response<ResourceHealthMetadataResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<ResourceHealthMetadataResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<ResourceHealthMetadataResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<ResourceHealthMetadataResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
