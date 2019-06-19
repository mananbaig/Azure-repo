// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The updates profile
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Updates : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the Updates class.
        /// </summary>
        public Updates()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Updates class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="deviceVersion">The current Device version.</param>
        /// <param name="deviceLastScannedTime">The last time when the device
        /// did an update scan.</param>
        /// <param name="regularUpdatesAvailable">Set to true if regular
        /// updates were detected for the current version of the
        /// device.</param>
        /// <param name="rebootRequiredForInstall">Set to true if
        /// RegularUpdatesAvailable is true and if atleast one of the
        /// updateItems detected has needs a reboot to install.</param>
        /// <param name="totalItemsPendingForDownload">The total number of
        /// items pending for download.</param>
        /// <param name="totalItemsPendingForInstall">The total number of items
        /// pending for install.</param>
        /// <param name="status">The current update operation. Possible values
        /// include: 'Idle', 'Scanning', 'Downloading', 'Installing'</param>
        /// <param name="lastCompletedScanTime">The time when the last scan job
        /// was completed (success|cancelled|failed) on the device.</param>
        /// <param name="lastCompletedDownloadJobTime">The time when the last
        /// Download job was completed (success|cancelled|failed) on the
        /// device.</param>
        /// <param name="lastCompletedInstallJobTime">The time when the last
        /// Install job was completed (success|cancelled|failed) on the
        /// device.</param>
        /// <param name="inProgressDownloadJobId">If a download is in progress,
        /// this field contains the JobId of that particular download
        /// job</param>
        /// <param name="inProgressInstallJobId">If an install is in progress,
        /// this field contains the JobId of that particular install
        /// job</param>
        /// <param name="inProgressScanStartedTime">The time when the currently
        /// running scan (if any) started</param>
        /// <param name="inProgressDownloadJobStartedTime">The time when the
        /// currently running download (if any) started</param>
        /// <param name="inProgressInstallJobStartedTime">The time when the
        /// currently running install (if any) started</param>
        public Updates(string id = default(string), string name = default(string), string type = default(string), string deviceVersion = default(string), System.DateTime? deviceLastScannedTime = default(System.DateTime?), bool? regularUpdatesAvailable = default(bool?), bool? rebootRequiredForInstall = default(bool?), int? totalItemsPendingForDownload = default(int?), int? totalItemsPendingForInstall = default(int?), UpdateOperation? status = default(UpdateOperation?), System.DateTime? lastCompletedScanTime = default(System.DateTime?), System.DateTime? lastCompletedDownloadJobTime = default(System.DateTime?), System.DateTime? lastCompletedInstallJobTime = default(System.DateTime?), string inProgressDownloadJobId = default(string), string inProgressInstallJobId = default(string), System.DateTime? inProgressScanStartedTime = default(System.DateTime?), System.DateTime? inProgressDownloadJobStartedTime = default(System.DateTime?), System.DateTime? inProgressInstallJobStartedTime = default(System.DateTime?))
            : base(id, name, type)
        {
            DeviceVersion = deviceVersion;
            DeviceLastScannedTime = deviceLastScannedTime;
            RegularUpdatesAvailable = regularUpdatesAvailable;
            RebootRequiredForInstall = rebootRequiredForInstall;
            TotalItemsPendingForDownload = totalItemsPendingForDownload;
            TotalItemsPendingForInstall = totalItemsPendingForInstall;
            Status = status;
            LastCompletedScanTime = lastCompletedScanTime;
            LastCompletedDownloadJobTime = lastCompletedDownloadJobTime;
            LastCompletedInstallJobTime = lastCompletedInstallJobTime;
            InProgressDownloadJobId = inProgressDownloadJobId;
            InProgressInstallJobId = inProgressInstallJobId;
            InProgressScanStartedTime = inProgressScanStartedTime;
            InProgressDownloadJobStartedTime = inProgressDownloadJobStartedTime;
            InProgressInstallJobStartedTime = inProgressInstallJobStartedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current Device version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceVersion")]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// Gets or sets the last time when the device did an update scan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceLastScannedTime")]
        public System.DateTime? DeviceLastScannedTime { get; set; }

        /// <summary>
        /// Gets or sets set to true if regular updates were detected for the
        /// current version of the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.regularUpdatesAvailable")]
        public bool? RegularUpdatesAvailable { get; set; }

        /// <summary>
        /// Gets or sets set to true if RegularUpdatesAvailable is true and if
        /// atleast one of the updateItems detected has needs a reboot to
        /// install.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rebootRequiredForInstall")]
        public bool? RebootRequiredForInstall { get; set; }

        /// <summary>
        /// Gets or sets the total number of items pending for download.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalItemsPendingForDownload")]
        public int? TotalItemsPendingForDownload { get; set; }

        /// <summary>
        /// Gets or sets the total number of items pending for install.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalItemsPendingForInstall")]
        public int? TotalItemsPendingForInstall { get; set; }

        /// <summary>
        /// Gets or sets the current update operation. Possible values include:
        /// 'Idle', 'Scanning', 'Downloading', 'Installing'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public UpdateOperation? Status { get; set; }

        /// <summary>
        /// Gets or sets the time when the last scan job was completed
        /// (success|cancelled|failed) on the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedScanTime")]
        public System.DateTime? LastCompletedScanTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the last Download job was completed
        /// (success|cancelled|failed) on the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedDownloadJobTime")]
        public System.DateTime? LastCompletedDownloadJobTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the last Install job was completed
        /// (success|cancelled|failed) on the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedInstallJobTime")]
        public System.DateTime? LastCompletedInstallJobTime { get; set; }

        /// <summary>
        /// Gets or sets if a download is in progress, this field contains the
        /// JobId of that particular download job
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressDownloadJobId")]
        public string InProgressDownloadJobId { get; set; }

        /// <summary>
        /// Gets or sets if an install is in progress, this field contains the
        /// JobId of that particular install job
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressInstallJobId")]
        public string InProgressInstallJobId { get; set; }

        /// <summary>
        /// Gets or sets the time when the currently running scan (if any)
        /// started
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressScanStartedTime")]
        public System.DateTime? InProgressScanStartedTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the currently running download (if any)
        /// started
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressDownloadJobStartedTime")]
        public System.DateTime? InProgressDownloadJobStartedTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the currently running install (if any)
        /// started
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressInstallJobStartedTime")]
        public System.DateTime? InProgressInstallJobStartedTime { get; set; }

    }
}
