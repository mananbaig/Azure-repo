// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> Field Deprecated, use virtualizationModel instead. The type of the virtio interface. </summary>
    public readonly partial struct VirtualMachineVirtioInterfaceType : IEquatable<VirtualMachineVirtioInterfaceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineVirtioInterfaceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineVirtioInterfaceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ModernValue = "Modern";
        private const string TransitionalValue = "Transitional";

        /// <summary> Modern. </summary>
        public static VirtualMachineVirtioInterfaceType Modern { get; } = new VirtualMachineVirtioInterfaceType(ModernValue);
        /// <summary> Transitional. </summary>
        public static VirtualMachineVirtioInterfaceType Transitional { get; } = new VirtualMachineVirtioInterfaceType(TransitionalValue);
        /// <summary> Determines if two <see cref="VirtualMachineVirtioInterfaceType"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineVirtioInterfaceType left, VirtualMachineVirtioInterfaceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineVirtioInterfaceType"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineVirtioInterfaceType left, VirtualMachineVirtioInterfaceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualMachineVirtioInterfaceType"/>. </summary>
        public static implicit operator VirtualMachineVirtioInterfaceType(string value) => new VirtualMachineVirtioInterfaceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineVirtioInterfaceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineVirtioInterfaceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
