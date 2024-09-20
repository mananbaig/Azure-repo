// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableOracleDatabaseArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableOracleDatabaseArmClient"/> class for mocking. </summary>
        protected MockableOracleDatabaseArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableOracleDatabaseArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableOracleDatabaseArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableOracleDatabaseArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutonomousDatabaseResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutonomousDatabaseResource.CreateResourceIdentifier" /> to create an <see cref="AutonomousDatabaseResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutonomousDatabaseResource"/> object. </returns>
        public virtual AutonomousDatabaseResource GetAutonomousDatabaseResource(ResourceIdentifier id)
        {
            AutonomousDatabaseResource.ValidateResourceId(id);
            return new AutonomousDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudExadataInfrastructureResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudExadataInfrastructureResource.CreateResourceIdentifier" /> to create a <see cref="CloudExadataInfrastructureResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudExadataInfrastructureResource"/> object. </returns>
        public virtual CloudExadataInfrastructureResource GetCloudExadataInfrastructureResource(ResourceIdentifier id)
        {
            CloudExadataInfrastructureResource.ValidateResourceId(id);
            return new CloudExadataInfrastructureResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudVmClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudVmClusterResource.CreateResourceIdentifier" /> to create a <see cref="CloudVmClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudVmClusterResource"/> object. </returns>
        public virtual CloudVmClusterResource GetCloudVmClusterResource(ResourceIdentifier id)
        {
            CloudVmClusterResource.ValidateResourceId(id);
            return new CloudVmClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutonomousDatabaseCharacterSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutonomousDatabaseCharacterSetResource.CreateResourceIdentifier" /> to create an <see cref="AutonomousDatabaseCharacterSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutonomousDatabaseCharacterSetResource"/> object. </returns>
        public virtual AutonomousDatabaseCharacterSetResource GetAutonomousDatabaseCharacterSetResource(ResourceIdentifier id)
        {
            AutonomousDatabaseCharacterSetResource.ValidateResourceId(id);
            return new AutonomousDatabaseCharacterSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutonomousDatabaseNationalCharacterSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutonomousDatabaseNationalCharacterSetResource.CreateResourceIdentifier" /> to create an <see cref="AutonomousDatabaseNationalCharacterSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutonomousDatabaseNationalCharacterSetResource"/> object. </returns>
        public virtual AutonomousDatabaseNationalCharacterSetResource GetAutonomousDatabaseNationalCharacterSetResource(ResourceIdentifier id)
        {
            AutonomousDatabaseNationalCharacterSetResource.ValidateResourceId(id);
            return new AutonomousDatabaseNationalCharacterSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutonomousDBVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutonomousDBVersionResource.CreateResourceIdentifier" /> to create an <see cref="AutonomousDBVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutonomousDBVersionResource"/> object. </returns>
        public virtual AutonomousDBVersionResource GetAutonomousDBVersionResource(ResourceIdentifier id)
        {
            AutonomousDBVersionResource.ValidateResourceId(id);
            return new AutonomousDBVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleDBSystemShapeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleDBSystemShapeResource.CreateResourceIdentifier" /> to create an <see cref="OracleDBSystemShapeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleDBSystemShapeResource"/> object. </returns>
        public virtual OracleDBSystemShapeResource GetOracleDBSystemShapeResource(ResourceIdentifier id)
        {
            OracleDBSystemShapeResource.ValidateResourceId(id);
            return new OracleDBSystemShapeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleDnsPrivateViewResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleDnsPrivateViewResource.CreateResourceIdentifier" /> to create an <see cref="OracleDnsPrivateViewResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleDnsPrivateViewResource"/> object. </returns>
        public virtual OracleDnsPrivateViewResource GetOracleDnsPrivateViewResource(ResourceIdentifier id)
        {
            OracleDnsPrivateViewResource.ValidateResourceId(id);
            return new OracleDnsPrivateViewResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleDnsPrivateZoneResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleDnsPrivateZoneResource.CreateResourceIdentifier" /> to create an <see cref="OracleDnsPrivateZoneResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleDnsPrivateZoneResource"/> object. </returns>
        public virtual OracleDnsPrivateZoneResource GetOracleDnsPrivateZoneResource(ResourceIdentifier id)
        {
            OracleDnsPrivateZoneResource.ValidateResourceId(id);
            return new OracleDnsPrivateZoneResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleGIVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleGIVersionResource.CreateResourceIdentifier" /> to create an <see cref="OracleGIVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleGIVersionResource"/> object. </returns>
        public virtual OracleGIVersionResource GetOracleGIVersionResource(ResourceIdentifier id)
        {
            OracleGIVersionResource.ValidateResourceId(id);
            return new OracleGIVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleSystemVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleSystemVersionResource.CreateResourceIdentifier" /> to create an <see cref="OracleSystemVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleSystemVersionResource"/> object. </returns>
        public virtual OracleSystemVersionResource GetOracleSystemVersionResource(ResourceIdentifier id)
        {
            OracleSystemVersionResource.ValidateResourceId(id);
            return new OracleSystemVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleSubscriptionResource.CreateResourceIdentifier" /> to create an <see cref="OracleSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleSubscriptionResource"/> object. </returns>
        public virtual OracleSubscriptionResource GetOracleSubscriptionResource(ResourceIdentifier id)
        {
            OracleSubscriptionResource.ValidateResourceId(id);
            return new OracleSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutonomousDatabaseBackupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutonomousDatabaseBackupResource.CreateResourceIdentifier" /> to create an <see cref="AutonomousDatabaseBackupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutonomousDatabaseBackupResource"/> object. </returns>
        public virtual AutonomousDatabaseBackupResource GetAutonomousDatabaseBackupResource(ResourceIdentifier id)
        {
            AutonomousDatabaseBackupResource.ValidateResourceId(id);
            return new AutonomousDatabaseBackupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OracleDBServerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OracleDBServerResource.CreateResourceIdentifier" /> to create an <see cref="OracleDBServerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OracleDBServerResource"/> object. </returns>
        public virtual OracleDBServerResource GetOracleDBServerResource(ResourceIdentifier id)
        {
            OracleDBServerResource.ValidateResourceId(id);
            return new OracleDBServerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudVmClusterDBNodeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudVmClusterDBNodeResource.CreateResourceIdentifier" /> to create a <see cref="CloudVmClusterDBNodeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudVmClusterDBNodeResource"/> object. </returns>
        public virtual CloudVmClusterDBNodeResource GetCloudVmClusterDBNodeResource(ResourceIdentifier id)
        {
            CloudVmClusterDBNodeResource.ValidateResourceId(id);
            return new CloudVmClusterDBNodeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudVmClusterVirtualNetworkAddressResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudVmClusterVirtualNetworkAddressResource.CreateResourceIdentifier" /> to create a <see cref="CloudVmClusterVirtualNetworkAddressResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudVmClusterVirtualNetworkAddressResource"/> object. </returns>
        public virtual CloudVmClusterVirtualNetworkAddressResource GetCloudVmClusterVirtualNetworkAddressResource(ResourceIdentifier id)
        {
            CloudVmClusterVirtualNetworkAddressResource.ValidateResourceId(id);
            return new CloudVmClusterVirtualNetworkAddressResource(Client, id);
        }
    }
}
