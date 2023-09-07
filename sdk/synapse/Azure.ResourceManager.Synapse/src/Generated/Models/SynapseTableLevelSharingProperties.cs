// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Tables that will be included and excluded in the follower database. </summary>
    public partial class SynapseTableLevelSharingProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseTableLevelSharingProperties"/>. </summary>
        public SynapseTableLevelSharingProperties()
        {
            TablesToInclude = new ChangeTrackingList<string>();
            TablesToExclude = new ChangeTrackingList<string>();
            ExternalTablesToInclude = new ChangeTrackingList<string>();
            ExternalTablesToExclude = new ChangeTrackingList<string>();
            MaterializedViewsToInclude = new ChangeTrackingList<string>();
            MaterializedViewsToExclude = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseTableLevelSharingProperties"/>. </summary>
        /// <param name="tablesToInclude"> List of tables to include in the follower database. </param>
        /// <param name="tablesToExclude"> List of tables to exclude from the follower database. </param>
        /// <param name="externalTablesToInclude"> List of external tables to include in the follower database. </param>
        /// <param name="externalTablesToExclude"> List of external tables exclude from the follower database. </param>
        /// <param name="materializedViewsToInclude"> List of materialized views to include in the follower database. </param>
        /// <param name="materializedViewsToExclude"> List of materialized views exclude from the follower database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseTableLevelSharingProperties(IList<string> tablesToInclude, IList<string> tablesToExclude, IList<string> externalTablesToInclude, IList<string> externalTablesToExclude, IList<string> materializedViewsToInclude, IList<string> materializedViewsToExclude, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TablesToInclude = tablesToInclude;
            TablesToExclude = tablesToExclude;
            ExternalTablesToInclude = externalTablesToInclude;
            ExternalTablesToExclude = externalTablesToExclude;
            MaterializedViewsToInclude = materializedViewsToInclude;
            MaterializedViewsToExclude = materializedViewsToExclude;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of tables to include in the follower database. </summary>
        public IList<string> TablesToInclude { get; }
        /// <summary> List of tables to exclude from the follower database. </summary>
        public IList<string> TablesToExclude { get; }
        /// <summary> List of external tables to include in the follower database. </summary>
        public IList<string> ExternalTablesToInclude { get; }
        /// <summary> List of external tables exclude from the follower database. </summary>
        public IList<string> ExternalTablesToExclude { get; }
        /// <summary> List of materialized views to include in the follower database. </summary>
        public IList<string> MaterializedViewsToInclude { get; }
        /// <summary> List of materialized views exclude from the follower database. </summary>
        public IList<string> MaterializedViewsToExclude { get; }
    }
}
