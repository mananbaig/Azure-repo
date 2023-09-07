// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Details of the service principal. </summary>
    public partial class ServicePrincipalProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalProperties"/>. </summary>
        public ServicePrincipalProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalProperties"/>. </summary>
        /// <param name="applicationId"> Application ID of service principal. </param>
        /// <param name="secret"> A secret string that the application uses to prove its identity, also can be referred to as application password (write only). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipalProperties(Guid? applicationId, string secret, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplicationId = applicationId;
            Secret = secret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Application ID of service principal. </summary>
        public Guid? ApplicationId { get; set; }
        /// <summary> A secret string that the application uses to prove its identity, also can be referred to as application password (write only). </summary>
        public string Secret { get; set; }
    }
}
