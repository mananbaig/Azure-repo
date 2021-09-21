// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Microsoft Azure management API provides create, read, update, and
    /// delete functionality for Azure MySQL resources including servers,
    /// databases, firewall rules, VNET rules, log files and configurations
    /// with new business model.
    /// </summary>
    public partial interface IMySQLManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The ID of the target subscription.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IServersOperations.
        /// </summary>
        IServersOperations Servers { get; }

        /// <summary>
        /// Gets the IReplicasOperations.
        /// </summary>
        IReplicasOperations Replicas { get; }

        /// <summary>
        /// Gets the IServerKeysOperations.
        /// </summary>
        IServerKeysOperations ServerKeys { get; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        IFirewallRulesOperations FirewallRules { get; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        IDatabasesOperations Databases { get; }

        /// <summary>
        /// Gets the IConfigurationsOperations.
        /// </summary>
        IConfigurationsOperations Configurations { get; }

        /// <summary>
        /// Gets the IServerParametersOperations.
        /// </summary>
        IServerParametersOperations ServerParameters { get; }

        /// <summary>
        /// Gets the ILocationBasedCapabilitiesOperations.
        /// </summary>
        ILocationBasedCapabilitiesOperations LocationBasedCapabilities { get; }

        /// <summary>
        /// Gets the ICheckVirtualNetworkSubnetUsageOperations.
        /// </summary>
        ICheckVirtualNetworkSubnetUsageOperations CheckVirtualNetworkSubnetUsage { get; }

        /// <summary>
        /// Gets the ICheckNameAvailabilityOperations.
        /// </summary>
        ICheckNameAvailabilityOperations CheckNameAvailability { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

    }
}
