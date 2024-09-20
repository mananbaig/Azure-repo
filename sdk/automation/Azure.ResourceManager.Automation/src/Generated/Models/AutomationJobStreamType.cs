// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Gets or sets the stream type. </summary>
    public readonly partial struct AutomationJobStreamType : IEquatable<AutomationJobStreamType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationJobStreamType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationJobStreamType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProgressValue = "Progress";
        private const string OutputValue = "Output";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string DebugValue = "Debug";
        private const string VerboseValue = "Verbose";
        private const string AnyValue = "Any";

        /// <summary> Progress. </summary>
        public static AutomationJobStreamType Progress { get; } = new AutomationJobStreamType(ProgressValue);
        /// <summary> Output. </summary>
        public static AutomationJobStreamType Output { get; } = new AutomationJobStreamType(OutputValue);
        /// <summary> Warning. </summary>
        public static AutomationJobStreamType Warning { get; } = new AutomationJobStreamType(WarningValue);
        /// <summary> Error. </summary>
        public static AutomationJobStreamType Error { get; } = new AutomationJobStreamType(ErrorValue);
        /// <summary> Debug. </summary>
        public static AutomationJobStreamType Debug { get; } = new AutomationJobStreamType(DebugValue);
        /// <summary> Verbose. </summary>
        public static AutomationJobStreamType Verbose { get; } = new AutomationJobStreamType(VerboseValue);
        /// <summary> Any. </summary>
        public static AutomationJobStreamType Any { get; } = new AutomationJobStreamType(AnyValue);
        /// <summary> Determines if two <see cref="AutomationJobStreamType"/> values are the same. </summary>
        public static bool operator ==(AutomationJobStreamType left, AutomationJobStreamType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationJobStreamType"/> values are not the same. </summary>
        public static bool operator !=(AutomationJobStreamType left, AutomationJobStreamType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationJobStreamType"/>. </summary>
        public static implicit operator AutomationJobStreamType(string value) => new AutomationJobStreamType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationJobStreamType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationJobStreamType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
