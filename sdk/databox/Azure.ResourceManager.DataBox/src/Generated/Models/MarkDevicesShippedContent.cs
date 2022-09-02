// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The request body to provide the delivery package details of job. </summary>
    public partial class MarkDevicesShippedContent
    {
        /// <summary> Initializes a new instance of MarkDevicesShippedContent. </summary>
        /// <param name="deliverToDcPackageDetails"> Delivery package details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deliverToDcPackageDetails"/> is null. </exception>
        public MarkDevicesShippedContent(PackageCarrierInfo deliverToDcPackageDetails)
        {
            if (deliverToDcPackageDetails == null)
            {
                throw new ArgumentNullException(nameof(deliverToDcPackageDetails));
            }

            DeliverToDcPackageDetails = deliverToDcPackageDetails;
        }

        /// <summary> Delivery package details. </summary>
        public PackageCarrierInfo DeliverToDcPackageDetails { get; }
    }
}
