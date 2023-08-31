// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The client access policy. </summary>
    public partial class CrossSiteAccessPolicies
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CrossSiteAccessPolicies"/>. </summary>
        public CrossSiteAccessPolicies()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CrossSiteAccessPolicies"/>. </summary>
        /// <param name="clientAccessPolicy"> The content of clientaccesspolicy.xml used by Silverlight. </param>
        /// <param name="crossDomainPolicy"> The content of crossdomain.xml used by Silverlight. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CrossSiteAccessPolicies(string clientAccessPolicy, string crossDomainPolicy, Dictionary<string, BinaryData> rawData)
        {
            ClientAccessPolicy = clientAccessPolicy;
            CrossDomainPolicy = crossDomainPolicy;
            _rawData = rawData;
        }

        /// <summary> The content of clientaccesspolicy.xml used by Silverlight. </summary>
        public string ClientAccessPolicy { get; set; }
        /// <summary> The content of crossdomain.xml used by Silverlight. </summary>
        public string CrossDomainPolicy { get; set; }
    }
}
