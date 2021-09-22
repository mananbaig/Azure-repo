// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Stored procedure parameter type. </summary>
    public readonly partial struct StoredProcedureParameterType : IEquatable<StoredProcedureParameterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StoredProcedureParameterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StoredProcedureParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "String";
        private const string IntValue = "Int";
        private const string Int64Value = "Int64";
        private const string DecimalValue = "Decimal";
        private const string GuidValue = "Guid";
        private const string BooleanValue = "Boolean";
        private const string DateValue = "Date";

        /// <summary> String. </summary>
        public static StoredProcedureParameterType String { get; } = new StoredProcedureParameterType(StringValue);
        /// <summary> Int. </summary>
        public static StoredProcedureParameterType Int { get; } = new StoredProcedureParameterType(IntValue);
        /// <summary> Int64. </summary>
        public static StoredProcedureParameterType Int64 { get; } = new StoredProcedureParameterType(Int64Value);
        /// <summary> Decimal. </summary>
        public static StoredProcedureParameterType Decimal { get; } = new StoredProcedureParameterType(DecimalValue);
        /// <summary> Guid. </summary>
        public static StoredProcedureParameterType Guid { get; } = new StoredProcedureParameterType(GuidValue);
        /// <summary> Boolean. </summary>
        public static StoredProcedureParameterType Boolean { get; } = new StoredProcedureParameterType(BooleanValue);
        /// <summary> Date. </summary>
        public static StoredProcedureParameterType Date { get; } = new StoredProcedureParameterType(DateValue);
        /// <summary> Determines if two <see cref="StoredProcedureParameterType"/> values are the same. </summary>
        public static bool operator ==(StoredProcedureParameterType left, StoredProcedureParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StoredProcedureParameterType"/> values are not the same. </summary>
        public static bool operator !=(StoredProcedureParameterType left, StoredProcedureParameterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StoredProcedureParameterType"/>. </summary>
        public static implicit operator StoredProcedureParameterType(string value) => new StoredProcedureParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StoredProcedureParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StoredProcedureParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
