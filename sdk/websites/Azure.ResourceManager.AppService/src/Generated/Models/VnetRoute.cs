// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Virtual Network route contract used to pass routing information for a Virtual Network. </summary>
    public partial class VnetRoute : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="VnetRoute"/>. </summary>
        public VnetRoute()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VnetRoute"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="startAddress"> The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified. </param>
        /// <param name="endAddress"> The ending address for this route. If the start address is specified in CIDR notation, this must be omitted. </param>
        /// <param name="routeType">
        /// The type of route this is:
        /// DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
        /// INHERITED - Routes inherited from the real Virtual Network routes
        /// STATIC - Static route set on the app only
        /// 
        /// These values will be used for syncing an app&apos;s routes with those from a Virtual Network.
        /// </param>
        internal VnetRoute(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string startAddress, string endAddress, RouteType? routeType) : base(id, name, resourceType, systemData, kind)
        {
            StartAddress = startAddress;
            EndAddress = endAddress;
            RouteType = routeType;
        }

        /// <summary> The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified. </summary>
        public string StartAddress { get; set; }
        /// <summary> The ending address for this route. If the start address is specified in CIDR notation, this must be omitted. </summary>
        public string EndAddress { get; set; }
        /// <summary>
        /// The type of route this is:
        /// DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
        /// INHERITED - Routes inherited from the real Virtual Network routes
        /// STATIC - Static route set on the app only
        /// 
        /// These values will be used for syncing an app&apos;s routes with those from a Virtual Network.
        /// </summary>
        public RouteType? RouteType { get; set; }
    }
}
