// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmNginxModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="NginxCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"></param>
        /// <returns> A new <see cref="Nginx.NginxCertificateData"/> instance for mocking. </returns>
        public static NginxCertificateData NginxCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NginxCertificateProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NginxCertificateData(id, name, resourceType, systemData, tags, location, properties, default);
        }

        /// <summary> Initializes a new instance of <see cref="NginxCertificateProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="keyVirtualPath"></param>
        /// <param name="certificateVirtualPath"></param>
        /// <param name="keyVaultSecretId"></param>
        /// <returns> A new <see cref="Models.NginxCertificateProperties"/> instance for mocking. </returns>
        public static NginxCertificateProperties NginxCertificateProperties(ProvisioningState? provisioningState = null, string keyVirtualPath = null, string certificateVirtualPath = null, string keyVaultSecretId = null)
        {
            return new NginxCertificateProperties(provisioningState, keyVirtualPath, certificateVirtualPath, keyVaultSecretId, default);
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"></param>
        /// <returns> A new <see cref="Nginx.NginxConfigurationData"/> instance for mocking. </returns>
        public static NginxConfigurationData NginxConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NginxConfigurationProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NginxConfigurationData(id, name, resourceType, systemData, tags, location, properties, default);
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="files"></param>
        /// <param name="protectedFiles"></param>
        /// <param name="packageData"></param>
        /// <param name="rootFile"></param>
        /// <returns> A new <see cref="Models.NginxConfigurationProperties"/> instance for mocking. </returns>
        public static NginxConfigurationProperties NginxConfigurationProperties(ProvisioningState? provisioningState = null, IEnumerable<NginxConfigurationFile> files = null, IEnumerable<NginxConfigurationFile> protectedFiles = null, string packageData = null, string rootFile = null)
        {
            files ??= new List<NginxConfigurationFile>();
            protectedFiles ??= new List<NginxConfigurationFile>();

            return new NginxConfigurationProperties(provisioningState, files?.ToList(), protectedFiles?.ToList(), packageData != null ? new NginxConfigurationPackage(packageData, new Dictionary<string, BinaryData>()) : null, rootFile, default);
        }

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Gets or sets the identity. </param>
        /// <param name="properties"></param>
        /// <param name="skuName"></param>
        /// <returns> A new <see cref="Nginx.NginxDeploymentData"/> instance for mocking. </returns>
        public static NginxDeploymentData NginxDeploymentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, NginxDeploymentProperties properties = null, string skuName = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NginxDeploymentData(id, name, resourceType, systemData, tags, location, identity, properties, skuName != null ? new ResourceSku(skuName, new Dictionary<string, BinaryData>()) : null, default);
        }

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="nginxVersion"></param>
        /// <param name="managedResourceGroup"> The managed resource group to deploy VNet injection related network resources. </param>
        /// <param name="networkProfile"></param>
        /// <param name="ipAddress"> The IP address of the deployment. </param>
        /// <param name="enableDiagnosticsSupport"></param>
        /// <param name="loggingStorageAccount"></param>
        /// <returns> A new <see cref="Models.NginxDeploymentProperties"/> instance for mocking. </returns>
        public static NginxDeploymentProperties NginxDeploymentProperties(ProvisioningState? provisioningState = null, string nginxVersion = null, string managedResourceGroup = null, NginxNetworkProfile networkProfile = null, string ipAddress = null, bool? enableDiagnosticsSupport = null, NginxStorageAccount loggingStorageAccount = null)
        {
            return new NginxDeploymentProperties(provisioningState, nginxVersion, managedResourceGroup, networkProfile, ipAddress, enableDiagnosticsSupport, loggingStorageAccount != null ? new NginxLogging(loggingStorageAccount, new Dictionary<string, BinaryData>()) : null, default);
        }
    }
}
