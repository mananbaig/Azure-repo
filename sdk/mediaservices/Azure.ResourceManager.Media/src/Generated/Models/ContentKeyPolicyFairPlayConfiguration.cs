// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Specifies a configuration for FairPlay licenses. </summary>
    public partial class ContentKeyPolicyFairPlayConfiguration : ContentKeyPolicyConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyFairPlayConfiguration"/>. </summary>
        /// <param name="applicationSecretKey"> The key that must be used as FairPlay Application Secret key. This needs to be base64 encoded. </param>
        /// <param name="fairPlayPfxPassword"> The password encrypting FairPlay certificate in PKCS 12 (pfx) format. </param>
        /// <param name="fairPlayPfx"> The Base64 representation of FairPlay certificate in PKCS 12 (pfx) format (including private key). </param>
        /// <param name="rentalAndLeaseKeyType"> The rental and lease key type. </param>
        /// <param name="rentalDuration"> The rental duration. Must be greater than or equal to 0. </param>
        public ContentKeyPolicyFairPlayConfiguration(byte[] applicationSecretKey, string fairPlayPfxPassword, string fairPlayPfx, ContentKeyPolicyFairPlayRentalAndLeaseKeyType rentalAndLeaseKeyType, long rentalDuration)
        {
            ApplicationSecretKey = applicationSecretKey;
            FairPlayPfxPassword = fairPlayPfxPassword;
            FairPlayPfx = fairPlayPfx;
            RentalAndLeaseKeyType = rentalAndLeaseKeyType;
            RentalDuration = rentalDuration;
            OdataType = "#Microsoft.Media.ContentKeyPolicyFairPlayConfiguration";
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyFairPlayConfiguration"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="applicationSecretKey"> The key that must be used as FairPlay Application Secret key. This needs to be base64 encoded. </param>
        /// <param name="fairPlayPfxPassword"> The password encrypting FairPlay certificate in PKCS 12 (pfx) format. </param>
        /// <param name="fairPlayPfx"> The Base64 representation of FairPlay certificate in PKCS 12 (pfx) format (including private key). </param>
        /// <param name="rentalAndLeaseKeyType"> The rental and lease key type. </param>
        /// <param name="rentalDuration"> The rental duration. Must be greater than or equal to 0. </param>
        /// <param name="offlineRentalConfiguration"> Offline rental policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentKeyPolicyFairPlayConfiguration(string odataType, byte[] applicationSecretKey, string fairPlayPfxPassword, string fairPlayPfx, ContentKeyPolicyFairPlayRentalAndLeaseKeyType rentalAndLeaseKeyType, long rentalDuration, ContentKeyPolicyFairPlayOfflineRentalConfiguration offlineRentalConfiguration, Dictionary<string, BinaryData> rawData) : base(odataType, rawData)
        {
            ApplicationSecretKey = applicationSecretKey;
            FairPlayPfxPassword = fairPlayPfxPassword;
            FairPlayPfx = fairPlayPfx;
            RentalAndLeaseKeyType = rentalAndLeaseKeyType;
            RentalDuration = rentalDuration;
            OfflineRentalConfiguration = offlineRentalConfiguration;
            OdataType = odataType ?? "#Microsoft.Media.ContentKeyPolicyFairPlayConfiguration";
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyFairPlayConfiguration"/> for deserialization. </summary>
        internal ContentKeyPolicyFairPlayConfiguration()
        {
        }

        /// <summary> The key that must be used as FairPlay Application Secret key. This needs to be base64 encoded. </summary>
        public byte[] ApplicationSecretKey { get; set; }
        /// <summary> The password encrypting FairPlay certificate in PKCS 12 (pfx) format. </summary>
        public string FairPlayPfxPassword { get; set; }
        /// <summary> The Base64 representation of FairPlay certificate in PKCS 12 (pfx) format (including private key). </summary>
        public string FairPlayPfx { get; set; }
        /// <summary> The rental and lease key type. </summary>
        public ContentKeyPolicyFairPlayRentalAndLeaseKeyType RentalAndLeaseKeyType { get; set; }
        /// <summary> The rental duration. Must be greater than or equal to 0. </summary>
        public long RentalDuration { get; set; }
        /// <summary> Offline rental policy. </summary>
        public ContentKeyPolicyFairPlayOfflineRentalConfiguration OfflineRentalConfiguration { get; set; }
    }
}
