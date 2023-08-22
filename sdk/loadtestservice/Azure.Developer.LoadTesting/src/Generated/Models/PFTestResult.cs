// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Test result for pass/Fail criteria used during the test run. </summary>
    public readonly partial struct PFTestResult : IEquatable<PFTestResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PFTestResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PFTestResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PassedValue = "PASSED";
        private const string NOTApplicableValue = "NOT_APPLICABLE";
        private const string FailedValue = "FAILED";

        /// <summary> Pass/fail criteria has passed. </summary>
        public static PFTestResult Passed { get; } = new PFTestResult(PassedValue);
        /// <summary> Pass/fail criteria is not applicable. </summary>
        public static PFTestResult NOTApplicable { get; } = new PFTestResult(NOTApplicableValue);
        /// <summary> Pass/fail criteria has failed. </summary>
        public static PFTestResult Failed { get; } = new PFTestResult(FailedValue);
        /// <summary> Determines if two <see cref="PFTestResult"/> values are the same. </summary>
        public static bool operator ==(PFTestResult left, PFTestResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PFTestResult"/> values are not the same. </summary>
        public static bool operator !=(PFTestResult left, PFTestResult right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PFTestResult"/>. </summary>
        public static implicit operator PFTestResult(string value) => new PFTestResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PFTestResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PFTestResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
