// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the RegulatoryComplianceAssessment data model.
    /// Regulatory compliance assessment details and state
    /// </summary>
    public partial class RegulatoryComplianceAssessmentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RegulatoryComplianceAssessmentData"/>. </summary>
        public RegulatoryComplianceAssessmentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegulatoryComplianceAssessmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the regulatory compliance assessment. </param>
        /// <param name="assessmentType"> The expected type of assessment contained in the AssessmentDetailsLink. </param>
        /// <param name="assessmentDetailsLink"> Link to more detailed assessment results data. The response type will be according to the assessmentType field. </param>
        /// <param name="state"> Aggregative state based on the assessment's scanned resources states. </param>
        /// <param name="passedResources"> The given assessment's related resources count with passed state. </param>
        /// <param name="failedResources"> The given assessment's related resources count with failed state. </param>
        /// <param name="skippedResources"> The given assessment's related resources count with skipped state. </param>
        /// <param name="unsupportedResources"> The given assessment's related resources count with unsupported state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegulatoryComplianceAssessmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string assessmentType, string assessmentDetailsLink, RegulatoryComplianceState? state, int? passedResources, int? failedResources, int? skippedResources, int? unsupportedResources, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            AssessmentType = assessmentType;
            AssessmentDetailsLink = assessmentDetailsLink;
            State = state;
            PassedResources = passedResources;
            FailedResources = failedResources;
            SkippedResources = skippedResources;
            UnsupportedResources = unsupportedResources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description of the regulatory compliance assessment. </summary>
        public string Description { get; }
        /// <summary> The expected type of assessment contained in the AssessmentDetailsLink. </summary>
        public string AssessmentType { get; }
        /// <summary> Link to more detailed assessment results data. The response type will be according to the assessmentType field. </summary>
        public string AssessmentDetailsLink { get; }
        /// <summary> Aggregative state based on the assessment's scanned resources states. </summary>
        public RegulatoryComplianceState? State { get; set; }
        /// <summary> The given assessment's related resources count with passed state. </summary>
        public int? PassedResources { get; }
        /// <summary> The given assessment's related resources count with failed state. </summary>
        public int? FailedResources { get; }
        /// <summary> The given assessment's related resources count with skipped state. </summary>
        public int? SkippedResources { get; }
        /// <summary> The given assessment's related resources count with unsupported state. </summary>
        public int? UnsupportedResources { get; }
    }
}
