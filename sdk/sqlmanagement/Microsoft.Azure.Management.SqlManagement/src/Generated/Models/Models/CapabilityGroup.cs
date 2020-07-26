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

    /// <summary>
    /// Defines values for CapabilityGroup.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(CapabilityGroupConverter))]
    public struct CapabilityGroup : System.IEquatable<CapabilityGroup>
    {
        private CapabilityGroup(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly CapabilityGroup SupportedEditions = "supportedEditions";

        public static readonly CapabilityGroup SupportedElasticPoolEditions = "supportedElasticPoolEditions";

        public static readonly CapabilityGroup SupportedManagedInstanceVersions = "supportedManagedInstanceVersions";

        public static readonly CapabilityGroup SupportedInstancePoolEditions = "supportedInstancePoolEditions";

        public static readonly CapabilityGroup SupportedManagedInstanceEditions = "supportedManagedInstanceEditions";


        /// <summary>
        /// Underlying value of enum CapabilityGroup
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for CapabilityGroup
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type CapabilityGroup
        /// </summary>
        public bool Equals(CapabilityGroup e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to CapabilityGroup
        /// </summary>
        public static implicit operator CapabilityGroup(string value)
        {
            return new CapabilityGroup(value);
        }

        /// <summary>
        /// Implicit operator to convert CapabilityGroup to string
        /// </summary>
        public static implicit operator string(CapabilityGroup e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum CapabilityGroup
        /// </summary>
        public static bool operator == (CapabilityGroup e1, CapabilityGroup e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum CapabilityGroup
        /// </summary>
        public static bool operator != (CapabilityGroup e1, CapabilityGroup e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for CapabilityGroup
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is CapabilityGroup && Equals((CapabilityGroup)obj);
        }

        /// <summary>
        /// Returns for hashCode CapabilityGroup
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
