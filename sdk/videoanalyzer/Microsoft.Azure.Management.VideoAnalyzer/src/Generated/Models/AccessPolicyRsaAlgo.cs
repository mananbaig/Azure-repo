// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AccessPolicyRsaAlgo.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AccessPolicyRsaAlgoConverter))]
    public struct AccessPolicyRsaAlgo : System.IEquatable<AccessPolicyRsaAlgo>
    {
        private AccessPolicyRsaAlgo(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// RS256
        /// </summary>
        public static readonly AccessPolicyRsaAlgo RS256 = "RS256";

        /// <summary>
        /// RS384
        /// </summary>
        public static readonly AccessPolicyRsaAlgo RS384 = "RS384";

        /// <summary>
        /// RS512
        /// </summary>
        public static readonly AccessPolicyRsaAlgo RS512 = "RS512";


        /// <summary>
        /// Underlying value of enum AccessPolicyRsaAlgo
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AccessPolicyRsaAlgo
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AccessPolicyRsaAlgo
        /// </summary>
        public bool Equals(AccessPolicyRsaAlgo e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AccessPolicyRsaAlgo
        /// </summary>
        public static implicit operator AccessPolicyRsaAlgo(string value)
        {
            return new AccessPolicyRsaAlgo(value);
        }

        /// <summary>
        /// Implicit operator to convert AccessPolicyRsaAlgo to string
        /// </summary>
        public static implicit operator string(AccessPolicyRsaAlgo e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AccessPolicyRsaAlgo
        /// </summary>
        public static bool operator == (AccessPolicyRsaAlgo e1, AccessPolicyRsaAlgo e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AccessPolicyRsaAlgo
        /// </summary>
        public static bool operator != (AccessPolicyRsaAlgo e1, AccessPolicyRsaAlgo e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AccessPolicyRsaAlgo
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AccessPolicyRsaAlgo && Equals((AccessPolicyRsaAlgo)obj);
        }

        /// <summary>
        /// Returns for hashCode AccessPolicyRsaAlgo
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
