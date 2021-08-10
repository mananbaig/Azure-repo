// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for NodePlacementPolicyType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NodePlacementPolicyType
    {
        /// <summary>
        /// All nodes in the pool will be allocated in the same region.
        /// </summary>
        [EnumMember(Value = "regional")]
        Regional,
        /// <summary>
        /// Nodes in the pool will be spread across different availability
        /// zones with best effort balancing.
        /// </summary>
        [EnumMember(Value = "zonal")]
        Zonal
    }
    internal static class NodePlacementPolicyTypeEnumExtension
    {
        internal static string ToSerializedValue(this NodePlacementPolicyType? value)
        {
            return value == null ? null : ((NodePlacementPolicyType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this NodePlacementPolicyType value)
        {
            switch( value )
            {
                case NodePlacementPolicyType.Regional:
                    return "regional";
                case NodePlacementPolicyType.Zonal:
                    return "zonal";
            }
            return null;
        }

        internal static NodePlacementPolicyType? ParseNodePlacementPolicyType(this string value)
        {
            switch( value )
            {
                case "regional":
                    return NodePlacementPolicyType.Regional;
                case "zonal":
                    return NodePlacementPolicyType.Zonal;
            }
            return null;
        }
    }
}
