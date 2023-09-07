// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Request body to build a new custom document model. </summary>
    internal partial class BuildDocumentModelRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BuildDocumentModelRequest"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="buildMode"> Custom document model build mode. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public BuildDocumentModelRequest(string modelId, DocumentBuildMode buildMode)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
            BuildMode = buildMode;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentModelRequest"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="description"> Document model description. </param>
        /// <param name="buildMode"> Custom document model build mode. </param>
        /// <param name="azureBlobSource"> Azure Blob Storage location containing the training data.  Either azureBlobSource or azureBlobFileListSource must be specified. </param>
        /// <param name="azureBlobFileListSource"> Azure Blob Storage file list specifying the training data.  Either azureBlobSource or azureBlobFileListSource must be specified. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildDocumentModelRequest(string modelId, string description, DocumentBuildMode buildMode, BlobContentSource azureBlobSource, BlobFileListContentSource azureBlobFileListSource, IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            Description = description;
            BuildMode = buildMode;
            AzureBlobSource = azureBlobSource;
            AzureBlobFileListSource = azureBlobFileListSource;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentModelRequest"/> for deserialization. </summary>
        internal BuildDocumentModelRequest()
        {
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
        /// <summary> Document model description. </summary>
        public string Description { get; set; }
        /// <summary> Custom document model build mode. </summary>
        public DocumentBuildMode BuildMode { get; }
        /// <summary> Azure Blob Storage location containing the training data.  Either azureBlobSource or azureBlobFileListSource must be specified. </summary>
        public BlobContentSource AzureBlobSource { get; set; }
        /// <summary> Azure Blob Storage file list specifying the training data.  Either azureBlobSource or azureBlobFileListSource must be specified. </summary>
        public BlobFileListContentSource AzureBlobFileListSource { get; set; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
