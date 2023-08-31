// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> LDAP search scope. </summary>
    public partial class NetAppLdapSearchScopeConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppLdapSearchScopeConfiguration"/>. </summary>
        public NetAppLdapSearchScopeConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppLdapSearchScopeConfiguration"/>. </summary>
        /// <param name="userDN"> This specifies the user DN, which overrides the base DN for user lookups. </param>
        /// <param name="groupDN"> This specifies the group DN, which overrides the base DN for group lookups. </param>
        /// <param name="groupMembershipFilter"> This specifies the custom LDAP search filter to be used when looking up group membership from LDAP server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppLdapSearchScopeConfiguration(string userDN, string groupDN, string groupMembershipFilter, Dictionary<string, BinaryData> rawData)
        {
            UserDN = userDN;
            GroupDN = groupDN;
            GroupMembershipFilter = groupMembershipFilter;
            _rawData = rawData;
        }

        /// <summary> This specifies the user DN, which overrides the base DN for user lookups. </summary>
        public string UserDN { get; set; }
        /// <summary> This specifies the group DN, which overrides the base DN for group lookups. </summary>
        public string GroupDN { get; set; }
        /// <summary> This specifies the custom LDAP search filter to be used when looking up group membership from LDAP server. </summary>
        public string GroupMembershipFilter { get; set; }
    }
}
