// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Flag indicating whether file access logs are enabled for the volume, based on active diagnostic settings present on the volume.
    /// Serialized Name: FileAccessLogs
    /// </summary>
    public readonly partial struct NetAppFileAccessLog : IEquatable<NetAppFileAccessLog>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppFileAccessLog"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppFileAccessLog(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary>
        /// fileAccessLogs are enabled
        /// Serialized Name: FileAccessLogs.Enabled
        /// </summary>
        public static NetAppFileAccessLog Enabled { get; } = new NetAppFileAccessLog(EnabledValue);
        /// <summary>
        /// fileAccessLogs are not enabled
        /// Serialized Name: FileAccessLogs.Disabled
        /// </summary>
        public static NetAppFileAccessLog Disabled { get; } = new NetAppFileAccessLog(DisabledValue);
        /// <summary> Determines if two <see cref="NetAppFileAccessLog"/> values are the same. </summary>
        public static bool operator ==(NetAppFileAccessLog left, NetAppFileAccessLog right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppFileAccessLog"/> values are not the same. </summary>
        public static bool operator !=(NetAppFileAccessLog left, NetAppFileAccessLog right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppFileAccessLog"/>. </summary>
        public static implicit operator NetAppFileAccessLog(string value) => new NetAppFileAccessLog(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppFileAccessLog other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppFileAccessLog other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
