// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Enum to determine the datastore secrets type. </summary>
    public readonly partial struct SecretsType : IEquatable<SecretsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecretsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecretsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountKeyValue = "AccountKey";
        private const string CertificateValue = "Certificate";
        private const string SasValue = "Sas";
        private const string ServicePrincipalValue = "ServicePrincipal";

        /// <summary> AccountKey. </summary>
        public static SecretsType AccountKey { get; } = new SecretsType(AccountKeyValue);
        /// <summary> Certificate. </summary>
        public static SecretsType Certificate { get; } = new SecretsType(CertificateValue);
        /// <summary> Sas. </summary>
        public static SecretsType Sas { get; } = new SecretsType(SasValue);
        /// <summary> ServicePrincipal. </summary>
        public static SecretsType ServicePrincipal { get; } = new SecretsType(ServicePrincipalValue);
        /// <summary> Determines if two <see cref="SecretsType"/> values are the same. </summary>
        public static bool operator ==(SecretsType left, SecretsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecretsType"/> values are not the same. </summary>
        public static bool operator !=(SecretsType left, SecretsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecretsType"/>. </summary>
        public static implicit operator SecretsType(string value) => new SecretsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecretsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecretsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
