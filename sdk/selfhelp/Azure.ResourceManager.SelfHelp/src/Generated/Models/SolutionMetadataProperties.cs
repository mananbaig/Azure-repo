// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Metadata Properties. </summary>
    public partial class SolutionMetadataProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SolutionMetadataProperties"/>. </summary>
        public SolutionMetadataProperties()
        {
            RequiredInputs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SolutionMetadataProperties"/>. </summary>
        /// <param name="solutionId"> Solution Id. </param>
        /// <param name="solutionType"> Solution Type. </param>
        /// <param name="description"> A detailed description of solution. </param>
        /// <param name="requiredInputs"> Required parameters for invoking this particular solution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SolutionMetadataProperties(string solutionId, SolutionType? solutionType, string description, IReadOnlyList<string> requiredInputs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SolutionId = solutionId;
            SolutionType = solutionType;
            Description = description;
            RequiredInputs = requiredInputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Solution Id. </summary>
        public string SolutionId { get; set; }
        /// <summary> Solution Type. </summary>
        public SolutionType? SolutionType { get; }
        /// <summary> A detailed description of solution. </summary>
        public string Description { get; }
        /// <summary> Required parameters for invoking this particular solution. </summary>
        public IReadOnlyList<string> RequiredInputs { get; }
    }
}
