// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> A string property that indicates the upgrade mode to be performed on the Flink job. It can have one of the following enum values =&gt; STATELESS_UPDATE, UPDATE, LAST_STATE_UPDATE. </summary>
    public readonly partial struct UpgradeMode : IEquatable<UpgradeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UpgradeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpgradeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StatelessUpdateValue = "STATELESS_UPDATE";
        private const string UpdateValue = "UPDATE";
        private const string LastStateUpdateValue = "LAST_STATE_UPDATE";

        /// <summary> STATELESS_UPDATE. </summary>
        public static UpgradeMode StatelessUpdate { get; } = new UpgradeMode(StatelessUpdateValue);
        /// <summary> UPDATE. </summary>
        public static UpgradeMode Update { get; } = new UpgradeMode(UpdateValue);
        /// <summary> LAST_STATE_UPDATE. </summary>
        public static UpgradeMode LastStateUpdate { get; } = new UpgradeMode(LastStateUpdateValue);
        /// <summary> Determines if two <see cref="UpgradeMode"/> values are the same. </summary>
        public static bool operator ==(UpgradeMode left, UpgradeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpgradeMode"/> values are not the same. </summary>
        public static bool operator !=(UpgradeMode left, UpgradeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpgradeMode"/>. </summary>
        public static implicit operator UpgradeMode(string value) => new UpgradeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpgradeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpgradeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
