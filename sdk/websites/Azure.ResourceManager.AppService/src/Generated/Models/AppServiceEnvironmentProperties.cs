// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of an App Service Environment. </summary>
    public partial class AppServiceEnvironmentProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceEnvironmentProperties"/>. </summary>
        /// <param name="virtualNetwork"> Description of the Virtual Network. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetwork"/> is null. </exception>
        public AppServiceEnvironmentProperties(AppServiceVirtualNetworkProfile virtualNetwork)
        {
            Argument.AssertNotNull(virtualNetwork, nameof(virtualNetwork));

            VirtualNetwork = virtualNetwork;
            ClusterSettings = new ChangeTrackingList<AppServiceNameValuePair>();
            UserWhitelistedIPRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceEnvironmentProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the App Service Environment. </param>
        /// <param name="status"> Current status of the App Service Environment. </param>
        /// <param name="virtualNetwork"> Description of the Virtual Network. </param>
        /// <param name="internalLoadBalancingMode"> Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. </param>
        /// <param name="multiSize"> Front-end VM size, e.g. "Medium", "Large". </param>
        /// <param name="multiRoleCount"> Number of front-end instances. </param>
        /// <param name="ipSslAddressCount"> Number of IP SSL addresses reserved for the App Service Environment. </param>
        /// <param name="dnsSuffix"> DNS suffix of the App Service Environment. </param>
        /// <param name="maximumNumberOfMachines"> Maximum number of VMs in the App Service Environment. </param>
        /// <param name="frontEndScaleFactor"> Scale factor for front-ends. </param>
        /// <param name="isSuspended">
        /// &lt;code&gt;true&lt;/code&gt; if the App Service Environment is suspended; otherwise, &lt;code&gt;false&lt;/code&gt;. The environment can be suspended, e.g. when the management endpoint is no longer available
        ///  (most likely because NSG blocked the incoming traffic).
        /// </param>
        /// <param name="clusterSettings"> Custom settings for changing the behavior of the App Service Environment. </param>
        /// <param name="userWhitelistedIPRanges"> User added ip ranges to whitelist on ASE db. </param>
        /// <param name="hasLinuxWorkers"> Flag that displays whether an ASE has linux workers or not. </param>
        /// <param name="dedicatedHostCount"> Dedicated Host Count. </param>
        /// <param name="isZoneRedundant"> Whether or not this App Service Environment is zone-redundant. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceEnvironmentProperties(ProvisioningState? provisioningState, HostingEnvironmentStatus? status, AppServiceVirtualNetworkProfile virtualNetwork, LoadBalancingMode? internalLoadBalancingMode, string multiSize, int? multiRoleCount, int? ipSslAddressCount, string dnsSuffix, int? maximumNumberOfMachines, int? frontEndScaleFactor, bool? isSuspended, IList<AppServiceNameValuePair> clusterSettings, IList<string> userWhitelistedIPRanges, bool? hasLinuxWorkers, int? dedicatedHostCount, bool? isZoneRedundant, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Status = status;
            VirtualNetwork = virtualNetwork;
            InternalLoadBalancingMode = internalLoadBalancingMode;
            MultiSize = multiSize;
            MultiRoleCount = multiRoleCount;
            IPSslAddressCount = ipSslAddressCount;
            DnsSuffix = dnsSuffix;
            MaximumNumberOfMachines = maximumNumberOfMachines;
            FrontEndScaleFactor = frontEndScaleFactor;
            IsSuspended = isSuspended;
            ClusterSettings = clusterSettings;
            UserWhitelistedIPRanges = userWhitelistedIPRanges;
            HasLinuxWorkers = hasLinuxWorkers;
            DedicatedHostCount = dedicatedHostCount;
            IsZoneRedundant = isZoneRedundant;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceEnvironmentProperties"/> for deserialization. </summary>
        internal AppServiceEnvironmentProperties()
        {
        }

        /// <summary> Provisioning state of the App Service Environment. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Current status of the App Service Environment. </summary>
        public HostingEnvironmentStatus? Status { get; }
        /// <summary> Description of the Virtual Network. </summary>
        public AppServiceVirtualNetworkProfile VirtualNetwork { get; set; }
        /// <summary> Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment. </summary>
        public LoadBalancingMode? InternalLoadBalancingMode { get; set; }
        /// <summary> Front-end VM size, e.g. "Medium", "Large". </summary>
        public string MultiSize { get; set; }
        /// <summary> Number of front-end instances. </summary>
        public int? MultiRoleCount { get; }
        /// <summary> Number of IP SSL addresses reserved for the App Service Environment. </summary>
        public int? IPSslAddressCount { get; set; }
        /// <summary> DNS suffix of the App Service Environment. </summary>
        public string DnsSuffix { get; set; }
        /// <summary> Maximum number of VMs in the App Service Environment. </summary>
        public int? MaximumNumberOfMachines { get; }
        /// <summary> Scale factor for front-ends. </summary>
        public int? FrontEndScaleFactor { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the App Service Environment is suspended; otherwise, &lt;code&gt;false&lt;/code&gt;. The environment can be suspended, e.g. when the management endpoint is no longer available
        ///  (most likely because NSG blocked the incoming traffic).
        /// </summary>
        public bool? IsSuspended { get; }
        /// <summary> Custom settings for changing the behavior of the App Service Environment. </summary>
        public IList<AppServiceNameValuePair> ClusterSettings { get; }
        /// <summary> User added ip ranges to whitelist on ASE db. </summary>
        public IList<string> UserWhitelistedIPRanges { get; }
        /// <summary> Flag that displays whether an ASE has linux workers or not. </summary>
        public bool? HasLinuxWorkers { get; }
        /// <summary> Dedicated Host Count. </summary>
        public int? DedicatedHostCount { get; set; }
        /// <summary> Whether or not this App Service Environment is zone-redundant. </summary>
        public bool? IsZoneRedundant { get; set; }
    }
}
