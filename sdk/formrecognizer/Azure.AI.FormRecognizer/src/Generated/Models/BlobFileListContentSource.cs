// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> File list in Azure Blob Storage. </summary>
    public partial class BlobFileListContentSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobFileListContentSource"/>. </summary>
        /// <param name="containerUri"> Azure Blob Storage container URL. </param>
        /// <param name="fileList"> Path to a JSONL file within the container specifying a subset of documents for training. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobFileListContentSource(Uri containerUri, string fileList, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContainerUri = containerUri;
            FileList = fileList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobFileListContentSource"/> for deserialization. </summary>
        internal BlobFileListContentSource()
        {
        }
    }
}
