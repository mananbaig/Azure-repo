// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SmartDetectionConditionPatch. </summary>
    internal partial class SmartDetectionConditionPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SmartDetectionConditionPatch"/>. </summary>
        public SmartDetectionConditionPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SmartDetectionConditionPatch"/>. </summary>
        /// <param name="sensitivity"> sensitivity, value range : (0, 100]. </param>
        /// <param name="anomalyDetectorDirection"> detection direction. </param>
        /// <param name="suppressCondition"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SmartDetectionConditionPatch(double? sensitivity, AnomalyDetectorDirection? anomalyDetectorDirection, SuppressConditionPatch suppressCondition, Dictionary<string, BinaryData> rawData)
        {
            Sensitivity = sensitivity;
            AnomalyDetectorDirection = anomalyDetectorDirection;
            SuppressCondition = suppressCondition;
            _rawData = rawData;
        }

        /// <summary> sensitivity, value range : (0, 100]. </summary>
        public double? Sensitivity { get; set; }
        /// <summary> detection direction. </summary>
        public AnomalyDetectorDirection? AnomalyDetectorDirection { get; set; }
        /// <summary> Gets or sets the suppress condition. </summary>
        public SuppressConditionPatch SuppressCondition { get; set; }
    }
}
