// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The properties of the volume mount. </summary>
    public partial class ContainerInstanceVolumeMount
    {
        /// <summary> Initializes a new instance of ContainerInstanceVolumeMount. </summary>
        /// <param name="name"> The name of the volume mount. </param>
        /// <param name="mountPath"> The path within the container where the volume should be mounted. Must not contain colon (:). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="mountPath"/> is null. </exception>
        public ContainerInstanceVolumeMount(string name, string mountPath)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (mountPath == null)
            {
                throw new ArgumentNullException(nameof(mountPath));
            }

            Name = name;
            MountPath = mountPath;
        }

        /// <summary> Initializes a new instance of ContainerInstanceVolumeMount. </summary>
        /// <param name="name"> The name of the volume mount. </param>
        /// <param name="mountPath"> The path within the container where the volume should be mounted. Must not contain colon (:). </param>
        /// <param name="isReadOnly"> The flag indicating whether the volume mount is read-only. </param>
        internal ContainerInstanceVolumeMount(string name, string mountPath, bool? isReadOnly)
        {
            Name = name;
            MountPath = mountPath;
            IsReadOnly = isReadOnly;
        }

        /// <summary> The name of the volume mount. </summary>
        public string Name { get; set; }
        /// <summary> The path within the container where the volume should be mounted. Must not contain colon (:). </summary>
        public string MountPath { get; set; }
        /// <summary> The flag indicating whether the volume mount is read-only. </summary>
        public bool? IsReadOnly { get; set; }
    }
}
