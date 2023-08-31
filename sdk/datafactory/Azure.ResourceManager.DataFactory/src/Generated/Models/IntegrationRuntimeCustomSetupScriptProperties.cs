// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Custom setup script properties for a managed dedicated integration runtime. </summary>
    public partial class IntegrationRuntimeCustomSetupScriptProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeCustomSetupScriptProperties"/>. </summary>
        public IntegrationRuntimeCustomSetupScriptProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeCustomSetupScriptProperties"/>. </summary>
        /// <param name="blobContainerUri"> The URI of the Azure blob container that contains the custom setup script. </param>
        /// <param name="sasToken"> The SAS token of the Azure blob container. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationRuntimeCustomSetupScriptProperties(Uri blobContainerUri, DataFactorySecretString sasToken, Dictionary<string, BinaryData> rawData)
        {
            BlobContainerUri = blobContainerUri;
            SasToken = sasToken;
            _rawData = rawData;
        }

        /// <summary> The URI of the Azure blob container that contains the custom setup script. </summary>
        public Uri BlobContainerUri { get; set; }
        /// <summary> The SAS token of the Azure blob container. </summary>
        public DataFactorySecretString SasToken { get; set; }
    }
}
