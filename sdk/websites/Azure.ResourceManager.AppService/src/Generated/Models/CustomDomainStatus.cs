// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The status of the custom domain. </summary>
    public readonly partial struct CustomDomainStatus : IEquatable<CustomDomainStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CustomDomainStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CustomDomainStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RetrievingValidationTokenValue = "RetrievingValidationToken";
        private const string ValidatingValue = "Validating";
        private const string AddingValue = "Adding";
        private const string ReadyValue = "Ready";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";
        private const string UnhealthyValue = "Unhealthy";

        /// <summary> RetrievingValidationToken. </summary>
        public static CustomDomainStatus RetrievingValidationToken { get; } = new CustomDomainStatus(RetrievingValidationTokenValue);
        /// <summary> Validating. </summary>
        public static CustomDomainStatus Validating { get; } = new CustomDomainStatus(ValidatingValue);
        /// <summary> Adding. </summary>
        public static CustomDomainStatus Adding { get; } = new CustomDomainStatus(AddingValue);
        /// <summary> Ready. </summary>
        public static CustomDomainStatus Ready { get; } = new CustomDomainStatus(ReadyValue);
        /// <summary> Failed. </summary>
        public static CustomDomainStatus Failed { get; } = new CustomDomainStatus(FailedValue);
        /// <summary> Deleting. </summary>
        public static CustomDomainStatus Deleting { get; } = new CustomDomainStatus(DeletingValue);
        /// <summary> Unhealthy. </summary>
        public static CustomDomainStatus Unhealthy { get; } = new CustomDomainStatus(UnhealthyValue);
        /// <summary> Determines if two <see cref="CustomDomainStatus"/> values are the same. </summary>
        public static bool operator ==(CustomDomainStatus left, CustomDomainStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CustomDomainStatus"/> values are not the same. </summary>
        public static bool operator !=(CustomDomainStatus left, CustomDomainStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CustomDomainStatus"/>. </summary>
        public static implicit operator CustomDomainStatus(string value) => new CustomDomainStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CustomDomainStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CustomDomainStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
