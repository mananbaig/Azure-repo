// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Image type values. </summary>
    public readonly partial struct SphereImageType : IEquatable<SphereImageType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SphereImageType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SphereImageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidImageTypeValue = "InvalidImageType";
        private const string OneBlValue = "OneBl";
        private const string PlutonRuntimeValue = "PlutonRuntime";
        private const string WifiFirmwareValue = "WifiFirmware";
        private const string SecurityMonitorValue = "SecurityMonitor";
        private const string NormalWorldLoaderValue = "NormalWorldLoader";
        private const string NormalWorldDtbValue = "NormalWorldDtb";
        private const string NormalWorldKernelValue = "NormalWorldKernel";
        private const string RootFsValue = "RootFs";
        private const string ServicesValue = "Services";
        private const string ApplicationsValue = "Applications";
        private const string FwConfigValue = "FwConfig";
        private const string BootManifestValue = "BootManifest";
        private const string NwfsValue = "Nwfs";
        private const string TrustedKeystoreValue = "TrustedKeystore";
        private const string PolicyValue = "Policy";
        private const string CustomerBoardConfigValue = "CustomerBoardConfig";
        private const string UpdateCertStoreValue = "UpdateCertStore";
        private const string BaseSystemUpdateManifestValue = "BaseSystemUpdateManifest";
        private const string FirmwareUpdateManifestValue = "FirmwareUpdateManifest";
        private const string CustomerUpdateManifestValue = "CustomerUpdateManifest";
        private const string RecoveryManifestValue = "RecoveryManifest";
        private const string ManifestSetValue = "ManifestSet";
        private const string OtherValue = "Other";

        /// <summary> Invalid image. </summary>
        public static SphereImageType InvalidImageType { get; } = new SphereImageType(InvalidImageTypeValue);
        /// <summary> One Bl image type. </summary>
        public static SphereImageType OneBl { get; } = new SphereImageType(OneBlValue);
        /// <summary> Pluton image type. </summary>
        public static SphereImageType PlutonRuntime { get; } = new SphereImageType(PlutonRuntimeValue);
        /// <summary> Wifi firmware image type. </summary>
        public static SphereImageType WifiFirmware { get; } = new SphereImageType(WifiFirmwareValue);
        /// <summary> Security monitor image type. </summary>
        public static SphereImageType SecurityMonitor { get; } = new SphereImageType(SecurityMonitorValue);
        /// <summary> Normal world loader image type. </summary>
        public static SphereImageType NormalWorldLoader { get; } = new SphereImageType(NormalWorldLoaderValue);
        /// <summary> Normal world dtb image type. </summary>
        public static SphereImageType NormalWorldDtb { get; } = new SphereImageType(NormalWorldDtbValue);
        /// <summary> Normal world kernel image type. </summary>
        public static SphereImageType NormalWorldKernel { get; } = new SphereImageType(NormalWorldKernelValue);
        /// <summary> Root FS image type. </summary>
        public static SphereImageType RootFs { get; } = new SphereImageType(RootFsValue);
        /// <summary> Services image type. </summary>
        public static SphereImageType Services { get; } = new SphereImageType(ServicesValue);
        /// <summary> Applications image type. </summary>
        public static SphereImageType Applications { get; } = new SphereImageType(ApplicationsValue);
        /// <summary> FW config image type. </summary>
        public static SphereImageType FwConfig { get; } = new SphereImageType(FwConfigValue);
        /// <summary> Boot manifest image type. </summary>
        public static SphereImageType BootManifest { get; } = new SphereImageType(BootManifestValue);
        /// <summary> Nwfs image type. </summary>
        public static SphereImageType Nwfs { get; } = new SphereImageType(NwfsValue);
        /// <summary> Trusted key store image type. </summary>
        public static SphereImageType TrustedKeystore { get; } = new SphereImageType(TrustedKeystoreValue);
        /// <summary> Policy image type. </summary>
        public static SphereImageType Policy { get; } = new SphereImageType(PolicyValue);
        /// <summary> Customer board config image type. </summary>
        public static SphereImageType CustomerBoardConfig { get; } = new SphereImageType(CustomerBoardConfigValue);
        /// <summary> Update certificate store image type. </summary>
        public static SphereImageType UpdateCertStore { get; } = new SphereImageType(UpdateCertStoreValue);
        /// <summary> Base system update manifest image type. </summary>
        public static SphereImageType BaseSystemUpdateManifest { get; } = new SphereImageType(BaseSystemUpdateManifestValue);
        /// <summary> Firmware update manifest image type. </summary>
        public static SphereImageType FirmwareUpdateManifest { get; } = new SphereImageType(FirmwareUpdateManifestValue);
        /// <summary> Customer update manifest image type. </summary>
        public static SphereImageType CustomerUpdateManifest { get; } = new SphereImageType(CustomerUpdateManifestValue);
        /// <summary> Recovery manifest image type. </summary>
        public static SphereImageType RecoveryManifest { get; } = new SphereImageType(RecoveryManifestValue);
        /// <summary> manifest set image type. </summary>
        public static SphereImageType ManifestSet { get; } = new SphereImageType(ManifestSetValue);
        /// <summary> Other image type. </summary>
        public static SphereImageType Other { get; } = new SphereImageType(OtherValue);
        /// <summary> Determines if two <see cref="SphereImageType"/> values are the same. </summary>
        public static bool operator ==(SphereImageType left, SphereImageType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SphereImageType"/> values are not the same. </summary>
        public static bool operator !=(SphereImageType left, SphereImageType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SphereImageType"/>. </summary>
        public static implicit operator SphereImageType(string value) => new SphereImageType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SphereImageType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SphereImageType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
