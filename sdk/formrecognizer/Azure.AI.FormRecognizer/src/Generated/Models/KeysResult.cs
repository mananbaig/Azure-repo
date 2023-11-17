// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Keys extracted by the custom model. </summary>
    internal partial class KeysResult
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

        /// <summary> Initializes a new instance of <see cref="KeysResult"/>. </summary>
        /// <param name="clusters"> Object mapping clusterIds to a list of keys. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusters"/> is null. </exception>
        internal KeysResult(IReadOnlyDictionary<string, IList<string>> clusters)
        {
            Argument.AssertNotNull(clusters, nameof(clusters));

            Clusters = clusters;
        }

        /// <summary> Initializes a new instance of <see cref="KeysResult"/>. </summary>
        /// <param name="clusters"> Object mapping clusterIds to a list of keys. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeysResult(IReadOnlyDictionary<string, IList<string>> clusters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Clusters = clusters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeysResult"/> for deserialization. </summary>
        internal KeysResult()
        {
        }

        /// <summary> Object mapping clusterIds to a list of keys. </summary>
        public IReadOnlyDictionary<string, IList<string>> Clusters { get; }
    }
}
