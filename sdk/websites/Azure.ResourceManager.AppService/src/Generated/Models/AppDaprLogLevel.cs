// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Sets the log level for the Dapr sidecar. Allowed values are debug, info, warn, error. Default is info. </summary>
    public readonly partial struct AppDaprLogLevel : IEquatable<AppDaprLogLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppDaprLogLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppDaprLogLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InfoValue = "info";
        private const string DebugValue = "debug";
        private const string WarnValue = "warn";
        private const string ErrorValue = "error";

        /// <summary> info. </summary>
        public static AppDaprLogLevel Info { get; } = new AppDaprLogLevel(InfoValue);
        /// <summary> debug. </summary>
        public static AppDaprLogLevel Debug { get; } = new AppDaprLogLevel(DebugValue);
        /// <summary> warn. </summary>
        public static AppDaprLogLevel Warn { get; } = new AppDaprLogLevel(WarnValue);
        /// <summary> error. </summary>
        public static AppDaprLogLevel Error { get; } = new AppDaprLogLevel(ErrorValue);
        /// <summary> Determines if two <see cref="AppDaprLogLevel"/> values are the same. </summary>
        public static bool operator ==(AppDaprLogLevel left, AppDaprLogLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppDaprLogLevel"/> values are not the same. </summary>
        public static bool operator !=(AppDaprLogLevel left, AppDaprLogLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppDaprLogLevel"/>. </summary>
        public static implicit operator AppDaprLogLevel(string value) => new AppDaprLogLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppDaprLogLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppDaprLogLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
