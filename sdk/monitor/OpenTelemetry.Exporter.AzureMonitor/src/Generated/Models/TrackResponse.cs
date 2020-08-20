// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> Response containing the status of each telemetry item. </summary>
    public partial class TrackResponse
    {
        /// <summary> Initializes a new instance of TrackResponse. </summary>
        internal TrackResponse()
        {
            Errors = new ChangeTrackingList<ErrorDetails>();
        }

        /// <summary> Initializes a new instance of TrackResponse. </summary>
        /// <param name="itemsReceived"> The number of items received. </param>
        /// <param name="itemsAccepted"> The number of items accepted. </param>
        /// <param name="errors"> An array of error detail objects. </param>
        internal TrackResponse(int? itemsReceived, int? itemsAccepted, IReadOnlyList<ErrorDetails> errors)
        {
            ItemsReceived = itemsReceived;
            ItemsAccepted = itemsAccepted;
            Errors = errors;
        }

        /// <summary> The number of items received. </summary>
        public int? ItemsReceived { get; }
        /// <summary> The number of items accepted. </summary>
        public int? ItemsAccepted { get; }
        /// <summary> An array of error detail objects. </summary>
        public IReadOnlyList<ErrorDetails> Errors { get; }
    }
}
