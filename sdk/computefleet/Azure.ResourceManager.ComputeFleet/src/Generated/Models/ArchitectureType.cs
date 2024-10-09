// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Architecture types supported by Azure VMs. </summary>
    public readonly partial struct ArchitectureType : IEquatable<ArchitectureType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArchitectureType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArchitectureType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ARM64Value = "ARM64";
        private const string X86Value = "X86";

        /// <summary> ARM64 Architecture. </summary>
        public static ArchitectureType ARM64 { get; } = new ArchitectureType(ARM64Value);
        /// <summary> X86 Architecture. </summary>
        public static ArchitectureType X86 { get; } = new ArchitectureType(X86Value);
        /// <summary> Determines if two <see cref="ArchitectureType"/> values are the same. </summary>
        public static bool operator ==(ArchitectureType left, ArchitectureType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArchitectureType"/> values are not the same. </summary>
        public static bool operator !=(ArchitectureType left, ArchitectureType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ArchitectureType"/>. </summary>
        public static implicit operator ArchitectureType(string value) => new ArchitectureType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArchitectureType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArchitectureType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
