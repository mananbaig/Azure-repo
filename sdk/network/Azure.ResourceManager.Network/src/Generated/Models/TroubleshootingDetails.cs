// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information gained from troubleshooting of specified resource. </summary>
    public partial class TroubleshootingDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TroubleshootingDetails"/>. </summary>
        internal TroubleshootingDetails()
        {
            RecommendedActions = new ChangeTrackingList<TroubleshootingRecommendedActions>();
        }

        /// <summary> Initializes a new instance of <see cref="TroubleshootingDetails"/>. </summary>
        /// <param name="id"> The id of the get troubleshoot operation. </param>
        /// <param name="reasonType"> Reason type of failure. </param>
        /// <param name="summary"> A summary of troubleshooting. </param>
        /// <param name="detail"> Details on troubleshooting results. </param>
        /// <param name="recommendedActions"> List of recommended actions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TroubleshootingDetails(string id, string reasonType, string summary, string detail, IReadOnlyList<TroubleshootingRecommendedActions> recommendedActions, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ReasonType = reasonType;
            Summary = summary;
            Detail = detail;
            RecommendedActions = recommendedActions;
            _rawData = rawData;
        }

        /// <summary> The id of the get troubleshoot operation. </summary>
        public string Id { get; }
        /// <summary> Reason type of failure. </summary>
        public string ReasonType { get; }
        /// <summary> A summary of troubleshooting. </summary>
        public string Summary { get; }
        /// <summary> Details on troubleshooting results. </summary>
        public string Detail { get; }
        /// <summary> List of recommended actions. </summary>
        public IReadOnlyList<TroubleshootingRecommendedActions> RecommendedActions { get; }
    }
}
