// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHciArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHciArmClient"/> class for mocking. </summary>
        protected MockableHciArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHciArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHciArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHciArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="ArcSettingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArcSettingResource.CreateResourceIdentifier" /> to create an <see cref="ArcSettingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcSettingResource"/> object. </returns>
        public virtual ArcSettingResource GetArcSettingResource(ResourceIdentifier id)
        {
            ArcSettingResource.ValidateResourceId(id);
            return new ArcSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HciClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HciClusterResource.CreateResourceIdentifier" /> to create a <see cref="HciClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HciClusterResource"/> object. </returns>
        public virtual HciClusterResource GetHciClusterResource(ResourceIdentifier id)
        {
            HciClusterResource.ValidateResourceId(id);
            return new HciClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ArcExtensionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArcExtensionResource.CreateResourceIdentifier" /> to create an <see cref="ArcExtensionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcExtensionResource"/> object. </returns>
        public virtual ArcExtensionResource GetArcExtensionResource(ResourceIdentifier id)
        {
            ArcExtensionResource.ValidateResourceId(id);
            return new ArcExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OfferResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OfferResource.CreateResourceIdentifier" /> to create an <see cref="OfferResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OfferResource"/> object. </returns>
        public virtual OfferResource GetOfferResource(ResourceIdentifier id)
        {
            OfferResource.ValidateResourceId(id);
            return new OfferResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PublisherResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PublisherResource.CreateResourceIdentifier" /> to create a <see cref="PublisherResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PublisherResource"/> object. </returns>
        public virtual PublisherResource GetPublisherResource(ResourceIdentifier id)
        {
            PublisherResource.ValidateResourceId(id);
            return new PublisherResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HciSkuResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HciSkuResource.CreateResourceIdentifier" /> to create a <see cref="HciSkuResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HciSkuResource"/> object. </returns>
        public virtual HciSkuResource GetHciSkuResource(ResourceIdentifier id)
        {
            HciSkuResource.ValidateResourceId(id);
            return new HciSkuResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="UpdateRunResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UpdateRunResource.CreateResourceIdentifier" /> to create an <see cref="UpdateRunResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UpdateRunResource"/> object. </returns>
        public virtual UpdateRunResource GetUpdateRunResource(ResourceIdentifier id)
        {
            UpdateRunResource.ValidateResourceId(id);
            return new UpdateRunResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="UpdateSummaryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UpdateSummaryResource.CreateResourceIdentifier" /> to create an <see cref="UpdateSummaryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UpdateSummaryResource"/> object. </returns>
        public virtual UpdateSummaryResource GetUpdateSummaryResource(ResourceIdentifier id)
        {
            UpdateSummaryResource.ValidateResourceId(id);
            return new UpdateSummaryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="UpdateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UpdateResource.CreateResourceIdentifier" /> to create an <see cref="UpdateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UpdateResource"/> object. </returns>
        public virtual UpdateResource GetUpdateResource(ResourceIdentifier id)
        {
            UpdateResource.ValidateResourceId(id);
            return new UpdateResource(Client, id);
        }
    }
}
