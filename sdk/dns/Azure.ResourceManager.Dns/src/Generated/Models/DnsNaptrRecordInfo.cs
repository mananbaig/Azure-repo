// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> A NAPTR record. For more information about the NAPTR record format, see RFC 3403: https://www.rfc-editor.org/rfc/rfc3403. </summary>
    public partial class DnsNaptrRecordInfo
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

        /// <summary> Initializes a new instance of <see cref="DnsNaptrRecordInfo"/>. </summary>
        public DnsNaptrRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DnsNaptrRecordInfo"/>. </summary>
        /// <param name="order"> The order in which the NAPTR records MUST be processed in order to accurately represent the ordered list of rules. The ordering is from lowest to highest. Valid values: 0-65535. </param>
        /// <param name="preference"> The preference specifies the order in which NAPTR records with equal 'order' values should be processed, low numbers being processed before high numbers. Valid values: 0-65535. </param>
        /// <param name="flags"> The flags specific to DDDS applications. Values currently defined in RFC 3404 are uppercase and lowercase letters "A", "P", "S", and "U", and the empty string, "". Enclose Flags in quotation marks. </param>
        /// <param name="services"> The services specific to DDDS applications. Enclose Services in quotation marks. </param>
        /// <param name="regexp"> The regular expression that the DDDS application uses to convert an input value into an output value. For example: an IP phone system might use a regular expression to convert a phone number that is entered by a user into a SIP URI. Enclose the regular expression in quotation marks. Specify either a value for 'regexp' or a value for 'replacement'. </param>
        /// <param name="replacement"> The replacement is a fully qualified domain name (FQDN) of the next domain name that you want the DDDS application to submit a DNS query for. The DDDS application replaces the input value with the value specified for replacement. Specify either a value for 'regexp' or a value for 'replacement'. If you specify a value for 'regexp', specify a dot (.) for 'replacement'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsNaptrRecordInfo(int? order, int? preference, string flags, string services, string regexp, string replacement, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Order = order;
            Preference = preference;
            Flags = flags;
            Services = services;
            Regexp = regexp;
            Replacement = replacement;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The order in which the NAPTR records MUST be processed in order to accurately represent the ordered list of rules. The ordering is from lowest to highest. Valid values: 0-65535. </summary>
        public int? Order { get; set; }
        /// <summary> The preference specifies the order in which NAPTR records with equal 'order' values should be processed, low numbers being processed before high numbers. Valid values: 0-65535. </summary>
        public int? Preference { get; set; }
        /// <summary> The flags specific to DDDS applications. Values currently defined in RFC 3404 are uppercase and lowercase letters "A", "P", "S", and "U", and the empty string, "". Enclose Flags in quotation marks. </summary>
        public string Flags { get; set; }
        /// <summary> The services specific to DDDS applications. Enclose Services in quotation marks. </summary>
        public string Services { get; set; }
        /// <summary> The regular expression that the DDDS application uses to convert an input value into an output value. For example: an IP phone system might use a regular expression to convert a phone number that is entered by a user into a SIP URI. Enclose the regular expression in quotation marks. Specify either a value for 'regexp' or a value for 'replacement'. </summary>
        public string Regexp { get; set; }
        /// <summary> The replacement is a fully qualified domain name (FQDN) of the next domain name that you want the DDDS application to submit a DNS query for. The DDDS application replaces the input value with the value specified for replacement. Specify either a value for 'regexp' or a value for 'replacement'. If you specify a value for 'regexp', specify a dot (.) for 'replacement'. </summary>
        public string Replacement { get; set; }
    }
}
