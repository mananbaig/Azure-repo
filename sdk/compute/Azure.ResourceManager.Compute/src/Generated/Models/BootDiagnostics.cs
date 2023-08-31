// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
    public partial class BootDiagnostics
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BootDiagnostics"/>. </summary>
        public BootDiagnostics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BootDiagnostics"/>. </summary>
        /// <param name="enabled"> Whether boot diagnostics should be enabled on the Virtual Machine. </param>
        /// <param name="storageUri"> Uri of the storage account to use for placing the console output and screenshot. If storageUri is not specified while enabling boot diagnostics, managed storage will be used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BootDiagnostics(bool? enabled, Uri storageUri, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            StorageUri = storageUri;
            _rawData = rawData;
        }

        /// <summary> Whether boot diagnostics should be enabled on the Virtual Machine. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Uri of the storage account to use for placing the console output and screenshot. If storageUri is not specified while enabling boot diagnostics, managed storage will be used. </summary>
        public Uri StorageUri { get; set; }
    }
}
