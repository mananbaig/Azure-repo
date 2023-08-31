// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The complete operation. </summary>
    public partial class ConnectorMappingCompleteOperation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingCompleteOperation"/>. </summary>
        public ConnectorMappingCompleteOperation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingCompleteOperation"/>. </summary>
        /// <param name="completionOperationType"> The type of completion operation. </param>
        /// <param name="destinationFolder"> The destination folder where files will be moved to once the import is done. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectorMappingCompleteOperation(CompletionOperationType? completionOperationType, string destinationFolder, Dictionary<string, BinaryData> rawData)
        {
            CompletionOperationType = completionOperationType;
            DestinationFolder = destinationFolder;
            _rawData = rawData;
        }

        /// <summary> The type of completion operation. </summary>
        public CompletionOperationType? CompletionOperationType { get; set; }
        /// <summary> The destination folder where files will be moved to once the import is done. </summary>
        public string DestinationFolder { get; set; }
    }
}
