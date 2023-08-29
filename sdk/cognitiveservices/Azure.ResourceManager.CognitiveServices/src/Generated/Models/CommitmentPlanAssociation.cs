// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The commitment plan association. </summary>
    public partial class CommitmentPlanAssociation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanAssociation"/>. </summary>
        internal CommitmentPlanAssociation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanAssociation"/>. </summary>
        /// <param name="commitmentPlanId"> The Azure resource id of the commitment plan. </param>
        /// <param name="commitmentPlanLocation"> The location of of the commitment plan. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommitmentPlanAssociation(ResourceIdentifier commitmentPlanId, string commitmentPlanLocation, Dictionary<string, BinaryData> rawData)
        {
            CommitmentPlanId = commitmentPlanId;
            CommitmentPlanLocation = commitmentPlanLocation;
            _rawData = rawData;
        }

        /// <summary> The Azure resource id of the commitment plan. </summary>
        public ResourceIdentifier CommitmentPlanId { get; }
        /// <summary> The location of of the commitment plan. </summary>
        public string CommitmentPlanLocation { get; }
    }
}
