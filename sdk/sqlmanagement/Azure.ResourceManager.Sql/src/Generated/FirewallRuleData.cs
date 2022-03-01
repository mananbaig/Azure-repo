// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the FirewallRule data model. </summary>
    public partial class FirewallRuleData : ProxyResourceWithWritableName
    {
        /// <summary> Initializes a new instance of FirewallRuleData. </summary>
        public FirewallRuleData()
        {
        }

        /// <summary> Initializes a new instance of FirewallRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="startIPAddress"> The start IP address of the firewall rule. Must be IPv4 format. Use value &apos;0.0.0.0&apos; for all Azure-internal IP addresses. </param>
        /// <param name="endIPAddress"> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. Use value &apos;0.0.0.0&apos; for all Azure-internal IP addresses. </param>
        internal FirewallRuleData(string id, string name, string type, string startIPAddress, string endIPAddress) : base(id, name, type)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> The start IP address of the firewall rule. Must be IPv4 format. Use value &apos;0.0.0.0&apos; for all Azure-internal IP addresses. </summary>
        public string StartIPAddress { get; set; }
        /// <summary> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. Use value &apos;0.0.0.0&apos; for all Azure-internal IP addresses. </summary>
        public string EndIPAddress { get; set; }
    }
}
