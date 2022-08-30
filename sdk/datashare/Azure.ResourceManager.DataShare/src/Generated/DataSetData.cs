// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the DataSet data model.
    /// Please note <see cref="DataSetData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AdlsGen1FileDataSet"/>, <see cref="AdlsGen1FolderDataSet"/>, <see cref="AdlsGen2FileDataSet"/>, <see cref="AdlsGen2FileSystemDataSet"/>, <see cref="AdlsGen2FolderDataSet"/>, <see cref="BlobDataSet"/>, <see cref="BlobFolderDataSet"/>, <see cref="BlobContainerDataSet"/>, <see cref="KustoClusterDataSet"/>, <see cref="KustoDatabaseDataSet"/>, <see cref="KustoTableDataSet"/>, <see cref="SqlDBTableDataSet"/>, <see cref="SqlDWTableDataSet"/> and <see cref="SynapseWorkspaceSqlPoolTableDataSet"/>.
    /// </summary>
    public partial class DataSetData : ResourceData
    {
        /// <summary> Initializes a new instance of DataSetData. </summary>
        public DataSetData()
        {
        }

        /// <summary> Initializes a new instance of DataSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        internal DataSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Kind of data set. </summary>
        internal DataSetKind Kind { get; set; }
    }
}
