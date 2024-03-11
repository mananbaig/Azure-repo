// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of an IoT hub shared access policy. </summary>
    public partial class SharedAccessSignatureAuthorizationRule
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

        /// <summary> Initializes a new instance of <see cref="SharedAccessSignatureAuthorizationRule"/>. </summary>
        /// <param name="keyName"> The name of the shared access policy. </param>
        /// <param name="rights"> The permissions assigned to the shared access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public SharedAccessSignatureAuthorizationRule(string keyName, IotHubSharedAccessRight rights)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
            Rights = rights;
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessSignatureAuthorizationRule"/>. </summary>
        /// <param name="keyName"> The name of the shared access policy. </param>
        /// <param name="primaryKey"> The primary key. </param>
        /// <param name="secondaryKey"> The secondary key. </param>
        /// <param name="rights"> The permissions assigned to the shared access policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedAccessSignatureAuthorizationRule(string keyName, string primaryKey, string secondaryKey, IotHubSharedAccessRight rights, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            Rights = rights;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SharedAccessSignatureAuthorizationRule"/> for deserialization. </summary>
        internal SharedAccessSignatureAuthorizationRule()
        {
        }

        /// <summary> The name of the shared access policy. </summary>
        public string KeyName { get; set; }
        /// <summary> The primary key. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> The secondary key. </summary>
        public string SecondaryKey { get; set; }
        /// <summary> The permissions assigned to the shared access policy. </summary>
        public IotHubSharedAccessRight Rights { get; set; }
    }
}
