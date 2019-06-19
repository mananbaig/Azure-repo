// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DataBox Disk Job Details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxDisk")]
    public partial class DataBoxDiskJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxDiskJobDetails class.
        /// </summary>
        public DataBoxDiskJobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxDiskJobDetails class.
        /// </summary>
        /// <param name="contactDetails">Contact details for notification and
        /// shipping.</param>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="destinationAccountDetails">Destination account
        /// details.</param>
        /// <param name="expectedDataSizeInTeraBytes">The expected size of the
        /// data, which needs to be transfered in this job, in tera
        /// bytes.</param>
        /// <param name="jobStages">List of stages that run in the job.</param>
        /// <param name="deliveryPackage">Delivery package shipping
        /// details.</param>
        /// <param name="returnPackage">Return package shipping
        /// details.</param>
        /// <param name="errorDetails">Error details for failure. This is
        /// optional.</param>
        /// <param name="preferences">Preferences for the order.</param>
        /// <param name="copyLogDetails">List of copy log details.</param>
        /// <param name="reverseShipmentLabelSasKey">Shared access key to
        /// download the return shipment label</param>
        /// <param name="chainOfCustodySasKey">Shared access key to download
        /// the chain of custody logs</param>
        /// <param name="preferredDisks">User preference on what size disks are
        /// needed for the job. The map is from the disk size in TB to the
        /// count. Eg. {2,5} means 5 disks of 2 TB size. Key is string but will
        /// be checked against an int.</param>
        /// <param name="copyProgress">Copy progress per disk.</param>
        /// <param name="disksAndSizeDetails">Contains the map of disk serial
        /// number to the disk size being used for the job. Is returned only
        /// after the disks are shipped to the customer.</param>
        /// <param name="passkey">User entered passkey for DataBox Disk
        /// job.</param>
        public DataBoxDiskJobDetails(ContactDetails contactDetails, ShippingAddress shippingAddress, IList<DestinationAccountDetails> destinationAccountDetails, int? expectedDataSizeInTeraBytes = default(int?), IList<JobStages> jobStages = default(IList<JobStages>), PackageShippingDetails deliveryPackage = default(PackageShippingDetails), PackageShippingDetails returnPackage = default(PackageShippingDetails), IList<JobErrorDetails> errorDetails = default(IList<JobErrorDetails>), Preferences preferences = default(Preferences), IList<CopyLogDetails> copyLogDetails = default(IList<CopyLogDetails>), string reverseShipmentLabelSasKey = default(string), string chainOfCustodySasKey = default(string), IDictionary<string, int?> preferredDisks = default(IDictionary<string, int?>), IList<DataBoxDiskCopyProgress> copyProgress = default(IList<DataBoxDiskCopyProgress>), IDictionary<string, int?> disksAndSizeDetails = default(IDictionary<string, int?>), string passkey = default(string))
            : base(contactDetails, shippingAddress, destinationAccountDetails, expectedDataSizeInTeraBytes, jobStages, deliveryPackage, returnPackage, errorDetails, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey)
        {
            PreferredDisks = preferredDisks;
            CopyProgress = copyProgress;
            DisksAndSizeDetails = disksAndSizeDetails;
            Passkey = passkey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user preference on what size disks are needed for the
        /// job. The map is from the disk size in TB to the count. Eg. {2,5}
        /// means 5 disks of 2 TB size. Key is string but will be checked
        /// against an int.
        /// </summary>
        [JsonProperty(PropertyName = "preferredDisks")]
        public IDictionary<string, int?> PreferredDisks { get; set; }

        /// <summary>
        /// Gets copy progress per disk.
        /// </summary>
        [JsonProperty(PropertyName = "copyProgress")]
        public IList<DataBoxDiskCopyProgress> CopyProgress { get; private set; }

        /// <summary>
        /// Gets contains the map of disk serial number to the disk size being
        /// used for the job. Is returned only after the disks are shipped to
        /// the customer.
        /// </summary>
        [JsonProperty(PropertyName = "disksAndSizeDetails")]
        public IDictionary<string, int?> DisksAndSizeDetails { get; private set; }

        /// <summary>
        /// Gets or sets user entered passkey for DataBox Disk job.
        /// </summary>
        [JsonProperty(PropertyName = "passkey")]
        public string Passkey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
