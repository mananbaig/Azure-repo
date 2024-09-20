// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The destination of logs. Type: string. </summary>
    public readonly partial struct ScriptActivityLogDestination : IEquatable<ScriptActivityLogDestination>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptActivityLogDestination"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptActivityLogDestination(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActivityOutputValue = "ActivityOutput";
        private const string ExternalStoreValue = "ExternalStore";

        /// <summary> ActivityOutput. </summary>
        public static ScriptActivityLogDestination ActivityOutput { get; } = new ScriptActivityLogDestination(ActivityOutputValue);
        /// <summary> ExternalStore. </summary>
        public static ScriptActivityLogDestination ExternalStore { get; } = new ScriptActivityLogDestination(ExternalStoreValue);
        /// <summary> Determines if two <see cref="ScriptActivityLogDestination"/> values are the same. </summary>
        public static bool operator ==(ScriptActivityLogDestination left, ScriptActivityLogDestination right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptActivityLogDestination"/> values are not the same. </summary>
        public static bool operator !=(ScriptActivityLogDestination left, ScriptActivityLogDestination right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptActivityLogDestination"/>. </summary>
        public static implicit operator ScriptActivityLogDestination(string value) => new ScriptActivityLogDestination(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptActivityLogDestination other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptActivityLogDestination other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
