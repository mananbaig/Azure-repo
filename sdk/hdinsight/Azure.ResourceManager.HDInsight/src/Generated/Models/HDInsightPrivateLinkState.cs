// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Indicates whether or not private link is enabled. </summary>
    public readonly partial struct HDInsightPrivateLinkState : IEquatable<HDInsightPrivateLinkState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightPrivateLinkState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightPrivateLinkState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static HDInsightPrivateLinkState Disabled { get; } = new HDInsightPrivateLinkState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static HDInsightPrivateLinkState Enabled { get; } = new HDInsightPrivateLinkState(EnabledValue);
        /// <summary> Determines if two <see cref="HDInsightPrivateLinkState"/> values are the same. </summary>
        public static bool operator ==(HDInsightPrivateLinkState left, HDInsightPrivateLinkState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightPrivateLinkState"/> values are not the same. </summary>
        public static bool operator !=(HDInsightPrivateLinkState left, HDInsightPrivateLinkState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightPrivateLinkState"/>. </summary>
        public static implicit operator HDInsightPrivateLinkState(string value) => new HDInsightPrivateLinkState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightPrivateLinkState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightPrivateLinkState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
