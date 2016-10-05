// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resource.Fluent.Models
{
    using System.Linq;

    public partial class DebugSetting
    {
        /// <summary>
        /// Initializes a new instance of the DebugSetting class.
        /// </summary>
        public DebugSetting() { }

        /// <summary>
        /// Initializes a new instance of the DebugSetting class.
        /// </summary>
        /// <param name="detailLevel">The debug detail level.</param>
        public DebugSetting(string detailLevel = default(string))
        {
            DetailLevel = detailLevel;
        }

        /// <summary>
        /// Gets or sets the debug detail level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "detailLevel")]
        public string DetailLevel { get; set; }

    }
}
