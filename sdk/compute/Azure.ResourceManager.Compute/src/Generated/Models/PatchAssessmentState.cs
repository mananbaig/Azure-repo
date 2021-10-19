// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the availability of a given patch. </summary>
    public readonly partial struct PatchAssessmentState : IEquatable<PatchAssessmentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PatchAssessmentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PatchAssessmentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AvailableValue = "Available";

        /// <summary> Unknown. </summary>
        public static PatchAssessmentState Unknown { get; } = new PatchAssessmentState(UnknownValue);
        /// <summary> Available. </summary>
        public static PatchAssessmentState Available { get; } = new PatchAssessmentState(AvailableValue);
        /// <summary> Determines if two <see cref="PatchAssessmentState"/> values are the same. </summary>
        public static bool operator ==(PatchAssessmentState left, PatchAssessmentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PatchAssessmentState"/> values are not the same. </summary>
        public static bool operator !=(PatchAssessmentState left, PatchAssessmentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PatchAssessmentState"/>. </summary>
        public static implicit operator PatchAssessmentState(string value) => new PatchAssessmentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PatchAssessmentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PatchAssessmentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
