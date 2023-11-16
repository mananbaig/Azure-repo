// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The IdentityManagementProperties. </summary>
    public partial class IdentityManagementProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IdentityManagementProperties"/>. </summary>
        public IdentityManagementProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IdentityManagementProperties"/>. </summary>
        /// <param name="managementType"></param>
        /// <param name="applicationId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IdentityManagementProperties(IdentityManagementType? managementType, string applicationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManagementType = managementType;
            ApplicationId = applicationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the management type. </summary>
        public IdentityManagementType? ManagementType { get; set; }
        /// <summary> Gets or sets the application id. </summary>
        public string ApplicationId { get; set; }
    }
}
