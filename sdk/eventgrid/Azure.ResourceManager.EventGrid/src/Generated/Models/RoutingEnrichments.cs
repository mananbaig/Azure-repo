// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The RoutingEnrichments. </summary>
    public partial class RoutingEnrichments
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

        /// <summary> Initializes a new instance of <see cref="RoutingEnrichments"/>. </summary>
        public RoutingEnrichments()
        {
            Static = new ChangeTrackingList<StaticRoutingEnrichment>();
            Dynamic = new ChangeTrackingList<DynamicRoutingEnrichment>();
        }

        /// <summary> Initializes a new instance of <see cref="RoutingEnrichments"/>. </summary>
        /// <param name="static"></param>
        /// <param name="dynamic"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingEnrichments(IList<StaticRoutingEnrichment> @static, IList<DynamicRoutingEnrichment> @dynamic, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Static = @static;
            Dynamic = @dynamic;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the static. </summary>
        public IList<StaticRoutingEnrichment> Static { get; }
        /// <summary> Gets the dynamic. </summary>
        public IList<DynamicRoutingEnrichment> Dynamic { get; }
    }
}
