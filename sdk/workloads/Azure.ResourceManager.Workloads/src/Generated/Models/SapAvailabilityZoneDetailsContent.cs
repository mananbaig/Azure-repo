// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP request to get list of availability zones. </summary>
    public partial class SapAvailabilityZoneDetailsContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZoneDetailsContent"/>. </summary>
        /// <param name="appLocation"> The geo-location where the SAP resources will be created. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="databaseType"> The database type. Eg: HANA, DB2, etc. </param>
        public SapAvailabilityZoneDetailsContent(AzureLocation appLocation, SapProductType sapProduct, SapDatabaseType databaseType)
        {
            AppLocation = appLocation;
            SapProduct = sapProduct;
            DatabaseType = databaseType;
        }

        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZoneDetailsContent"/>. </summary>
        /// <param name="appLocation"> The geo-location where the SAP resources will be created. </param>
        /// <param name="sapProduct"> Defines the SAP Product type. </param>
        /// <param name="databaseType"> The database type. Eg: HANA, DB2, etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapAvailabilityZoneDetailsContent(AzureLocation appLocation, SapProductType sapProduct, SapDatabaseType databaseType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppLocation = appLocation;
            SapProduct = sapProduct;
            DatabaseType = databaseType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZoneDetailsContent"/> for deserialization. </summary>
        internal SapAvailabilityZoneDetailsContent()
        {
        }

        /// <summary> The geo-location where the SAP resources will be created. </summary>
        public AzureLocation AppLocation { get; }
        /// <summary> Defines the SAP Product type. </summary>
        public SapProductType SapProduct { get; }
        /// <summary> The database type. Eg: HANA, DB2, etc. </summary>
        public SapDatabaseType DatabaseType { get; }
    }
}
