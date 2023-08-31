// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Details about the target where the backup content will be stored. </summary>
    public partial class PostgreSqlFlexibleServerBackupStoreDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupStoreDetails"/>. </summary>
        /// <param name="sasUriList"> List of SAS uri of storage containers where backup data is to be streamed/copied. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUriList"/> is null. </exception>
        public PostgreSqlFlexibleServerBackupStoreDetails(IEnumerable<string> sasUriList)
        {
            Argument.AssertNotNull(sasUriList, nameof(sasUriList));

            SasUriList = sasUriList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupStoreDetails"/>. </summary>
        /// <param name="sasUriList"> List of SAS uri of storage containers where backup data is to be streamed/copied. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerBackupStoreDetails(IList<string> sasUriList, Dictionary<string, BinaryData> rawData)
        {
            SasUriList = sasUriList;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupStoreDetails"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerBackupStoreDetails()
        {
        }

        /// <summary> List of SAS uri of storage containers where backup data is to be streamed/copied. </summary>
        public IList<string> SasUriList { get; }
    }
}
