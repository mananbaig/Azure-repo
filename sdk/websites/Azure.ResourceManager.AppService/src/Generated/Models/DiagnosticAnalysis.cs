// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing a diagnostic analysis done on an application. </summary>
    public partial class DiagnosticAnalysis : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="DiagnosticAnalysis"/>. </summary>
        public DiagnosticAnalysis()
        {
            AbnormalTimePeriods = new ChangeTrackingList<AbnormalTimePeriod>();
            Payload = new ChangeTrackingList<AnalysisData>();
            NonCorrelatedDetectors = new ChangeTrackingList<DetectorDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticAnalysis"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="startOn"> Start time of the period. </param>
        /// <param name="endOn"> End time of the period. </param>
        /// <param name="abnormalTimePeriods"> List of time periods. </param>
        /// <param name="payload"> Data by each detector. </param>
        /// <param name="nonCorrelatedDetectors"> Data by each detector for detectors that did not corelate. </param>
        internal DiagnosticAnalysis(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, DateTimeOffset? startOn, DateTimeOffset? endOn, IList<AbnormalTimePeriod> abnormalTimePeriods, IList<AnalysisData> payload, IList<DetectorDefinition> nonCorrelatedDetectors) : base(id, name, resourceType, systemData, kind)
        {
            StartOn = startOn;
            EndOn = endOn;
            AbnormalTimePeriods = abnormalTimePeriods;
            Payload = payload;
            NonCorrelatedDetectors = nonCorrelatedDetectors;
        }

        /// <summary> Start time of the period. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the period. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> List of time periods. </summary>
        public IList<AbnormalTimePeriod> AbnormalTimePeriods { get; }
        /// <summary> Data by each detector. </summary>
        public IList<AnalysisData> Payload { get; }
        /// <summary> Data by each detector for detectors that did not corelate. </summary>
        public IList<DetectorDefinition> NonCorrelatedDetectors { get; }
    }
}
