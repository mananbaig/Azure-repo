// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of on-premise IoT sensors
    /// </summary>
    public partial class OnPremiseIotSensorsList
    {
        /// <summary>
        /// Initializes a new instance of the OnPremiseIotSensorsList class.
        /// </summary>
        public OnPremiseIotSensorsList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OnPremiseIotSensorsList class.
        /// </summary>
        /// <param name="value">List data</param>
        public OnPremiseIotSensorsList(IList<OnPremiseIotSensor> value = default(IList<OnPremiseIotSensor>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list data
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<OnPremiseIotSensor> Value { get; private set; }

    }
}
