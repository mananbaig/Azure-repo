// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    ///
    /// </summary>
    public partial class ArmApplicationHealthPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationHealthPolicy"/>. </summary>
        public ArmApplicationHealthPolicy()
        {
            ServiceTypeHealthPolicyMap = new ChangeTrackingDictionary<string, ArmServiceTypeHealthPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationHealthPolicy"/>. </summary>
        /// <param name="considerWarningAsError"> Indicates whether warnings are treated with the same severity as errors. </param>
        /// <param name="maxPercentUnhealthyDeployedApplications">
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        ///
        /// </param>
        /// <param name="defaultServiceTypeHealthPolicy"> The health policy used by default to evaluate the health of a service type. </param>
        /// <param name="serviceTypeHealthPolicyMap"> The map with service type health policy per service type name. The map is empty by default. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationHealthPolicy(bool? considerWarningAsError, int? maxPercentUnhealthyDeployedApplications, ArmServiceTypeHealthPolicy defaultServiceTypeHealthPolicy, IDictionary<string, ArmServiceTypeHealthPolicy> serviceTypeHealthPolicyMap, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConsiderWarningAsError = considerWarningAsError;
            MaxPercentUnhealthyDeployedApplications = maxPercentUnhealthyDeployedApplications;
            DefaultServiceTypeHealthPolicy = defaultServiceTypeHealthPolicy;
            ServiceTypeHealthPolicyMap = serviceTypeHealthPolicyMap;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether warnings are treated with the same severity as errors. </summary>
        public bool? ConsiderWarningAsError { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        ///
        /// </summary>
        public int? MaxPercentUnhealthyDeployedApplications { get; set; }
        /// <summary> The health policy used by default to evaluate the health of a service type. </summary>
        public ArmServiceTypeHealthPolicy DefaultServiceTypeHealthPolicy { get; set; }
        /// <summary> The map with service type health policy per service type name. The map is empty by default. </summary>
        public IDictionary<string, ArmServiceTypeHealthPolicy> ServiceTypeHealthPolicyMap { get; }
    }
}
