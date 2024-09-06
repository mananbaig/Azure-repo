// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Specifies the data types to use when storing values in the registry, or identifies the data type of a value in the registry.
    /// Serialized Name: RegistryValueKind
    /// </summary>
    public readonly partial struct SecurityInsightsRegistryValueKind : IEquatable<SecurityInsightsRegistryValueKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsRegistryValueKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsRegistryValueKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string UnknownValue = "Unknown";
        private const string StringValue = "String";
        private const string ExpandStringValue = "ExpandString";
        private const string BinaryValue = "Binary";
        private const string DWordValue = "DWord";
        private const string MultiStringValue = "MultiString";
        private const string QWordValue = "QWord";

        /// <summary>
        /// None
        /// Serialized Name: RegistryValueKind.None
        /// </summary>
        public static SecurityInsightsRegistryValueKind None { get; } = new SecurityInsightsRegistryValueKind(NoneValue);
        /// <summary>
        /// Unknown value type
        /// Serialized Name: RegistryValueKind.Unknown
        /// </summary>
        public static SecurityInsightsRegistryValueKind Unknown { get; } = new SecurityInsightsRegistryValueKind(UnknownValue);
        /// <summary>
        /// String value type
        /// Serialized Name: RegistryValueKind.String
        /// </summary>
        public static SecurityInsightsRegistryValueKind String { get; } = new SecurityInsightsRegistryValueKind(StringValue);
        /// <summary>
        /// ExpandString value type
        /// Serialized Name: RegistryValueKind.ExpandString
        /// </summary>
        public static SecurityInsightsRegistryValueKind ExpandString { get; } = new SecurityInsightsRegistryValueKind(ExpandStringValue);
        /// <summary>
        /// Binary value type
        /// Serialized Name: RegistryValueKind.Binary
        /// </summary>
        public static SecurityInsightsRegistryValueKind Binary { get; } = new SecurityInsightsRegistryValueKind(BinaryValue);
        /// <summary>
        /// DWord value type
        /// Serialized Name: RegistryValueKind.DWord
        /// </summary>
        public static SecurityInsightsRegistryValueKind DWord { get; } = new SecurityInsightsRegistryValueKind(DWordValue);
        /// <summary>
        /// MultiString value type
        /// Serialized Name: RegistryValueKind.MultiString
        /// </summary>
        public static SecurityInsightsRegistryValueKind MultiString { get; } = new SecurityInsightsRegistryValueKind(MultiStringValue);
        /// <summary>
        /// QWord value type
        /// Serialized Name: RegistryValueKind.QWord
        /// </summary>
        public static SecurityInsightsRegistryValueKind QWord { get; } = new SecurityInsightsRegistryValueKind(QWordValue);
        /// <summary> Determines if two <see cref="SecurityInsightsRegistryValueKind"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsRegistryValueKind left, SecurityInsightsRegistryValueKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsRegistryValueKind"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsRegistryValueKind left, SecurityInsightsRegistryValueKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsRegistryValueKind"/>. </summary>
        public static implicit operator SecurityInsightsRegistryValueKind(string value) => new SecurityInsightsRegistryValueKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsRegistryValueKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsRegistryValueKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
