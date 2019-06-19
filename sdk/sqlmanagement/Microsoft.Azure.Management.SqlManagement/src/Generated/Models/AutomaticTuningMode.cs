// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutomaticTuningMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutomaticTuningMode
    {
        [EnumMember(Value = "Inherit")]
        Inherit,
        [EnumMember(Value = "Custom")]
        Custom,
        [EnumMember(Value = "Auto")]
        Auto,
        [EnumMember(Value = "Unspecified")]
        Unspecified
    }
    internal static class AutomaticTuningModeEnumExtension
    {
        internal static string ToSerializedValue(this AutomaticTuningMode? value)
        {
            return value == null ? null : ((AutomaticTuningMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutomaticTuningMode value)
        {
            switch( value )
            {
                case AutomaticTuningMode.Inherit:
                    return "Inherit";
                case AutomaticTuningMode.Custom:
                    return "Custom";
                case AutomaticTuningMode.Auto:
                    return "Auto";
                case AutomaticTuningMode.Unspecified:
                    return "Unspecified";
            }
            return null;
        }

        internal static AutomaticTuningMode? ParseAutomaticTuningMode(this string value)
        {
            switch( value )
            {
                case "Inherit":
                    return AutomaticTuningMode.Inherit;
                case "Custom":
                    return AutomaticTuningMode.Custom;
                case "Auto":
                    return AutomaticTuningMode.Auto;
                case "Unspecified":
                    return AutomaticTuningMode.Unspecified;
            }
            return null;
        }
    }
}
