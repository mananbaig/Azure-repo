// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MachineLearningArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MachineLearningArmClientMockingExtension"/> class for mocking. </summary>
        protected MachineLearningArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MachineLearningArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningComputeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningComputeResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningComputeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningComputeResource" /> object. </returns>
        public virtual MachineLearningComputeResource GetMachineLearningComputeResource(ResourceIdentifier id)
        {
            MachineLearningComputeResource.ValidateResourceId(id);
            return new MachineLearningComputeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryCodeContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryCodeContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryCodeContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryCodeContainerResource" /> object. </returns>
        public virtual MachineLearningRegistryCodeContainerResource GetMachineLearningRegistryCodeContainerResource(ResourceIdentifier id)
        {
            MachineLearningRegistryCodeContainerResource.ValidateResourceId(id);
            return new MachineLearningRegistryCodeContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningCodeContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningCodeContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningCodeContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningCodeContainerResource" /> object. </returns>
        public virtual MachineLearningCodeContainerResource GetMachineLearningCodeContainerResource(ResourceIdentifier id)
        {
            MachineLearningCodeContainerResource.ValidateResourceId(id);
            return new MachineLearningCodeContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryCodeVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryCodeVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryCodeVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryCodeVersionResource" /> object. </returns>
        public virtual MachineLearningRegistryCodeVersionResource GetMachineLearningRegistryCodeVersionResource(ResourceIdentifier id)
        {
            MachineLearningRegistryCodeVersionResource.ValidateResourceId(id);
            return new MachineLearningRegistryCodeVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningCodeVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningCodeVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningCodeVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningCodeVersionResource" /> object. </returns>
        public virtual MachineLearningCodeVersionResource GetMachineLearningCodeVersionResource(ResourceIdentifier id)
        {
            MachineLearningCodeVersionResource.ValidateResourceId(id);
            return new MachineLearningCodeVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearninRegistryComponentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearninRegistryComponentContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearninRegistryComponentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearninRegistryComponentContainerResource" /> object. </returns>
        public virtual MachineLearninRegistryComponentContainerResource GetMachineLearninRegistryComponentContainerResource(ResourceIdentifier id)
        {
            MachineLearninRegistryComponentContainerResource.ValidateResourceId(id);
            return new MachineLearninRegistryComponentContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningComponentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningComponentContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningComponentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningComponentContainerResource" /> object. </returns>
        public virtual MachineLearningComponentContainerResource GetMachineLearningComponentContainerResource(ResourceIdentifier id)
        {
            MachineLearningComponentContainerResource.ValidateResourceId(id);
            return new MachineLearningComponentContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearninRegistryComponentVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearninRegistryComponentVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearninRegistryComponentVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearninRegistryComponentVersionResource" /> object. </returns>
        public virtual MachineLearninRegistryComponentVersionResource GetMachineLearninRegistryComponentVersionResource(ResourceIdentifier id)
        {
            MachineLearninRegistryComponentVersionResource.ValidateResourceId(id);
            return new MachineLearninRegistryComponentVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningComponentVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningComponentVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningComponentVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningComponentVersionResource" /> object. </returns>
        public virtual MachineLearningComponentVersionResource GetMachineLearningComponentVersionResource(ResourceIdentifier id)
        {
            MachineLearningComponentVersionResource.ValidateResourceId(id);
            return new MachineLearningComponentVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryDataContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryDataContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryDataContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryDataContainerResource" /> object. </returns>
        public virtual MachineLearningRegistryDataContainerResource GetMachineLearningRegistryDataContainerResource(ResourceIdentifier id)
        {
            MachineLearningRegistryDataContainerResource.ValidateResourceId(id);
            return new MachineLearningRegistryDataContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningDataContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningDataContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningDataContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningDataContainerResource" /> object. </returns>
        public virtual MachineLearningDataContainerResource GetMachineLearningDataContainerResource(ResourceIdentifier id)
        {
            MachineLearningDataContainerResource.ValidateResourceId(id);
            return new MachineLearningDataContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryDataVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryDataVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryDataVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryDataVersionResource" /> object. </returns>
        public virtual MachineLearningRegistryDataVersionResource GetMachineLearningRegistryDataVersionResource(ResourceIdentifier id)
        {
            MachineLearningRegistryDataVersionResource.ValidateResourceId(id);
            return new MachineLearningRegistryDataVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningDataVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningDataVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningDataVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningDataVersionResource" /> object. </returns>
        public virtual MachineLearningDataVersionResource GetMachineLearningDataVersionResource(ResourceIdentifier id)
        {
            MachineLearningDataVersionResource.ValidateResourceId(id);
            return new MachineLearningDataVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryEnvironmentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryEnvironmentContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryEnvironmentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryEnvironmentContainerResource" /> object. </returns>
        public virtual MachineLearningRegistryEnvironmentContainerResource GetMachineLearningRegistryEnvironmentContainerResource(ResourceIdentifier id)
        {
            MachineLearningRegistryEnvironmentContainerResource.ValidateResourceId(id);
            return new MachineLearningRegistryEnvironmentContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningEnvironmentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningEnvironmentContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningEnvironmentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningEnvironmentContainerResource" /> object. </returns>
        public virtual MachineLearningEnvironmentContainerResource GetMachineLearningEnvironmentContainerResource(ResourceIdentifier id)
        {
            MachineLearningEnvironmentContainerResource.ValidateResourceId(id);
            return new MachineLearningEnvironmentContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryEnvironmentVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryEnvironmentVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryEnvironmentVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryEnvironmentVersionResource" /> object. </returns>
        public virtual MachineLearningRegistryEnvironmentVersionResource GetMachineLearningRegistryEnvironmentVersionResource(ResourceIdentifier id)
        {
            MachineLearningRegistryEnvironmentVersionResource.ValidateResourceId(id);
            return new MachineLearningRegistryEnvironmentVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningEnvironmentVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningEnvironmentVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningEnvironmentVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningEnvironmentVersionResource" /> object. </returns>
        public virtual MachineLearningEnvironmentVersionResource GetMachineLearningEnvironmentVersionResource(ResourceIdentifier id)
        {
            MachineLearningEnvironmentVersionResource.ValidateResourceId(id);
            return new MachineLearningEnvironmentVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryModelContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryModelContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryModelContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryModelContainerResource" /> object. </returns>
        public virtual MachineLearningRegistryModelContainerResource GetMachineLearningRegistryModelContainerResource(ResourceIdentifier id)
        {
            MachineLearningRegistryModelContainerResource.ValidateResourceId(id);
            return new MachineLearningRegistryModelContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningModelContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningModelContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningModelContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningModelContainerResource" /> object. </returns>
        public virtual MachineLearningModelContainerResource GetMachineLearningModelContainerResource(ResourceIdentifier id)
        {
            MachineLearningModelContainerResource.ValidateResourceId(id);
            return new MachineLearningModelContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryModelVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryModelVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryModelVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryModelVersionResource" /> object. </returns>
        public virtual MachineLearningRegistryModelVersionResource GetMachineLearningRegistryModelVersionResource(ResourceIdentifier id)
        {
            MachineLearningRegistryModelVersionResource.ValidateResourceId(id);
            return new MachineLearningRegistryModelVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningModelVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningModelVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningModelVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningModelVersionResource" /> object. </returns>
        public virtual MachineLearningModelVersionResource GetMachineLearningModelVersionResource(ResourceIdentifier id)
        {
            MachineLearningModelVersionResource.ValidateResourceId(id);
            return new MachineLearningModelVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningBatchEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningBatchEndpointResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningBatchEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningBatchEndpointResource" /> object. </returns>
        public virtual MachineLearningBatchEndpointResource GetMachineLearningBatchEndpointResource(ResourceIdentifier id)
        {
            MachineLearningBatchEndpointResource.ValidateResourceId(id);
            return new MachineLearningBatchEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningBatchDeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningBatchDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningBatchDeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningBatchDeploymentResource" /> object. </returns>
        public virtual MachineLearningBatchDeploymentResource GetMachineLearningBatchDeploymentResource(ResourceIdentifier id)
        {
            MachineLearningBatchDeploymentResource.ValidateResourceId(id);
            return new MachineLearningBatchDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningDatastoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningDatastoreResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningDatastoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningDatastoreResource" /> object. </returns>
        public virtual MachineLearningDatastoreResource GetMachineLearningDatastoreResource(ResourceIdentifier id)
        {
            MachineLearningDatastoreResource.ValidateResourceId(id);
            return new MachineLearningDatastoreResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningFeatureSetContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningFeatureSetContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningFeatureSetContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningFeatureSetContainerResource" /> object. </returns>
        public virtual MachineLearningFeatureSetContainerResource GetMachineLearningFeatureSetContainerResource(ResourceIdentifier id)
        {
            MachineLearningFeatureSetContainerResource.ValidateResourceId(id);
            return new MachineLearningFeatureSetContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningFeatureResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningFeatureResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningFeatureResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningFeatureResource" /> object. </returns>
        public virtual MachineLearningFeatureResource GetMachineLearningFeatureResource(ResourceIdentifier id)
        {
            MachineLearningFeatureResource.ValidateResourceId(id);
            return new MachineLearningFeatureResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningFeatureSetVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningFeatureSetVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningFeatureSetVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningFeatureSetVersionResource" /> object. </returns>
        public virtual MachineLearningFeatureSetVersionResource GetMachineLearningFeatureSetVersionResource(ResourceIdentifier id)
        {
            MachineLearningFeatureSetVersionResource.ValidateResourceId(id);
            return new MachineLearningFeatureSetVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningFeatureStoreEntityContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningFeatureStoreEntityContainerResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningFeatureStoreEntityContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningFeatureStoreEntityContainerResource" /> object. </returns>
        public virtual MachineLearningFeatureStoreEntityContainerResource GetMachineLearningFeatureStoreEntityContainerResource(ResourceIdentifier id)
        {
            MachineLearningFeatureStoreEntityContainerResource.ValidateResourceId(id);
            return new MachineLearningFeatureStoreEntityContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningFeaturestoreEntityVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningFeaturestoreEntityVersionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningFeaturestoreEntityVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningFeaturestoreEntityVersionResource" /> object. </returns>
        public virtual MachineLearningFeaturestoreEntityVersionResource GetMachineLearningFeaturestoreEntityVersionResource(ResourceIdentifier id)
        {
            MachineLearningFeaturestoreEntityVersionResource.ValidateResourceId(id);
            return new MachineLearningFeaturestoreEntityVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningJobResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningJobResource" /> object. </returns>
        public virtual MachineLearningJobResource GetMachineLearningJobResource(ResourceIdentifier id)
        {
            MachineLearningJobResource.ValidateResourceId(id);
            return new MachineLearningJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningLabelingJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningLabelingJobResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningLabelingJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningLabelingJobResource" /> object. </returns>
        public virtual MachineLearningLabelingJobResource GetMachineLearningLabelingJobResource(ResourceIdentifier id)
        {
            MachineLearningLabelingJobResource.ValidateResourceId(id);
            return new MachineLearningLabelingJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningOnlineEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningOnlineEndpointResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningOnlineEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningOnlineEndpointResource" /> object. </returns>
        public virtual MachineLearningOnlineEndpointResource GetMachineLearningOnlineEndpointResource(ResourceIdentifier id)
        {
            MachineLearningOnlineEndpointResource.ValidateResourceId(id);
            return new MachineLearningOnlineEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningOnlineDeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningOnlineDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningOnlineDeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningOnlineDeploymentResource" /> object. </returns>
        public virtual MachineLearningOnlineDeploymentResource GetMachineLearningOnlineDeploymentResource(ResourceIdentifier id)
        {
            MachineLearningOnlineDeploymentResource.ValidateResourceId(id);
            return new MachineLearningOnlineDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningScheduleResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningScheduleResource" /> object. </returns>
        public virtual MachineLearningScheduleResource GetMachineLearningScheduleResource(ResourceIdentifier id)
        {
            MachineLearningScheduleResource.ValidateResourceId(id);
            return new MachineLearningScheduleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningRegistryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningRegistryResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningRegistryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningRegistryResource" /> object. </returns>
        public virtual MachineLearningRegistryResource GetMachineLearningRegistryResource(ResourceIdentifier id)
        {
            MachineLearningRegistryResource.ValidateResourceId(id);
            return new MachineLearningRegistryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningWorkspaceResource" /> object. </returns>
        public virtual MachineLearningWorkspaceResource GetMachineLearningWorkspaceResource(ResourceIdentifier id)
        {
            MachineLearningWorkspaceResource.ValidateResourceId(id);
            return new MachineLearningWorkspaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningWorkspaceConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningWorkspaceConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningWorkspaceConnectionResource" /> object. </returns>
        public virtual MachineLearningWorkspaceConnectionResource GetMachineLearningWorkspaceConnectionResource(ResourceIdentifier id)
        {
            MachineLearningWorkspaceConnectionResource.ValidateResourceId(id);
            return new MachineLearningWorkspaceConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningOutboundRuleBasicResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningOutboundRuleBasicResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningOutboundRuleBasicResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningOutboundRuleBasicResource" /> object. </returns>
        public virtual MachineLearningOutboundRuleBasicResource GetMachineLearningOutboundRuleBasicResource(ResourceIdentifier id)
        {
            MachineLearningOutboundRuleBasicResource.ValidateResourceId(id);
            return new MachineLearningOutboundRuleBasicResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MachineLearningPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MachineLearningPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MachineLearningPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineLearningPrivateEndpointConnectionResource" /> object. </returns>
        public virtual MachineLearningPrivateEndpointConnectionResource GetMachineLearningPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            MachineLearningPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new MachineLearningPrivateEndpointConnectionResource(Client, id);
        }
    }
}
