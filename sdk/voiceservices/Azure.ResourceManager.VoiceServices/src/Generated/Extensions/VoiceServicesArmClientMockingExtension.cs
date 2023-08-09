// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.VoiceServices;

namespace Azure.ResourceManager.VoiceServices.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class VoiceServicesArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="VoiceServicesArmClientMockingExtension"/> class for mocking. </summary>
        protected VoiceServicesArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VoiceServicesArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VoiceServicesArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal VoiceServicesArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="VoiceServicesCommunicationsGatewayResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VoiceServicesCommunicationsGatewayResource.CreateResourceIdentifier" /> to create a <see cref="VoiceServicesCommunicationsGatewayResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VoiceServicesCommunicationsGatewayResource" /> object. </returns>
        public virtual VoiceServicesCommunicationsGatewayResource GetVoiceServicesCommunicationsGatewayResource(ResourceIdentifier id)
        {
            VoiceServicesCommunicationsGatewayResource.ValidateResourceId(id);
            return new VoiceServicesCommunicationsGatewayResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VoiceServicesTestLineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VoiceServicesTestLineResource.CreateResourceIdentifier" /> to create a <see cref="VoiceServicesTestLineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VoiceServicesTestLineResource" /> object. </returns>
        public virtual VoiceServicesTestLineResource GetVoiceServicesTestLineResource(ResourceIdentifier id)
        {
            VoiceServicesTestLineResource.ValidateResourceId(id);
            return new VoiceServicesTestLineResource(Client, id);
        }
    }
}
