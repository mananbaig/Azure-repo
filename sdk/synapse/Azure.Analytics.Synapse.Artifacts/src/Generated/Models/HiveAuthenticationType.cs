// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The authentication method used to access the Hive server. </summary>
    public readonly partial struct HiveAuthenticationType : IEquatable<HiveAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HiveAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HiveAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnonymousValue = "Anonymous";
        private const string UsernameValue = "Username";
        private const string UsernameAndPasswordValue = "UsernameAndPassword";
        private const string WindowsAzureHDInsightServiceValue = "WindowsAzureHDInsightService";

        /// <summary> Anonymous. </summary>
        public static HiveAuthenticationType Anonymous { get; } = new HiveAuthenticationType(AnonymousValue);
        /// <summary> Username. </summary>
        public static HiveAuthenticationType Username { get; } = new HiveAuthenticationType(UsernameValue);
        /// <summary> UsernameAndPassword. </summary>
        public static HiveAuthenticationType UsernameAndPassword { get; } = new HiveAuthenticationType(UsernameAndPasswordValue);
        /// <summary> WindowsAzureHDInsightService. </summary>
        public static HiveAuthenticationType WindowsAzureHDInsightService { get; } = new HiveAuthenticationType(WindowsAzureHDInsightServiceValue);
        /// <summary> Determines if two <see cref="HiveAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(HiveAuthenticationType left, HiveAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HiveAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(HiveAuthenticationType left, HiveAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HiveAuthenticationType"/>. </summary>
        public static implicit operator HiveAuthenticationType(string value) => new HiveAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HiveAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HiveAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
