// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The parameters for a PATCH request to a monitor resource. </summary>
    public partial class DatadogMonitorResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="DatadogMonitorResourcePatch"/>. </summary>
        public DatadogMonitorResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DatadogMonitorResourcePatch"/>. </summary>
        /// <param name="properties"> The set of properties that can be update in a PATCH request to a monitor resource. </param>
        /// <param name="tags"> The new tags of the monitor resource. </param>
        /// <param name="sku"></param>
        internal DatadogMonitorResourcePatch(MonitorUpdateProperties properties, IDictionary<string, string> tags, ResourceSku sku)
        {
            Properties = properties;
            Tags = tags;
            Sku = sku;
        }

        /// <summary> The set of properties that can be update in a PATCH request to a monitor resource. </summary>
        internal MonitorUpdateProperties Properties { get; set; }
        /// <summary> Flag specifying if the resource monitoring is enabled or disabled. </summary>
        public MonitoringStatus? MonitorUpdateMonitoringStatus
        {
            get => Properties is null ? default : Properties.MonitoringStatus;
            set
            {
                if (Properties is null)
                    Properties = new MonitorUpdateProperties();
                Properties.MonitoringStatus = value;
            }
        }

        /// <summary> The new tags of the monitor resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the sku. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> Name of the SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new ResourceSku(value);
        }
    }
}
