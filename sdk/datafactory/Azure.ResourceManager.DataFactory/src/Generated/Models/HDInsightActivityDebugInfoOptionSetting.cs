// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The HDInsightActivityDebugInfoOption settings to use. </summary>
    public readonly partial struct HDInsightActivityDebugInfoOptionSetting : IEquatable<HDInsightActivityDebugInfoOptionSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightActivityDebugInfoOptionSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightActivityDebugInfoOptionSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AlwaysValue = "Always";
        private const string FailureValue = "Failure";

        /// <summary> None. </summary>
        public static HDInsightActivityDebugInfoOptionSetting None { get; } = new HDInsightActivityDebugInfoOptionSetting(NoneValue);
        /// <summary> Always. </summary>
        public static HDInsightActivityDebugInfoOptionSetting Always { get; } = new HDInsightActivityDebugInfoOptionSetting(AlwaysValue);
        /// <summary> Failure. </summary>
        public static HDInsightActivityDebugInfoOptionSetting Failure { get; } = new HDInsightActivityDebugInfoOptionSetting(FailureValue);
        /// <summary> Determines if two <see cref="HDInsightActivityDebugInfoOptionSetting"/> values are the same. </summary>
        public static bool operator ==(HDInsightActivityDebugInfoOptionSetting left, HDInsightActivityDebugInfoOptionSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightActivityDebugInfoOptionSetting"/> values are not the same. </summary>
        public static bool operator !=(HDInsightActivityDebugInfoOptionSetting left, HDInsightActivityDebugInfoOptionSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightActivityDebugInfoOptionSetting"/>. </summary>
        public static implicit operator HDInsightActivityDebugInfoOptionSetting(string value) => new HDInsightActivityDebugInfoOptionSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightActivityDebugInfoOptionSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightActivityDebugInfoOptionSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
