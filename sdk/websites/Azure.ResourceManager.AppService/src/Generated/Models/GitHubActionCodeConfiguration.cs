// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The GitHub action code configuration. </summary>
    public partial class GitHubActionCodeConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GitHubActionCodeConfiguration"/>. </summary>
        public GitHubActionCodeConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubActionCodeConfiguration"/>. </summary>
        /// <param name="runtimeStack"> Runtime stack is used to determine the workflow file content for code base apps. </param>
        /// <param name="runtimeVersion"> Runtime version is used to determine what build version to set in the workflow file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubActionCodeConfiguration(string runtimeStack, string runtimeVersion, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuntimeStack = runtimeStack;
            RuntimeVersion = runtimeVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Runtime stack is used to determine the workflow file content for code base apps. </summary>
        public string RuntimeStack { get; set; }
        /// <summary> Runtime version is used to determine what build version to set in the workflow file. </summary>
        public string RuntimeVersion { get; set; }
    }
}
