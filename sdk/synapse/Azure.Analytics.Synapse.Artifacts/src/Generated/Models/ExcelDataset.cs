// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Excel dataset. </summary>
    public partial class ExcelDataset : Dataset
    {
        /// <summary> Initializes a new instance of <see cref="ExcelDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public ExcelDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            Type = "Excel";
        }

        /// <summary> Initializes a new instance of <see cref="ExcelDataset"/>. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="location">
        /// The location of the excel storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/>, <see cref="LakeHouseLocation"/> and <see cref="SftpLocation"/>.
        /// </param>
        /// <param name="sheetName"> The sheet name of excel file. Type: string (or Expression with resultType string). </param>
        /// <param name="sheetIndex"> The sheet index of excel file and default value is 0. Type: integer (or Expression with resultType integer). </param>
        /// <param name="range"> The partial data of one sheet. Type: string (or Expression with resultType string). </param>
        /// <param name="firstRowAsHeader"> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="compression"> The data compression method used for the json dataset. </param>
        /// <param name="nullValue"> The null value string. Type: string (or Expression with resultType string). </param>
        internal ExcelDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, DatasetLocation location, object sheetName, object sheetIndex, object range, object firstRowAsHeader, DatasetCompression compression, object nullValue) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Location = location;
            SheetName = sheetName;
            SheetIndex = sheetIndex;
            Range = range;
            FirstRowAsHeader = firstRowAsHeader;
            Compression = compression;
            NullValue = nullValue;
            Type = type ?? "Excel";
        }

        /// <summary>
        /// The location of the excel storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/>, <see cref="LakeHouseLocation"/> and <see cref="SftpLocation"/>.
        /// </summary>
        public DatasetLocation Location { get; set; }
        /// <summary> The sheet name of excel file. Type: string (or Expression with resultType string). </summary>
        public object SheetName { get; set; }
        /// <summary> The sheet index of excel file and default value is 0. Type: integer (or Expression with resultType integer). </summary>
        public object SheetIndex { get; set; }
        /// <summary> The partial data of one sheet. Type: string (or Expression with resultType string). </summary>
        public object Range { get; set; }
        /// <summary> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object FirstRowAsHeader { get; set; }
        /// <summary> The data compression method used for the json dataset. </summary>
        public DatasetCompression Compression { get; set; }
        /// <summary> The null value string. Type: string (or Expression with resultType string). </summary>
        public object NullValue { get; set; }
    }
}
