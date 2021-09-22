// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataLakeGen2SharedKeyCredentialPatch. </summary>
    internal partial class DataLakeGen2SharedKeyCredentialPatch : DataSourceCredentialPatch
    {
        /// <summary> Initializes a new instance of DataLakeGen2SharedKeyCredentialPatch. </summary>
        public DataLakeGen2SharedKeyCredentialPatch()
        {
            DataSourceCredentialType = DataSourceCredentialKind.DataLakeSharedKey;
        }

        /// <summary> Gets or sets the parameters. </summary>
        public DataLakeGen2SharedKeyParamPatch Parameters { get; set; }
    }
}
