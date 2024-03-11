// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a Run Command metadata. </summary>
    public partial class RunCommandDocumentBase
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RunCommandDocumentBase"/>. </summary>
        /// <param name="schema"> The VM run command schema. </param>
        /// <param name="id"> The VM run command id. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="label"> The VM run command label. </param>
        /// <param name="description"> The VM run command description. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schema"/>, <paramref name="id"/>, <paramref name="label"/> or <paramref name="description"/> is null. </exception>
        internal RunCommandDocumentBase(string schema, string id, SupportedOperatingSystemType osType, string label, string description)
        {
            Argument.AssertNotNull(schema, nameof(schema));
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(label, nameof(label));
            Argument.AssertNotNull(description, nameof(description));

            Schema = schema;
            Id = id;
            OSType = osType;
            Label = label;
            Description = description;
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandDocumentBase"/>. </summary>
        /// <param name="schema"> The VM run command schema. </param>
        /// <param name="id"> The VM run command id. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="label"> The VM run command label. </param>
        /// <param name="description"> The VM run command description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunCommandDocumentBase(string schema, string id, SupportedOperatingSystemType osType, string label, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Schema = schema;
            Id = id;
            OSType = osType;
            Label = label;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandDocumentBase"/> for deserialization. </summary>
        internal RunCommandDocumentBase()
        {
        }

        /// <summary> The VM run command schema. </summary>
        public string Schema { get; }
        /// <summary> The VM run command id. </summary>
        public string Id { get; }
        /// <summary> The Operating System type. </summary>
        public SupportedOperatingSystemType OSType { get; }
        /// <summary> The VM run command label. </summary>
        public string Label { get; }
        /// <summary> The VM run command description. </summary>
        public string Description { get; }
    }
}
