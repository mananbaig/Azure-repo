// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UpgradeOperationInvoker.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpgradeOperationInvoker
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Platform")]
        Platform
    }
    internal static class UpgradeOperationInvokerEnumExtension
    {
        internal static string ToSerializedValue(this UpgradeOperationInvoker? value)
        {
            return value == null ? null : ((UpgradeOperationInvoker)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UpgradeOperationInvoker value)
        {
            switch( value )
            {
                case UpgradeOperationInvoker.Unknown:
                    return "Unknown";
                case UpgradeOperationInvoker.User:
                    return "User";
                case UpgradeOperationInvoker.Platform:
                    return "Platform";
            }
            return null;
        }

        internal static UpgradeOperationInvoker? ParseUpgradeOperationInvoker(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return UpgradeOperationInvoker.Unknown;
                case "User":
                    return UpgradeOperationInvoker.User;
                case "Platform":
                    return UpgradeOperationInvoker.Platform;
            }
            return null;
        }
    }
}
