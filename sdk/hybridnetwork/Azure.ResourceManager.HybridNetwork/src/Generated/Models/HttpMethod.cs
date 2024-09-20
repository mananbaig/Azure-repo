// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The http method of the request. </summary>
    public readonly partial struct HttpMethod : IEquatable<HttpMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HttpMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string PostValue = "Post";
        private const string PutValue = "Put";
        private const string GetValue = "Get";
        private const string PatchValue = "Patch";
        private const string DeleteValue = "Delete";

        /// <summary> Unknown. </summary>
        public static HttpMethod Unknown { get; } = new HttpMethod(UnknownValue);
        /// <summary> Post. </summary>
        public static HttpMethod Post { get; } = new HttpMethod(PostValue);
        /// <summary> Put. </summary>
        public static HttpMethod Put { get; } = new HttpMethod(PutValue);
        /// <summary> Get. </summary>
        public static HttpMethod Get { get; } = new HttpMethod(GetValue);
        /// <summary> Patch. </summary>
        public static HttpMethod Patch { get; } = new HttpMethod(PatchValue);
        /// <summary> Delete. </summary>
        public static HttpMethod Delete { get; } = new HttpMethod(DeleteValue);
        /// <summary> Determines if two <see cref="HttpMethod"/> values are the same. </summary>
        public static bool operator ==(HttpMethod left, HttpMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpMethod"/> values are not the same. </summary>
        public static bool operator !=(HttpMethod left, HttpMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HttpMethod"/>. </summary>
        public static implicit operator HttpMethod(string value) => new HttpMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
