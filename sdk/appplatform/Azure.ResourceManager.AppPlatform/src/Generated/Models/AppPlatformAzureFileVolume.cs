// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The properties of the Azure File volume. Azure File shares are mounted as volumes. </summary>
    public partial class AppPlatformAzureFileVolume : AppCustomPersistentDiskProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformAzureFileVolume"/>. </summary>
        /// <param name="mountPath"> The mount path of the persistent disk. </param>
        /// <param name="shareName"> The share name of the Azure File share. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mountPath"/> or <paramref name="shareName"/> is null. </exception>
        public AppPlatformAzureFileVolume(string mountPath, string shareName) : base(mountPath)
        {
            Argument.AssertNotNull(mountPath, nameof(mountPath));
            Argument.AssertNotNull(shareName, nameof(shareName));

            ShareName = shareName;
            UnderlyingResourceType = UnderlyingResourceType.AzureFileVolume;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformAzureFileVolume"/>. </summary>
        /// <param name="underlyingResourceType"> The type of the underlying resource to mount as a persistent disk. </param>
        /// <param name="mountPath"> The mount path of the persistent disk. </param>
        /// <param name="isReadOnly"> Indicates whether the persistent disk is a readOnly one. </param>
        /// <param name="mountOptions"> These are the mount options for a persistent disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="shareName"> The share name of the Azure File share. </param>
        internal AppPlatformAzureFileVolume(UnderlyingResourceType underlyingResourceType, string mountPath, bool? isReadOnly, IList<string> mountOptions, IDictionary<string, BinaryData> serializedAdditionalRawData, string shareName) : base(underlyingResourceType, mountPath, isReadOnly, mountOptions, serializedAdditionalRawData)
        {
            ShareName = shareName;
            UnderlyingResourceType = underlyingResourceType;
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformAzureFileVolume"/> for deserialization. </summary>
        internal AppPlatformAzureFileVolume()
        {
        }

        /// <summary> The share name of the Azure File share. </summary>
        public string ShareName { get; set; }
    }
}
