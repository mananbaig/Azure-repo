// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> List response for get DataSetMappings. </summary>
    internal partial class DataSetMappingList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataSetMappingList"/>. </summary>
        /// <param name="value">
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="ShareDataSetMappingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AdlsGen2FileDataSetMapping"/>, <see cref="AdlsGen2FileSystemDataSetMapping"/>, <see cref="AdlsGen2FolderDataSetMapping"/>, <see cref="BlobDataSetMapping"/>, <see cref="BlobFolderDataSetMapping"/>, <see cref="BlobContainerDataSetMapping"/>, <see cref="KustoClusterDataSetMapping"/>, <see cref="KustoDatabaseDataSetMapping"/>, <see cref="KustoTableDataSetMapping"/>, <see cref="SqlDBTableDataSetMapping"/>, <see cref="SqlDWTableDataSetMapping"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataSetMappingList(IEnumerable<ShareDataSetMappingData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataSetMappingList"/>. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value">
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="ShareDataSetMappingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AdlsGen2FileDataSetMapping"/>, <see cref="AdlsGen2FileSystemDataSetMapping"/>, <see cref="AdlsGen2FolderDataSetMapping"/>, <see cref="BlobDataSetMapping"/>, <see cref="BlobFolderDataSetMapping"/>, <see cref="BlobContainerDataSetMapping"/>, <see cref="KustoClusterDataSetMapping"/>, <see cref="KustoDatabaseDataSetMapping"/>, <see cref="KustoTableDataSetMapping"/>, <see cref="SqlDBTableDataSetMapping"/>, <see cref="SqlDWTableDataSetMapping"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataSetMappingList(string nextLink, IReadOnlyList<ShareDataSetMappingData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataSetMappingList"/> for deserialization. </summary>
        internal DataSetMappingList()
        {
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="ShareDataSetMappingData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AdlsGen2FileDataSetMapping"/>, <see cref="AdlsGen2FileSystemDataSetMapping"/>, <see cref="AdlsGen2FolderDataSetMapping"/>, <see cref="BlobDataSetMapping"/>, <see cref="BlobFolderDataSetMapping"/>, <see cref="BlobContainerDataSetMapping"/>, <see cref="KustoClusterDataSetMapping"/>, <see cref="KustoDatabaseDataSetMapping"/>, <see cref="KustoTableDataSetMapping"/>, <see cref="SqlDBTableDataSetMapping"/>, <see cref="SqlDWTableDataSetMapping"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSetMapping"/>.
        /// </summary>
        public IReadOnlyList<ShareDataSetMappingData> Value { get; }
    }
}
