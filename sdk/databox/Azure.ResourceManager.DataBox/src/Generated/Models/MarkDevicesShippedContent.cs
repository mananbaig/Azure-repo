// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The request body to provide the delivery package details of job. </summary>
    public partial class MarkDevicesShippedContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MarkDevicesShippedContent"/>. </summary>
        /// <param name="deliverToDataCenterPackageDetails"> Delivery package details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deliverToDataCenterPackageDetails"/> is null. </exception>
        public MarkDevicesShippedContent(PackageCarrierInfo deliverToDataCenterPackageDetails)
        {
            Argument.AssertNotNull(deliverToDataCenterPackageDetails, nameof(deliverToDataCenterPackageDetails));

            DeliverToDataCenterPackageDetails = deliverToDataCenterPackageDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MarkDevicesShippedContent"/>. </summary>
        /// <param name="deliverToDataCenterPackageDetails"> Delivery package details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MarkDevicesShippedContent(PackageCarrierInfo deliverToDataCenterPackageDetails, Dictionary<string, BinaryData> rawData)
        {
            DeliverToDataCenterPackageDetails = deliverToDataCenterPackageDetails;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MarkDevicesShippedContent"/> for deserialization. </summary>
        internal MarkDevicesShippedContent()
        {
        }

        /// <summary> Delivery package details. </summary>
        public PackageCarrierInfo DeliverToDataCenterPackageDetails { get; }
    }
}
