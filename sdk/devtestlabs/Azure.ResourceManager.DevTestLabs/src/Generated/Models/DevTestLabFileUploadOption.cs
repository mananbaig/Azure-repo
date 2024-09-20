// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Options for uploading the files for the artifact. UploadFilesAndGenerateSasTokens is the default value. </summary>
    public readonly partial struct DevTestLabFileUploadOption : IEquatable<DevTestLabFileUploadOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabFileUploadOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabFileUploadOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UploadFilesAndGenerateSasTokensValue = "UploadFilesAndGenerateSasTokens";
        private const string NoneValue = "None";

        /// <summary> UploadFilesAndGenerateSasTokens. </summary>
        public static DevTestLabFileUploadOption UploadFilesAndGenerateSasTokens { get; } = new DevTestLabFileUploadOption(UploadFilesAndGenerateSasTokensValue);
        /// <summary> None. </summary>
        public static DevTestLabFileUploadOption None { get; } = new DevTestLabFileUploadOption(NoneValue);
        /// <summary> Determines if two <see cref="DevTestLabFileUploadOption"/> values are the same. </summary>
        public static bool operator ==(DevTestLabFileUploadOption left, DevTestLabFileUploadOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabFileUploadOption"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabFileUploadOption left, DevTestLabFileUploadOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevTestLabFileUploadOption"/>. </summary>
        public static implicit operator DevTestLabFileUploadOption(string value) => new DevTestLabFileUploadOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabFileUploadOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabFileUploadOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
