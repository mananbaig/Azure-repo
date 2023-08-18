// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> SSO details from the Dynatrace partner. </summary>
    public partial class DynatraceSsoDetailsResult
    {
        /// <summary> Initializes a new instance of DynatraceSsoDetailsResult. </summary>
        internal DynatraceSsoDetailsResult()
        {
            AadDomains = new Core.ChangeTrackingList<string>();
            AdminUsers = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DynatraceSsoDetailsResult. </summary>
        /// <param name="isSsoEnabled"> Whether the SSO is enabled for this resource or not. </param>
        /// <param name="metadataUri"> URL for Azure AD metadata. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Dynatrace Environment. </param>
        /// <param name="aadDomains"> array of Aad(azure active directory) domains. </param>
        /// <param name="adminUsers"> Array of admin user emails. </param>
        internal DynatraceSsoDetailsResult(DynatraceSsoStatus? isSsoEnabled, Uri metadataUri, Uri singleSignOnUri, IReadOnlyList<string> aadDomains, IReadOnlyList<string> adminUsers)
        {
            IsSsoEnabled = isSsoEnabled;
            MetadataUri = metadataUri;
            SingleSignOnUri = singleSignOnUri;
            AadDomains = aadDomains;
            AdminUsers = adminUsers;
        }

        /// <summary> Whether the SSO is enabled for this resource or not. </summary>
        public DynatraceSsoStatus? IsSsoEnabled { get; }
        /// <summary> URL for Azure AD metadata. </summary>
        public Uri MetadataUri { get; }
        /// <summary> The login URL specific to this Dynatrace Environment. </summary>
        public Uri SingleSignOnUri { get; }
        /// <summary> array of Aad(azure active directory) domains. </summary>
        public IReadOnlyList<string> AadDomains { get; }
        /// <summary> Array of admin user emails. </summary>
        public IReadOnlyList<string> AdminUsers { get; }
    }
}
