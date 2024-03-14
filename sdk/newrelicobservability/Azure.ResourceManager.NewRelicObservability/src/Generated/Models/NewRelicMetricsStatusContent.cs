// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.NewRelicObservability;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Request of get metrics status Operation. </summary>
    public partial class NewRelicMetricsStatusContent
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

        /// <summary> Initializes a new instance of <see cref="NewRelicMetricsStatusContent"/>. </summary>
        /// <param name="userEmail"> User Email. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        public NewRelicMetricsStatusContent(string userEmail)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            AzureResourceIds = new ChangeTrackingList<string>();
            UserEmail = userEmail;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicMetricsStatusContent"/>. </summary>
        /// <param name="azureResourceIds"> Azure resource IDs. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicMetricsStatusContent(IList<string> azureResourceIds, string userEmail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureResourceIds = azureResourceIds;
            UserEmail = userEmail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicMetricsStatusContent"/> for deserialization. </summary>
        internal NewRelicMetricsStatusContent()
        {
        }

        /// <summary> Azure resource IDs. </summary>
        public IList<string> AzureResourceIds { get; }
        /// <summary> User Email. </summary>
        public string UserEmail { get; }
    }
}
