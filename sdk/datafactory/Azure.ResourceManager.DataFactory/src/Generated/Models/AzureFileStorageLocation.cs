// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The location of file server dataset. </summary>
    public partial class AzureFileStorageLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of AzureFileStorageLocation. </summary>
        public AzureFileStorageLocation()
        {
            DatasetLocationType = "AzureFileStorageLocation";
        }

        /// <summary> Initializes a new instance of AzureFileStorageLocation. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal AzureFileStorageLocation(string datasetLocationType, BinaryData folderPath, BinaryData fileName, IDictionary<string, BinaryData> additionalProperties) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            DatasetLocationType = datasetLocationType ?? "AzureFileStorageLocation";
        }
    }
}
