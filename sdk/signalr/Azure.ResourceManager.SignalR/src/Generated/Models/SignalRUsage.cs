// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Object that describes a specific usage of the resources. </summary>
    public partial class SignalRUsage
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

        /// <summary> Initializes a new instance of <see cref="SignalRUsage"/>. </summary>
        internal SignalRUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRUsage"/>. </summary>
        /// <param name="id"> Fully qualified ARM resource id. </param>
        /// <param name="currentValue"> Current value for the usage quota. </param>
        /// <param name="limit"> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </param>
        /// <param name="name"> Localizable String object containing the name and a localized value. </param>
        /// <param name="unit"> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRUsage(ResourceIdentifier id, long? currentValue, long? limit, SignalRUsageName name, string unit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            Unit = unit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fully qualified ARM resource id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Current value for the usage quota. </summary>
        public long? CurrentValue { get; }
        /// <summary> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </summary>
        public long? Limit { get; }
        /// <summary> Localizable String object containing the name and a localized value. </summary>
        public SignalRUsageName Name { get; }
        /// <summary> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </summary>
        public string Unit { get; }
    }
}
