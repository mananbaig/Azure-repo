// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> The set of changes to be made to a Pool. </summary>
    public partial class PoolUpdatePropertiesParameter
    {
        /// <summary> Initializes a new instance of PoolUpdatePropertiesParameter. </summary>
        /// <param name="certificateReferences">
        /// This list replaces any existing Certificate references configured on the Pool. If you specify an empty collection, any existing Certificate references are removed from the Pool. For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location. For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location. For Certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory.
        ///
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </param>
        /// <param name="applicationPackageReferences"> The list replaces any existing Application Package references on the Pool. Changes to Application Package references affect all new Compute Nodes joining the Pool, but do not affect Compute Nodes that are already in the Pool until they are rebooted or reimaged. There is a maximum of 10 Application Package references on any given Pool. If omitted, or if you specify an empty collection, any existing Application Packages references are removed from the Pool. A maximum of 10 references may be specified on a given Pool. </param>
        /// <param name="metadata"> This list replaces any existing metadata configured on the Pool. If omitted, or if you specify an empty collection, any existing metadata is removed from the Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateReferences"/>, <paramref name="applicationPackageReferences"/> or <paramref name="metadata"/> is null. </exception>
        public PoolUpdatePropertiesParameter(IEnumerable<CertificateReference> certificateReferences, IEnumerable<ApplicationPackageReference> applicationPackageReferences, IEnumerable<MetadataItem> metadata)
        {
            Argument.AssertNotNull(certificateReferences, nameof(certificateReferences));
            Argument.AssertNotNull(applicationPackageReferences, nameof(applicationPackageReferences));
            Argument.AssertNotNull(metadata, nameof(metadata));

            CertificateReferences = certificateReferences.ToList();
            ApplicationPackageReferences = applicationPackageReferences.ToList();
            Metadata = metadata.ToList();
        }

        /// <summary> If this element is present, it overwrites any existing StartTask. If omitted, any existing StartTask is removed from the Pool. </summary>
        public StartTask StartTask { get; set; }
        /// <summary>
        /// This list replaces any existing Certificate references configured on the Pool. If you specify an empty collection, any existing Certificate references are removed from the Pool. For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location. For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location. For Certificates with visibility of 'remoteUser', a 'certs' directory is created in the user's home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory.
        ///
        /// Warning: This property is deprecated and will be removed after February, 2024. Please use the [Azure KeyVault Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide) instead.
        /// </summary>
        public IList<CertificateReference> CertificateReferences { get; }
        /// <summary> The list replaces any existing Application Package references on the Pool. Changes to Application Package references affect all new Compute Nodes joining the Pool, but do not affect Compute Nodes that are already in the Pool until they are rebooted or reimaged. There is a maximum of 10 Application Package references on any given Pool. If omitted, or if you specify an empty collection, any existing Application Packages references are removed from the Pool. A maximum of 10 references may be specified on a given Pool. </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; }
        /// <summary> This list replaces any existing metadata configured on the Pool. If omitted, or if you specify an empty collection, any existing metadata is removed from the Pool. </summary>
        public IList<MetadataItem> Metadata { get; }
        /// <summary> This setting replaces any existing targetNodeCommunication setting on the Pool. If omitted, the existing setting is default. </summary>
        public NodeCommunicationMode? TargetNodeCommunicationMode { get; set; }
    }
}
