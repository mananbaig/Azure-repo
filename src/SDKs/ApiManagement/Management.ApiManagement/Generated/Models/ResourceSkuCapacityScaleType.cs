// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResourceSkuCapacityScaleType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceSkuCapacityScaleType
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "none")]
        None
    }
    internal static class ResourceSkuCapacityScaleTypeEnumExtension
    {
        internal static string ToSerializedValue(this ResourceSkuCapacityScaleType? value)
        {
            return value == null ? null : ((ResourceSkuCapacityScaleType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResourceSkuCapacityScaleType value)
        {
            switch( value )
            {
                case ResourceSkuCapacityScaleType.Automatic:
                    return "automatic";
                case ResourceSkuCapacityScaleType.Manual:
                    return "manual";
                case ResourceSkuCapacityScaleType.None:
                    return "none";
            }
            return null;
        }

        internal static ResourceSkuCapacityScaleType? ParseResourceSkuCapacityScaleType(this string value)
        {
            switch( value )
            {
                case "automatic":
                    return ResourceSkuCapacityScaleType.Automatic;
                case "manual":
                    return ResourceSkuCapacityScaleType.Manual;
                case "none":
                    return ResourceSkuCapacityScaleType.None;
            }
            return null;
        }
    }
}
