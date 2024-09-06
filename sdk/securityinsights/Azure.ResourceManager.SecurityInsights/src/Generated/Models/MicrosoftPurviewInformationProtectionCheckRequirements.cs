// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents MicrosoftPurviewInformationProtection requirements check request.
    /// Serialized Name: MicrosoftPurviewInformationProtectionCheckRequirements
    /// </summary>
    public partial class MicrosoftPurviewInformationProtectionCheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary> Initializes a new instance of <see cref="MicrosoftPurviewInformationProtectionCheckRequirements"/>. </summary>
        public MicrosoftPurviewInformationProtectionCheckRequirements()
        {
            Kind = DataConnectorKind.MicrosoftPurviewInformationProtection;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftPurviewInformationProtectionCheckRequirements"/>. </summary>
        /// <param name="kind">
        /// Describes the kind of connector to be checked.
        /// Serialized Name: DataConnectorsCheckRequirements.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId">
        /// The tenant id to connect to, and get the data from.
        /// Serialized Name: MicrosoftPurviewInformationProtectionCheckRequirements.properties.tenantId
        /// </param>
        internal MicrosoftPurviewInformationProtectionCheckRequirements(DataConnectorKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId) : base(kind, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            Kind = kind;
        }

        /// <summary>
        /// The tenant id to connect to, and get the data from.
        /// Serialized Name: MicrosoftPurviewInformationProtectionCheckRequirements.properties.tenantId
        /// </summary>
        public Guid? TenantId { get; set; }
    }
}
