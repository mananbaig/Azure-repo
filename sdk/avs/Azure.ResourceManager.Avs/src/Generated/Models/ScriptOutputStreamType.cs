// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Script Output Stream type. </summary>
    public readonly partial struct ScriptOutputStreamType : IEquatable<ScriptOutputStreamType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptOutputStreamType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptOutputStreamType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InformationValue = "Information";
        private const string WarningValue = "Warning";
        private const string OutputValue = "Output";
        private const string ErrorValue = "Error";

        /// <summary> is information. </summary>
        public static ScriptOutputStreamType Information { get; } = new ScriptOutputStreamType(InformationValue);
        /// <summary> is warning. </summary>
        public static ScriptOutputStreamType Warning { get; } = new ScriptOutputStreamType(WarningValue);
        /// <summary> is output. </summary>
        public static ScriptOutputStreamType Output { get; } = new ScriptOutputStreamType(OutputValue);
        /// <summary> is error. </summary>
        public static ScriptOutputStreamType Error { get; } = new ScriptOutputStreamType(ErrorValue);
        /// <summary> Determines if two <see cref="ScriptOutputStreamType"/> values are the same. </summary>
        public static bool operator ==(ScriptOutputStreamType left, ScriptOutputStreamType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptOutputStreamType"/> values are not the same. </summary>
        public static bool operator !=(ScriptOutputStreamType left, ScriptOutputStreamType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScriptOutputStreamType"/>. </summary>
        public static implicit operator ScriptOutputStreamType(string value) => new ScriptOutputStreamType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptOutputStreamType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptOutputStreamType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
