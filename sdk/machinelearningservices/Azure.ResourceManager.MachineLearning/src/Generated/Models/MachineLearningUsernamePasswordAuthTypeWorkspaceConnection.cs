// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningUsernamePasswordAuthTypeWorkspaceConnection. </summary>
    public partial class MachineLearningUsernamePasswordAuthTypeWorkspaceConnection : MachineLearningWorkspaceConnectionProperties
    {
        /// <summary> Initializes a new instance of MachineLearningUsernamePasswordAuthTypeWorkspaceConnection. </summary>
        public MachineLearningUsernamePasswordAuthTypeWorkspaceConnection()
        {
            AuthType = MachineLearningConnectionAuthType.UsernamePassword;
        }

        /// <summary> Initializes a new instance of MachineLearningUsernamePasswordAuthTypeWorkspaceConnection. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="expiryOn"></param>
        /// <param name="metadata"> Any object. </param>
        /// <param name="target"></param>
        /// <param name="credentials"></param>
        internal MachineLearningUsernamePasswordAuthTypeWorkspaceConnection(MachineLearningConnectionAuthType authType, MachineLearningConnectionCategory? category, DateTimeOffset? expiryOn, BinaryData metadata, string target, MachineLearningWorkspaceConnectionUsernamePassword credentials) : base(authType, category, expiryOn, metadata, target)
        {
            Credentials = credentials;
            AuthType = authType;
        }

        /// <summary> Gets or sets the credentials. </summary>
        public MachineLearningWorkspaceConnectionUsernamePassword Credentials { get; set; }
    }
}
