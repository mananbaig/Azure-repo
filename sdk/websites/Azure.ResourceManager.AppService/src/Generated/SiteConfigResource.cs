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
    public abstract partial class SiteConfigResource : ArmResource
    {
        internal static SiteConfigResource GetResource(ArmClient client, SiteConfigData data)
        {
            if (IsWebSiteConfigResource(data.Id))
            {
                return new WebSiteConfigResource(client, data);
            }
            if (IsSiteConfigSnapshotResource(data.Id))
            {
                return new SiteConfigSnapshotResource(client, data);
            }
            if (IsWebSiteSlotConfigResource(data.Id))
            {
                return new WebSiteSlotConfigResource(client, data);
            }
            if (IsSiteSlotConfigSnapshotResource(data.Id))
            {
                return new SiteSlotConfigSnapshotResource(client, data);
            }
            throw new InvalidOperationException($"The resource identifier {data.Id} cannot be recognized as one of the following resource candidates: WebSiteConfigResource, SiteConfigSnapshotResource, WebSiteSlotConfigResource or SiteSlotConfigSnapshotResource");
        }

        private static bool IsWebSiteConfigResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteConfigResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "web")
            {
                return false;
            }
            return true;
        }

        private static bool IsSiteConfigSnapshotResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteConfigSnapshotResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private static bool IsWebSiteSlotConfigResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSlotConfigResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "web")
            {
                return false;
            }
            return true;
        }

        private static bool IsSiteSlotConfigSnapshotResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SiteSlotConfigSnapshotResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.ResourceType != ResourceGroupResource.ResourceType)
            {
                return false;
            }
            return true;
        }

        private readonly SiteConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigResource"/> class for mocking. </summary>
        protected SiteConfigResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteConfigResource(ArmClient client, SiteConfigData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteConfigData Data
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
        protected abstract Task<Response<SiteConfigResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<SiteConfigResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> The core implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected abstract Response<SiteConfigResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> The default implementation for operation Get. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<SiteConfigResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }
    }
}
