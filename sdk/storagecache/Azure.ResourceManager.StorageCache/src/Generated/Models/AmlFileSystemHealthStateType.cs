// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> List of AML file system health states. </summary>
    public readonly partial struct AmlFileSystemHealthStateType : IEquatable<AmlFileSystemHealthStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHealthStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AmlFileSystemHealthStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnavailableValue = "Unavailable";
        private const string AvailableValue = "Available";
        private const string DegradedValue = "Degraded";
        private const string TransitioningValue = "Transitioning";
        private const string MaintenanceValue = "Maintenance";

        /// <summary> Unavailable. </summary>
        public static AmlFileSystemHealthStateType Unavailable { get; } = new AmlFileSystemHealthStateType(UnavailableValue);
        /// <summary> Available. </summary>
        public static AmlFileSystemHealthStateType Available { get; } = new AmlFileSystemHealthStateType(AvailableValue);
        /// <summary> Degraded. </summary>
        public static AmlFileSystemHealthStateType Degraded { get; } = new AmlFileSystemHealthStateType(DegradedValue);
        /// <summary> Transitioning. </summary>
        public static AmlFileSystemHealthStateType Transitioning { get; } = new AmlFileSystemHealthStateType(TransitioningValue);
        /// <summary> Maintenance. </summary>
        public static AmlFileSystemHealthStateType Maintenance { get; } = new AmlFileSystemHealthStateType(MaintenanceValue);
        /// <summary> Determines if two <see cref="AmlFileSystemHealthStateType"/> values are the same. </summary>
        public static bool operator ==(AmlFileSystemHealthStateType left, AmlFileSystemHealthStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AmlFileSystemHealthStateType"/> values are not the same. </summary>
        public static bool operator !=(AmlFileSystemHealthStateType left, AmlFileSystemHealthStateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AmlFileSystemHealthStateType"/>. </summary>
        public static implicit operator AmlFileSystemHealthStateType(string value) => new AmlFileSystemHealthStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AmlFileSystemHealthStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AmlFileSystemHealthStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
