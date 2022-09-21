// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Cluster operating system, the default will be Windows. </summary>
    public readonly partial struct ServiceFabricManagedClusterOSType : IEquatable<ServiceFabricManagedClusterOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricManagedClusterOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";

        /// <summary> Windows. </summary>
        public static ServiceFabricManagedClusterOSType Windows { get; } = new ServiceFabricManagedClusterOSType(WindowsValue);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterOSType"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricManagedClusterOSType left, ServiceFabricManagedClusterOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterOSType"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricManagedClusterOSType left, ServiceFabricManagedClusterOSType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceFabricManagedClusterOSType"/>. </summary>
        public static implicit operator ServiceFabricManagedClusterOSType(string value) => new ServiceFabricManagedClusterOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricManagedClusterOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricManagedClusterOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
