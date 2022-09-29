// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Response of the update system services API. </summary>
    public partial class UpdateSystemServicesResponse
    {
        /// <summary> Initializes a new instance of UpdateSystemServicesResponse. </summary>
        internal UpdateSystemServicesResponse()
        {
        }

        /// <summary> Initializes a new instance of UpdateSystemServicesResponse. </summary>
        /// <param name="updateStatus"> Update status. </param>
        /// <param name="updateStartedOn"> The date and time when the last system services update was started. </param>
        /// <param name="updateCompletedOn"> The date and time when the last system services update completed. </param>
        internal UpdateSystemServicesResponse(OperationStatus? updateStatus, DateTimeOffset? updateStartedOn, DateTimeOffset? updateCompletedOn)
        {
            UpdateStatus = updateStatus;
            UpdateStartedOn = updateStartedOn;
            UpdateCompletedOn = updateCompletedOn;
        }

        /// <summary> Update status. </summary>
        public OperationStatus? UpdateStatus { get; }
        /// <summary> The date and time when the last system services update was started. </summary>
        public DateTimeOffset? UpdateStartedOn { get; }
        /// <summary> The date and time when the last system services update completed. </summary>
        public DateTimeOffset? UpdateCompletedOn { get; }
    }
}
