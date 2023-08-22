// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> The Interval. </summary>
    public readonly partial struct Interval : IEquatable<Interval>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Interval"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Interval(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PT5SValue = "PT5S";
        private const string PT10SValue = "PT10S";
        private const string PT1MValue = "PT1M";
        private const string PT5MValue = "PT5M";
        private const string PT1HValue = "PT1H";

        /// <summary> 5 seconds, available only if test run duration is less than 10 minutes. </summary>
        public static Interval PT5S { get; } = new Interval(PT5SValue);
        /// <summary> 10 seconds, available only if test run duration is less than 10 minutes. </summary>
        public static Interval PT10S { get; } = new Interval(PT10SValue);
        /// <summary> 1 minute. </summary>
        public static Interval PT1M { get; } = new Interval(PT1MValue);
        /// <summary> 5 minutes, available only if test run duration is greater than 1 minute. </summary>
        public static Interval PT5M { get; } = new Interval(PT5MValue);
        /// <summary> 1 hour, available only if test run duration is greater than 1 minute. </summary>
        public static Interval PT1H { get; } = new Interval(PT1HValue);
        /// <summary> Determines if two <see cref="Interval"/> values are the same. </summary>
        public static bool operator ==(Interval left, Interval right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Interval"/> values are not the same. </summary>
        public static bool operator !=(Interval left, Interval right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Interval"/>. </summary>
        public static implicit operator Interval(string value) => new Interval(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Interval other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Interval other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
