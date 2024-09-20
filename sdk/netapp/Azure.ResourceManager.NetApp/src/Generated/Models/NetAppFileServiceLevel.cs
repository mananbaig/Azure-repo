// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> The service level of the file system. </summary>
    public readonly partial struct NetAppFileServiceLevel : IEquatable<NetAppFileServiceLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppFileServiceLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppFileServiceLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";
        private const string UltraValue = "Ultra";
        private const string StandardZrsValue = "StandardZRS";

        /// <summary> Standard service level. </summary>
        public static NetAppFileServiceLevel Standard { get; } = new NetAppFileServiceLevel(StandardValue);
        /// <summary> Premium service level. </summary>
        public static NetAppFileServiceLevel Premium { get; } = new NetAppFileServiceLevel(PremiumValue);
        /// <summary> Ultra service level. </summary>
        public static NetAppFileServiceLevel Ultra { get; } = new NetAppFileServiceLevel(UltraValue);
        /// <summary> Zone redundant storage service level. </summary>
        public static NetAppFileServiceLevel StandardZrs { get; } = new NetAppFileServiceLevel(StandardZrsValue);
        /// <summary> Determines if two <see cref="NetAppFileServiceLevel"/> values are the same. </summary>
        public static bool operator ==(NetAppFileServiceLevel left, NetAppFileServiceLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppFileServiceLevel"/> values are not the same. </summary>
        public static bool operator !=(NetAppFileServiceLevel left, NetAppFileServiceLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetAppFileServiceLevel"/>. </summary>
        public static implicit operator NetAppFileServiceLevel(string value) => new NetAppFileServiceLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppFileServiceLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppFileServiceLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
