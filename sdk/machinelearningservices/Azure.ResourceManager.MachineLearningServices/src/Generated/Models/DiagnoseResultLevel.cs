// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Level of workspace setup error. </summary>
    public readonly partial struct DiagnoseResultLevel : IEquatable<DiagnoseResultLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiagnoseResultLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiagnoseResultLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string InformationValue = "Information";

        /// <summary> Warning. </summary>
        public static DiagnoseResultLevel Warning { get; } = new DiagnoseResultLevel(WarningValue);
        /// <summary> Error. </summary>
        public static DiagnoseResultLevel Error { get; } = new DiagnoseResultLevel(ErrorValue);
        /// <summary> Information. </summary>
        public static DiagnoseResultLevel Information { get; } = new DiagnoseResultLevel(InformationValue);
        /// <summary> Determines if two <see cref="DiagnoseResultLevel"/> values are the same. </summary>
        public static bool operator ==(DiagnoseResultLevel left, DiagnoseResultLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiagnoseResultLevel"/> values are not the same. </summary>
        public static bool operator !=(DiagnoseResultLevel left, DiagnoseResultLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiagnoseResultLevel"/>. </summary>
        public static implicit operator DiagnoseResultLevel(string value) => new DiagnoseResultLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiagnoseResultLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiagnoseResultLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
