// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The execution details of a script action. </summary>
    public partial class RuntimeScriptActionDetail : RuntimeScriptAction
    {
        /// <summary> Initializes a new instance of <see cref="RuntimeScriptActionDetail"/>. </summary>
        /// <param name="name"> The name of the script action. </param>
        /// <param name="uri"> The URI to the script. </param>
        /// <param name="roles"> The list of roles where script will be executed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="uri"/> or <paramref name="roles"/> is null. </exception>
        public RuntimeScriptActionDetail(string name, Uri uri, IEnumerable<string> roles) : base(name, uri, roles)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(uri, nameof(uri));
            Argument.AssertNotNull(roles, nameof(roles));

            ExecutionSummary = new ChangeTrackingList<ScriptActionExecutionSummary>();
        }

        /// <summary> Initializes a new instance of <see cref="RuntimeScriptActionDetail"/>. </summary>
        /// <param name="name"> The name of the script action. </param>
        /// <param name="uri"> The URI to the script. </param>
        /// <param name="parameters"> The parameters for the script. </param>
        /// <param name="roles"> The list of roles where script will be executed. </param>
        /// <param name="applicationName"> The application name of the script action, if any. </param>
        /// <param name="scriptExecutionId"> The execution id of the script action. </param>
        /// <param name="startOn"> The start time of script action execution. </param>
        /// <param name="endOn"> The end time of script action execution. </param>
        /// <param name="status"> The current execution status of the script action. </param>
        /// <param name="operation"> The reason why the script action was executed. </param>
        /// <param name="executionSummary"> The summary of script action execution result. </param>
        /// <param name="debugInformation"> The script action execution debug information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RuntimeScriptActionDetail(string name, Uri uri, string parameters, IList<string> roles, string applicationName, long? scriptExecutionId, DateTimeOffset? startOn, DateTimeOffset? endOn, string status, string operation, IReadOnlyList<ScriptActionExecutionSummary> executionSummary, string debugInformation, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(name, uri, parameters, roles, applicationName, serializedAdditionalRawData)
        {
            ScriptExecutionId = scriptExecutionId;
            StartOn = startOn;
            EndOn = endOn;
            Status = status;
            Operation = operation;
            ExecutionSummary = executionSummary;
            DebugInformation = debugInformation;
        }

        /// <summary> Initializes a new instance of <see cref="RuntimeScriptActionDetail"/> for deserialization. </summary>
        internal RuntimeScriptActionDetail()
        {
        }

        /// <summary> The execution id of the script action. </summary>
        public long? ScriptExecutionId { get; }
        /// <summary> The start time of script action execution. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of script action execution. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The current execution status of the script action. </summary>
        public string Status { get; }
        /// <summary> The reason why the script action was executed. </summary>
        public string Operation { get; }
        /// <summary> The summary of script action execution result. </summary>
        public IReadOnlyList<ScriptActionExecutionSummary> ExecutionSummary { get; }
        /// <summary> The script action execution debug information. </summary>
        public string DebugInformation { get; }
    }
}
