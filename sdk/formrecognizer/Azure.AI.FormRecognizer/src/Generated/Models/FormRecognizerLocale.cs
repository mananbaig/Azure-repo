// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer
{
    /// <summary> The Locale. </summary>
    public readonly partial struct FormRecognizerLocale : IEquatable<FormRecognizerLocale>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FormRecognizerLocale"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FormRecognizerLocale(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnAUValue = "en-AU";
        private const string EnCAValue = "en-CA";
        private const string EnGBValue = "en-GB";
        private const string EnINValue = "en-IN";
        private const string EnUSValue = "en-US";

        /// <summary> en-AU. </summary>
        public static FormRecognizerLocale EnAU { get; } = new FormRecognizerLocale(EnAUValue);
        /// <summary> en-CA. </summary>
        public static FormRecognizerLocale EnCA { get; } = new FormRecognizerLocale(EnCAValue);
        /// <summary> en-GB. </summary>
        public static FormRecognizerLocale EnGB { get; } = new FormRecognizerLocale(EnGBValue);
        /// <summary> en-IN. </summary>
        public static FormRecognizerLocale EnIN { get; } = new FormRecognizerLocale(EnINValue);
        /// <summary> en-US. </summary>
        public static FormRecognizerLocale EnUS { get; } = new FormRecognizerLocale(EnUSValue);
        /// <summary> Determines if two <see cref="FormRecognizerLocale"/> values are the same. </summary>
        public static bool operator ==(FormRecognizerLocale left, FormRecognizerLocale right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FormRecognizerLocale"/> values are not the same. </summary>
        public static bool operator !=(FormRecognizerLocale left, FormRecognizerLocale right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FormRecognizerLocale"/>. </summary>
        public static implicit operator FormRecognizerLocale(string value) => new FormRecognizerLocale(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FormRecognizerLocale other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FormRecognizerLocale other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
