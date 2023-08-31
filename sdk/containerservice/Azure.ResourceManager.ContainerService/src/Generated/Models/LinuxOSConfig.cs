// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details. </summary>
    public partial class LinuxOSConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinuxOSConfig"/>. </summary>
        public LinuxOSConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinuxOSConfig"/>. </summary>
        /// <param name="sysctls"> Sysctl settings for Linux agent nodes. </param>
        /// <param name="transparentHugePageEnabled"> Valid values are 'always', 'madvise', and 'never'. The default is 'always'. For more information see [Transparent Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge). </param>
        /// <param name="transparentHugePageDefrag"> Valid values are 'always', 'defer', 'defer+madvise', 'madvise' and 'never'. The default is 'madvise'. For more information see [Transparent Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge). </param>
        /// <param name="swapFileSizeInMB"> The size in MB of a swap file that will be created on each node. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinuxOSConfig(SysctlConfig sysctls, string transparentHugePageEnabled, string transparentHugePageDefrag, int? swapFileSizeInMB, Dictionary<string, BinaryData> rawData)
        {
            Sysctls = sysctls;
            TransparentHugePageEnabled = transparentHugePageEnabled;
            TransparentHugePageDefrag = transparentHugePageDefrag;
            SwapFileSizeInMB = swapFileSizeInMB;
            _rawData = rawData;
        }

        /// <summary> Sysctl settings for Linux agent nodes. </summary>
        public SysctlConfig Sysctls { get; set; }
        /// <summary> Valid values are 'always', 'madvise', and 'never'. The default is 'always'. For more information see [Transparent Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge). </summary>
        public string TransparentHugePageEnabled { get; set; }
        /// <summary> Valid values are 'always', 'defer', 'defer+madvise', 'madvise' and 'never'. The default is 'madvise'. For more information see [Transparent Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge). </summary>
        public string TransparentHugePageDefrag { get; set; }
        /// <summary> The size in MB of a swap file that will be created on each node. </summary>
        public int? SwapFileSizeInMB { get; set; }
    }
}
