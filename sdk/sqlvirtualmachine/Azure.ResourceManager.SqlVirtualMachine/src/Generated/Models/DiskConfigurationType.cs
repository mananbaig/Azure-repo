// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Disk configuration to apply to SQL Server. </summary>
    public readonly partial struct DiskConfigurationType : IEquatable<DiskConfigurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskConfigurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewValue = "NEW";
        private const string ExtendValue = "EXTEND";
        private const string AddValue = "ADD";

        /// <summary> NEW. </summary>
        public static DiskConfigurationType New { get; } = new DiskConfigurationType(NewValue);
        /// <summary> EXTEND. </summary>
        public static DiskConfigurationType Extend { get; } = new DiskConfigurationType(ExtendValue);
        /// <summary> ADD. </summary>
        public static DiskConfigurationType Add { get; } = new DiskConfigurationType(AddValue);
        /// <summary> Determines if two <see cref="DiskConfigurationType"/> values are the same. </summary>
        public static bool operator ==(DiskConfigurationType left, DiskConfigurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskConfigurationType"/> values are not the same. </summary>
        public static bool operator !=(DiskConfigurationType left, DiskConfigurationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskConfigurationType"/>. </summary>
        public static implicit operator DiskConfigurationType(string value) => new DiskConfigurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskConfigurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskConfigurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
