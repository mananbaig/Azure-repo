// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Specifies the reboot setting for all AutomaticByPlatform patch installation operations. </summary>
    public readonly partial struct WindowsVmGuestPatchAutomaticByPlatformRebootSetting : IEquatable<WindowsVmGuestPatchAutomaticByPlatformRebootSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WindowsVmGuestPatchAutomaticByPlatformRebootSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WindowsVmGuestPatchAutomaticByPlatformRebootSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string IfRequiredValue = "IfRequired";
        private const string NeverValue = "Never";
        private const string AlwaysValue = "Always";

        /// <summary> Unknown. </summary>
        public static WindowsVmGuestPatchAutomaticByPlatformRebootSetting Unknown { get; } = new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(UnknownValue);
        /// <summary> IfRequired. </summary>
        public static WindowsVmGuestPatchAutomaticByPlatformRebootSetting IfRequired { get; } = new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(IfRequiredValue);
        /// <summary> Never. </summary>
        public static WindowsVmGuestPatchAutomaticByPlatformRebootSetting Never { get; } = new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(NeverValue);
        /// <summary> Always. </summary>
        public static WindowsVmGuestPatchAutomaticByPlatformRebootSetting Always { get; } = new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(AlwaysValue);
        /// <summary> Determines if two <see cref="WindowsVmGuestPatchAutomaticByPlatformRebootSetting"/> values are the same. </summary>
        public static bool operator ==(WindowsVmGuestPatchAutomaticByPlatformRebootSetting left, WindowsVmGuestPatchAutomaticByPlatformRebootSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WindowsVmGuestPatchAutomaticByPlatformRebootSetting"/> values are not the same. </summary>
        public static bool operator !=(WindowsVmGuestPatchAutomaticByPlatformRebootSetting left, WindowsVmGuestPatchAutomaticByPlatformRebootSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WindowsVmGuestPatchAutomaticByPlatformRebootSetting"/>. </summary>
        public static implicit operator WindowsVmGuestPatchAutomaticByPlatformRebootSetting(string value) => new WindowsVmGuestPatchAutomaticByPlatformRebootSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WindowsVmGuestPatchAutomaticByPlatformRebootSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WindowsVmGuestPatchAutomaticByPlatformRebootSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
