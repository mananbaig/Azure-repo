// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The compression method used on a dataset. </summary>
    public partial class DatasetCompression
    {
        /// <summary> Initializes a new instance of <see cref="DatasetCompression"/>. </summary>
        /// <param name="datasetCompressionType"> Type of dataset compression. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasetCompressionType"/> is null. </exception>
        public DatasetCompression(DataFactoryElement<string> datasetCompressionType)
        {
            Argument.AssertNotNull(datasetCompressionType, nameof(datasetCompressionType));

            DatasetCompressionType = datasetCompressionType;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetCompression"/>. </summary>
        /// <param name="datasetCompressionType"> Type of dataset compression. Type: string (or Expression with resultType string). </param>
        /// <param name="level"> The dataset compression level. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DatasetCompression(DataFactoryElement<string> datasetCompressionType, DataFactoryElement<string> level, IDictionary<string, BinaryData> additionalProperties)
        {
            DatasetCompressionType = datasetCompressionType;
            Level = level;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DatasetCompression"/> for deserialization. </summary>
        internal DatasetCompression()
        {
        }

        /// <summary> Type of dataset compression. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DatasetCompressionType { get; set; }
        /// <summary> The dataset compression level. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Level { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
