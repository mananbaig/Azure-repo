// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The resource name object where the specified values will be full resource names of the corresponding resources in a three tier SAP system. </summary>
    public partial class ThreeTierFullResourceNames : ThreeTierCustomResourceNames
    {
        /// <summary> Initializes a new instance of <see cref="ThreeTierFullResourceNames"/>. </summary>
        public ThreeTierFullResourceNames()
        {
            NamingPatternType = SapNamingPatternType.FullResourceName;
        }

        /// <summary> Initializes a new instance of <see cref="ThreeTierFullResourceNames"/>. </summary>
        /// <param name="namingPatternType"> The pattern type to be used for resource naming. </param>
        /// <param name="centralServer"> The full resource names object for central server layer resources. </param>
        /// <param name="applicationServer"> The full resource names object for application layer resources. The number of entries in this list should be equal to the number VMs to be created for application layer. </param>
        /// <param name="databaseServer"> The full resource names object for database layer resources. The number of entries in this list should be equal to the number VMs to be created for database layer. </param>
        /// <param name="sharedStorage"> The resource names object for shared storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreeTierFullResourceNames(SapNamingPatternType namingPatternType, CentralServerFullResourceNames centralServer, ApplicationServerFullResourceNames applicationServer, DatabaseServerFullResourceNames databaseServer, SharedStorageResourceNames sharedStorage, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(namingPatternType, serializedAdditionalRawData)
        {
            CentralServer = centralServer;
            ApplicationServer = applicationServer;
            DatabaseServer = databaseServer;
            SharedStorage = sharedStorage;
            NamingPatternType = namingPatternType;
        }

        /// <summary> The full resource names object for central server layer resources. </summary>
        public CentralServerFullResourceNames CentralServer { get; set; }
        /// <summary> The full resource names object for application layer resources. The number of entries in this list should be equal to the number VMs to be created for application layer. </summary>
        public ApplicationServerFullResourceNames ApplicationServer { get; set; }
        /// <summary> The full resource names object for database layer resources. The number of entries in this list should be equal to the number VMs to be created for database layer. </summary>
        public DatabaseServerFullResourceNames DatabaseServer { get; set; }
        /// <summary> The resource names object for shared storage. </summary>
        public SharedStorageResourceNames SharedStorage { get; set; }
    }
}
