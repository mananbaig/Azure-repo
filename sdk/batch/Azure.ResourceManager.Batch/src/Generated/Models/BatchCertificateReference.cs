// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Warning: This object is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead. </summary>
    public partial class BatchCertificateReference
    {
        /// <summary> Initializes a new instance of BatchCertificateReference. </summary>
        /// <param name="id"> The fully qualified ID of the certificate to install on the pool. This must be inside the same batch account as the pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public BatchCertificateReference(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Visibility = new ChangeTrackingList<BatchCertificateVisibility>();
        }

        /// <summary> Initializes a new instance of BatchCertificateReference. </summary>
        /// <param name="id"> The fully qualified ID of the certificate to install on the pool. This must be inside the same batch account as the pool. </param>
        /// <param name="storeLocation"> The default value is currentUser. This property is applicable only for pools configured with Windows nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows image reference). For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory. </param>
        /// <param name="storeName"> This property is applicable only for pools configured with Windows nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows image reference). Common store names include: My, Root, CA, Trust, Disallowed, TrustedPeople, TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also be used. The default value is My. </param>
        /// <param name="visibility"> Which user accounts on the compute node should have access to the private data of the certificate. </param>
        internal BatchCertificateReference(ResourceIdentifier id, BatchCertificateStoreLocation? storeLocation, string storeName, IList<BatchCertificateVisibility> visibility)
        {
            Id = id;
            StoreLocation = storeLocation;
            StoreName = storeName;
            Visibility = visibility;
        }

        /// <summary> The fully qualified ID of the certificate to install on the pool. This must be inside the same batch account as the pool. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The default value is currentUser. This property is applicable only for pools configured with Windows nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows image reference). For Linux compute nodes, the certificates are stored in a directory inside the task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the task to query for this location. For certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and certificates are placed in that directory. </summary>
        public BatchCertificateStoreLocation? StoreLocation { get; set; }
        /// <summary> This property is applicable only for pools configured with Windows nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows image reference). Common store names include: My, Root, CA, Trust, Disallowed, TrustedPeople, TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also be used. The default value is My. </summary>
        public string StoreName { get; set; }
        /// <summary> Which user accounts on the compute node should have access to the private data of the certificate. </summary>
        public IList<BatchCertificateVisibility> Visibility { get; }
    }
}
