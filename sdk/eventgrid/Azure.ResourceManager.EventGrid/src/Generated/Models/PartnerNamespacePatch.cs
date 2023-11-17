// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Partner Namespace update. </summary>
    public partial class PartnerNamespacePatch
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

        /// <summary> Initializes a new instance of <see cref="PartnerNamespacePatch"/>. </summary>
        public PartnerNamespacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="PartnerNamespacePatch"/>. </summary>
        /// <param name="tags"> Tags of the Partner Namespace. </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PartnerNamespaceUpdateParameterProperties.InboundIpRules" /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="minimumTlsVersionAllowed"> Minimum TLS version of the publisher allowed to publish to this domain. </param>
        /// <param name="isLocalAuthDisabled"> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the partner namespace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PartnerNamespacePatch(IDictionary<string, string> tags, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, TlsVersion? minimumTlsVersionAllowed, bool? isLocalAuthDisabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            MinimumTlsVersionAllowed = minimumTlsVersionAllowed;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tags of the Partner Namespace. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.PartnerNamespaceUpdateParameterProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> Minimum TLS version of the publisher allowed to publish to this domain. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the partner namespace. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
    }
}
