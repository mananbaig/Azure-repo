// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster Instance View. </summary>
    public partial class ClusterInstanceViewResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClusterInstanceViewResult"/>. </summary>
        /// <param name="name"> Name of the instance view. </param>
        /// <param name="properties"> Properties of the instance view. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal ClusterInstanceViewResult(string name, ClusterInstanceViewProperties properties)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(properties, nameof(properties));

            Name = name;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterInstanceViewResult"/>. </summary>
        /// <param name="name"> Name of the instance view. </param>
        /// <param name="properties"> Properties of the instance view. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterInstanceViewResult(string name, ClusterInstanceViewProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterInstanceViewResult"/> for deserialization. </summary>
        internal ClusterInstanceViewResult()
        {
        }

        /// <summary> Name of the instance view. </summary>
        public string Name { get; }
        /// <summary> Properties of the instance view. </summary>
        public ClusterInstanceViewProperties Properties { get; }
    }
}
