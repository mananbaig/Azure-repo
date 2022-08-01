// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Describes a list of server certificates referenced by common name that are used to secure the cluster.
    /// Serialized Name: ServerCertificateCommonNames
    /// </summary>
    public partial class ClusterServerCertificateCommonNames
    {
        /// <summary> Initializes a new instance of ClusterServerCertificateCommonNames. </summary>
        public ClusterServerCertificateCommonNames()
        {
            CommonNames = new ChangeTrackingList<ClusterServerCertificateCommonName>();
        }

        /// <summary> Initializes a new instance of ClusterServerCertificateCommonNames. </summary>
        /// <param name="commonNames">
        /// The list of server certificates referenced by common name that are used to secure the cluster.
        /// Serialized Name: ServerCertificateCommonNames.commonNames
        /// </param>
        /// <param name="x509StoreName">
        /// The local certificate store location.
        /// Serialized Name: ServerCertificateCommonNames.x509StoreName
        /// </param>
        internal ClusterServerCertificateCommonNames(IList<ClusterServerCertificateCommonName> commonNames, ClusterCertificateStoreName? x509StoreName)
        {
            CommonNames = commonNames;
            X509StoreName = x509StoreName;
        }

        /// <summary>
        /// The list of server certificates referenced by common name that are used to secure the cluster.
        /// Serialized Name: ServerCertificateCommonNames.commonNames
        /// </summary>
        public IList<ClusterServerCertificateCommonName> CommonNames { get; }
        /// <summary>
        /// The local certificate store location.
        /// Serialized Name: ServerCertificateCommonNames.x509StoreName
        /// </summary>
        public ClusterCertificateStoreName? X509StoreName { get; set; }
    }
}
