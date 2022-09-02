// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The data format of the log files. </summary>
    public readonly partial struct LogFilesDataSourceFormat : IEquatable<LogFilesDataSourceFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogFilesDataSourceFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogFilesDataSourceFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";

        /// <summary> text. </summary>
        public static LogFilesDataSourceFormat Text { get; } = new LogFilesDataSourceFormat(TextValue);
        /// <summary> Determines if two <see cref="LogFilesDataSourceFormat"/> values are the same. </summary>
        public static bool operator ==(LogFilesDataSourceFormat left, LogFilesDataSourceFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogFilesDataSourceFormat"/> values are not the same. </summary>
        public static bool operator !=(LogFilesDataSourceFormat left, LogFilesDataSourceFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogFilesDataSourceFormat"/>. </summary>
        public static implicit operator LogFilesDataSourceFormat(string value) => new LogFilesDataSourceFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogFilesDataSourceFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogFilesDataSourceFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
