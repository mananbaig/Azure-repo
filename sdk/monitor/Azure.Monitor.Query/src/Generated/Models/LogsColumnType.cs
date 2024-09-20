// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The data type of this column. </summary>
    public readonly partial struct LogsColumnType : IEquatable<LogsColumnType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogsColumnType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogsColumnType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BoolValue = "bool";
        private const string DatetimeValue = "datetime";
        private const string DynamicValue = "dynamic";
        private const string IntValue = "int";
        private const string LongValue = "long";
        private const string RealValue = "real";
        private const string StringValue = "string";
        private const string GuidValue = "guid";
        private const string DecimalValue = "decimal";
        private const string TimespanValue = "timespan";

        /// <summary> bool. </summary>
        public static LogsColumnType Bool { get; } = new LogsColumnType(BoolValue);
        /// <summary> datetime. </summary>
        public static LogsColumnType Datetime { get; } = new LogsColumnType(DatetimeValue);
        /// <summary> dynamic. </summary>
        public static LogsColumnType Dynamic { get; } = new LogsColumnType(DynamicValue);
        /// <summary> int. </summary>
        public static LogsColumnType Int { get; } = new LogsColumnType(IntValue);
        /// <summary> long. </summary>
        public static LogsColumnType Long { get; } = new LogsColumnType(LongValue);
        /// <summary> real. </summary>
        public static LogsColumnType Real { get; } = new LogsColumnType(RealValue);
        /// <summary> string. </summary>
        public static LogsColumnType String { get; } = new LogsColumnType(StringValue);
        /// <summary> guid. </summary>
        public static LogsColumnType Guid { get; } = new LogsColumnType(GuidValue);
        /// <summary> decimal. </summary>
        public static LogsColumnType Decimal { get; } = new LogsColumnType(DecimalValue);
        /// <summary> timespan. </summary>
        public static LogsColumnType Timespan { get; } = new LogsColumnType(TimespanValue);
        /// <summary> Determines if two <see cref="LogsColumnType"/> values are the same. </summary>
        public static bool operator ==(LogsColumnType left, LogsColumnType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogsColumnType"/> values are not the same. </summary>
        public static bool operator !=(LogsColumnType left, LogsColumnType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogsColumnType"/>. </summary>
        public static implicit operator LogsColumnType(string value) => new LogsColumnType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogsColumnType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogsColumnType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
