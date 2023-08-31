// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// A charge summary resource.
    /// Please note <see cref="ConsumptionChargeSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConsumptionLegacyChargeSummary"/> and <see cref="ConsumptionModernChargeSummary"/>.
    /// </summary>
    public partial class ConsumptionChargeSummary : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConsumptionChargeSummary"/>. </summary>
        public ConsumptionChargeSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionChargeSummary"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of charge summary. </param>
        /// <param name="etag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionChargeSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ChargeSummaryKind kind, ETag? etag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
            _rawData = rawData;
        }

        /// <summary> Specifies the kind of charge summary. </summary>
        internal ChargeSummaryKind Kind { get; set; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
