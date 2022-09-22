// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> The AssignmentDeleteBehavior. </summary>
    public readonly partial struct AssignmentDeleteBehavior : IEquatable<AssignmentDeleteBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssignmentDeleteBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssignmentDeleteBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string AllValue = "all";

        /// <summary> none. </summary>
        public static AssignmentDeleteBehavior None { get; } = new AssignmentDeleteBehavior(NoneValue);
        /// <summary> all. </summary>
        public static AssignmentDeleteBehavior All { get; } = new AssignmentDeleteBehavior(AllValue);
        /// <summary> Determines if two <see cref="AssignmentDeleteBehavior"/> values are the same. </summary>
        public static bool operator ==(AssignmentDeleteBehavior left, AssignmentDeleteBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssignmentDeleteBehavior"/> values are not the same. </summary>
        public static bool operator !=(AssignmentDeleteBehavior left, AssignmentDeleteBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssignmentDeleteBehavior"/>. </summary>
        public static implicit operator AssignmentDeleteBehavior(string value) => new AssignmentDeleteBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssignmentDeleteBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssignmentDeleteBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
