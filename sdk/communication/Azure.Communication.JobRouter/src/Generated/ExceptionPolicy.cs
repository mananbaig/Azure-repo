// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.Communication.JobRouter
{
    /// <summary> A policy that defines actions to execute when exception are triggered. </summary>
    public partial class ExceptionPolicy
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

        /// <summary> Initializes a new instance of <see cref="ExceptionPolicy"/>. </summary>
        public ExceptionPolicy()
        {
            ExceptionRules = new ChangeTrackingList<ExceptionRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ExceptionPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of an exception policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="exceptionRules"> A collection of exception rules on the exception policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExceptionPolicy(ETag eTag, string id, string name, IList<ExceptionRule> exceptionRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ETag = eTag;
            Id = id;
            Name = name;
            ExceptionRules = exceptionRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Id of an exception policy. </summary>
        public string Id { get; }
    }
}
