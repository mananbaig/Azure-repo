// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Flag indicating whether subvolume operations are enabled on the volume. </summary>
    public readonly partial struct EnableNetAppSubvolume : IEquatable<EnableNetAppSubvolume>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnableNetAppSubvolume"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnableNetAppSubvolume(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> subvolumes are enabled. </summary>
        public static EnableNetAppSubvolume Enabled { get; } = new EnableNetAppSubvolume(EnabledValue);
        /// <summary> subvolumes are not enabled. </summary>
        public static EnableNetAppSubvolume Disabled { get; } = new EnableNetAppSubvolume(DisabledValue);
        /// <summary> Determines if two <see cref="EnableNetAppSubvolume"/> values are the same. </summary>
        public static bool operator ==(EnableNetAppSubvolume left, EnableNetAppSubvolume right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnableNetAppSubvolume"/> values are not the same. </summary>
        public static bool operator !=(EnableNetAppSubvolume left, EnableNetAppSubvolume right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnableNetAppSubvolume"/>. </summary>
        public static implicit operator EnableNetAppSubvolume(string value) => new EnableNetAppSubvolume(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnableNetAppSubvolume other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnableNetAppSubvolume other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
