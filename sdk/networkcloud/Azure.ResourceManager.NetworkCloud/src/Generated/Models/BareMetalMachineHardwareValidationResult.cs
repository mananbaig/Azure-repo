// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The outcome of the hardware validation. </summary>
    public readonly partial struct BareMetalMachineHardwareValidationResult : IEquatable<BareMetalMachineHardwareValidationResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineHardwareValidationResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BareMetalMachineHardwareValidationResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PassValue = "Pass";
        private const string FailValue = "Fail";

        /// <summary> Pass. </summary>
        public static BareMetalMachineHardwareValidationResult Pass { get; } = new BareMetalMachineHardwareValidationResult(PassValue);
        /// <summary> Fail. </summary>
        public static BareMetalMachineHardwareValidationResult Fail { get; } = new BareMetalMachineHardwareValidationResult(FailValue);
        /// <summary> Determines if two <see cref="BareMetalMachineHardwareValidationResult"/> values are the same. </summary>
        public static bool operator ==(BareMetalMachineHardwareValidationResult left, BareMetalMachineHardwareValidationResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BareMetalMachineHardwareValidationResult"/> values are not the same. </summary>
        public static bool operator !=(BareMetalMachineHardwareValidationResult left, BareMetalMachineHardwareValidationResult right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BareMetalMachineHardwareValidationResult"/>. </summary>
        public static implicit operator BareMetalMachineHardwareValidationResult(string value) => new BareMetalMachineHardwareValidationResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BareMetalMachineHardwareValidationResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BareMetalMachineHardwareValidationResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
