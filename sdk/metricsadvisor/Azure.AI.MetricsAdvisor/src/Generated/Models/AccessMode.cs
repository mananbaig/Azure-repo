// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> data feed access mode, default is Private. </summary>
    public readonly partial struct AccessMode : IEquatable<AccessMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AccessMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrivateValue = "Private";
        private const string PublicValue = "Public";

        /// <summary> Private. </summary>
        public static AccessMode Private { get; } = new AccessMode(PrivateValue);
        /// <summary> Public. </summary>
        public static AccessMode Public { get; } = new AccessMode(PublicValue);
        /// <summary> Determines if two <see cref="AccessMode"/> values are the same. </summary>
        public static bool operator ==(AccessMode left, AccessMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessMode"/> values are not the same. </summary>
        public static bool operator !=(AccessMode left, AccessMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessMode"/>. </summary>
        public static implicit operator AccessMode(string value) => new AccessMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
