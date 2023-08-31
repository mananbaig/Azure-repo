// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Single sign on Info of the NewRelic account. </summary>
    public partial class NewRelicSingleSignOnProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicSingleSignOnProperties"/>. </summary>
        public NewRelicSingleSignOnProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicSingleSignOnProperties"/>. </summary>
        /// <param name="singleSignOnState"> Single sign-on state. </param>
        /// <param name="enterpriseAppId"> The Id of the Enterprise App used for Single sign-on. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this NewRelic Organization. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicSingleSignOnProperties(NewRelicSingleSignOnState? singleSignOnState, string enterpriseAppId, Uri singleSignOnUri, NewRelicProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData)
        {
            SingleSignOnState = singleSignOnState;
            EnterpriseAppId = enterpriseAppId;
            SingleSignOnUri = singleSignOnUri;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Single sign-on state. </summary>
        public NewRelicSingleSignOnState? SingleSignOnState { get; set; }
        /// <summary> The Id of the Enterprise App used for Single sign-on. </summary>
        public string EnterpriseAppId { get; set; }
        /// <summary> The login URL specific to this NewRelic Organization. </summary>
        public Uri SingleSignOnUri { get; set; }
        /// <summary> Provisioning state. </summary>
        public NewRelicProvisioningState? ProvisioningState { get; set; }
    }
}
