// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// The status code and count of the virtual machine scale set instance
    /// view status summary.
    /// </summary>
    public partial class VirtualMachineStatusCodeCount
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineStatusCodeCount
        /// class.
        /// </summary>
        public VirtualMachineStatusCodeCount() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineStatusCodeCount
        /// class.
        /// </summary>
        /// <param name="code">The instance view status code.</param>
        /// <param name="count">The number of instances having a particular
        /// status code.</param>
        public VirtualMachineStatusCodeCount(string code = default(string), int? count = default(int?))
        {
            Code = code;
            Count = count;
        }

        /// <summary>
        /// Gets the instance view status code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the number of instances having a particular status code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public int? Count { get; private set; }

    }
}
