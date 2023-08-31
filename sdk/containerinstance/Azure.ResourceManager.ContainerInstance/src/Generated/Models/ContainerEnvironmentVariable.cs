// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The environment variable to set within the container instance. </summary>
    public partial class ContainerEnvironmentVariable
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerEnvironmentVariable"/>. </summary>
        /// <param name="name"> The name of the environment variable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ContainerEnvironmentVariable(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerEnvironmentVariable"/>. </summary>
        /// <param name="name"> The name of the environment variable. </param>
        /// <param name="value"> The value of the environment variable. </param>
        /// <param name="secureValue"> The value of the secure environment variable. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerEnvironmentVariable(string name, string value, string secureValue, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            SecureValue = secureValue;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerEnvironmentVariable"/> for deserialization. </summary>
        internal ContainerEnvironmentVariable()
        {
        }

        /// <summary> The name of the environment variable. </summary>
        public string Name { get; set; }
        /// <summary> The value of the environment variable. </summary>
        public string Value { get; set; }
        /// <summary> The value of the secure environment variable. </summary>
        public string SecureValue { get; set; }
    }
}
