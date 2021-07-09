// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using System.Linq;

    /// <summary>
    /// Azure Monitor Metrics destination.
    /// </summary>
    public partial class DestinationsSpecAzureMonitorMetrics : AzureMonitorMetricsDestination
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DestinationsSpecAzureMonitorMetrics class.
        /// </summary>
        public DestinationsSpecAzureMonitorMetrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DestinationsSpecAzureMonitorMetrics class.
        /// </summary>
        /// <param name="name">A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of
        /// type) within the data collection rule.</param>
        public DestinationsSpecAzureMonitorMetrics(string name = default(string))
            : base(name)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
