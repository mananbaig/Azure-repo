// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The protocol of an established TLS connection. </summary>
    public readonly partial struct SslProtocol : IEquatable<SslProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SslProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SslProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tls10Value = "TLSv1";
        private const string Tls11Value = "TLSv1.1";
        private const string Tls12Value = "TLSv1.2";

        /// <summary> TLSv1. </summary>
        public static SslProtocol Tls10 { get; } = new SslProtocol(Tls10Value);
        /// <summary> TLSv1.1. </summary>
        public static SslProtocol Tls11 { get; } = new SslProtocol(Tls11Value);
        /// <summary> TLSv1.2. </summary>
        public static SslProtocol Tls12 { get; } = new SslProtocol(Tls12Value);
        /// <summary> Determines if two <see cref="SslProtocol"/> values are the same. </summary>
        public static bool operator ==(SslProtocol left, SslProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SslProtocol"/> values are not the same. </summary>
        public static bool operator !=(SslProtocol left, SslProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SslProtocol"/>. </summary>
        public static implicit operator SslProtocol(string value) => new SslProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SslProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SslProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
