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
    /// Defines values for CatalogCollationType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(CatalogCollationTypeConverter))]
    public struct CatalogCollationType : System.IEquatable<CatalogCollationType>
    {
        private CatalogCollationType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly CatalogCollationType DATABASEDEFAULT = "DATABASE_DEFAULT";

        public static readonly CatalogCollationType SQLLatin1GeneralCP1CIAS = "SQL_Latin1_General_CP1_CI_AS";


        /// <summary>
        /// Underlying value of enum CatalogCollationType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for CatalogCollationType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type CatalogCollationType
        /// </summary>
        public bool Equals(CatalogCollationType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to CatalogCollationType
        /// </summary>
        public static implicit operator CatalogCollationType(string value)
        {
            return new CatalogCollationType(value);
        }

        /// <summary>
        /// Implicit operator to convert CatalogCollationType to string
        /// </summary>
        public static implicit operator string(CatalogCollationType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum CatalogCollationType
        /// </summary>
        public static bool operator == (CatalogCollationType e1, CatalogCollationType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum CatalogCollationType
        /// </summary>
        public static bool operator != (CatalogCollationType e1, CatalogCollationType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for CatalogCollationType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is CatalogCollationType && Equals((CatalogCollationType)obj);
        }

        /// <summary>
        /// Returns for hashCode CatalogCollationType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
