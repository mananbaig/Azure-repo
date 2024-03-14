// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Unknown version of CustomPersistentDiskProperties. </summary>
    internal partial class UnknownCustomPersistentDiskProperties : AppCustomPersistentDiskProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCustomPersistentDiskProperties"/>. </summary>
        /// <param name="underlyingResourceType"> The type of the underlying resource to mount as a persistent disk. </param>
        /// <param name="mountPath"> The mount path of the persistent disk. </param>
        /// <param name="isReadOnly"> Indicates whether the persistent disk is a readOnly one. </param>
        /// <param name="mountOptions"> These are the mount options for a persistent disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCustomPersistentDiskProperties(UnderlyingResourceType underlyingResourceType, string mountPath, bool? isReadOnly, IList<string> mountOptions, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(underlyingResourceType, mountPath, isReadOnly, mountOptions, serializedAdditionalRawData)
        {
            UnderlyingResourceType = underlyingResourceType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCustomPersistentDiskProperties"/> for deserialization. </summary>
        internal UnknownCustomPersistentDiskProperties()
        {
        }
    }
}
