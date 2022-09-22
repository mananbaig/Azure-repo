// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionDetailedStatus. </summary>
    public partial class LinkConnectionDetailedStatus
    {
        /// <summary> Initializes a new instance of LinkConnectionDetailedStatus. </summary>
        internal LinkConnectionDetailedStatus()
        {
        }

        /// <summary> Initializes a new instance of LinkConnectionDetailedStatus. </summary>
        /// <param name="id"> Link connection id. </param>
        /// <param name="name"> Link connection name. </param>
        /// <param name="isApplyingChanges"> Is link connection applying changes. </param>
        /// <param name="isPartiallyFailed"> Is link connection partially failed. </param>
        /// <param name="startTime"> Link connection start time. </param>
        /// <param name="stopTime"> Link connection stop time. </param>
        /// <param name="status"> Link connection status. </param>
        /// <param name="continuousRunId"> Link connection&apos;s corresponding continuous run id. </param>
        /// <param name="error"> Link connection error. </param>
        /// <param name="refreshStatus"> Link connection refresh status. </param>
        /// <param name="landingZoneCredentialExpireTime"> Link connection landing zone credential expire time. </param>
        internal LinkConnectionDetailedStatus(string id, string name, bool? isApplyingChanges, bool? isPartiallyFailed, object startTime, object stopTime, string status, string continuousRunId, object error, LinkConnectionRefreshStatus refreshStatus, DateTimeOffset? landingZoneCredentialExpireTime)
        {
            Id = id;
            Name = name;
            IsApplyingChanges = isApplyingChanges;
            IsPartiallyFailed = isPartiallyFailed;
            StartTime = startTime;
            StopTime = stopTime;
            Status = status;
            ContinuousRunId = continuousRunId;
            Error = error;
            RefreshStatus = refreshStatus;
            LandingZoneCredentialExpireTime = landingZoneCredentialExpireTime;
        }

        /// <summary> Link connection id. </summary>
        public string Id { get; }
        /// <summary> Link connection name. </summary>
        public string Name { get; }
        /// <summary> Is link connection applying changes. </summary>
        public bool? IsApplyingChanges { get; }
        /// <summary> Is link connection partially failed. </summary>
        public bool? IsPartiallyFailed { get; }
        /// <summary> Link connection start time. </summary>
        public object StartTime { get; }
        /// <summary> Link connection stop time. </summary>
        public object StopTime { get; }
        /// <summary> Link connection status. </summary>
        public string Status { get; }
        /// <summary> Link connection&apos;s corresponding continuous run id. </summary>
        public string ContinuousRunId { get; }
        /// <summary> Link connection error. </summary>
        public object Error { get; }
        /// <summary> Link connection refresh status. </summary>
        public LinkConnectionRefreshStatus RefreshStatus { get; }
        /// <summary> Link connection landing zone credential expire time. </summary>
        public DateTimeOffset? LandingZoneCredentialExpireTime { get; }
    }
}
