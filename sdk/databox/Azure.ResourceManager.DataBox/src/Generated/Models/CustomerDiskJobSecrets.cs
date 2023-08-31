// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The secrets related to customer disk job. </summary>
    public partial class CustomerDiskJobSecrets : JobSecrets
    {
        /// <summary> Initializes a new instance of <see cref="CustomerDiskJobSecrets"/>. </summary>
        internal CustomerDiskJobSecrets()
        {
            DiskSecrets = new ChangeTrackingList<DataBoxDiskSecret>();
            JobSecretsType = DataBoxOrderType.DataBoxCustomerDisk;
        }

        /// <summary> Initializes a new instance of <see cref="CustomerDiskJobSecrets"/>. </summary>
        /// <param name="jobSecretsType"> Used to indicate what type of job secrets object. </param>
        /// <param name="dataCenterAccessSecurityCode"> Dc Access Security Code for Customer Managed Shipping. </param>
        /// <param name="error"> Error while fetching the secrets. </param>
        /// <param name="diskSecrets"> Contains the list of secrets object for that device. </param>
        /// <param name="carrierAccountNumber"> Carrier Account Number of the customer. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomerDiskJobSecrets(DataBoxOrderType jobSecretsType, DataCenterAccessSecurityCode dataCenterAccessSecurityCode, ResponseError error, IReadOnlyList<DataBoxDiskSecret> diskSecrets, string carrierAccountNumber, Dictionary<string, BinaryData> rawData) : base(jobSecretsType, dataCenterAccessSecurityCode, error, rawData)
        {
            DiskSecrets = diskSecrets;
            CarrierAccountNumber = carrierAccountNumber;
            JobSecretsType = jobSecretsType;
        }

        /// <summary> Contains the list of secrets object for that device. </summary>
        public IReadOnlyList<DataBoxDiskSecret> DiskSecrets { get; }
        /// <summary> Carrier Account Number of the customer. </summary>
        public string CarrierAccountNumber { get; }
    }
}
