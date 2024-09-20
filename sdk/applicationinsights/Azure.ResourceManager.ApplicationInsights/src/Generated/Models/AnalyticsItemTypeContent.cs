// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The AnalyticsItemTypeContent. </summary>
    public readonly partial struct AnalyticsItemTypeContent : IEquatable<AnalyticsItemTypeContent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnalyticsItemTypeContent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnalyticsItemTypeContent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string QueryValue = "query";
        private const string FunctionValue = "function";
        private const string FolderValue = "folder";
        private const string RecentValue = "recent";

        /// <summary> none. </summary>
        public static AnalyticsItemTypeContent None { get; } = new AnalyticsItemTypeContent(NoneValue);
        /// <summary> query. </summary>
        public static AnalyticsItemTypeContent Query { get; } = new AnalyticsItemTypeContent(QueryValue);
        /// <summary> function. </summary>
        public static AnalyticsItemTypeContent Function { get; } = new AnalyticsItemTypeContent(FunctionValue);
        /// <summary> folder. </summary>
        public static AnalyticsItemTypeContent Folder { get; } = new AnalyticsItemTypeContent(FolderValue);
        /// <summary> recent. </summary>
        public static AnalyticsItemTypeContent Recent { get; } = new AnalyticsItemTypeContent(RecentValue);
        /// <summary> Determines if two <see cref="AnalyticsItemTypeContent"/> values are the same. </summary>
        public static bool operator ==(AnalyticsItemTypeContent left, AnalyticsItemTypeContent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyticsItemTypeContent"/> values are not the same. </summary>
        public static bool operator !=(AnalyticsItemTypeContent left, AnalyticsItemTypeContent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AnalyticsItemTypeContent"/>. </summary>
        public static implicit operator AnalyticsItemTypeContent(string value) => new AnalyticsItemTypeContent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyticsItemTypeContent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyticsItemTypeContent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
