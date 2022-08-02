// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// The kind of service (Stateless or Stateful).
    /// Serialized Name: ServiceKind
    /// </summary>
    internal readonly partial struct ApplicationServiceKind : IEquatable<ApplicationServiceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationServiceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationServiceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string StatelessValue = "Stateless";
        private const string StatefulValue = "Stateful";

        /// <summary>
        /// Indicates the service kind is invalid. All Service Fabric enumerations have the invalid type. The value is zero.
        /// Serialized Name: ServiceKind.Invalid
        /// </summary>
        public static ApplicationServiceKind Invalid { get; } = new ApplicationServiceKind(InvalidValue);
        /// <summary>
        /// Does not use Service Fabric to make its state highly available or reliable. The value is 1.
        /// Serialized Name: ServiceKind.Stateless
        /// </summary>
        public static ApplicationServiceKind Stateless { get; } = new ApplicationServiceKind(StatelessValue);
        /// <summary>
        /// Uses Service Fabric to make its state or part of its state highly available and reliable. The value is 2.
        /// Serialized Name: ServiceKind.Stateful
        /// </summary>
        public static ApplicationServiceKind Stateful { get; } = new ApplicationServiceKind(StatefulValue);
        /// <summary> Determines if two <see cref="ApplicationServiceKind"/> values are the same. </summary>
        public static bool operator ==(ApplicationServiceKind left, ApplicationServiceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationServiceKind"/> values are not the same. </summary>
        public static bool operator !=(ApplicationServiceKind left, ApplicationServiceKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationServiceKind"/>. </summary>
        public static implicit operator ApplicationServiceKind(string value) => new ApplicationServiceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationServiceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationServiceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
