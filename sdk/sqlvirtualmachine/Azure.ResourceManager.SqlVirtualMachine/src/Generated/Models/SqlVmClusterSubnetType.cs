// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Cluster subnet type. </summary>
    public readonly partial struct SqlVmClusterSubnetType : IEquatable<SqlVmClusterSubnetType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlVmClusterSubnetType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlVmClusterSubnetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleSubnetValue = "SingleSubnet";
        private const string MultiSubnetValue = "MultiSubnet";

        /// <summary> SingleSubnet. </summary>
        public static SqlVmClusterSubnetType SingleSubnet { get; } = new SqlVmClusterSubnetType(SingleSubnetValue);
        /// <summary> MultiSubnet. </summary>
        public static SqlVmClusterSubnetType MultiSubnet { get; } = new SqlVmClusterSubnetType(MultiSubnetValue);
        /// <summary> Determines if two <see cref="SqlVmClusterSubnetType"/> values are the same. </summary>
        public static bool operator ==(SqlVmClusterSubnetType left, SqlVmClusterSubnetType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlVmClusterSubnetType"/> values are not the same. </summary>
        public static bool operator !=(SqlVmClusterSubnetType left, SqlVmClusterSubnetType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlVmClusterSubnetType"/>. </summary>
        public static implicit operator SqlVmClusterSubnetType(string value) => new SqlVmClusterSubnetType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlVmClusterSubnetType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlVmClusterSubnetType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
