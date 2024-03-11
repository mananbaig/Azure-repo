// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Snowflake import command settings. </summary>
    public partial class SnowflakeImportCopyCommand : ImportSettings
    {
        /// <summary> Initializes a new instance of <see cref="SnowflakeImportCopyCommand"/>. </summary>
        public SnowflakeImportCopyCommand()
        {
            AdditionalCopyOptions = new ChangeTrackingDictionary<string, object>();
            AdditionalFormatOptions = new ChangeTrackingDictionary<string, object>();
            Type = "SnowflakeImportCopyCommand";
        }

        /// <summary> Initializes a new instance of <see cref="SnowflakeImportCopyCommand"/>. </summary>
        /// <param name="type"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="additionalCopyOptions"> Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }. </param>
        /// <param name="additionalFormatOptions"> Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "FORCE": "TRUE", "LOAD_UNCERTAIN_FILES": "'FALSE'" }. </param>
        internal SnowflakeImportCopyCommand(string type, IDictionary<string, object> additionalProperties, IDictionary<string, object> additionalCopyOptions, IDictionary<string, object> additionalFormatOptions) : base(type, additionalProperties)
        {
            AdditionalCopyOptions = additionalCopyOptions;
            AdditionalFormatOptions = additionalFormatOptions;
            Type = type ?? "SnowflakeImportCopyCommand";
        }

        /// <summary> Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }. </summary>
        public IDictionary<string, object> AdditionalCopyOptions { get; }
        /// <summary> Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "FORCE": "TRUE", "LOAD_UNCERTAIN_FILES": "'FALSE'" }. </summary>
        public IDictionary<string, object> AdditionalFormatOptions { get; }
    }
}
