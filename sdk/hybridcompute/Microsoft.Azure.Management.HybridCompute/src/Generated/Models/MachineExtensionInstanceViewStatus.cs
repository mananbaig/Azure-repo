// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridCompute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Instance view status.
    /// </summary>
    public partial class MachineExtensionInstanceViewStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MachineExtensionInstanceViewStatus class.
        /// </summary>
        public MachineExtensionInstanceViewStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MachineExtensionInstanceViewStatus class.
        /// </summary>
        /// <param name="code">The status code.</param>
        /// <param name="level">The level code. Possible values include:
        /// 'Info', 'Warning', 'Error'</param>
        /// <param name="displayStatus">The short localizable label for the
        /// status.</param>
        /// <param name="message">The detailed status message, including for
        /// alerts and error messages.</param>
        /// <param name="time">The time of the status.</param>
        public MachineExtensionInstanceViewStatus(string code = default(string), string level = default(string), string displayStatus = default(string), string message = default(string), System.DateTime? time = default(System.DateTime?))
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the level code. Possible values include: 'Info', 'Warning',
        /// 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; private set; }

        /// <summary>
        /// Gets the short localizable label for the status.
        /// </summary>
        [JsonProperty(PropertyName = "displayStatus")]
        public string DisplayStatus { get; private set; }

        /// <summary>
        /// Gets the detailed status message, including for alerts and error
        /// messages.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the time of the status.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; private set; }

    }
}
