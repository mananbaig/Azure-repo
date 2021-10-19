// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A string indicating what entity categories to return. </summary>
    public readonly partial struct EntityCategory : IEquatable<EntityCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EntityCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntityCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocationValue = "location";
        private const string OrganizationValue = "organization";
        private const string PersonValue = "person";
        private const string QuantityValue = "quantity";
        private const string DatetimeValue = "datetime";
        private const string UrlValue = "url";
        private const string EmailValue = "email";

        /// <summary> Entities describing a physical location. </summary>
        public static EntityCategory Location { get; } = new EntityCategory(LocationValue);
        /// <summary> Entities describing an organization. </summary>
        public static EntityCategory Organization { get; } = new EntityCategory(OrganizationValue);
        /// <summary> Entities describing a person. </summary>
        public static EntityCategory Person { get; } = new EntityCategory(PersonValue);
        /// <summary> Entities describing a quantity. </summary>
        public static EntityCategory Quantity { get; } = new EntityCategory(QuantityValue);
        /// <summary> Entities describing a date and time. </summary>
        public static EntityCategory Datetime { get; } = new EntityCategory(DatetimeValue);
        /// <summary> Entities describing a URL. </summary>
        public static EntityCategory Url { get; } = new EntityCategory(UrlValue);
        /// <summary> Entities describing an email address. </summary>
        public static EntityCategory Email { get; } = new EntityCategory(EmailValue);
        /// <summary> Determines if two <see cref="EntityCategory"/> values are the same. </summary>
        public static bool operator ==(EntityCategory left, EntityCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntityCategory"/> values are not the same. </summary>
        public static bool operator !=(EntityCategory left, EntityCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EntityCategory"/>. </summary>
        public static implicit operator EntityCategory(string value) => new EntityCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntityCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntityCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
