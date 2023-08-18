// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Table level sharing properties dto for kusto data set properties. </summary>
    public partial class TableLevelSharingProperties
    {
        /// <summary> Initializes a new instance of TableLevelSharingProperties. </summary>
        public TableLevelSharingProperties()
        {
            ExternalTablesToExclude = new Core.ChangeTrackingList<string>();
            ExternalTablesToInclude = new Core.ChangeTrackingList<string>();
            MaterializedViewsToExclude = new Core.ChangeTrackingList<string>();
            MaterializedViewsToInclude = new Core.ChangeTrackingList<string>();
            TablesToExclude = new Core.ChangeTrackingList<string>();
            TablesToInclude = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of TableLevelSharingProperties. </summary>
        /// <param name="externalTablesToExclude"> External tables to be excluded in the data set. </param>
        /// <param name="externalTablesToInclude"> External tables to be included in the data set. </param>
        /// <param name="materializedViewsToExclude"> Materialized views to be excluded in the data set. </param>
        /// <param name="materializedViewsToInclude"> Materialized views to be included in the data set. </param>
        /// <param name="tablesToExclude"> Tables to be excluded in the data set. </param>
        /// <param name="tablesToInclude"> Tables to be included in the data set. </param>
        internal TableLevelSharingProperties(IList<string> externalTablesToExclude, IList<string> externalTablesToInclude, IList<string> materializedViewsToExclude, IList<string> materializedViewsToInclude, IList<string> tablesToExclude, IList<string> tablesToInclude)
        {
            ExternalTablesToExclude = externalTablesToExclude;
            ExternalTablesToInclude = externalTablesToInclude;
            MaterializedViewsToExclude = materializedViewsToExclude;
            MaterializedViewsToInclude = materializedViewsToInclude;
            TablesToExclude = tablesToExclude;
            TablesToInclude = tablesToInclude;
        }

        /// <summary> External tables to be excluded in the data set. </summary>
        public IList<string> ExternalTablesToExclude { get; }
        /// <summary> External tables to be included in the data set. </summary>
        public IList<string> ExternalTablesToInclude { get; }
        /// <summary> Materialized views to be excluded in the data set. </summary>
        public IList<string> MaterializedViewsToExclude { get; }
        /// <summary> Materialized views to be included in the data set. </summary>
        public IList<string> MaterializedViewsToInclude { get; }
        /// <summary> Tables to be excluded in the data set. </summary>
        public IList<string> TablesToExclude { get; }
        /// <summary> Tables to be included in the data set. </summary>
        public IList<string> TablesToInclude { get; }
    }
}
