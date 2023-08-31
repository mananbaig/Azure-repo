// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for a quick task run request. </summary>
    public partial class ContainerRegistryEncodedTaskRunContent : ContainerRegistryRunContent
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncodedTaskRunContent"/>. </summary>
        /// <param name="encodedTaskContent"> Base64 encoded value of the template/definition file content. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="encodedTaskContent"/> or <paramref name="platform"/> is null. </exception>
        public ContainerRegistryEncodedTaskRunContent(string encodedTaskContent, ContainerRegistryPlatformProperties platform)
        {
            Argument.AssertNotNull(encodedTaskContent, nameof(encodedTaskContent));
            Argument.AssertNotNull(platform, nameof(platform));

            EncodedTaskContent = encodedTaskContent;
            Values = new ChangeTrackingList<ContainerRegistryTaskOverridableValue>();
            Platform = platform;
            RunRequestType = "EncodedTaskRunRequest";
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncodedTaskRunContent"/>. </summary>
        /// <param name="runRequestType"> The type of the run request. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled for the run or not. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="encodedTaskContent"> Base64 encoded value of the template/definition file content. </param>
        /// <param name="encodedValuesContent"> Base64 encoded value of the parameters/values file content. </param>
        /// <param name="values"> The collection of overridable values that can be passed when running a task. </param>
        /// <param name="timeoutInSeconds"> Run timeout in seconds. </param>
        /// <param name="platform"> The platform properties against which the run has to happen. </param>
        /// <param name="agentConfiguration"> The machine configuration of the run agent. </param>
        /// <param name="sourceLocation">
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </param>
        /// <param name="credentials"> The properties that describes a set of credentials that will be used when this run is invoked. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryEncodedTaskRunContent(string runRequestType, bool? isArchiveEnabled, string agentPoolName, string logTemplate, string encodedTaskContent, string encodedValuesContent, IList<ContainerRegistryTaskOverridableValue> values, int? timeoutInSeconds, ContainerRegistryPlatformProperties platform, ContainerRegistryAgentProperties agentConfiguration, string sourceLocation, ContainerRegistryCredentials credentials, Dictionary<string, BinaryData> rawData) : base(runRequestType, isArchiveEnabled, agentPoolName, logTemplate, rawData)
        {
            EncodedTaskContent = encodedTaskContent;
            EncodedValuesContent = encodedValuesContent;
            Values = values;
            TimeoutInSeconds = timeoutInSeconds;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            SourceLocation = sourceLocation;
            Credentials = credentials;
            RunRequestType = runRequestType ?? "EncodedTaskRunRequest";
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncodedTaskRunContent"/> for deserialization. </summary>
        internal ContainerRegistryEncodedTaskRunContent()
        {
        }

        /// <summary> Base64 encoded value of the template/definition file content. </summary>
        public string EncodedTaskContent { get; set; }
        /// <summary> Base64 encoded value of the parameters/values file content. </summary>
        public string EncodedValuesContent { get; set; }
        /// <summary> The collection of overridable values that can be passed when running a task. </summary>
        public IList<ContainerRegistryTaskOverridableValue> Values { get; }
        /// <summary> Run timeout in seconds. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> The platform properties against which the run has to happen. </summary>
        public ContainerRegistryPlatformProperties Platform { get; set; }
        /// <summary> The machine configuration of the run agent. </summary>
        internal ContainerRegistryAgentProperties AgentConfiguration { get; set; }
        /// <summary> The CPU configuration in terms of number of cores required for the run. </summary>
        public int? AgentCpu
        {
            get => AgentConfiguration is null ? default : AgentConfiguration.Cpu;
            set
            {
                if (AgentConfiguration is null)
                    AgentConfiguration = new ContainerRegistryAgentProperties();
                AgentConfiguration.Cpu = value;
            }
        }

        /// <summary>
        /// The URL(absolute or relative) of the source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from calling listBuildSourceUploadUrl API.
        /// </summary>
        public string SourceLocation { get; set; }
        /// <summary> The properties that describes a set of credentials that will be used when this run is invoked. </summary>
        public ContainerRegistryCredentials Credentials { get; set; }
    }
}
