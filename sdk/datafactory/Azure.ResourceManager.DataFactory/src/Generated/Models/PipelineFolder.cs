// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </summary>
    internal partial class PipelineFolder
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PipelineFolder"/>. </summary>
        public PipelineFolder()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PipelineFolder"/>. </summary>
        /// <param name="name"> The name of the folder that this Pipeline is in. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineFolder(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The name of the folder that this Pipeline is in. </summary>
        public string Name { get; set; }
    }
}
