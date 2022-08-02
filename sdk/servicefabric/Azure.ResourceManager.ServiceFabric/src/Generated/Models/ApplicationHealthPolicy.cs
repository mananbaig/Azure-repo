// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    /// 
    /// Serialized Name: ApplicationHealthPolicy
    /// </summary>
    public partial class ApplicationHealthPolicy
    {
        /// <summary> Initializes a new instance of ApplicationHealthPolicy. </summary>
        public ApplicationHealthPolicy()
        {
            ServiceTypeHealthPolicies = new ChangeTrackingDictionary<string, ServiceTypeHealthPolicy>();
        }

        /// <summary> Initializes a new instance of ApplicationHealthPolicy. </summary>
        /// <param name="defaultServiceTypeHealthPolicy">
        /// The health policy used by default to evaluate the health of a service type.
        /// Serialized Name: ApplicationHealthPolicy.defaultServiceTypeHealthPolicy
        /// </param>
        /// <param name="serviceTypeHealthPolicies">
        /// The map with service type health policy per service type name. The map is empty by default.
        /// Serialized Name: ApplicationHealthPolicy.serviceTypeHealthPolicies
        /// </param>
        internal ApplicationHealthPolicy(ServiceTypeHealthPolicy defaultServiceTypeHealthPolicy, IDictionary<string, ServiceTypeHealthPolicy> serviceTypeHealthPolicies)
        {
            DefaultServiceTypeHealthPolicy = defaultServiceTypeHealthPolicy;
            ServiceTypeHealthPolicies = serviceTypeHealthPolicies;
        }

        /// <summary>
        /// The health policy used by default to evaluate the health of a service type.
        /// Serialized Name: ApplicationHealthPolicy.defaultServiceTypeHealthPolicy
        /// </summary>
        internal ServiceTypeHealthPolicy DefaultServiceTypeHealthPolicy { get; set; }
        /// <summary>
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        /// 
        /// Serialized Name: ServiceTypeHealthPolicy.maxPercentUnhealthyServices
        /// </summary>
        public int? MaxPercentUnhealthyServices
        {
            get => DefaultServiceTypeHealthPolicy is null ? default : DefaultServiceTypeHealthPolicy.MaxPercentUnhealthyServices;
            set
            {
                if (DefaultServiceTypeHealthPolicy is null)
                    DefaultServiceTypeHealthPolicy = new ServiceTypeHealthPolicy();
                DefaultServiceTypeHealthPolicy.MaxPercentUnhealthyServices = value;
            }
        }

        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// Serialized Name: ApplicationHealthPolicy.serviceTypeHealthPolicies
        /// </summary>
        public IDictionary<string, ServiceTypeHealthPolicy> ServiceTypeHealthPolicies { get; }
    }
}
