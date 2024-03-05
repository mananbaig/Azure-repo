// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Notification Parameter contract. </summary>
    public partial class RecipientsContractProperties
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

        /// <summary> Initializes a new instance of <see cref="RecipientsContractProperties"/>. </summary>
        public RecipientsContractProperties()
        {
            Emails = new ChangeTrackingList<string>();
            Users = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RecipientsContractProperties"/>. </summary>
        /// <param name="emails"> List of Emails subscribed for the notification. </param>
        /// <param name="users"> List of Users subscribed for the notification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecipientsContractProperties(IList<string> emails, IList<string> users, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Emails = emails;
            Users = users;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Emails subscribed for the notification. </summary>
        public IList<string> Emails { get; }
        /// <summary> List of Users subscribed for the notification. </summary>
        public IList<string> Users { get; }
    }
}
