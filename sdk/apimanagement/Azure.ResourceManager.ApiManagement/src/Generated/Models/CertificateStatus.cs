// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Certificate Status. </summary>
    public readonly partial struct CertificateStatus : IEquatable<CertificateStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CertificateStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CertificateStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";
        private const string InProgressValue = "InProgress";

        /// <summary> Completed. </summary>
        public static CertificateStatus Completed { get; } = new CertificateStatus(CompletedValue);
        /// <summary> Failed. </summary>
        public static CertificateStatus Failed { get; } = new CertificateStatus(FailedValue);
        /// <summary> InProgress. </summary>
        public static CertificateStatus InProgress { get; } = new CertificateStatus(InProgressValue);
        /// <summary> Determines if two <see cref="CertificateStatus"/> values are the same. </summary>
        public static bool operator ==(CertificateStatus left, CertificateStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CertificateStatus"/> values are not the same. </summary>
        public static bool operator !=(CertificateStatus left, CertificateStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CertificateStatus"/>. </summary>
        public static implicit operator CertificateStatus(string value) => new CertificateStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CertificateStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CertificateStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
