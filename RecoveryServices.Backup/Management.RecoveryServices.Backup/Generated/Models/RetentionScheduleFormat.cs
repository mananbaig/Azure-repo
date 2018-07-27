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
    /// Defines values for RetentionScheduleFormat.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(RetentionScheduleFormatConverter))]
    public struct RetentionScheduleFormat : System.IEquatable<RetentionScheduleFormat>
    {
        private RetentionScheduleFormat(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly RetentionScheduleFormat Invalid = "Invalid";

        public static readonly RetentionScheduleFormat Daily = "Daily";

        public static readonly RetentionScheduleFormat Weekly = "Weekly";


        /// <summary>
        /// Underlying value of enum RetentionScheduleFormat
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for RetentionScheduleFormat
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type RetentionScheduleFormat
        /// </summary>
        public bool Equals(RetentionScheduleFormat e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to RetentionScheduleFormat
        /// </summary>
        public static implicit operator RetentionScheduleFormat(string value)
        {
            return new RetentionScheduleFormat(value);
        }

        /// <summary>
        /// Implicit operator to convert RetentionScheduleFormat to string
        /// </summary>
        public static implicit operator string(RetentionScheduleFormat e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum RetentionScheduleFormat
        /// </summary>
        public static bool operator == (RetentionScheduleFormat e1, RetentionScheduleFormat e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum RetentionScheduleFormat
        /// </summary>
        public static bool operator != (RetentionScheduleFormat e1, RetentionScheduleFormat e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for RetentionScheduleFormat
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is RetentionScheduleFormat && Equals((RetentionScheduleFormat)obj);
        }

        /// <summary>
        /// Returns for hashCode RetentionScheduleFormat
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
