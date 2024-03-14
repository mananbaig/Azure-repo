// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.IoT.Hub.Service;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The desired and reported properties of the twin. The maximum depth of the object is 10. </summary>
    public partial class PropertyContainer
    {
        /// <summary> Initializes a new instance of <see cref="PropertyContainer"/>. </summary>
        public PropertyContainer()
        {
            Desired = new ChangeTrackingDictionary<string, object>();
            Reported = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="PropertyContainer"/>. </summary>
        /// <param name="desired"> The collection of desired property key-value pairs. The keys are UTF-8 encoded, case-sensitive and up-to 1KB in length. Allowed characters exclude UNICODE control characters (segments C0 and C1), '.', '$' and space. The desired porperty values are JSON objects, up-to 4KB in length. </param>
        /// <param name="reported"> The collection of reported property key-value pairs. The keys are UTF-8 encoded, case-sensitive and up-to 1KB in length. Allowed characters exclude UNICODE control characters (segments C0 and C1), '.', '$' and space. The reported property values are JSON objects, up-to 4KB in length. </param>
        internal PropertyContainer(IDictionary<string, object> desired, IDictionary<string, object> reported)
        {
            Desired = desired;
            Reported = reported;
        }

        /// <summary> The collection of desired property key-value pairs. The keys are UTF-8 encoded, case-sensitive and up-to 1KB in length. Allowed characters exclude UNICODE control characters (segments C0 and C1), '.', '$' and space. The desired porperty values are JSON objects, up-to 4KB in length. </summary>
        public IDictionary<string, object> Desired { get; }
        /// <summary> The collection of reported property key-value pairs. The keys are UTF-8 encoded, case-sensitive and up-to 1KB in length. Allowed characters exclude UNICODE control characters (segments C0 and C1), '.', '$' and space. The reported property values are JSON objects, up-to 4KB in length. </summary>
        public IDictionary<string, object> Reported { get; }
    }
}
