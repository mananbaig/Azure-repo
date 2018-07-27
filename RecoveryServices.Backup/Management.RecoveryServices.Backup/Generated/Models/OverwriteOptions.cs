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
    /// Defines values for OverwriteOptions.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(OverwriteOptionsConverter))]
    public struct OverwriteOptions : System.IEquatable<OverwriteOptions>
    {
        private OverwriteOptions(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly OverwriteOptions Invalid = "Invalid";

        public static readonly OverwriteOptions FailOnConflict = "FailOnConflict";

        public static readonly OverwriteOptions Overwrite = "Overwrite";


        /// <summary>
        /// Underlying value of enum OverwriteOptions
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for OverwriteOptions
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type OverwriteOptions
        /// </summary>
        public bool Equals(OverwriteOptions e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to OverwriteOptions
        /// </summary>
        public static implicit operator OverwriteOptions(string value)
        {
            return new OverwriteOptions(value);
        }

        /// <summary>
        /// Implicit operator to convert OverwriteOptions to string
        /// </summary>
        public static implicit operator string(OverwriteOptions e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum OverwriteOptions
        /// </summary>
        public static bool operator == (OverwriteOptions e1, OverwriteOptions e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum OverwriteOptions
        /// </summary>
        public static bool operator != (OverwriteOptions e1, OverwriteOptions e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for OverwriteOptions
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is OverwriteOptions && Equals((OverwriteOptions)obj);
        }

        /// <summary>
        /// Returns for hashCode OverwriteOptions
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
