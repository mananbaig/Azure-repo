// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the move resource status. </summary>
    public partial class MoveResourceStatus
    {
        /// <summary> Initializes a new instance of MoveResourceStatus. </summary>
        internal MoveResourceStatus()
        {
        }

        /// <summary> Initializes a new instance of MoveResourceStatus. </summary>
        /// <param name="moveState"> Defines the MoveResource states. </param>
        /// <param name="jobStatus"> Defines the job status. </param>
        /// <param name="errors"> An error response from the azure resource mover service. </param>
        internal MoveResourceStatus(MoveResourceState? moveState, MoveResourceJobStatus jobStatus, MoveResourceError errors)
        {
            MoveState = moveState;
            JobStatus = jobStatus;
            Errors = errors;
        }

        /// <summary> Defines the MoveResource states. </summary>
        public MoveResourceState? MoveState { get; }
        /// <summary> Defines the job status. </summary>
        public MoveResourceJobStatus JobStatus { get; }
        /// <summary> An error response from the azure resource mover service. </summary>
        internal MoveResourceError Errors { get; }
        /// <summary> The move resource error body. </summary>
        public ResponseError ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
