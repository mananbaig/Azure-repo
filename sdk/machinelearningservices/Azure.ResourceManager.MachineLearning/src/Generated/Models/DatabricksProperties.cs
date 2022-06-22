// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Properties of Databricks. </summary>
    public partial class DatabricksProperties
    {
        /// <summary> Initializes a new instance of DatabricksProperties. </summary>
        public DatabricksProperties()
        {
        }

        /// <summary> Initializes a new instance of DatabricksProperties. </summary>
        /// <param name="databricksAccessToken"> Databricks access token. </param>
        /// <param name="workspaceUri"> Workspace Url. </param>
        internal DatabricksProperties(string databricksAccessToken, string workspaceUri)
        {
            DatabricksAccessToken = databricksAccessToken;
            WorkspaceUri = workspaceUri;
        }

        /// <summary> Databricks access token. </summary>
        public string DatabricksAccessToken { get; set; }
        /// <summary> Workspace Url. </summary>
        public string WorkspaceUri { get; set; }
    }
}
