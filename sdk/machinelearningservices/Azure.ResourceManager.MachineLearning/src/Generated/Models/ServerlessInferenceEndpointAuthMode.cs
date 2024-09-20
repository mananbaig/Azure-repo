// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ServerlessInferenceEndpointAuthMode. </summary>
    public readonly partial struct ServerlessInferenceEndpointAuthMode : IEquatable<ServerlessInferenceEndpointAuthMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerlessInferenceEndpointAuthMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerlessInferenceEndpointAuthMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyValue = "Key";

        /// <summary> Key. </summary>
        public static ServerlessInferenceEndpointAuthMode Key { get; } = new ServerlessInferenceEndpointAuthMode(KeyValue);
        /// <summary> Determines if two <see cref="ServerlessInferenceEndpointAuthMode"/> values are the same. </summary>
        public static bool operator ==(ServerlessInferenceEndpointAuthMode left, ServerlessInferenceEndpointAuthMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerlessInferenceEndpointAuthMode"/> values are not the same. </summary>
        public static bool operator !=(ServerlessInferenceEndpointAuthMode left, ServerlessInferenceEndpointAuthMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerlessInferenceEndpointAuthMode"/>. </summary>
        public static implicit operator ServerlessInferenceEndpointAuthMode(string value) => new ServerlessInferenceEndpointAuthMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerlessInferenceEndpointAuthMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerlessInferenceEndpointAuthMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
