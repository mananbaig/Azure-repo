// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Dynatrace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A class representing the DynatraceSingleSignOn data model.
    /// Single sign-on configurations for a given monitor resource.
    /// </summary>
    public partial class DynatraceSingleSignOnData : ResourceData
    {
        /// <summary> Initializes a new instance of DynatraceSingleSignOnData. </summary>
        public DynatraceSingleSignOnData()
        {
            AadDomains = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DynatraceSingleSignOnData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="singleSignOnState"> State of Single Sign On. </param>
        /// <param name="enterpriseAppId"> Version of the Dynatrace agent installed on the VM. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Dynatrace Environment. </param>
        /// <param name="aadDomains"> array of Aad(azure active directory) domains. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        internal DynatraceSingleSignOnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DynatraceSingleSignOnState? singleSignOnState, Guid? enterpriseAppId, Uri singleSignOnUri, IList<string> aadDomains, DynatraceProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            SingleSignOnState = singleSignOnState;
            EnterpriseAppId = enterpriseAppId;
            SingleSignOnUri = singleSignOnUri;
            AadDomains = aadDomains;
            ProvisioningState = provisioningState;
        }

        /// <summary> State of Single Sign On. </summary>
        public DynatraceSingleSignOnState? SingleSignOnState { get; set; }
        /// <summary> Version of the Dynatrace agent installed on the VM. </summary>
        public Guid? EnterpriseAppId { get; set; }
        /// <summary> The login URL specific to this Dynatrace Environment. </summary>
        public Uri SingleSignOnUri { get; set; }
        /// <summary> array of Aad(azure active directory) domains. </summary>
        public IList<string> AadDomains { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public DynatraceProvisioningState? ProvisioningState { get; }
    }
}
