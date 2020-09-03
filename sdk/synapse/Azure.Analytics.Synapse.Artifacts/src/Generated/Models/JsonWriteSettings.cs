// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Json write settings. </summary>
    public partial class JsonWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of JsonWriteSettings. </summary>
        public JsonWriteSettings()
        {
            Type = "JsonWriteSettings";
        }

        /// <summary> Initializes a new instance of JsonWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="filePattern"> File pattern of JSON. This setting controls the way a collection of JSON objects will be treated. The default value is &apos;setOfObjects&apos;. It is case-sensitive. </param>
        internal JsonWriteSettings(string type, IDictionary<string, object> additionalProperties, JsonWriteFilePattern? filePattern) : base(type, additionalProperties)
        {
            FilePattern = filePattern;
            Type = type ?? "JsonWriteSettings";
        }

        /// <summary> File pattern of JSON. This setting controls the way a collection of JSON objects will be treated. The default value is &apos;setOfObjects&apos;. It is case-sensitive. </summary>
        public JsonWriteFilePattern? FilePattern { get; set; }
    }
}
