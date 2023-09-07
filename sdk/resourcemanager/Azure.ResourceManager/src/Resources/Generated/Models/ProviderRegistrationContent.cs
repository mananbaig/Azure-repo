// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The provider registration definition. </summary>
    public partial class ProviderRegistrationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationContent"/>. </summary>
        public ProviderRegistrationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationContent"/>. </summary>
        /// <param name="thirdPartyProviderConsent"> The provider consent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderRegistrationContent(ProviderConsentDefinition thirdPartyProviderConsent, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ThirdPartyProviderConsent = thirdPartyProviderConsent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provider consent. </summary>
        internal ProviderConsentDefinition ThirdPartyProviderConsent { get; set; }
        /// <summary> A value indicating whether authorization is consented or not. </summary>
        public bool? ConsentToAuthorization
        {
            get => ThirdPartyProviderConsent is null ? default : ThirdPartyProviderConsent.ConsentToAuthorization;
            set
            {
                if (ThirdPartyProviderConsent is null)
                    ThirdPartyProviderConsent = new ProviderConsentDefinition();
                ThirdPartyProviderConsent.ConsentToAuthorization = value;
            }
        }
    }
}
