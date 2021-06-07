// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> The sort order of the search. </summary>
    public readonly partial struct SearchSortEnum : IEquatable<SearchSortEnum>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SearchSortEnum"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchSortEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AscValue = "asc";
        private const string DescValue = "desc";

        /// <summary> asc. </summary>
        public static SearchSortEnum Asc { get; } = new SearchSortEnum(AscValue);
        /// <summary> desc. </summary>
        public static SearchSortEnum Desc { get; } = new SearchSortEnum(DescValue);
        /// <summary> Determines if two <see cref="SearchSortEnum"/> values are the same. </summary>
        public static bool operator ==(SearchSortEnum left, SearchSortEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchSortEnum"/> values are not the same. </summary>
        public static bool operator !=(SearchSortEnum left, SearchSortEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SearchSortEnum"/>. </summary>
        public static implicit operator SearchSortEnum(string value) => new SearchSortEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchSortEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchSortEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
