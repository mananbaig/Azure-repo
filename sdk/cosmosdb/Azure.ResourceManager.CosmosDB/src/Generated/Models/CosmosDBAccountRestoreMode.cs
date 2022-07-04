// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Describes the mode of the restore. </summary>
    public readonly partial struct CosmosDBAccountRestoreMode : IEquatable<CosmosDBAccountRestoreMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountRestoreMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBAccountRestoreMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PointInTimeValue = "PointInTime";

        /// <summary> PointInTime. </summary>
        public static CosmosDBAccountRestoreMode PointInTime { get; } = new CosmosDBAccountRestoreMode(PointInTimeValue);
        /// <summary> Determines if two <see cref="CosmosDBAccountRestoreMode"/> values are the same. </summary>
        public static bool operator ==(CosmosDBAccountRestoreMode left, CosmosDBAccountRestoreMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBAccountRestoreMode"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBAccountRestoreMode left, CosmosDBAccountRestoreMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBAccountRestoreMode"/>. </summary>
        public static implicit operator CosmosDBAccountRestoreMode(string value) => new CosmosDBAccountRestoreMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBAccountRestoreMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBAccountRestoreMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
