// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The content type of call recording. </summary>
    public readonly partial struct RecordingContent : IEquatable<RecordingContent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecordingContent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecordingContent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AudioValue = "audio";
        private const string AudioVideoValue = "audioVideo";

        /// <summary> audio. </summary>
        public static RecordingContent Audio { get; } = new RecordingContent(AudioValue);
        /// <summary> audioVideo. </summary>
        public static RecordingContent AudioVideo { get; } = new RecordingContent(AudioVideoValue);
        /// <summary> Determines if two <see cref="RecordingContent"/> values are the same. </summary>
        public static bool operator ==(RecordingContent left, RecordingContent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecordingContent"/> values are not the same. </summary>
        public static bool operator !=(RecordingContent left, RecordingContent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecordingContent"/>. </summary>
        public static implicit operator RecordingContent(string value) => new RecordingContent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecordingContent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecordingContent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
