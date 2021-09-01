// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This property allows you to specify the type of sharing group. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Subscriptions** &lt;br&gt;&lt;br&gt; **AADTenants**. </summary>
    public readonly partial struct SharingProfileGroupTypes : IEquatable<SharingProfileGroupTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SharingProfileGroupTypes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SharingProfileGroupTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SubscriptionsValue = "Subscriptions";
        private const string AADTenantsValue = "AADTenants";

        /// <summary> Subscriptions. </summary>
        public static SharingProfileGroupTypes Subscriptions { get; } = new SharingProfileGroupTypes(SubscriptionsValue);
        /// <summary> AADTenants. </summary>
        public static SharingProfileGroupTypes AADTenants { get; } = new SharingProfileGroupTypes(AADTenantsValue);
        /// <summary> Determines if two <see cref="SharingProfileGroupTypes"/> values are the same. </summary>
        public static bool operator ==(SharingProfileGroupTypes left, SharingProfileGroupTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SharingProfileGroupTypes"/> values are not the same. </summary>
        public static bool operator !=(SharingProfileGroupTypes left, SharingProfileGroupTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SharingProfileGroupTypes"/>. </summary>
        public static implicit operator SharingProfileGroupTypes(string value) => new SharingProfileGroupTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SharingProfileGroupTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SharingProfileGroupTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
