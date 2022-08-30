// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The verbosity of logs persisted on the connected registry. </summary>
    public readonly partial struct ConnectedRegistryLogLevel : IEquatable<ConnectedRegistryLogLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryLogLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectedRegistryLogLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DebugValue = "Debug";
        private const string InformationValue = "Information";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string NoneValue = "None";

        /// <summary> Debug. </summary>
        public static ConnectedRegistryLogLevel Debug { get; } = new ConnectedRegistryLogLevel(DebugValue);
        /// <summary> Information. </summary>
        public static ConnectedRegistryLogLevel Information { get; } = new ConnectedRegistryLogLevel(InformationValue);
        /// <summary> Warning. </summary>
        public static ConnectedRegistryLogLevel Warning { get; } = new ConnectedRegistryLogLevel(WarningValue);
        /// <summary> Error. </summary>
        public static ConnectedRegistryLogLevel Error { get; } = new ConnectedRegistryLogLevel(ErrorValue);
        /// <summary> None. </summary>
        public static ConnectedRegistryLogLevel None { get; } = new ConnectedRegistryLogLevel(NoneValue);
        /// <summary> Determines if two <see cref="ConnectedRegistryLogLevel"/> values are the same. </summary>
        public static bool operator ==(ConnectedRegistryLogLevel left, ConnectedRegistryLogLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectedRegistryLogLevel"/> values are not the same. </summary>
        public static bool operator !=(ConnectedRegistryLogLevel left, ConnectedRegistryLogLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectedRegistryLogLevel"/>. </summary>
        public static implicit operator ConnectedRegistryLogLevel(string value) => new ConnectedRegistryLogLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectedRegistryLogLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectedRegistryLogLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
