// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Script reference. </summary>
    public partial class MachineLearningScriptReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningScriptReference"/>. </summary>
        public MachineLearningScriptReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningScriptReference"/>. </summary>
        /// <param name="scriptSource"> The storage source of the script: workspace. </param>
        /// <param name="scriptData"> The location of scripts in the mounted volume. </param>
        /// <param name="scriptArguments"> Optional command line arguments passed to the script to run. </param>
        /// <param name="timeout"> Optional time period passed to timeout command. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningScriptReference(string scriptSource, string scriptData, string scriptArguments, string timeout, Dictionary<string, BinaryData> rawData)
        {
            ScriptSource = scriptSource;
            ScriptData = scriptData;
            ScriptArguments = scriptArguments;
            Timeout = timeout;
            _rawData = rawData;
        }

        /// <summary> The storage source of the script: workspace. </summary>
        public string ScriptSource { get; set; }
        /// <summary> The location of scripts in the mounted volume. </summary>
        public string ScriptData { get; set; }
        /// <summary> Optional command line arguments passed to the script to run. </summary>
        public string ScriptArguments { get; set; }
        /// <summary> Optional time period passed to timeout command. </summary>
        public string Timeout { get; set; }
    }
}
