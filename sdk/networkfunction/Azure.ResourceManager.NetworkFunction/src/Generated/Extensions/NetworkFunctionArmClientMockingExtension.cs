// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkFunction;

namespace Azure.ResourceManager.NetworkFunction.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class NetworkFunctionArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionArmClientMockingExtension"/> class for mocking. </summary>
        protected NetworkFunctionArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkFunctionArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal NetworkFunctionArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AzureTrafficCollectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AzureTrafficCollectorResource.CreateResourceIdentifier" /> to create an <see cref="AzureTrafficCollectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AzureTrafficCollectorResource" /> object. </returns>
        public virtual AzureTrafficCollectorResource GetAzureTrafficCollectorResource(ResourceIdentifier id)
        {
            AzureTrafficCollectorResource.ValidateResourceId(id);
            return new AzureTrafficCollectorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CollectorPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CollectorPolicyResource.CreateResourceIdentifier" /> to create a <see cref="CollectorPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CollectorPolicyResource" /> object. </returns>
        public virtual CollectorPolicyResource GetCollectorPolicyResource(ResourceIdentifier id)
        {
            CollectorPolicyResource.ValidateResourceId(id);
            return new CollectorPolicyResource(Client, id);
        }
    }
}
