// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of an IoT hub. </summary>
    public partial class IotHubProperties
    {
        /// <summary> Initializes a new instance of IotHubProperties. </summary>
        public IotHubProperties()
        {
            AuthorizationPolicies = new ChangeTrackingList<SharedAccessSignatureAuthorizationRule>();
            AllowedFqdns = new ChangeTrackingList<string>();
            IPFilterRules = new ChangeTrackingList<IPFilterRule>();
            PrivateEndpointConnections = new ChangeTrackingList<IotHubPrivateEndpointConnectionData>();
            EventHubEndpoints = new ChangeTrackingDictionary<string, EventHubCompatibleEndpointProperties>();
            StorageEndpoints = new ChangeTrackingDictionary<string, IotHubStorageEndpointProperties>();
            MessagingEndpoints = new ChangeTrackingDictionary<string, MessagingEndpointProperties>();
            Locations = new ChangeTrackingList<IotHubLocationDescription>();
        }

        /// <summary> Initializes a new instance of IotHubProperties. </summary>
        /// <param name="authorizationPolicies"> The shared access policies you can use to secure a connection to the IoT hub. </param>
        /// <param name="disableLocalAuth"> If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. </param>
        /// <param name="disableDeviceSas"> If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for authentication. </param>
        /// <param name="disableModuleSas"> If true, all module scoped SAS keys cannot be used for authentication. </param>
        /// <param name="restrictOutboundNetworkAccess"> If true, egress from IotHub will be restricted to only the allowed FQDNs that are configured via allowedFqdnList. </param>
        /// <param name="allowedFqdns"> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="ipFilterRules"> The IP filter rules. </param>
        /// <param name="networkRuleSets"> Network Rule Set Properties of IotHub. </param>
        /// <param name="minTlsVersion"> Specifies the minimum TLS version to support for this hub. Can be set to "1.2" to have clients that use a TLS version below 1.2 to be rejected. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IotHub. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="state"> The hub state. </param>
        /// <param name="hostName"> The name of the host. </param>
        /// <param name="eventHubEndpoints"> The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events. This key has to be present in the dictionary while making create or update calls for the IoT hub. </param>
        /// <param name="routing"> The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging. </param>
        /// <param name="storageEndpoints"> The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. </param>
        /// <param name="messagingEndpoints"> The messaging endpoint properties for the file upload notification queue. </param>
        /// <param name="enableFileUploadNotifications"> If True, file upload notifications are enabled. </param>
        /// <param name="cloudToDevice"> The IoT hub cloud-to-device messaging properties. </param>
        /// <param name="comments"> IoT hub comments. </param>
        /// <param name="features"> The capabilities and features enabled for the IoT hub. </param>
        /// <param name="locations"> Primary and secondary location for iot hub. </param>
        /// <param name="enableDataResidency"> This property when set to true, will enable data residency, thus, disabling disaster recovery. </param>
        internal IotHubProperties(IList<SharedAccessSignatureAuthorizationRule> authorizationPolicies, bool? disableLocalAuth, bool? disableDeviceSas, bool? disableModuleSas, bool? restrictOutboundNetworkAccess, IList<string> allowedFqdns, IotHubPublicNetworkAccess? publicNetworkAccess, IList<IPFilterRule> ipFilterRules, IotHubNetworkRuleSetProperties networkRuleSets, string minTlsVersion, IList<IotHubPrivateEndpointConnectionData> privateEndpointConnections, string provisioningState, string state, string hostName, IDictionary<string, EventHubCompatibleEndpointProperties> eventHubEndpoints, IotHubRoutingProperties routing, IDictionary<string, IotHubStorageEndpointProperties> storageEndpoints, IDictionary<string, MessagingEndpointProperties> messagingEndpoints, bool? enableFileUploadNotifications, CloudToDeviceProperties cloudToDevice, string comments, IotHubCapability? features, IReadOnlyList<IotHubLocationDescription> locations, bool? enableDataResidency)
        {
            AuthorizationPolicies = authorizationPolicies;
            DisableLocalAuth = disableLocalAuth;
            DisableDeviceSas = disableDeviceSas;
            DisableModuleSas = disableModuleSas;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            AllowedFqdns = allowedFqdns;
            PublicNetworkAccess = publicNetworkAccess;
            IPFilterRules = ipFilterRules;
            NetworkRuleSets = networkRuleSets;
            MinTlsVersion = minTlsVersion;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            State = state;
            HostName = hostName;
            EventHubEndpoints = eventHubEndpoints;
            Routing = routing;
            StorageEndpoints = storageEndpoints;
            MessagingEndpoints = messagingEndpoints;
            EnableFileUploadNotifications = enableFileUploadNotifications;
            CloudToDevice = cloudToDevice;
            Comments = comments;
            Features = features;
            Locations = locations;
            EnableDataResidency = enableDataResidency;
        }

        /// <summary> The shared access policies you can use to secure a connection to the IoT hub. </summary>
        public IList<SharedAccessSignatureAuthorizationRule> AuthorizationPolicies { get; }
        /// <summary> If true, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> If true, all device(including Edge devices but excluding modules) scoped SAS keys cannot be used for authentication. </summary>
        public bool? DisableDeviceSas { get; set; }
        /// <summary> If true, all module scoped SAS keys cannot be used for authentication. </summary>
        public bool? DisableModuleSas { get; set; }
        /// <summary> If true, egress from IotHub will be restricted to only the allowed FQDNs that are configured via allowedFqdnList. </summary>
        public bool? RestrictOutboundNetworkAccess { get; set; }
        /// <summary> List of allowed FQDNs(Fully Qualified Domain Name) for egress from Iot Hub. </summary>
        public IList<string> AllowedFqdns { get; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public IotHubPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The IP filter rules. </summary>
        public IList<IPFilterRule> IPFilterRules { get; }
        /// <summary> Network Rule Set Properties of IotHub. </summary>
        public IotHubNetworkRuleSetProperties NetworkRuleSets { get; set; }
        /// <summary> Specifies the minimum TLS version to support for this hub. Can be set to "1.2" to have clients that use a TLS version below 1.2 to be rejected. </summary>
        public string MinTlsVersion { get; set; }
        /// <summary> Private endpoint connections created on this IotHub. </summary>
        public IList<IotHubPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The hub state. </summary>
        public string State { get; }
        /// <summary> The name of the host. </summary>
        public string HostName { get; }
        /// <summary> The Event Hub-compatible endpoint properties. The only possible keys to this dictionary is events. This key has to be present in the dictionary while making create or update calls for the IoT hub. </summary>
        public IDictionary<string, EventHubCompatibleEndpointProperties> EventHubEndpoints { get; }
        /// <summary> The routing related properties of the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging. </summary>
        public IotHubRoutingProperties Routing { get; set; }
        /// <summary> The list of Azure Storage endpoints where you can upload files. Currently you can configure only one Azure Storage account and that MUST have its key as $default. Specifying more than one storage account causes an error to be thrown. Not specifying a value for this property when the enableFileUploadNotifications property is set to True, causes an error to be thrown. </summary>
        public IDictionary<string, IotHubStorageEndpointProperties> StorageEndpoints { get; }
        /// <summary> The messaging endpoint properties for the file upload notification queue. </summary>
        public IDictionary<string, MessagingEndpointProperties> MessagingEndpoints { get; }
        /// <summary> If True, file upload notifications are enabled. </summary>
        public bool? EnableFileUploadNotifications { get; set; }
        /// <summary> The IoT hub cloud-to-device messaging properties. </summary>
        public CloudToDeviceProperties CloudToDevice { get; set; }
        /// <summary> IoT hub comments. </summary>
        public string Comments { get; set; }
        /// <summary> The capabilities and features enabled for the IoT hub. </summary>
        public IotHubCapability? Features { get; set; }
        /// <summary> Primary and secondary location for iot hub. </summary>
        public IReadOnlyList<IotHubLocationDescription> Locations { get; }
        /// <summary> This property when set to true, will enable data residency, thus, disabling disaster recovery. </summary>
        public bool? EnableDataResidency { get; set; }
    }
}
