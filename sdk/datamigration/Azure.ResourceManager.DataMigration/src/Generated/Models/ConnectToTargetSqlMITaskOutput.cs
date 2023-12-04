// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for the task that validates connection to Azure SQL Database Managed Instance. </summary>
    public partial class ConnectToTargetSqlMITaskOutput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMITaskOutput"/>. </summary>
        internal ConnectToTargetSqlMITaskOutput()
        {
            Logins = new ChangeTrackingList<string>();
            AgentJobs = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMITaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="logins"> List of logins on the target server. </param>
        /// <param name="agentJobs"> List of agent jobs on the target server. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetSqlMITaskOutput(string id, string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<string> logins, IReadOnlyList<string> agentJobs, IReadOnlyList<ReportableException> validationErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            Logins = logins;
            AgentJobs = agentJobs;
            ValidationErrors = validationErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> List of logins on the target server. </summary>
        public IReadOnlyList<string> Logins { get; }
        /// <summary> List of agent jobs on the target server. </summary>
        public IReadOnlyList<string> AgentJobs { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
