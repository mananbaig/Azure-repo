// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A class representing the TrafficManagerEndpoint data model.
    /// Class representing a Traffic Manager endpoint.
    /// </summary>
    public partial class TrafficManagerEndpointData : TrafficManagerProxyResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TrafficManagerEndpointData"/>. </summary>
        public TrafficManagerEndpointData()
        {
            GeoMapping = new ChangeTrackingList<string>();
            Subnets = new ChangeTrackingList<TrafficManagerEndpointSubnetInfo>();
            CustomHeaders = new ChangeTrackingList<TrafficManagerEndpointCustomHeaderInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerEndpointData"/>. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="targetResourceId"> The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'. </param>
        /// <param name="target"> The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint. </param>
        /// <param name="endpointStatus"> The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method. </param>
        /// <param name="weight"> The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000. </param>
        /// <param name="priority"> The priority of this endpoint when using the 'Priority' traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value. </param>
        /// <param name="endpointLocation"> Specifies the location of the external or nested endpoints when using the 'Performance' traffic routing method. </param>
        /// <param name="endpointMonitorStatus"> The monitoring status of the endpoint. </param>
        /// <param name="minChildEndpoints"> The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. </param>
        /// <param name="minChildEndpointsIPv4"> The minimum number of IPv4 (DNS record type A) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. </param>
        /// <param name="minChildEndpointsIPv6"> The minimum number of IPv6 (DNS record type AAAA) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. </param>
        /// <param name="geoMapping"> The list of countries/regions mapped to this endpoint when using the 'Geographic' traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values. </param>
        /// <param name="subnets"> The list of subnets, IP addresses, and/or address ranges mapped to this endpoint when using the 'Subnet' traffic routing method. An empty list will match all ranges not covered by other endpoints. </param>
        /// <param name="customHeaders"> List of custom headers. </param>
        /// <param name="alwaysServe"> If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in the traffic routing method. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerEndpointData(ResourceIdentifier id, string name, ResourceType? resourceType, ResourceIdentifier targetResourceId, string target, TrafficManagerEndpointStatus? endpointStatus, long? weight, long? priority, string endpointLocation, TrafficManagerEndpointMonitorStatus? endpointMonitorStatus, long? minChildEndpoints, long? minChildEndpointsIPv4, long? minChildEndpointsIPv6, IList<string> geoMapping, IList<TrafficManagerEndpointSubnetInfo> subnets, IList<TrafficManagerEndpointCustomHeaderInfo> customHeaders, TrafficManagerEndpointAlwaysServeStatus? alwaysServe, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            TargetResourceId = targetResourceId;
            Target = target;
            EndpointStatus = endpointStatus;
            Weight = weight;
            Priority = priority;
            EndpointLocation = endpointLocation;
            EndpointMonitorStatus = endpointMonitorStatus;
            MinChildEndpoints = minChildEndpoints;
            MinChildEndpointsIPv4 = minChildEndpointsIPv4;
            MinChildEndpointsIPv6 = minChildEndpointsIPv6;
            GeoMapping = geoMapping;
            Subnets = subnets;
            CustomHeaders = customHeaders;
            AlwaysServe = alwaysServe;
        }

        /// <summary> The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'. </summary>
        public ResourceIdentifier TargetResourceId { get; set; }
        /// <summary> The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint. </summary>
        public string Target { get; set; }
        /// <summary> The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method. </summary>
        public TrafficManagerEndpointStatus? EndpointStatus { get; set; }
        /// <summary> The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000. </summary>
        public long? Weight { get; set; }
        /// <summary> The priority of this endpoint when using the 'Priority' traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value. </summary>
        public long? Priority { get; set; }
        /// <summary> Specifies the location of the external or nested endpoints when using the 'Performance' traffic routing method. </summary>
        public string EndpointLocation { get; set; }
        /// <summary> The monitoring status of the endpoint. </summary>
        public TrafficManagerEndpointMonitorStatus? EndpointMonitorStatus { get; set; }
        /// <summary> The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. </summary>
        public long? MinChildEndpoints { get; set; }
        /// <summary> The minimum number of IPv4 (DNS record type A) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. </summary>
        public long? MinChildEndpointsIPv4 { get; set; }
        /// <summary> The minimum number of IPv6 (DNS record type AAAA) endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'. </summary>
        public long? MinChildEndpointsIPv6 { get; set; }
        /// <summary> The list of countries/regions mapped to this endpoint when using the 'Geographic' traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values. </summary>
        public IList<string> GeoMapping { get; }
        /// <summary> The list of subnets, IP addresses, and/or address ranges mapped to this endpoint when using the 'Subnet' traffic routing method. An empty list will match all ranges not covered by other endpoints. </summary>
        public IList<TrafficManagerEndpointSubnetInfo> Subnets { get; }
        /// <summary> List of custom headers. </summary>
        public IList<TrafficManagerEndpointCustomHeaderInfo> CustomHeaders { get; }
        /// <summary> If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in the traffic routing method. </summary>
        public TrafficManagerEndpointAlwaysServeStatus? AlwaysServe { get; set; }
    }
}
