// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The choice of if the scan operation should run the scan. </summary>
    public readonly partial struct ClusterScanRuntimeParametersScanActivity : IEquatable<ClusterScanRuntimeParametersScanActivity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterScanRuntimeParametersScanActivity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterScanRuntimeParametersScanActivity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScanValue = "Scan";
        private const string SkipValue = "Skip";

        /// <summary> Scan. </summary>
        public static ClusterScanRuntimeParametersScanActivity Scan { get; } = new ClusterScanRuntimeParametersScanActivity(ScanValue);
        /// <summary> Skip. </summary>
        public static ClusterScanRuntimeParametersScanActivity Skip { get; } = new ClusterScanRuntimeParametersScanActivity(SkipValue);
        /// <summary> Determines if two <see cref="ClusterScanRuntimeParametersScanActivity"/> values are the same. </summary>
        public static bool operator ==(ClusterScanRuntimeParametersScanActivity left, ClusterScanRuntimeParametersScanActivity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterScanRuntimeParametersScanActivity"/> values are not the same. </summary>
        public static bool operator !=(ClusterScanRuntimeParametersScanActivity left, ClusterScanRuntimeParametersScanActivity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterScanRuntimeParametersScanActivity"/>. </summary>
        public static implicit operator ClusterScanRuntimeParametersScanActivity(string value) => new ClusterScanRuntimeParametersScanActivity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterScanRuntimeParametersScanActivity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterScanRuntimeParametersScanActivity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
