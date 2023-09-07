// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the script action task details. </summary>
    public partial class ScriptActionTaskDetails : SiteRecoveryTaskTypeDetails
    {
        /// <summary> Initializes a new instance of <see cref="ScriptActionTaskDetails"/>. </summary>
        internal ScriptActionTaskDetails()
        {
            InstanceType = "ScriptActionTaskDetails";
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActionTaskDetails"/>. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="name"> The name. </param>
        /// <param name="path"> The path. </param>
        /// <param name="output"> The output. </param>
        /// <param name="isPrimarySideScript"> A value indicating whether it is a primary side script or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptActionTaskDetails(string instanceType, string name, string path, string output, bool? isPrimarySideScript, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            Name = name;
            Path = path;
            Output = output;
            IsPrimarySideScript = isPrimarySideScript;
            InstanceType = instanceType ?? "ScriptActionTaskDetails";
        }

        /// <summary> The name. </summary>
        public string Name { get; }
        /// <summary> The path. </summary>
        public string Path { get; }
        /// <summary> The output. </summary>
        public string Output { get; }
        /// <summary> A value indicating whether it is a primary side script or not. </summary>
        public bool? IsPrimarySideScript { get; }
    }
}
