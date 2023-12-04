// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Changeable attributes. </summary>
    internal partial class TagWriteableProperties
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

        /// <summary> Initializes a new instance of <see cref="TagWriteableProperties"/>. </summary>
        public TagWriteableProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TagWriteableProperties"/>. </summary>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TagWriteableProperties(bool? canDelete, bool? canWrite, bool? canList, bool? canRead, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Delete enabled. </summary>
        public bool? CanDelete { get; set; }
        /// <summary> Write enabled. </summary>
        public bool? CanWrite { get; set; }
        /// <summary> List enabled. </summary>
        public bool? CanList { get; set; }
        /// <summary> Read enabled. </summary>
        public bool? CanRead { get; set; }
    }
}
