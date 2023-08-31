// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes storage class info. </summary>
    public partial class EdgeKubernetesRoleStorageClassInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleStorageClassInfo"/>. </summary>
        internal EdgeKubernetesRoleStorageClassInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesRoleStorageClassInfo"/>. </summary>
        /// <param name="name"> Storage class name. </param>
        /// <param name="kubernetesRoleStorageClassInfoType"> Storage class type. </param>
        /// <param name="posixCompliant"> If provisioned storage is posix compliant. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeKubernetesRoleStorageClassInfo(string name, string kubernetesRoleStorageClassInfoType, PosixComplianceStatus? posixCompliant, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            KubernetesRoleStorageClassInfoType = kubernetesRoleStorageClassInfoType;
            PosixCompliant = posixCompliant;
            _rawData = rawData;
        }

        /// <summary> Storage class name. </summary>
        public string Name { get; }
        /// <summary> Storage class type. </summary>
        public string KubernetesRoleStorageClassInfoType { get; }
        /// <summary> If provisioned storage is posix compliant. </summary>
        public PosixComplianceStatus? PosixCompliant { get; }
    }
}
