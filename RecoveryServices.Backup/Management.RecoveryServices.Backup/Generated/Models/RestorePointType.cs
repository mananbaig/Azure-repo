// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for RestorePointType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(RestorePointTypeConverter))]
    public struct RestorePointType : System.IEquatable<RestorePointType>
    {
        private RestorePointType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly RestorePointType Invalid = "Invalid";

        public static readonly RestorePointType Full = "Full";

        public static readonly RestorePointType Log = "Log";

        public static readonly RestorePointType Differential = "Differential";


        /// <summary>
        /// Underlying value of enum RestorePointType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for RestorePointType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type RestorePointType
        /// </summary>
        public bool Equals(RestorePointType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to RestorePointType
        /// </summary>
        public static implicit operator RestorePointType(string value)
        {
            return new RestorePointType(value);
        }

        /// <summary>
        /// Implicit operator to convert RestorePointType to string
        /// </summary>
        public static implicit operator string(RestorePointType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum RestorePointType
        /// </summary>
        public static bool operator == (RestorePointType e1, RestorePointType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum RestorePointType
        /// </summary>
        public static bool operator != (RestorePointType e1, RestorePointType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for RestorePointType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is RestorePointType && Equals((RestorePointType)obj);
        }

        /// <summary>
        /// Returns for hashCode RestorePointType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
