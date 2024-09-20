// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Gets the type of restrictions. Possible values include: 'Location', 'Zone'. </summary>
    public readonly partial struct AppPlatformSkuRestrictionsType : IEquatable<AppPlatformSkuRestrictionsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuRestrictionsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformSkuRestrictionsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocationValue = "Location";
        private const string ZoneValue = "Zone";

        /// <summary> Location. </summary>
        public static AppPlatformSkuRestrictionsType Location { get; } = new AppPlatformSkuRestrictionsType(LocationValue);
        /// <summary> Zone. </summary>
        public static AppPlatformSkuRestrictionsType Zone { get; } = new AppPlatformSkuRestrictionsType(ZoneValue);
        /// <summary> Determines if two <see cref="AppPlatformSkuRestrictionsType"/> values are the same. </summary>
        public static bool operator ==(AppPlatformSkuRestrictionsType left, AppPlatformSkuRestrictionsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformSkuRestrictionsType"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformSkuRestrictionsType left, AppPlatformSkuRestrictionsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppPlatformSkuRestrictionsType"/>. </summary>
        public static implicit operator AppPlatformSkuRestrictionsType(string value) => new AppPlatformSkuRestrictionsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformSkuRestrictionsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformSkuRestrictionsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
