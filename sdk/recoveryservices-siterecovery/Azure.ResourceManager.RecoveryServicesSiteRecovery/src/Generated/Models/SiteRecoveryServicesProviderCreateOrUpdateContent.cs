// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input required to add a provider. </summary>
    public partial class SiteRecoveryServicesProviderCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryServicesProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> The properties of an add provider request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryServicesProviderCreateOrUpdateContent(SiteRecoveryAddRecoveryServicesProviderProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryServicesProviderCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> The properties of an add provider request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryServicesProviderCreateOrUpdateContent(SiteRecoveryAddRecoveryServicesProviderProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryServicesProviderCreateOrUpdateContent"/> for deserialization. </summary>
        internal SiteRecoveryServicesProviderCreateOrUpdateContent()
        {
        }

        /// <summary> The properties of an add provider request. </summary>
        public SiteRecoveryAddRecoveryServicesProviderProperties Properties { get; }
    }
}
