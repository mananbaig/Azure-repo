// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> JSON web key parameter. </summary>
    public partial class JWKHeader
    {
        /// <summary> Initializes a new instance of JWKHeader. </summary>
        public JWKHeader()
        {
        }

        /// <summary> Initializes a new instance of JWKHeader. </summary>
        /// <param name="crv"> crv value. </param>
        /// <param name="kid"> kid value. </param>
        /// <param name="kty"> kty value. </param>
        /// <param name="x"> x value. </param>
        /// <param name="y"> y value. </param>
        internal JWKHeader(string crv, string kid, string kty, string x, string y)
        {
            Crv = crv;
            Kid = kid;
            Kty = kty;
            X = x;
            Y = y;
        }

        /// <summary> crv value. </summary>
        public string Crv { get; set; }
        /// <summary> kid value. </summary>
        public string Kid { get; set; }
        /// <summary> kty value. </summary>
        public string Kty { get; set; }
        /// <summary> x value. </summary>
        public string X { get; set; }
        /// <summary> y value. </summary>
        public string Y { get; set; }
    }
}
