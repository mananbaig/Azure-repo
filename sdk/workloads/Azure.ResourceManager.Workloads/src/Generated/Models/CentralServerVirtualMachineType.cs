// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the type of central server VM. </summary>
    public readonly partial struct CentralServerVirtualMachineType : IEquatable<CentralServerVirtualMachineType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CentralServerVirtualMachineType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CentralServerVirtualMachineType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";
        private const string UnknownValue = "Unknown";
        private const string AscsValue = "ASCS";
        private const string ErsInactiveValue = "ERSInactive";
        private const string ErsValue = "ERS";
        private const string StandbyValue = "Standby";

        /// <summary> Primary. </summary>
        public static CentralServerVirtualMachineType Primary { get; } = new CentralServerVirtualMachineType(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static CentralServerVirtualMachineType Secondary { get; } = new CentralServerVirtualMachineType(SecondaryValue);
        /// <summary> Unknown. </summary>
        public static CentralServerVirtualMachineType Unknown { get; } = new CentralServerVirtualMachineType(UnknownValue);
        /// <summary> ASCS. </summary>
        public static CentralServerVirtualMachineType Ascs { get; } = new CentralServerVirtualMachineType(AscsValue);
        /// <summary> ERSInactive. </summary>
        public static CentralServerVirtualMachineType ErsInactive { get; } = new CentralServerVirtualMachineType(ErsInactiveValue);
        /// <summary> ERS. </summary>
        public static CentralServerVirtualMachineType Ers { get; } = new CentralServerVirtualMachineType(ErsValue);
        /// <summary> Standby. </summary>
        public static CentralServerVirtualMachineType Standby { get; } = new CentralServerVirtualMachineType(StandbyValue);
        /// <summary> Determines if two <see cref="CentralServerVirtualMachineType"/> values are the same. </summary>
        public static bool operator ==(CentralServerVirtualMachineType left, CentralServerVirtualMachineType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CentralServerVirtualMachineType"/> values are not the same. </summary>
        public static bool operator !=(CentralServerVirtualMachineType left, CentralServerVirtualMachineType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CentralServerVirtualMachineType"/>. </summary>
        public static implicit operator CentralServerVirtualMachineType(string value) => new CentralServerVirtualMachineType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CentralServerVirtualMachineType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CentralServerVirtualMachineType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
