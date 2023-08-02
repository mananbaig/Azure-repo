// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class DataBoxArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="DataBoxArmClientMockingExtension"/> class for mocking. </summary>
        protected DataBoxArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataBoxArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataBoxArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal DataBoxArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataBoxJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxJobResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxJobResource" /> object. </returns>
        public virtual DataBoxJobResource GetDataBoxJobResource(ResourceIdentifier id)
        {
            DataBoxJobResource.ValidateResourceId(id);
            return new DataBoxJobResource(Client, id);
        }
    }
}
