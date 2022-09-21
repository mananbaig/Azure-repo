// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Represents a scaling policy related to an average load of a metric/resource of a service. </summary>
    public partial class AverageServiceLoadScalingTrigger : ManagedClusterServiceScalingTrigger
    {
        /// <summary> Initializes a new instance of AverageServiceLoadScalingTrigger. </summary>
        /// <param name="metricName"> The name of the metric for which usage should be tracked. </param>
        /// <param name="lowerLoadThreshold"> The lower limit of the load below which a scale in operation should be performed. </param>
        /// <param name="upperLoadThreshold"> The upper limit of the load beyond which a scale out operation should be performed. </param>
        /// <param name="scaleInterval"> The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format &quot;hh:mm:ss&quot;. </param>
        /// <param name="useOnlyPrimaryLoad"> Flag determines whether only the load of primary replica should be considered for scaling. If set to true, then trigger will only consider the load of primary replicas of stateful service. If set to false, trigger will consider load of all replicas. This parameter cannot be set to true for stateless service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricName"/> or <paramref name="scaleInterval"/> is null. </exception>
        public AverageServiceLoadScalingTrigger(string metricName, double lowerLoadThreshold, double upperLoadThreshold, string scaleInterval, bool useOnlyPrimaryLoad)
        {
            if (metricName == null)
            {
                throw new ArgumentNullException(nameof(metricName));
            }
            if (scaleInterval == null)
            {
                throw new ArgumentNullException(nameof(scaleInterval));
            }

            MetricName = metricName;
            LowerLoadThreshold = lowerLoadThreshold;
            UpperLoadThreshold = upperLoadThreshold;
            ScaleInterval = scaleInterval;
            UseOnlyPrimaryLoad = useOnlyPrimaryLoad;
            Kind = ServiceScalingTriggerKind.AverageServiceLoadTrigger;
        }

        /// <summary> Initializes a new instance of AverageServiceLoadScalingTrigger. </summary>
        /// <param name="kind"> Specifies the trigger associated with this scaling policy. </param>
        /// <param name="metricName"> The name of the metric for which usage should be tracked. </param>
        /// <param name="lowerLoadThreshold"> The lower limit of the load below which a scale in operation should be performed. </param>
        /// <param name="upperLoadThreshold"> The upper limit of the load beyond which a scale out operation should be performed. </param>
        /// <param name="scaleInterval"> The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format &quot;hh:mm:ss&quot;. </param>
        /// <param name="useOnlyPrimaryLoad"> Flag determines whether only the load of primary replica should be considered for scaling. If set to true, then trigger will only consider the load of primary replicas of stateful service. If set to false, trigger will consider load of all replicas. This parameter cannot be set to true for stateless service. </param>
        internal AverageServiceLoadScalingTrigger(ServiceScalingTriggerKind kind, string metricName, double lowerLoadThreshold, double upperLoadThreshold, string scaleInterval, bool useOnlyPrimaryLoad) : base(kind)
        {
            MetricName = metricName;
            LowerLoadThreshold = lowerLoadThreshold;
            UpperLoadThreshold = upperLoadThreshold;
            ScaleInterval = scaleInterval;
            UseOnlyPrimaryLoad = useOnlyPrimaryLoad;
            Kind = kind;
        }

        /// <summary> The name of the metric for which usage should be tracked. </summary>
        public string MetricName { get; set; }
        /// <summary> The lower limit of the load below which a scale in operation should be performed. </summary>
        public double LowerLoadThreshold { get; set; }
        /// <summary> The upper limit of the load beyond which a scale out operation should be performed. </summary>
        public double UpperLoadThreshold { get; set; }
        /// <summary> The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format &quot;hh:mm:ss&quot;. </summary>
        public string ScaleInterval { get; set; }
        /// <summary> Flag determines whether only the load of primary replica should be considered for scaling. If set to true, then trigger will only consider the load of primary replicas of stateful service. If set to false, trigger will consider load of all replicas. This parameter cannot be set to true for stateless service. </summary>
        public bool UseOnlyPrimaryLoad { get; set; }
    }
}
