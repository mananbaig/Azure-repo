// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Single resource Id's metadata. </summary>
    public partial class ResourceMetadata
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

        /// <summary> Initializes a new instance of <see cref="ResourceMetadata"/>. </summary>
        /// <param name="resourceId"> Resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public ResourceMetadata(string resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceMetadata"/>. </summary>
        /// <param name="resourceId"> Resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1". </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceKind"> Resource kind. </param>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="tags"> Resource's tag type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceMetadata(string resourceId, string resourceType, string resourceKind, string resourceName, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            ResourceType = resourceType;
            ResourceKind = resourceKind;
            ResourceName = resourceName;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceMetadata"/> for deserialization. </summary>
        internal ResourceMetadata()
        {
        }

        /// <summary> Resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1". </summary>
        public string ResourceId { get; set; }
        /// <summary> Resource type. </summary>
        public string ResourceType { get; set; }
        /// <summary> Resource kind. </summary>
        public string ResourceKind { get; set; }
        /// <summary> Resource name. </summary>
        public string ResourceName { get; set; }
        /// <summary> Resource's tag type. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
