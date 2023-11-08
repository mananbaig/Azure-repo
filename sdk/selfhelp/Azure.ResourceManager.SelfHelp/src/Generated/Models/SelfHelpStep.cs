// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Troubleshooter step. </summary>
    public partial class SelfHelpStep
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SelfHelpStep"/>. </summary>
        internal SelfHelpStep()
        {
            Inputs = new ChangeTrackingList<StepInput>();
            Insights = new ChangeTrackingList<SelfHelpDiagnosticInsight>();
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelpStep"/>. </summary>
        /// <param name="id"> Unique step id. </param>
        /// <param name="title"> Step title. </param>
        /// <param name="description"> Step description. </param>
        /// <param name="guidance"> Get or sets the Step guidance. </param>
        /// <param name="executionStatus"> Status of Troubleshooter Step execution. </param>
        /// <param name="executionStatusDescription"> This field has more detailed status description of the execution status. </param>
        /// <param name="stepType"> Type of Troubleshooting step. </param>
        /// <param name="isLastStep"> is this last step of the workflow. </param>
        /// <param name="inputs"></param>
        /// <param name="automatedCheckResults"> Only for AutomatedStep type. </param>
        /// <param name="insights"></param>
        /// <param name="error"> The error detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SelfHelpStep(string id, string title, string description, string guidance, ExecutionStatus? executionStatus, string executionStatusDescription, SelfHelpType? stepType, bool? isLastStep, IReadOnlyList<StepInput> inputs, AutomatedCheckResult automatedCheckResults, IReadOnlyList<SelfHelpDiagnosticInsight> insights, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Title = title;
            Description = description;
            Guidance = guidance;
            ExecutionStatus = executionStatus;
            ExecutionStatusDescription = executionStatusDescription;
            StepType = stepType;
            IsLastStep = isLastStep;
            Inputs = inputs;
            AutomatedCheckResults = automatedCheckResults;
            Insights = insights;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique step id. </summary>
        public string Id { get; }
        /// <summary> Step title. </summary>
        public string Title { get; }
        /// <summary> Step description. </summary>
        public string Description { get; }
        /// <summary> Get or sets the Step guidance. </summary>
        public string Guidance { get; }
        /// <summary> Status of Troubleshooter Step execution. </summary>
        public ExecutionStatus? ExecutionStatus { get; }
        /// <summary> This field has more detailed status description of the execution status. </summary>
        public string ExecutionStatusDescription { get; }
        /// <summary> Type of Troubleshooting step. </summary>
        public SelfHelpType? StepType { get; }
        /// <summary> is this last step of the workflow. </summary>
        public bool? IsLastStep { get; }
        /// <summary> Gets the inputs. </summary>
        public IReadOnlyList<StepInput> Inputs { get; }
        /// <summary> Only for AutomatedStep type. </summary>
        public AutomatedCheckResult AutomatedCheckResults { get; }
        /// <summary> Gets the insights. </summary>
        public IReadOnlyList<SelfHelpDiagnosticInsight> Insights { get; }
        /// <summary> The error detail. </summary>
        public ResponseError Error { get; }
    }
}
