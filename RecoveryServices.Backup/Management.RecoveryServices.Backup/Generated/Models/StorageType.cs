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
    /// Defines values for StorageType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(StorageTypeConverter))]
    public struct StorageType : System.IEquatable<StorageType>
    {
        private StorageType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly StorageType Invalid = "Invalid";

        public static readonly StorageType GeoRedundant = "GeoRedundant";

        public static readonly StorageType LocallyRedundant = "LocallyRedundant";


        /// <summary>
        /// Underlying value of enum StorageType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for StorageType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type StorageType
        /// </summary>
        public bool Equals(StorageType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to StorageType
        /// </summary>
        public static implicit operator StorageType(string value)
        {
            return new StorageType(value);
        }

        /// <summary>
        /// Implicit operator to convert StorageType to string
        /// </summary>
        public static implicit operator string(StorageType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum StorageType
        /// </summary>
        public static bool operator == (StorageType e1, StorageType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum StorageType
        /// </summary>
        public static bool operator != (StorageType e1, StorageType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for StorageType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is StorageType && Equals((StorageType)obj);
        }

        /// <summary>
        /// Returns for hashCode StorageType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
