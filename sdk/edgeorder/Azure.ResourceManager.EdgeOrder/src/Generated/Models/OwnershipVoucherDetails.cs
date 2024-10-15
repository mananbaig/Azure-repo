// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents Ownership Voucher details. </summary>
    internal partial class OwnershipVoucherDetails
    {
        /// <summary> Initializes a new instance of OwnershipVoucherDetails. </summary>
        /// <param name="ownershipVoucher"> Ownership voucher. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ownershipVoucher"/> is null. </exception>
        public OwnershipVoucherDetails(string ownershipVoucher)
        {
            Argument.AssertNotNull(ownershipVoucher, nameof(ownershipVoucher));

            OwnershipVoucher = ownershipVoucher;
        }

        /// <summary> Ownership voucher. </summary>
        public string OwnershipVoucher { get; set; }
    }
}
