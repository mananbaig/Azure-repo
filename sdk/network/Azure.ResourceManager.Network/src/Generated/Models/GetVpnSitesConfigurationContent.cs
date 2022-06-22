// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of Vpn-Sites. </summary>
    public partial class GetVpnSitesConfigurationContent
    {
        /// <summary> Initializes a new instance of GetVpnSitesConfigurationContent. </summary>
        /// <param name="outputBlobSasUri"> The sas-url to download the configurations for vpn-sites. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outputBlobSasUri"/> is null. </exception>
        public GetVpnSitesConfigurationContent(string outputBlobSasUri)
        {
            if (outputBlobSasUri == null)
            {
                throw new ArgumentNullException(nameof(outputBlobSasUri));
            }

            VpnSites = new ChangeTrackingList<string>();
            OutputBlobSasUri = outputBlobSasUri;
        }

        /// <summary> List of resource-ids of the vpn-sites for which config is to be downloaded. </summary>
        public IList<string> VpnSites { get; }
        /// <summary> The sas-url to download the configurations for vpn-sites. </summary>
        public string OutputBlobSasUri { get; }
    }
}
