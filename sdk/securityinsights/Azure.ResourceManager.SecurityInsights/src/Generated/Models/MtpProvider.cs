// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The available data providers. </summary>
    public readonly partial struct MtpProvider : IEquatable<MtpProvider>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MtpProvider"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MtpProvider(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftDefenderForCloudAppsValue = "microsoftDefenderForCloudApps";
        private const string MicrosoftDefenderForIdentityValue = "microsoftDefenderForIdentity";

        /// <summary> microsoftDefenderForCloudApps. </summary>
        public static MtpProvider MicrosoftDefenderForCloudApps { get; } = new MtpProvider(MicrosoftDefenderForCloudAppsValue);
        /// <summary> microsoftDefenderForIdentity. </summary>
        public static MtpProvider MicrosoftDefenderForIdentity { get; } = new MtpProvider(MicrosoftDefenderForIdentityValue);
        /// <summary> Determines if two <see cref="MtpProvider"/> values are the same. </summary>
        public static bool operator ==(MtpProvider left, MtpProvider right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MtpProvider"/> values are not the same. </summary>
        public static bool operator !=(MtpProvider left, MtpProvider right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MtpProvider"/>. </summary>
        public static implicit operator MtpProvider(string value) => new MtpProvider(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MtpProvider other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MtpProvider other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
