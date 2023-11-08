// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Operation status REST resource. </summary>
    public partial class MoverOperationStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoverOperationStatus"/>. </summary>
        internal MoverOperationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MoverOperationStatus"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Operation name. </param>
        /// <param name="status"> Status of the operation. ARM expects the terminal status to be one of Succeeded/ Failed/ Canceled. All other values imply that the operation is still running. </param>
        /// <param name="startOn"> Start time. </param>
        /// <param name="endOn"> End time. </param>
        /// <param name="error"> Error stating all error details for the operation. </param>
        /// <param name="properties"> Custom data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverOperationStatus(ResourceIdentifier id, string name, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, MoverOperationStatusError error, BinaryData properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            Error = error;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Operation name. </summary>
        public string Name { get; }
        /// <summary> Status of the operation. ARM expects the terminal status to be one of Succeeded/ Failed/ Canceled. All other values imply that the operation is still running. </summary>
        public string Status { get; }
        /// <summary> Start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Error stating all error details for the operation. </summary>
        public MoverOperationStatusError Error { get; }
        /// <summary>
        /// Custom data.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Properties { get; }
    }
}
