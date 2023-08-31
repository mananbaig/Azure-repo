// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The UnknownRuleDataSource. </summary>
    internal partial class UnknownRuleDataSource : RuleDataSource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRuleDataSource"/>. </summary>
        /// <param name="odataType"> specifies the type of data source. There are two types of rule data sources: RuleMetricDataSource and RuleManagementEventDataSource. </param>
        /// <param name="resourceId"> the resource identifier of the resource the rule monitors. **NOTE**: this property cannot be updated for an existing rule. </param>
        /// <param name="legacyResourceId"> the legacy resource identifier of the resource the rule monitors. **NOTE**: this property cannot be updated for an existing rule. </param>
        /// <param name="resourceLocation"> the location of the resource. </param>
        /// <param name="metricNamespace"> the namespace of the metric. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRuleDataSource(string odataType, ResourceIdentifier resourceId, ResourceIdentifier legacyResourceId, string resourceLocation, string metricNamespace, Dictionary<string, BinaryData> rawData) : base(odataType, resourceId, legacyResourceId, resourceLocation, metricNamespace, rawData)
        {
            OdataType = odataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRuleDataSource"/> for deserialization. </summary>
        internal UnknownRuleDataSource()
        {
        }
    }
}
