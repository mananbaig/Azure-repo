// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Manager Deployment Status. </summary>
    public partial class NetworkManagerDeploymentStatus
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

        /// <summary> Initializes a new instance of <see cref="NetworkManagerDeploymentStatus"/>. </summary>
        internal NetworkManagerDeploymentStatus()
        {
            ConfigurationIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerDeploymentStatus"/>. </summary>
        /// <param name="commitOn"> Commit Time. </param>
        /// <param name="region"> Region Name. </param>
        /// <param name="deploymentState"> Deployment Status. </param>
        /// <param name="configurationIds"> List of configuration ids. </param>
        /// <param name="deploymentType"> Configuration Deployment Type. </param>
        /// <param name="errorMessage"> Error Message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkManagerDeploymentStatus(DateTimeOffset? commitOn, string region, NetworkManagerDeploymentState? deploymentState, IReadOnlyList<string> configurationIds, NetworkConfigurationDeploymentType? deploymentType, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CommitOn = commitOn;
            Region = region;
            DeploymentState = deploymentState;
            ConfigurationIds = configurationIds;
            DeploymentType = deploymentType;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Commit Time. </summary>
        public DateTimeOffset? CommitOn { get; }
        /// <summary> Region Name. </summary>
        public string Region { get; }
        /// <summary> Deployment Status. </summary>
        public NetworkManagerDeploymentState? DeploymentState { get; }
        /// <summary> List of configuration ids. </summary>
        public IReadOnlyList<string> ConfigurationIds { get; }
        /// <summary> Configuration Deployment Type. </summary>
        public NetworkConfigurationDeploymentType? DeploymentType { get; }
        /// <summary> Error Message. </summary>
        public string ErrorMessage { get; }
    }
}
