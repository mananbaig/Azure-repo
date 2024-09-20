// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> All available dynamicsAuthenticationType values. </summary>
    internal readonly partial struct DynamicsAuthenticationType : IEquatable<DynamicsAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynamicsAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynamicsAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Office365Value = "Office365";
        private const string IfdValue = "Ifd";
        private const string AADServicePrincipalValue = "AADServicePrincipal";

        /// <summary> Office365. </summary>
        public static DynamicsAuthenticationType Office365 { get; } = new DynamicsAuthenticationType(Office365Value);
        /// <summary> Ifd. </summary>
        public static DynamicsAuthenticationType Ifd { get; } = new DynamicsAuthenticationType(IfdValue);
        /// <summary> AADServicePrincipal. </summary>
        public static DynamicsAuthenticationType AADServicePrincipal { get; } = new DynamicsAuthenticationType(AADServicePrincipalValue);
        /// <summary> Determines if two <see cref="DynamicsAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(DynamicsAuthenticationType left, DynamicsAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynamicsAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(DynamicsAuthenticationType left, DynamicsAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DynamicsAuthenticationType"/>. </summary>
        public static implicit operator DynamicsAuthenticationType(string value) => new DynamicsAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynamicsAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynamicsAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
