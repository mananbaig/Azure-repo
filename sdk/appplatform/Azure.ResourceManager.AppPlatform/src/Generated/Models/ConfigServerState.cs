// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> State of the config server. </summary>
    public readonly partial struct ConfigServerState : IEquatable<ConfigServerState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfigServerState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigServerState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotAvailableValue = "NotAvailable";
        private const string DeletedValue = "Deleted";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";

        /// <summary> NotAvailable. </summary>
        public static ConfigServerState NotAvailable { get; } = new ConfigServerState(NotAvailableValue);
        /// <summary> Deleted. </summary>
        public static ConfigServerState Deleted { get; } = new ConfigServerState(DeletedValue);
        /// <summary> Failed. </summary>
        public static ConfigServerState Failed { get; } = new ConfigServerState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static ConfigServerState Succeeded { get; } = new ConfigServerState(SucceededValue);
        /// <summary> Updating. </summary>
        public static ConfigServerState Updating { get; } = new ConfigServerState(UpdatingValue);
        /// <summary> Determines if two <see cref="ConfigServerState"/> values are the same. </summary>
        public static bool operator ==(ConfigServerState left, ConfigServerState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigServerState"/> values are not the same. </summary>
        public static bool operator !=(ConfigServerState left, ConfigServerState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfigServerState"/>. </summary>
        public static implicit operator ConfigServerState(string value) => new ConfigServerState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigServerState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigServerState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
