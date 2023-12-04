// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Policy governing how jobs are distributed to workers. </summary>
    public partial class DistributionPolicy
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

        /// <summary> Initializes a new instance of <see cref="DistributionPolicy"/>. </summary>
        internal DistributionPolicy()
        {
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DistributionPolicy"/>. </summary>
        /// <param name="etag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a distribution policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="offerExpiresAfterSeconds"> Number of seconds after which any offers created under this policy will be expired. </param>
        /// <param name="mode"> Mode governing the specific distribution method. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DistributionPolicy(string etag, string id, string name, double? offerExpiresAfterSeconds, DistributionMode mode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            _etag = etag;
            Id = id;
            Name = name;
            _offerExpiresAfterSeconds = offerExpiresAfterSeconds;
            Mode = mode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Id of a distribution policy. </summary>
        public string Id { get; }
    }
}
