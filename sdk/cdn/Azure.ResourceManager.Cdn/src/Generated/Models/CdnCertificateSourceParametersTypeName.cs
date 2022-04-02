// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The CdnCertificateSourceParametersTypeName. </summary>
    public readonly partial struct CdnCertificateSourceParametersTypeName : IEquatable<CdnCertificateSourceParametersTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CdnCertificateSourceParametersTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CdnCertificateSourceParametersTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CdnCertificateSourceParametersValue = "CdnCertificateSourceParameters";

        /// <summary> CdnCertificateSourceParameters. </summary>
        public static CdnCertificateSourceParametersTypeName CdnCertificateSourceParameters { get; } = new CdnCertificateSourceParametersTypeName(CdnCertificateSourceParametersValue);
        /// <summary> Determines if two <see cref="CdnCertificateSourceParametersTypeName"/> values are the same. </summary>
        public static bool operator ==(CdnCertificateSourceParametersTypeName left, CdnCertificateSourceParametersTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CdnCertificateSourceParametersTypeName"/> values are not the same. </summary>
        public static bool operator !=(CdnCertificateSourceParametersTypeName left, CdnCertificateSourceParametersTypeName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CdnCertificateSourceParametersTypeName"/>. </summary>
        public static implicit operator CdnCertificateSourceParametersTypeName(string value) => new CdnCertificateSourceParametersTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CdnCertificateSourceParametersTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CdnCertificateSourceParametersTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
